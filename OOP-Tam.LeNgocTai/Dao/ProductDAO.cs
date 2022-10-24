using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tam.LeNgocTai.Dao
{
    internal class ProductDAO
    {
        Database DataProduct = new Database();
        public bool insert(BaseEntity row)
        {
            try
            {
                DataProduct.insertProductTable(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int update(BaseEntity row)
        {
            DataProduct.updateProductTable(row.id, row);
            return 0;
        }
        public bool delete(BaseEntity row)
        {
            try
            {
                DataProduct.deleteProduct(row.id);
                return true;    
            }
            catch
            {
                return false;
            }
        }
    }
}
