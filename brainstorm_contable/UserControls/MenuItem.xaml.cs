using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace brainstorm_contable.UserControls
{
    /// <summary>
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {
        public ImageSource IconSource
        {
            get { return (ImageSource)GetValue(IconSourceProperty); }
            set { SetValue(IconSourceProperty, value); }
        }

        public static readonly DependencyProperty IconSourceProperty =
            DependencyProperty.Register(
                "IconSource",
                typeof(ImageSource),
                typeof(MenuItem),
                new UIPropertyMetadata());
        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }

        public static readonly DependencyProperty TextContentProperty =
            DependencyProperty.Register(
                "TextContent",
                typeof(string),
                typeof(MenuItem),
                new UIPropertyMetadata());

        
        public event EventHandler Click;

        public MenuItem()
        {
            InitializeComponent();
            btn.Click += HandleClick;
        }

        private void HandleClick(object sender, RoutedEventArgs e)
        {
            OnClick(EventArgs.Empty);
        }

        protected virtual void OnClick(EventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
