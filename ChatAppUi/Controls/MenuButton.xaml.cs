using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatAppUi.Controls
{
    /// <summary>
    /// Interaction logic for MenuButton.xaml
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(MenuButton));
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(MenuButton));
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(MahApps.Metro.IconPacks.PackIconMaterialKind), typeof(MenuButton));


        public MenuButton()
        {
            InitializeComponent();
        }
    }
}
