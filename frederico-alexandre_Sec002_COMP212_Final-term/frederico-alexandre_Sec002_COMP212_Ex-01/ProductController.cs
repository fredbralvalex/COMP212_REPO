using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frederico_alexandre_Sec002_COMP212_Ex_01
{
    class ProductController
    {
        private static ProductController instance;
        public SortedDictionary<long, Product> Products = new SortedDictionary<long, Product>();

        public static ProductController GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductController();
            }
            return instance;
        }

        public void GenerateProducts() {
            Product p1 = new Product(101, "Product01", 10.0, "Company1");
            Product p2 = new Product(102, "Product02", 11.0, "Company2");
            Product p3 = new Product(103, "Product03", 12.0, "Company3");
            Product p4 = new Product(104, "Product04", 13.0, "Company4");
            Product p5 = new Product(105, "Product05", 14.0, "Company5");
            Products.Add(101, p1);
            Products.Add(102, p2);
            Products.Add(103, p3);
            Products.Add(104, p4);
            Products.Add(105, p5);
        }

        public void AddProduct(long ID, string Name, Double Price, string Company)
        {
            Product product = new Product(ID, Name, Price, Company);
            if (SearchProduct(Name) != null)
            {
                throw new ArgumentException("Product Already Exists!");
            }
            Products.Add(ID, product);
        }

        public void RemoveProduct(long ID)
        {
            Products.Remove(ID);
        }

        public Product SearchProduct(string Name)
        {
            foreach (KeyValuePair<long, Product> pair in Products)
            {
                Product p = pair.Value;
                if ((p.Name).Equals(Name))
                {
                    return p;
                }
            }
            return null;
        }
        public Product SearchProduct(long ID)
        {
            foreach (KeyValuePair<long, Product> pair in Products)
            {
                Product p = pair.Value;
                if ((p.ID).Equals(ID))
                {
                    return p;
                }
            }
            return null;
        }

        public void RemoveProduct(string Name)
        {
            Product p = SearchProduct(Name);
            if (p == null)
            {
                throw new ArgumentException("Product Does not exists!");
            }
            Products.Remove(p.ID);            
        }
        public string PrintProducts()
        {
            string print = "";
            foreach (KeyValuePair<long, Product> pair in Products)
            {
                Product p = pair.Value;
                print = print + "\r\n" + p;
            }
            return print;
        }

    }
}
