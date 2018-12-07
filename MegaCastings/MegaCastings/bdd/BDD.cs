using MegaCastings.Pages.Anglais.Castings;
using MegaCastings.Pages.Anglais.Clients;
using MegaCastings.Pages.Français.Castings;
using MegaCastings.Pages.Français.Clients;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastings.bdd
{
    class BDD
    {
        private MySqlConnection connection;

        // Constructeur
        public BDD()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=172.16.2.133; DATABASE=megacastings_database; UID=megacastings; PASSWORD=Not24get";
            this.connection = new MySqlConnection(connectionString);
        }

        #region Gestion des Clients
        #region Affichage des Clients
        public void ShowCustomer(ListView listview)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT nom, prenom, email, password, role, nbr_castings FROM Clients";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Clients");
                listview.ItemsSource = ds.Tables[0].DefaultView;
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
        #endregion
        #region Affichage des Clients - Combobox
        public void ShowCustomerCombobox(ComboBox combobox)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Id, nom FROM Clients";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Clients");
                combobox.ItemsSource = ds.Tables[0].DefaultView;
                combobox.DisplayMemberPath = ds.Tables[0].Columns["Libelle"].ToString();
                combobox.SelectedValuePath = ds.Tables[0].Columns["Id"].ToString();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        #endregion
        #region Affichage des Clients depuis un Id - Suppression
        public void ShowCustomerByIdDelete(Label Libelle, Label Phone, Label Mail, Label Postal, Label Ville)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "SELECT nom, prenom, email, password, role, nbr_castings FROM Clients Where Id = @Id";
                if(mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@Id", DeleteCustomerFr.IdSelected);
                }else
                {
                    cmd.Parameters.AddWithValue("@Id", DeleteCustomerEn.IdSelected);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Libelle.Content = reader.GetValue(0).ToString();
                    Phone.Content = reader.GetValue(1).ToString();
                    Mail.Content = reader.GetValue(2).ToString();
                    Postal.Content = reader.GetValue(3).ToString();
                    Ville.Content = reader.GetValue(4).ToString();
                }
                reader.Dispose();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
        #endregion
        #region Ajout d'un Client
        public void AddCustomer(Customer customer)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Clients (nom, prenom, email, password, role, nbr_castings) VALUES (@nom, @prenom, @email, @password, @role, @nbcasting)";
                cmd.Parameters.AddWithValue("@nom", customer.nom);
                cmd.Parameters.AddWithValue("@prenom", customer.prenom);
                cmd.Parameters.AddWithValue("@email", customer.email);
                cmd.Parameters.AddWithValue("@password", customer.password);
                cmd.Parameters.AddWithValue("@role", customer.role);
                cmd.Parameters.AddWithValue("@nbcasting", 10);
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
        #endregion
        #region Supprimer un Client
        public void DeleteCustomer()
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "DELETE FROM Clients Where Id = @Id";
                if(mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@Id", Int32.Parse(DeleteCustomerFr.IdSelected));
                }else
                {
                    cmd.Parameters.AddWithValue("@Id", Int32.Parse(DeleteCustomerEn.IdSelected));
                }
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        #endregion
        #region Modifier un Client
        public void UpdateCustomer(TextBox Nom, TextBox Prenom, TextBox Mail, TextBox Password, ComboBox Role)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "UPDATE Clients SET nom = @nom, prenom = @prenom, email = @email, password = @password, role = @role WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@nom", Nom.Text);
                cmd.Parameters.AddWithValue("@prenom", Prenom.Text);
                cmd.Parameters.AddWithValue("@email", Mail.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);
                cmd.Parameters.AddWithValue("@role", Role.SelectedValue);
                if (mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@Id", EditeCustomerFr.IdSelected);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Id", EditeCustomerEn.IdSelected);
                }
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
        #region Gestion du Nombre de Casting
        public void ManageCasting(Customer customer, ComboBox combobox)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Clients (nb_castings) VALUES (@nbCasting) WHERE Id = @id";
                cmd.Parameters.AddWithValue("@nbCasting", customer.Nbr_castings);
                cmd.Parameters.AddWithValue("@Id", combobox.SelectedIndex);
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #endregion

        #region Gestion des Castings
        #region Affichage des Casting
        public void ShowCasting(ListView listview)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Intitule, DateDebutPublication, DureeDiffusion, DateDebutContrat FROM Castings";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Castings");
                listview.ItemsSource = ds.Tables[0].DefaultView;
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #region Affichage des Castings - 2
        public void ShowCasting2(ListView listview)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Localisation, DescriptionPoste, DescriptionProfil, Coordonnées FROM Castings";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Castings");
                listview.ItemsSource = ds.Tables[0].DefaultView;
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #region Affichage des Castings - Combobox
        public void ShowCastingCombobox(ComboBox combobox)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Intitule FROM Castings";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Castings");
                combobox.ItemsSource = ds.Tables[0].DefaultView;
                combobox.DisplayMemberPath = ds.Tables[0].Columns["Intitule"].ToString();
                combobox.SelectedValuePath = ds.Tables[0].Columns["Id"].ToString();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #region Affichage des Castings depuis un Id - Suppression
        public void ShowCastingByIdDelete(Label Intitule)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "SELECT Intitule FROM Castings Where Id = @Id";
                if (mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@Id", DeleteCastingFr.IdSelected);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Id", DeleteCastingEn.IdSelected);
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Intitule.Content = reader.GetValue(0).ToString();
                }
                reader.Dispose();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #region Ajout d'une Offre de Casting
        public void AddCasting(Casting casting)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "INSERT INTO Castings (Intitule, DateDebutPublication, DureeDiffusion, DateDebutContrat, Localisation, DescriptionPoste, DescriptionProfil, Coordonnées, ClientId, MetierId, TypeContratId) VALUES (@intitule, @datedebutpublication, @dureediffusion, @datedebutcontrat, @localisation, @descriptionposte, @descriptionprofil, @coordonnees, @clientid, @metierid, @typecontratid)";
                cmd.Parameters.AddWithValue("@intitule", casting.intitule);
                cmd.Parameters.AddWithValue("@datedebutpublication", casting.DateDebutPublication);
                cmd.Parameters.AddWithValue("@dureediffusion", casting.DureeDiffusion);
                cmd.Parameters.AddWithValue("@datedebutcontrat", casting.DateDebutContrat);
                cmd.Parameters.AddWithValue("@localisation", casting.Localisation);
                cmd.Parameters.AddWithValue("@descriptionposte", casting.DescriptionPoste);
                cmd.Parameters.AddWithValue("@descriptionprofil", casting.DescriptionProfil);
                cmd.Parameters.AddWithValue("@coordonnees", casting.Coordonnees);
                if(mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@clientid", AddCasting2Fr.ClientIdSelected);
                    cmd.Parameters.AddWithValue("@metierid", AddCasting2Fr.MetierIdSelected);
                    cmd.Parameters.AddWithValue("@typecontratid", AddCasting2Fr.TypeContratSelected);
                }else
                {
                    cmd.Parameters.AddWithValue("@clientid", AddCasting2En.ClientIdSelected);
                    cmd.Parameters.AddWithValue("@metierid", AddCasting2En.MetierIdSelected);
                    cmd.Parameters.AddWithValue("@typecontratid", AddCasting2En.TypeContratSelected);
                }
                
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
        #region Supprimer un Casting
        public void DeleteCasting()
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "DELETE FROM Casting Where Id = @Id";
                if (mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@Id", Int32.Parse(DeleteCastingFr.IdSelected));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Id", Int32.Parse(DeleteCastingEn.IdSelected));
                }
                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        #region Modifier un Casting
        public void UpdateCasting(TextBox Localisation, TextBox Poste, TextBox Profil, TextBox Coordonnees)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                var mainwindow = Application.Current.MainWindow as MainWindow;
                cmd.CommandText = "UPDATE Castings SET Intitule = @intitule, DateDebutPublication = @publication, DureeDiffusion = @diffusion, DateDebutContrat = @contrat, Localisation = @localisation, DescriptionPoste = @poste, DescriptionProfil = @profil, Coordonnées = @coordonnees, ClientId = @client, MetierId = @metier, TypeContrat = @typecontrat WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@localisation", Localisation.Text);
                cmd.Parameters.AddWithValue("@poste", Poste.Text);
                cmd.Parameters.AddWithValue("@profil", Profil.Text);
                cmd.Parameters.AddWithValue("@cordonneess", Coordonnees.Text);
                if (mainwindow.FrLabel.Visibility == Visibility.Visible)
                {
                    cmd.Parameters.AddWithValue("@intitule", EditeCastingFr.IntituleVar);
                    cmd.Parameters.AddWithValue("@publication", EditeCastingFr.DateDebutPubliacationVar);
                    cmd.Parameters.AddWithValue("@diffusion", EditeCastingFr.DureeDiffusionVar);
                    cmd.Parameters.AddWithValue("@contrat", EditeCastingFr.DateDebutContratVar);
                    cmd.Parameters.AddWithValue("@client", EditeCasting2Fr.ClientIdSelected);
                    cmd.Parameters.AddWithValue("@metier", EditeCasting2Fr.MetierIdSelected);
                    cmd.Parameters.AddWithValue("@typecontrat", EditeCasting2Fr.TypeContratSelected);
                    cmd.Parameters.AddWithValue("@Id", EditeCastingFr.IdSelected);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@intitule", EditeCastingEn.IntituleVar);
                    cmd.Parameters.AddWithValue("@publication", EditeCastingEn.DateDebutPubliacationVar);
                    cmd.Parameters.AddWithValue("@diffusion", EditeCastingEn.DureeDiffusionVar);
                    cmd.Parameters.AddWithValue("@contrat", EditeCastingEn.DateDebutContratVar);
                    cmd.Parameters.AddWithValue("@client", EditeCasting2En.ClientIdSelected);
                    cmd.Parameters.AddWithValue("@metier", EditeCasting2En.MetierIdSelected);
                    cmd.Parameters.AddWithValue("@typecontrat", EditeCasting2En.TypeContratSelected);
                    cmd.Parameters.AddWithValue("@Id", EditeCastingEn.IdSelected);
                }

                cmd.ExecuteNonQuery();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
        #endregion

        #region Metier - Combobox
        public void ShowMetierCombobox(ComboBox combobox)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Libelle FROM Metier";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Metier");
                combobox.ItemsSource = ds.Tables[0].DefaultView;
                combobox.DisplayMemberPath = ds.Tables[0].Columns["Libelle"].ToString();
                combobox.SelectedValuePath = ds.Tables[0].Columns["Id"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion

        #region TypeContrat - Combobox
        public void ShowTypeContratCombobox(ComboBox combobox)
        {
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Libelle FROM TypeContrat";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TypeContrat");
                combobox.ItemsSource = ds.Tables[0].DefaultView;
                combobox.DisplayMemberPath = ds.Tables[0].Columns["Libelle"].ToString();
                combobox.SelectedValuePath = ds.Tables[0].Columns["Id"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
    }
}
