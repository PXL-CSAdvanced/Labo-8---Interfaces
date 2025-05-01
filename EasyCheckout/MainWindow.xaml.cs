using EasyCheckout.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyCheckout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OnCheckout_Clicked(object sender, RoutedEventArgs e)
        {
            IPaymentMethod method = paymentMethodComboBox.SelectedItem as IPaymentMethod;

            if (method is not null)
            {
                paymentResultTextBlock.Text = method.ProcessPayment(0);
            }
        }
    }
}