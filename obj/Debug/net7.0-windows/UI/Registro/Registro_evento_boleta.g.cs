﻿#pragma checksum "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0919426226C27CCFFB0A9B3D8CEEA31AF472936A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Registro_venta_boleta.UI.Registro;
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


namespace Registro_venta_boleta.UI.Registro {
    
    
    /// <summary>
    /// Registro_evento_boleta
    /// </summary>
    public partial class Registro_evento_boleta : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TexBoxNombre;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerFecha;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTipo;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxImage;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCiudad;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TexBoxLugar;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TexBoxCantidad;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Registro_venta_boleta;component/ui/registro/registro_evento_boleta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TexBoxNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DatePickerFecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.ComboBoxTipo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TextboxImage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ComboBoxCiudad = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TexBoxLugar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TexBoxCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 210 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Nuevo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 228 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 245 "..\..\..\..\..\UI\Registro\Registro_evento_boleta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

