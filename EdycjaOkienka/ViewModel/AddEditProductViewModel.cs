using System.Windows.Input;
using EdycjaOkienka.Common;
using EdycjaOkienka.Controller;
using EdycjaOkienka.Model;

namespace EdycjaOkienka.ViewModel
{
    public class AddEditProductViewModel
    {
        private ICommand btnAddEdit;
        public ICommand BtnAddEdit => btnAddEdit ?? (btnAddEdit = new RelayCommand(btnAddEdit_click));

        private bool isEdited;
        public Product CurrentProduct { get; set; }


        public AddEditProductViewModel(Product currentProduct = null)
        {
            isEdited = currentProduct is null;
            
            if (currentProduct is null)
            {
                CurrentProduct = new Product();
            }
            else
            {
                CurrentProduct = new Product
                {
                    ID = currentProduct.ID,
                    Magazyn = currentProduct.Magazyn,
                    Nazwa = currentProduct.Nazwa,
                    Symbol = currentProduct.Symbol,
                    LiczbaSztuk = currentProduct.LiczbaSztuk
                };
            }
        }

        private void btnAddEdit_click(object obj)
        {
            OperationStatus status;
            if (CheckData())
            {
                if (isEdited)
                {
                    status = ProductController.Edit(CurrentProduct);
                }
                else
                {
                    status = ProductController.Save(CurrentProduct);
                }
            }
            else
            {
                MessageController.ShowError("Nie podano wszystkich danych.");
            }
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(CurrentProduct.Symbol)
                || string.IsNullOrWhiteSpace(CurrentProduct.Nazwa)
                || CurrentProduct.LiczbaSztuk < 0
                || string.IsNullOrWhiteSpace(CurrentProduct.Magazyn))
                return false;
            return true;
        }
    }
}