﻿#pragma checksum "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D054F2025D19AE2FC114E375D0CC726A4A96F073"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MegaCastings.Pages.Anglais.Clients;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MegaCastings.Pages.Anglais.Clients {
    
    
    /// <summary>
    /// CustomerManagerEn
    /// </summary>
    public partial class CustomerManagerEn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MainTitle;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowCustomerButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCustomerButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditeCustomerButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCustomerButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MegaCastings;component/pages/anglais/clients/customermanageren.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ShowCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
            this.ShowCustomerButton.Click += new System.Windows.RoutedEventHandler(this.ShowCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
            this.AddCustomerButton.Click += new System.Windows.RoutedEventHandler(this.AddCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditeCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
            this.EditeCustomerButton.Click += new System.Windows.RoutedEventHandler(this.EditeCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteCustomerButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\Pages\Anglais\Clients\CustomerManagerEn.xaml"
            this.DeleteCustomerButton.Click += new System.Windows.RoutedEventHandler(this.DeleteCustomerButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

