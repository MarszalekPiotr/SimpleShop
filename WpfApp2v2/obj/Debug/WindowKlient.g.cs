﻿#pragma checksum "..\..\WindowKlient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F574177421BE74D2FD6E4E58605BF33B4730EB76EA23A4EEA3310A841219F65E"
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
    /// WindowKlient
    /// </summary>
    public partial class WindowKlient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajProduktButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UsunProduktButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZmienIloscButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ListaZakupówLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IdzDKasyButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaZakupowOFF;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button przyciskSortuj;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label KwotaLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindowKlient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IloscTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/windowklient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowKlient.xaml"
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
            this.DodajProduktButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\WindowKlient.xaml"
            this.DodajProduktButton.Click += new System.Windows.RoutedEventHandler(this.DodajProduktButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsunProduktButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\WindowKlient.xaml"
            this.UsunProduktButton.Click += new System.Windows.RoutedEventHandler(this.button_Usun_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ZmienIloscButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WindowKlient.xaml"
            this.ZmienIloscButton.Click += new System.Windows.RoutedEventHandler(this.ZmienIloscButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListaZakupówLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.IdzDKasyButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\WindowKlient.xaml"
            this.IdzDKasyButton.Click += new System.Windows.RoutedEventHandler(this.IdzDKasyButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListaZakupowOFF = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\WindowKlient.xaml"
            this.ListaZakupowOFF.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 22 "..\..\WindowKlient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Odswiez);
            
            #line default
            #line hidden
            return;
            case 8:
            this.przyciskSortuj = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\WindowKlient.xaml"
            this.przyciskSortuj.Click += new System.Windows.RoutedEventHandler(this.przyciskSortuj_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.KwotaLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.IloscTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
