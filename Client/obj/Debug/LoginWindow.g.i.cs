﻿#pragma checksum "..\..\LoginWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5461281386C8FE9FFF08915DC6E8B4FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Client {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbLoginMenu;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrate;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox gbRoomMenu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbRooms;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterToRoom;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRoomName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRoomPassword;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateRoom;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lbActive;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginWindow.xaml"
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
            this.gbLoginMenu = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\LoginWindow.xaml"
            this.tbLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbLogin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\LoginWindow.xaml"
            this.tbPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\LoginWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRegistrate = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\LoginWindow.xaml"
            this.btnRegistrate.Click += new System.Windows.RoutedEventHandler(this.btnRegistrate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gbRoomMenu = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 7:
            this.lbRooms = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.btnEnterToRoom = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\LoginWindow.xaml"
            this.btnEnterToRoom.Click += new System.Windows.RoutedEventHandler(this.btnEnterToRoom_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbRoomName = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\LoginWindow.xaml"
            this.tbRoomName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbRoomName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tbRoomPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\LoginWindow.xaml"
            this.tbRoomPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbRoomName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCreateRoom = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\LoginWindow.xaml"
            this.btnCreateRoom.Click += new System.Windows.RoutedEventHandler(this.btnCreateRoom_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lbActive = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

