﻿#pragma checksum "..\..\..\Pages\DeleteFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BBC2CC5C964F99EE8F4FFFCD494BED2067409941EF6191CD929D72564977083"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ADO;
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


namespace ADO {
    
    
    /// <summary>
    /// DeleteFrame
    /// </summary>
    public partial class DeleteFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Discipline;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Lector;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel DisciplineNamePanel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DisciplineName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SNP;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\DeleteFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SNPName;
        
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
            System.Uri resourceLocater = new System.Uri("/ADO;component/pages/deleteframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DeleteFrame.xaml"
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
            this.Discipline = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\..\Pages\DeleteFrame.xaml"
            this.Discipline.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Lector = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\..\Pages\DeleteFrame.xaml"
            this.Lector.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DisciplineNamePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.DisciplineName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SNP = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.SNPName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 34 "..\..\..\Pages\DeleteFrame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_from_database);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

