﻿#pragma checksum "..\..\PoWybraniuLozka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B2023E485E87099E884E490B895F810486EE3AB953BBE47F4846104B15E47A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// PoWybraniuLozka
    /// </summary>
    public partial class PoWybraniuLozka : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwaModeluBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CenaBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WysokoscBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SzerokoscBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GlebokoscBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxProducenci;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxMaterialy;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PoWybraniuLozka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MateracCHeckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/powybraniulozka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PoWybraniuLozka.xaml"
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
            this.NazwaModeluBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CenaBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.WysokoscBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SzerokoscBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GlebokoscBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ComboBoxProducenci = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 36 "..\..\PoWybraniuLozka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ComboBoxMaterialy = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.MateracCHeckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

