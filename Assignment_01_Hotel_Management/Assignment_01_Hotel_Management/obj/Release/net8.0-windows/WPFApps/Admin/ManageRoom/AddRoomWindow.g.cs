﻿#pragma checksum "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EDF4C1C32308CB084459FA4252374D4C0F90C2FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assignment_01_Hotel_Management.WPFApps;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Assignment_01_Hotel_Management.WPFApps {
    
    
    /// <summary>
    /// AddRoomWindow
    /// </summary>
    public partial class AddRoomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomCapacityTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoomTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoomStatusComboBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment_01_Hotel_Management;component/wpfapps/admin/manageroom/addroomwindow." +
                    "xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RoomNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RoomDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RoomCapacityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RoomPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RoomTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.RoomStatusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 24 "..\..\..\..\..\..\WPFApps\Admin\ManageRoom\AddRoomWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveRoomButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
