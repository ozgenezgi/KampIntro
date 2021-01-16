using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi"+  product.ProductName);
        }

        public void EkleAlternatif(string ProductName, string Explanation,double Price, int StokAdeti)//ayrı ayrı yazılacak yapıyı bir düzene sokuyoruz
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi" + ProductName);

        }
     

        
    }
}
