using EasyCheckout.Data;
using EasyCheckout.Entities;
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
        private ProductStore _productStore = new ProductStore();
        private PaymentStore _paymentStore = new PaymentStore();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Product product in _productStore.GetAllProducts())
            {
                productsComboBox.Items.Add(product);
            }

            foreach(IPaymentMethod method in _paymentStore.GetAvailablePaymentMethods())
            {
                paymentMethodComboBox.Items.Add(method);
            }
        }

        private void OnProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            amountLabel.Content = SelectedProduct?.Price.ToString("C");
        }

        public Product SelectedProduct => productsComboBox.SelectedItem as Product;

        private void OnCheckout_Clicked(object sender, RoutedEventArgs e)
        {
            IPaymentMethod method = paymentMethodComboBox.SelectedItem as IPaymentMethod;

            if (method is not null && SelectedProduct is not null)
            {
                paymentResultTextBlock.Text = method.ProcessPayment(SelectedProduct.Price);
            }
        }


    }
}