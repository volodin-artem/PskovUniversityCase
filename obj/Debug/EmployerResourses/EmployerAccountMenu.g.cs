﻿#pragma checksum "..\..\..\EmployerResourses\EmployerAccountMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2CB6CA1B67CCCE2E3A6F75BBCEB2088F0ED804AB"
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


namespace PskovUniversityCase.EmployerResourses {
    
    
    /// <summary>
    /// EmployerAccountMenu
    /// </summary>
    public partial class EmployerAccountMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 54 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textWelcome;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSettings;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExitAcc;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddVacancy;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWatchResp;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox vacanciesList;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageOrg;
        
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
            System.Uri resourceLocater = new System.Uri("/PskovUniversityCase;component/employerresourses/employeraccountmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
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
            case 3:
            this.textWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.buttonSettings = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            this.buttonSettings.Click += new System.Windows.RoutedEventHandler(this.ButtonSettings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonExitAcc = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            this.buttonExitAcc.Click += new System.Windows.RoutedEventHandler(this.ButtonExitAcc_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonAddVacancy = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            this.buttonAddVacancy.Click += new System.Windows.RoutedEventHandler(this.buttonAddVacancyClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonWatchResp = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            this.buttonWatchResp.Click += new System.Windows.RoutedEventHandler(this.ButtonWatchResp_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.vacanciesList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.imageOrg = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 35 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonChangeVac_Click);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 39 "..\..\..\EmployerResourses\EmployerAccountMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonVacDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

