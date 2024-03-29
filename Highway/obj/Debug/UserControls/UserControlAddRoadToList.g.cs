﻿#pragma checksum "..\..\..\UserControls\UserControlAddRoadToList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8D812BD4AA490D280278FFFFD9BE2B451127E10C8BE84299D500347E9DA26EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Highway.UserControls;
using MaterialDesignThemes.MahApps;
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


namespace Highway.UserControls {
    
    
    /// <summary>
    /// UserControlAddRoadToList
    /// </summary>
    public partial class UserControlAddRoadToList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRoadToList;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoadName;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoadTypeBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoadLength;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountRoadLines;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BanquetteBox;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SeparatorBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Highway;component/usercontrols/usercontroladdroadtolist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
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
            this.AddRoadToList = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\UserControls\UserControlAddRoadToList.xaml"
            this.AddRoadToList.Click += new System.Windows.RoutedEventHandler(this.AddRoadToList_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RoadName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RoadTypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.RoadLength = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AmountRoadLines = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BanquetteBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.SeparatorBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

