﻿#pragma checksum "..\..\VehiclePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7635C7BCF8C2296A0DFE79D6B7990217888697607DC859F099BF21B7D6C84E3"
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
    /// VehiclePage
    /// </summary>
    public partial class VehiclePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVPurchasePrice;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVDeposite;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInterest;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumberMonths;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInsurance;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtModel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\VehiclePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSumbit;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF BUDGET PLANNER;component/vehiclepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VehiclePage.xaml"
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
            this.txtVPurchasePrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtVDeposite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtInterest = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNumberMonths = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtInsurance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSumbit = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\VehiclePage.xaml"
            this.btnSumbit.Click += new System.Windows.RoutedEventHandler(this.btnSumbit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

