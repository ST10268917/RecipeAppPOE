﻿#pragma checksum "..\..\..\Scale.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E5BDC3B1D243EEFE4A5CEEA224EAF40EEAE27E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RecipeApp;
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


namespace RecipeApp {
    
    
    /// <summary>
    /// Scale
    /// </summary>
    public partial class Scale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox recipesCB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayTB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button halfButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tripleButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Scale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button doubleButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RecipeApp;component/scale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Scale.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.titleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.recipesCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\Scale.xaml"
            this.recipesCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.recipesCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.displayTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.halfButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Scale.xaml"
            this.halfButton.Click += new System.Windows.RoutedEventHandler(this.halfButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tripleButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Scale.xaml"
            this.tripleButton.Click += new System.Windows.RoutedEventHandler(this.tripleButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.doubleButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Scale.xaml"
            this.doubleButton.Click += new System.Windows.RoutedEventHandler(this.doubleButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

