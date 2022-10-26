using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam;

namespace OOP_Tam.LeNgocTai
{
    public class ProductDemo : Product
    {
        static void printProduct(Product product)
        {
            Console.WriteLine(product.name);
            Console.WriteLine(product.id);
            Console.WriteLine(product.categoryId);
        }
        static Product createProductTest()
        {   
            Product productSystemIn = new Product ();
            Console.WriteLine("Mời bạn nhập dữ liệu đầu vào");
            Console.WriteLine("name = ");
            productSystemIn.name = Console.ReadLine();
            Console.WriteLine("id = ");
            productSystemIn.id = int.Parse(Console.ReadLine());
            Console.WriteLine("categoryId = ");
            productSystemIn.categoryId = int.Parse(Console.ReadLine());
            return productSystemIn;
        }
    }
}
