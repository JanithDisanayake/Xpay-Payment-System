﻿#pragma checksum "..\..\Customer Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FA0557C85567EF853FB28601FBA2098C9B9F42AB41617A76F7CEA1F5A81E14F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_GAD_CW2;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Final_GAD_CW2 {
    
    
    /// <summary>
    /// Customer_Login
    /// </summary>
    public partial class Customer_Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btn_toggle;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_customer_name;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_customer_psswd;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_forgotpw;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_signin;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Customer Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Register;
        
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
            System.Uri resourceLocater = new System.Uri("/Xpay;component/customer%20login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customer Login.xaml"
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
            
            #line 23 "..\..\Customer Login.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Rectangle_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_toggle = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 3:
            this.txt_customer_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_customer_psswd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btn_forgotpw = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btn_signin = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Customer Login.xaml"
            this.btn_signin.Click += new System.Windows.RoutedEventHandler(this.btn_signin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Register = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Customer Login.xaml"
            this.btn_Register.Click += new System.Windows.RoutedEventHandler(this.btn_Register_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

