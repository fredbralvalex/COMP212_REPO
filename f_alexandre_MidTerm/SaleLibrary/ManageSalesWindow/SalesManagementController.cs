using SaleLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSalesWindow
{


    class SalesManagementController
    {
        PMSEntities dbContext = new PMSEntities();
        public IEnumerable<product> Products => dbContext.products.Local;

        public SalesManagementController()
        {
            dbContext.sales.Load();
            dbContext.products.Load();
            dbContext.employees.Load();
            QuerySales();
        }

        public IEnumerable QuerySales(string employeeId = null)
        {

            if (employeeId != null && employeeId.Length > 0)
            {
                return from sales in dbContext.sales.Local
                            join product p in dbContext.products.Local on sales.product_code equals p.code
                            where sales.id.Equals(employeeId)
                select new { ProductID = p.code, ProductName = p.name, Quantity = sales.quantity, SoldTime = sales.saleDate };
            }
            else
            {
                return from sales in dbContext.sales.Local
                       join product p in dbContext.products.Local on sales.product_code equals p.code                       
                       select new { ProductID = p.code, ProductName = p.name, Quantity = sales.quantity, SoldTime = sales.saleDate};
            }

        }

        private int QueryCountSales()
        {
            return dbContext.sales.Local.Count();
        }

        public IEnumerable InsertSale(product pduct, int quantity, string employeeId)
        {

            var employees = from e in dbContext.employees.Local
                        where e.id.Equals(employeeId)
                        select e;

            employee em = null;
            foreach (employee e in employees)
            {
                em  = e;
            }

            sale s = new sale
            {
                id = employeeId,
                product = pduct,
                employee = em,
                product_code = pduct.code,
                quantity = quantity,
                saleDate = DateTime.Now
                
            };

            var count = from p in dbContext.products.Local
                        where p.code.Equals(pduct.code)
                        select p.inventory;

            int qt = 0;
            foreach(int c in count)
            {
                qt += c;
            }

            if (qt >= quantity)
            {
                //int id = QueryCountSales();
                dbContext.sales.Local.Add(s);
                pduct.inventory = pduct.inventory - quantity;
                dbContext.SaveChanges();
            } else
            {
                //show some message
            }
            
            return QuerySales(employeeId);
        }
    }
}
