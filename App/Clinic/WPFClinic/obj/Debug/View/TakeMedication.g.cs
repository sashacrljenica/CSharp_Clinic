﻿#pragma checksum "..\..\..\View\TakeMedication.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04433BCBF1AE2476A24EB3ED0580436E"
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
using WPFClinic.View;


namespace WPFClinic.View {
    
    
    /// <summary>
    /// TakeMedication
    /// </summary>
    public partial class TakeMedication : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTakeMedication;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPharmacy;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPatientName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuantity;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtDatePicker;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPatientName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\TakeMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFClinic;component/view/takemedication.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TakeMedication.xaml"
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
            this.lblTakeMedication = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblPharmacy = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.lblDate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblPatientName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblQuantity = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.cmbPatientName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

