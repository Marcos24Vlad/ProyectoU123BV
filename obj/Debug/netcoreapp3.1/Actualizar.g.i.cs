﻿#pragma checksum "..\..\..\Actualizar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59CD191B0B2760AB2DD37794FB68476BDDF01929"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_GYM;
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


namespace Proyecto_GYM {
    
    
    /// <summary>
    /// Actualizar
    /// </summary>
    public partial class Actualizar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCorreo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDia;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbMes;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAño;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbMembresia;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarcorreo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Actualizar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAtras;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto_GYM;component/actualizar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Actualizar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbDia = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Actualizar.xaml"
            this.cmbDia.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbDia_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbMes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Actualizar.xaml"
            this.cmbMes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbMes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbAño = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\Actualizar.xaml"
            this.cmbAño.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbAño_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbMembresia = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\Actualizar.xaml"
            this.cmbMembresia.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbMembresia_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Actualizar.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEditarcorreo = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Actualizar.xaml"
            this.btnEditarcorreo.Click += new System.Windows.RoutedEventHandler(this.btnEditarcorreo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAtras = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Actualizar.xaml"
            this.btnAtras.Click += new System.Windows.RoutedEventHandler(this.btnAtras_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
