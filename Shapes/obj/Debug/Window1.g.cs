#pragma checksum "..\..\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1DB55A02B74EE2CACC07462D9EE07D94E6D1D0A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Shapes
{


    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 5 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas1;

#line default
#line hidden


#line 6 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectangle1;

#line default
#line hidden


#line 7 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse1;

#line default
#line hidden


#line 8 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line line1;

#line default
#line hidden


#line 20 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polygon Poly1;

#line default
#line hidden


#line 21 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polyline pline1;

#line default
#line hidden


#line 22 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path1;

#line default
#line hidden


#line 24 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Shapes;component/window1.xaml", System.UriKind.Relative);

#line 1 "..\..\Window1.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.w1 = ((Shapes.Window1)(target));
                    return;
                case 2:
                    this.canvas1 = ((System.Windows.Controls.Canvas)(target));

#line 5 "..\..\Window1.xaml"
                    this.canvas1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.canvas1_MouseLeftButtonDown);

#line default
#line hidden

#line 5 "..\..\Window1.xaml"
                    this.canvas1.MouseMove += new System.Windows.Input.MouseEventHandler(this.canvas1_MouseMove);

#line default
#line hidden
                    return;
                case 3:
                    this.rectangle1 = ((System.Windows.Shapes.Rectangle)(target));

#line 6 "..\..\Window1.xaml"
                    this.rectangle1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.rectangle1_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 4:
                    this.ellipse1 = ((System.Windows.Shapes.Ellipse)(target));

#line 7 "..\..\Window1.xaml"
                    this.ellipse1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ellipse1_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 5:
                    this.line1 = ((System.Windows.Shapes.Line)(target));

#line 8 "..\..\Window1.xaml"
                    this.line1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Line_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 6:
                    this.Poly1 = ((System.Windows.Shapes.Polygon)(target));

#line 20 "..\..\Window1.xaml"
                    this.Poly1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Poly1_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 7:
                    this.pline1 = ((System.Windows.Shapes.Polyline)(target));

#line 21 "..\..\Window1.xaml"
                    this.pline1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pline1_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 8:
                    this.path1 = ((System.Windows.Shapes.Path)(target));

#line 22 "..\..\Window1.xaml"
                    this.path1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Path_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 9:

#line 23 "..\..\Window1.xaml"
                    ((System.Windows.Shapes.Path)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Path_MouseLeftButtonDown);

#line default
#line hidden
                    return;
                case 10:
                    this.button1 = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\Window1.xaml"
                    this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);

#line default
#line hidden
                    return;
                case 11:

#line 25 "..\..\Window1.xaml"
                    ((System.Windows.Shapes.Path)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Path_MouseLeftButtonDown);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window w1;
        internal System.Windows.Controls.Button button;
        internal System.Windows.Controls.Button button2;
        internal System.Windows.Controls.Button button3;
    }
}

