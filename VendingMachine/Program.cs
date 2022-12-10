using VendingMachine.Menus;
using VendingMachine.MulledWine;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IProduct selectedProduct = ProductFactory.GetProduct("4");

            //ProductInformation selectedProduct = ProductFactory.GetProduct("4");

            //selectedProduct.Description();
            //selectedProduct.Buy();
            //selectedProduct.Use();

            //Console.WriteLine($"\nKategori: {selectedProduct.Category}\nNamn: {selectedProduct.Name}" +
            //    $"\nBeskrivning: {selectedProduct.ProductDescription}\nPris: {selectedProduct.Price}");

            StartMenu.Menu();
        }
    }
}