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
    /// Interaction logic for AccountMenu.xaml
    /// </summary>
    public partial class AccountMenu : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(AccountMenu));
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(AccountMenu));
        public static readonly DependencyProperty GradientColor1Property = DependencyProperty.Register("GradientColor1", typeof(Color), typeof(AccountMenu));
        public static readonly DependencyProperty GradientColor2Property = DependencyProperty.Register("GradientColor2", typeof(Color), typeof(AccountMenu));


        public AccountMenu()
        {
            InitializeComponent();
        }
    }
}
