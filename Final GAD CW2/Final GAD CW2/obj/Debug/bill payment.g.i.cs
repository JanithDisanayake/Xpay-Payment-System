﻿#pragma checksum "..\..\bill payment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2DFDFEBD971920C53E718ACD39E87CECEBF8AA2DB08F202CECDA9643551FC8CD"
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
    /// bill_payment
    /// </summary>
    public partial class bill_payment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_category;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_biller;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_accno;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_bnum;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_bamt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_pay;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_clear;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_open_menu;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close_menu;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_home;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_bill_paymeny;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_echanneling;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_mobile_reload;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_cart;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_offers;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\bill payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_transaction_history;
        
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
            System.Uri resourceLocater = new System.Uri("/Final GAD CW2;component/bill%20payment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\bill payment.xaml"
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
            this.cmb_category = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\bill payment.xaml"
            this.cmb_category.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_category_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmb_biller = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txt_accno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_bnum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_bamt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_pay = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\bill payment.xaml"
            this.btn_pay.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_clear = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.btn_open_menu = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\bill payment.xaml"
            this.btn_open_menu.Click += new System.Windows.RoutedEventHandler(this.btn_open_menu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_close_menu = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\bill payment.xaml"
            this.btn_close_menu.Click += new System.Windows.RoutedEventHandler(this.btn_close_menu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 137 "..\..\bill payment.xaml"
            ((System.Windows.Controls.ListView)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_home = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 143 "..\..\bill payment.xaml"
            this.btn_home.Selected += new System.Windows.RoutedEventHandler(this.btn_home_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_bill_paymeny = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 14:
            this.btn_echanneling = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 15:
            this.btn_mobile_reload = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 16:
            this.btn_cart = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 17:
            this.btn_offers = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 18:
            this.btn_transaction_history = ((System.Windows.Controls.ListViewItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

