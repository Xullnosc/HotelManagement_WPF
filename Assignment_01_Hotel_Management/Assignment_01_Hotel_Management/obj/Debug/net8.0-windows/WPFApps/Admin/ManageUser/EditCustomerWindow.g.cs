﻿#pragma checksum "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FE2C222A10D6A7CD17164174802E1395F9797CC"
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
    /// EditCustomerWindow
    /// </summary>
    public partial class EditCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TelephoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthdayPicker;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Assignment_01_Hotel_Management;component/wpfapps/admin/manageuser/editcustomerwi" +
                    "ndow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
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
            this.FullNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TelephoneTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
            this.TelephoneTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TelephoneTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BirthdayPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            
            #line 21 "..\..\..\..\..\..\WPFApps\Admin\ManageUser\EditCustomerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveChangesButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

