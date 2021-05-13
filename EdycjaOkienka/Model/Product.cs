namespace EdycjaOkienka.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }

        public Product(int id, string symbol, string nazwa, int liczbaSztuk, string magazyn)
        {
            ID = id;
            Symbol = symbol;
            Nazwa = nazwa;
            LiczbaSztuk = liczbaSztuk;
            Magazyn = magazyn;
        }

        public Product()
        {
        }
    }
}