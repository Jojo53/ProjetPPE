﻿#pragma checksum "..\..\..\..\Pages\Français\ConnexionFr.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D9C2169862FBDD9D16B0DDEB485D130FE820C59"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MegaCastings.Pages.Français;
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


namespace MegaCastings.Pages.Français {
    
    
    /// <summary>
    /// ConnexionFr
    /// </summary>
    public partial class ConnexionFr : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MainTitle;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LoginLabel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SignInError;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastings;component/pages/fran%c3%a7ais/connexionfr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
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
            
            #line 9 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
            ((MegaCastings.Pages.Français.ConnexionFr)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LoginLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.SignInButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Pages\Français\ConnexionFr.xaml"
            this.SignInButton.Click += new System.Windows.RoutedEventHandler(this.SignInButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SignInError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

