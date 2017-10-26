using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;
                IQueryable<string> productNames = from p in products select p.Name;

                Console.WriteLine("Productos:");
                foreach(var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
            }*/

            /* using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
             {
                 var products = AWEntities.Product;
                 IQueryable<string> productNames = products.Select(p => p.Name) ;

                 Console.WriteLine("Productos:");
                 foreach (var productName in productNames)
                 {
                     Console.WriteLine(productName);
                 }
                 Console.ReadKey();
             }*/

            /*using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;
                IQueryable<Product> productQuery = from p in products select p;
                IQueryable<Product> largeProducts = productQuery.Where(p => p.Size == "L");

                Console.WriteLine("Productos de tamaño 'L':");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Product> productsQuery = from product in context.Product select product;

                Console.WriteLine("Productos:");
                foreach (var product in productsQuery)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from product in context.Product
                            select new
                            {
                                ProductId = product.ProductID,
                                ProductName = product.Name
                            };

                Console.WriteLine("Información de productos:");
                foreach (var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product name: {1}", productInfo.ProductId, productInfo.ProductName );
                }
                Console.ReadKey();
            }*/

            /*decimal totalDue = 500.00M;
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var contacts = context.Contact;
                var orders = context.SalesOrderHeader;

                var query = from contact in contacts
                            from order in orders
                            where contact.ContactID == order.Contact.ContactID
                            && order.TotalDue < totalDue
                            select new
                            {
                                ContactID = contact.ContactID,
                                LastName = contact.LastName,
                                FirstName = contact.FirstName,
                                OrderID = order.SalesOrderID,
                                Total = order.TotalDue
                            };
                foreach (var smallOrder in query)
                {
                    Console.WriteLine("Contact ID: {0} \t Name: {1} \t Order ID: {3}" + "\t Total Due: ${4}",
                        smallOrder.ContactID, smallOrder.LastName, smallOrder.FirstName, smallOrder.OrderID, smallOrder.Total
                    );
                }
                
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var contacts = context.Contact;
                var orders = context.SalesOrderHeader;

                var query = from contact in contacts
                            from order in orders
                            where contact.ContactID == order.Contact.ContactID
                            && order.OrderDate >= new DateTime(2002, 10, 1)
                            select new
                            {
                                ContactID = contact.ContactID,
                                LastName = contact.LastName,
                                FirstName = contact.FirstName,
                                OrderID = order.SalesOrderID,
                                OrderDate = order.OrderDate
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("Contact ID: {0} \t Order ID: {3} \t Order date: {4}",
                        order.ContactID, order.LastName, order.FirstName, order.OrderID, order.OrderDate
                        );
                }


            }*/

            /*int orderQtyMin = 2;
            int orderQtyMax = 6;
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from order in context.SalesOrderDetail
                            where order.OrderQty > orderQtyMin
                            && order.OrderQty < orderQtyMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                OrderQty = order.OrderQty
                            };

                foreach (var order in query)
                {
                    Console.WriteLine("Order ID: {0} Order quantity: {1}",
                        order.SalesOrderID, order.OrderQty
                    );
                }

            }*/

            /*String color = "Red";
            using (AdventureWorksEntities context = new AdventureWorksEntities()) {
                var query = from product in context.Product
                            where product.Color == color
                            select new
                            {
                                Name = product.Name,
                                ProductNumber = product.ProductNumber,
                                ListPrice = product.ListPrice
                            };

                foreach (var product in query)
                {
                    Console.WriteLine("Name: {0}", product.Name);
                    Console.WriteLine("ProductNumber: {0}", product.ProductNumber);
                    Console.WriteLine("ListPrice: {0}", product.ListPrice);
                    Console.WriteLine("");
                }

            }*/

            /*using (AdventureWorksEntities AWEctities = new AdventureWorksEntities())
            {
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in AWEctities.Product
                               where productModelIds.Contains(p.ProductModelID)
                               select p;
                foreach (var product in products)
                {
                    Console.WriteLine("{0}: {1}", product.ProductModelID, product.ProductID);
                }

            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> sortedNames = from n in context.Contact
                                                  orderby n.LastName
                                                  select n;

                Console.WriteLine("Lista ordenada por apellido");
                foreach(Contact n in sortedNames)
                {
                    Console.WriteLine(n.LastName);
                }
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Decimal> sortedPrices = from p in context.Product 
                                                  orderby p.ListPrice descending
                                                  select p.ListPrice;

                Console.WriteLine("Lista de precios desde el más alto al más bajo");
                foreach (Decimal price in sortedPrices)
                {
                    Console.WriteLine(price);
                }
                Console.ReadKey();
            }
            */

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> sortedContacts = from c in context.Contact
                                                   orderby c.LastName, c.FirstName
                                                   select c;

                Console.WriteLine("Contactos ordenador por apellido y nombre :");
                foreach (Contact c in sortedContacts)
                {
                    Console.WriteLine(c.LastName + ", " + c.FirstName);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };

                foreach (var p in query)
                {
                    Console.WriteLine("Estilo: {0} Precio Promedio : {1}", p.Style, p.AverageListPrice);
                }
                Console.ReadKey();
            }*/

            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };

                foreach (var p in query)
                {
                    Console.WriteLine("Color: {0} \t Cantidad : {1}", p.Color, p.ProductCount);
                }
                Console.ReadKey();
            }*/

            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var orders = context.SalesOrderHeader;
                var query = from o in orders
                            group o by o.Contact.ContactID into g
                            select new
                            {
                                Category = g.Key,
                                maxTotalDue = g.Max(o => o.TotalDue)
                            };

                foreach (var o in query)
                {
                    Console.WriteLine("ContactID = {0} \t TotalDue máximo : {1}", o.Category, o.maxTotalDue);
                }
                Console.ReadKey();
            }
        }
    }
}
