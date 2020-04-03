using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace WpfCustomControlLibrary1
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomControlLibrary1"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomControlLibrary1;assembly=WpfCustomControlLibrary1"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public partial class ControlLibrary1 : UserControl
    {
        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;

        static ControlLibrary1()
        {
            // Регистрация свойств зависимости
            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ControlLibrary1),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));
            RedProperty = DependencyProperty.Register("Red", typeof(byte), typeof(ControlLibrary1),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            GreenProperty = DependencyProperty.Register("Green", typeof(byte), typeof(ControlLibrary1),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            BlueProperty = DependencyProperty.Register("Blue", typeof(byte), typeof(ControlLibrary1),
                 new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            ColorChangedEvent = EventManager.RegisterRoutedEvent("ColorChanged", RoutingStrategy.Bubble,
        typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ControlLibrary1));
        }
        public Color Color
        {
            get => (Color)this.GetValue(ColorProperty);

            set => this.SetValue(ColorProperty, value);
        }
        public byte Red
        {
            get => (byte)this.GetValue(RedProperty);
            set => this.SetValue(RedProperty, value);
        }
        public byte Green
        {
            get => (byte)this.GetValue(GreenProperty);
            set => this.SetValue(GreenProperty, value);
        }
        public byte Blue
        {
            get => (byte)this.GetValue(BlueProperty);
            set => this.SetValue(BlueProperty, value);
        }
        private static void OnColorRGBChanged(DependencyObject sender,
            DependencyPropertyChangedEventArgs e)
        {
            var ControlLibrary1 = (ControlLibrary1)sender;
            var color = ControlLibrary1.Color;
            if (e.Property == RedProperty)
                color.R = (byte)e.NewValue;
            else if (e.Property == GreenProperty)
                color.G = (byte)e.NewValue;
            else if (e.Property == BlueProperty)
                color.B = (byte)e.NewValue;

            ControlLibrary1.Color = color;
        }
        private static void OnColorChanged(DependencyObject sender,
      DependencyPropertyChangedEventArgs e)
        {
            var newColor = (Color)e.NewValue;
            var ControlLibrary1 = (ControlLibrary1)sender;
            ControlLibrary1.Red = newColor.R;
            ControlLibrary1.Green = newColor.G;
            ControlLibrary1.Blue = newColor.B;
        }
        public static readonly RoutedEvent ColorChangedEvent;
        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { this.AddHandler(routedEvent: ColorChangedEvent, value); }
            remove { this.RemoveHandler(ColorChangedEvent, value); }
        }
    }
}
