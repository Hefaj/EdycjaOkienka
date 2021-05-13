using System.Windows;
using EdycjaOkienka.Model;
using EdycjaOkienka.ViewModel;

namespace EdycjaOkienka.View
{
    public partial class AddEditProduct : Window
    {
        public AddEditProduct(Product product = null)
        {
            InitializeComponent();
            DataContext = new AddEditProductViewModel(product);
        }
    }
}