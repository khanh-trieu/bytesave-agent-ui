#pragma checksum "..\..\..\..\Views\AddConfigBackupView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325E8CFB0EAA521C2FBEBF0A53E8F0F9A6689ABA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using TransferWorker.UI.Views;


namespace TransferWorker.UI.Views {
    
    
    /// <summary>
    /// AddConfigBackupView
    /// </summary>
    public partial class AddConfigBackupView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TransferWorker.UI.Views.AddConfigBackupView ConfigList;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InputBox;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YesButton;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoButton;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton day3;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\..\Views\AddConfigBackupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker PresetTimePicker;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TransferWorker.UI;component/views/addconfigbackupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddConfigBackupView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ConfigList = ((TransferWorker.UI.Views.AddConfigBackupView)(target));
            return;
            case 2:
            
            #line 86 "..\..\..\..\Views\AddConfigBackupView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Browse_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 88 "..\..\..\..\Views\AddConfigBackupView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Browse_ClickedFile);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 196 "..\..\..\..\Views\AddConfigBackupView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CoolButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InputBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.YesButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.NoButton = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\..\..\Views\AddConfigBackupView.xaml"
            this.NoButton.Click += new System.Windows.RoutedEventHandler(this.NoButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.day3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.PresetTimePicker = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            
            #line 339 "..\..\..\..\Views\AddConfigBackupView.xaml"
            this.PresetTimePicker.SelectedTimeChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.DateTime>>(this.PresetTimePicker_SelectedTimeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

