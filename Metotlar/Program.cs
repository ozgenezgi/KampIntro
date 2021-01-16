using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Product1 = new Product();
            Product1.ProductName = "Apple";
            Product1.Price = 15;
            Product1.Explanation = "Apple of Amasya";

            Product Product2 = new Product();
            Product2.ProductName = "Watermelon";
            Product2.Price = 80;
            Product2.Explanation = "Watermelon of Diyarbakir";


            Product[] Products = new Product[] { Product1, Product2 };

            foreach (Product product in Products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------");



            }

            Console.WriteLine("--------Metotlar--------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Product1);
            sepetManager.Ekle(Product2);


            sepetManager.EkleAlternatif("Armut", "yeşil armut", 12, 10);
            sepetManager.EkleAlternatif("elma", "yeşil elma", 12, 9);
            sepetManager.EkleAlternatif("karpuz", "diyarbakır karpuzu", 12, 8); 
        }
    }
}
