﻿#pragma checksum "..\..\Savings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E96167C39AC743F6D09A67B43BFA30D8D042A676F03CBAE89565435282B25D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPF_BUDGET_PLANNER;


namespace WPF_BUDGET_PLANNER {
    
    
    /// <summary>
    /// Savings
    /// </summary>
    public partial class Savings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtA;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtN;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtR;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtT;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveValues;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoback;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbCmpInt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Savings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbSmpInt;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF BUDGET PLANNER;component/savings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Savings.xaml"
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
            this.txtA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSaveValues = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Savings.xaml"
            this.btnSaveValues.Click += new System.Windows.RoutedEventHandler(this.btnSaveValues_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGoback = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Savings.xaml"
            this.btnGoback.Click += new System.Windows.RoutedEventHandler(this.btnGoback_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdbCmpInt = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.rdbSmpInt = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

