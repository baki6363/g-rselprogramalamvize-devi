﻿#pragma checksum "..\..\OgrenciEkle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AC29EAEE9E72D1BA74A95D6D61C853041449D31"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstProject;
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


namespace FirstProject {
    
    
    /// <summary>
    /// Edit
    /// </summary>
    public partial class Edit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoyad;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBolum;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCinsiyet;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAd;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOgrenciNo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKaydet;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablo2;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbIndex;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\OgrenciEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMesaj;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstProject;component/ogrenciekle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OgrenciEkle.xaml"
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
            this.txtSoyad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmbBolum = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cmbCinsiyet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtAd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtOgrenciNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnKaydet = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\OgrenciEkle.xaml"
            this.btnKaydet.Click += new System.Windows.RoutedEventHandler(this.btnKaydet_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tablo2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.cmbIndex = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\OgrenciEkle.xaml"
            this.cmbIndex.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbIndex_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblMesaj = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 68 "..\..\OgrenciEkle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

