// Updated by XamlIntelliSenseFileGenerator 23/12/2021 10:42:57
#pragma checksum "..\..\..\..\Tankkaart\TankkaartWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EBD62455D69497F275992D7E18ACD05CBFE16FA"
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
using WpfFleetManagement;


namespace WpfFleetManagement.Tankkaart
{


    /// <summary>
    /// TankkaartWindow
    /// </summary>
    public partial class TankkaartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 54 "..\..\..\..\Tankkaart\TankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterButton;

#line default
#line hidden


#line 62 "..\..\..\..\Tankkaart\TankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VerwijderButton;

#line default
#line hidden


#line 103 "..\..\..\..\Tankkaart\TankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VoegToeButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfFleetManagement;V1.0.0.0;component/tankkaart/tankkaartwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Tankkaart\TankkaartWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 8 "..\..\..\..\Tankkaart\TankkaartWindow.xaml"
                    ((WpfFleetManagement.TankkaartWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.TankkaartWindow_Closing);

#line default
#line hidden
                    return;
                case 2:
                    this.FilterButton = ((System.Windows.Controls.Button)(target));
                    return;
                case 3:
                    this.VerwijderButton = ((System.Windows.Controls.Button)(target));
                    return;
                case 4:
                    this.VoegToeButton = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox TextBoxGekozenBestuurder;
        internal System.Windows.Controls.Button KiesBestuurderButton;
        internal System.Windows.Controls.Button WijzigButton;
        internal System.Windows.Controls.TextBox Aanpassen_KaartnummerTextbox;
        internal System.Windows.Controls.DatePicker Aanpassen_GeldigheidsdatumDatePicker;
        internal System.Windows.Controls.TextBox Aanpassen_PincodeTextbox;
        internal System.Windows.Controls.CheckBox Aanpassen_IsGeblokkeerdCheckbox;
        internal System.Windows.Controls.ComboBox Aanpassen_BrandstoftypeCombobox;
        internal System.Windows.Controls.TextBox Aanpassen_TankkaartIdTextbox;
        internal System.Windows.Controls.DataGrid TankkaartDatagrid;
        internal System.Windows.Controls.TextBox VoegToe_KaartnummerTextbox;
        internal System.Windows.Controls.DatePicker VoegToe_GeldigheidsdatumDatePicker;
        internal System.Windows.Controls.TextBox VoegToe_PincodeTextbox;
        internal System.Windows.Controls.CheckBox VoegToe_IsGeblokkeerdCheckbox;
        internal System.Windows.Controls.ComboBox VoegToe_BrandstofTypeCombobox;
    }
}

