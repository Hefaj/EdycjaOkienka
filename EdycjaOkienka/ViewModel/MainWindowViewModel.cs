using System.Collections.ObjectModel;
using System.Windows.Input;
using EdycjaOkienka.Common;
using EdycjaOkienka.Controller;
using EdycjaOkienka.Model;
using EdycjaOkienka.View;

namespace EdycjaOkienka.ViewModel
{
    public class MainWindowViewModel
    {
        private ICommand btnAdd;
        public ICommand BtnAdd => btnAdd ?? (btnAdd = new RelayCommand(btnAdd_click));

        private ICommand btnEdit;
        public ICommand BtnEdit => btnEdit ?? (btnEdit = new RelayCommand(btnEdit_click));

        private ICommand btnDelete;
        public ICommand BtnDelete => btnDelete ?? (btnDelete = new RelayCommand(btnDelete_click));

        public ObservableCollection<Product> ProductList { get; set; }

        public MainWindowViewModel()
        {
            ProductList = ProductController.GetData();
        }

        private void btnAdd_click(object obj)
        {
            var frm = new AddEditProduct();
            frm.ShowDialog();
        }

        private void btnEdit_click(object obj)
        {
            if (obj is Product product)
            {
                var frm = new AddEditProduct(product);
                frm.ShowDialog();
            }
            else
            {
                MessageController.ShowError("Nie wybrano produktu.");
            }
        }

        private void btnDelete_click(object obj)
        {
            if (obj is Product selectedProduct)
            {
                var status = ProductController.DeleteItem(selectedProduct);
                ShowMessage(status);
            }
            else
            {
                MessageController.ShowError("Nie wybrano produktu.");
            }
        }

        private void ShowMessage(OperationStatus status)
        {
            switch (status)
            {
                case OperationStatus.Ok:
                    MessageController.ShowInfo("Operacja wykonana poprawnie.");
                    break;
                case OperationStatus.NotExist:
                    MessageController.ShowError("Element nie istnieje. Odśwież liste.");
                    break;
                case OperationStatus.Exception:
                    MessageController.ShowError("Nieoczekiwany błąd zgłoś się do IT.");
                    break;
            }
        }
    }
}