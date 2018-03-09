﻿#pragma checksum "..\..\..\Dialogs\MessageBoxSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E3FC9F85C96AE5FA9A2C240F621D5FBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WPFTutorial.Dialogs {
    
    
    /// <summary>
    /// MessageBoxSample
    /// </summary>
    public partial class MessageBoxSample : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSimpleMessageBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessageBoxWithTitle;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessageBoxWithButtons;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessageBoxWithResponse;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessageBoxWithIcon;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Dialogs\MessageBoxSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessageBoxWithDefaultChoice;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFTutorial;component/dialogs/messageboxsample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\MessageBoxSample.xaml"
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
            this.btnSimpleMessageBox = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnSimpleMessageBox.Click += new System.Windows.RoutedEventHandler(this.btnSimpleMessageBox_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMessageBoxWithTitle = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnMessageBoxWithTitle.Click += new System.Windows.RoutedEventHandler(this.btnMessageBoxWithTitle_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMessageBoxWithButtons = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnMessageBoxWithButtons.Click += new System.Windows.RoutedEventHandler(this.btnMessageBoxWithButtons_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnMessageBoxWithResponse = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnMessageBoxWithResponse.Click += new System.Windows.RoutedEventHandler(this.btnMessageBoxWithResponse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnMessageBoxWithIcon = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnMessageBoxWithIcon.Click += new System.Windows.RoutedEventHandler(this.btnMessageBoxWithIcon_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMessageBoxWithDefaultChoice = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Dialogs\MessageBoxSample.xaml"
            this.btnMessageBoxWithDefaultChoice.Click += new System.Windows.RoutedEventHandler(this.btnMessageBoxWithDefaultChoice_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

