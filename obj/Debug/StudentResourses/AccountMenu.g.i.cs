﻿#pragma checksum "..\..\..\StudentResourses\AccountMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530A7616BE167B3DC6B16FF50DCE884A3C59E5C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
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


namespace PskovUniversityCase.StudentResourses {
    
    
    /// <summary>
    /// AccountMenu
    /// </summary>
    public partial class AccountMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textWelcome;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWatchVac;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWatchStatus;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWatchSummary;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSettingsAcc;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\StudentResourses\AccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
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
            System.Uri resourceLocater = new System.Uri("/PskovUniversityCase;component/studentresourses/accountmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StudentResourses\AccountMenu.xaml"
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
            this.textWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.buttonWatchVac = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\StudentResourses\AccountMenu.xaml"
            this.buttonWatchVac.Click += new System.Windows.RoutedEventHandler(this.buttonWatchVacClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonWatchStatus = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\StudentResourses\AccountMenu.xaml"
            this.buttonWatchStatus.Click += new System.Windows.RoutedEventHandler(this.ButtonWatchStatus_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonWatchSummary = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\StudentResourses\AccountMenu.xaml"
            this.buttonWatchSummary.Click += new System.Windows.RoutedEventHandler(this.ButtonWatchSummary_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonSettingsAcc = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\StudentResourses\AccountMenu.xaml"
            this.buttonSettingsAcc.Click += new System.Windows.RoutedEventHandler(this.ButtonSettingsAcc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\StudentResourses\AccountMenu.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.ButtonExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

