using NorthwindSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Northwind.Data.Entities;
#endregion

namespace NorthwindSystem.BLL
{
    //this is the public interface class that will handle
    //  web page service request for data to the Product sql table
    //Methods in this class can interact with the internal DAL Context class
    public class ProductController
    {
        // this method will return all from the sql table Products
        //this method will first create a transaction code block which uses
        //  the Dal context class
        //the context ckass has a DbSet<Product> property for referencing
        //  the sql table
        //The Property works with EntityFramework to retrieve the data
        public List<Product> Products_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        //this method will return specific record from sql products table
        //  based on the primary key
        public Product Products_GetProducts(int productid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }
        
    }
}
