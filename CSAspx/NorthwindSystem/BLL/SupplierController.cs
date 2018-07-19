using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Northwind.Data.Entities;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    public class SupplierController
    {
        public List<Supplier> Supplier_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }
        }
    }
}
