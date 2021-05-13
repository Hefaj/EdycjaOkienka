using System;
using System.Collections.ObjectModel;
using System.Linq;
using EdycjaOkienka.Common;
using EdycjaOkienka.Model;

namespace EdycjaOkienka.Controller
{
    public static class ProductController
    {
        private static ObservableCollection<Product> data = new ObservableCollection<Product>
        {
            new Product(0, "O1-11", "ołówek", 8, "Katowice 1"),
            new Product(1, "PW-20", "pióro wieczne", 75, "Katowice 2"),
            new Product(2, "DZ-10", "długopis żelowy", 1121, "Katowice 1"),
            new Product(3, "DZ-12", "długopis kulkowy", 280, "Katowice 2")
        };
        
        public static ObservableCollection<Product> GetData()
        {
            return data;
        }

        public static OperationStatus DeleteItem(Product selectedProduct)
        {
            try
            {
                return TryDeleteItem(selectedProduct);
            }
            catch (Exception)
            {
                return OperationStatus.Exception;
            }
        }

        private static OperationStatus TryDeleteItem(Product selectedProduct)
        {
            if (!data.Contains(selectedProduct))
            {
                return OperationStatus.NotExist;
            }
            
            data.Remove(selectedProduct);
            return OperationStatus.Ok;
        }

        public static OperationStatus Save(Product currentProduct)
        {
            try
            {
                return TryAddItem(currentProduct);
            }
            catch (Exception)
            {
                return OperationStatus.Exception;
            }
        }

        private static OperationStatus TryAddItem(object currentProduct)
        {
            
            if (currentProduct is Product product)
            {
                data.Add(product);
                return OperationStatus.Ok;
            }
            return OperationStatus.Null;
        }

        public static OperationStatus Edit(Product currentProduct)
        {
            try
            {
                return TryEdit(currentProduct);
            }
            catch (Exception)
            {
                return OperationStatus.Exception;
            }
        }

        private static OperationStatus TryEdit(Product currentProduct)
        {
            if (data.All(x => x.ID != currentProduct.ID))
            {
                return OperationStatus.NotExist;
            }
            data[currentProduct.ID] = currentProduct; 
            return OperationStatus.Ok;
        }
    }
}