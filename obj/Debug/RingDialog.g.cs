﻿#pragma checksum "..\..\RingDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "719EEE222E3864CDE645EA585CA9CA09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace Vault_Calculator {
    
    
    /// <summary>
    /// RingDialog
    /// </summary>
    public partial class RingDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Start;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Number;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Space;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Iron;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Stone;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Diamond;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReinforceCost;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReinforcementsTotal;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiamondsTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/Vault Calculator;component/ringdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RingDialog.xaml"
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
            this.Start = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\RingDialog.xaml"
            this.Start.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 10 "..\..\RingDialog.xaml"
            this.Start.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RadiusChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Number = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\RingDialog.xaml"
            this.Number.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 11 "..\..\RingDialog.xaml"
            this.Number.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RingChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Space = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\RingDialog.xaml"
            this.Space.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 12 "..\..\RingDialog.xaml"
            this.Space.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SpaceChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Iron = ((System.Windows.Controls.RadioButton)(target));
            
            #line 16 "..\..\RingDialog.xaml"
            this.Iron.Checked += new System.Windows.RoutedEventHandler(this.Iron_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Stone = ((System.Windows.Controls.RadioButton)(target));
            
            #line 17 "..\..\RingDialog.xaml"
            this.Stone.Checked += new System.Windows.RoutedEventHandler(this.Stone_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Diamond = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\RingDialog.xaml"
            this.Diamond.Checked += new System.Windows.RoutedEventHandler(this.Diamond_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 19 "..\..\RingDialog.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ReinforceCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\RingDialog.xaml"
            this.ReinforceCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 21 "..\..\RingDialog.xaml"
            this.ReinforceCost.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ReinforcementCost_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ReinforcementsTotal = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\RingDialog.xaml"
            this.ReinforcementsTotal.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DiamondsTotal = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\RingDialog.xaml"
            this.DiamondsTotal.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

