using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //origen de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //TAREA

            //creaciòn de consulta
            //var query = from s in context.Suppliers from c in context.Categories from p in context.Products where p.Categories.CategoryName == "Dairy Products" select s;

            var query = from s in context.Suppliers from p in context.Products where s.Country == "USA" select p;

            foreach (var p in query)
            {
                Console.WriteLine("Name Products={0}", p.ProductName);
                
            }
            Console.ReadKey();


            /*var product = (from p in context.Products where p.ProductName == "Tofu" select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();*/

            /*var product = (from p in context.Products where p.ProductID == 78 select p).FirstOrDefault();

            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();*/

            /*Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;

            FileInfo info = new FileInfo(@"C:\Users\rosario\Desktop\IMAGENES\leche.jpg");
            int fileSize = Convert.ToInt32(info.Length);*/

            /*Categories cat = new Categories();
            cat.CategoryName = "Lacteos";
            cat.Description = "Leche Gloria, Ideal, Pura Vida";
             
                           
            //ejecución de consultas
            context.Categories.InsertOnSubmit(cat);
            context.SubmitChanges();*/

            //CONSULTAS
            //creaciòn de consulta
            //var query = from p in context.Products select p;

            //listar ID y Beverages
            //var query = from p in context.Products where p.Categories.CategoryName == "Beverages" select p;

            //var query = from p in context.Products where p.UnitPrice < 20 select p;

            //nombre =queso
            //var query = from p in context.Products where p.ProductName.Contains("Queso") select p;

            //var query = from p in context.Products where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs") select p;

            //var query = from p in context.Products where p.ProductName.StartsWith("A") select p;

            //var query = from p in context.Products where p.UnitsInStock == 0 select p;

            var query = from p in context.Products where p.Discontinued == true select p;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
                //Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice,  prod.ProductName);
            }
            Console.ReadKey();


        }
    }
}
