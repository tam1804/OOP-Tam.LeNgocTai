using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.entity;

namespace OOP_Tam.LeNgocTai.demo
{
    public class ProductDaoDemo
    {
        Database DataProduct = new Database();

        public bool insertTest(BaseEntity row)
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
        public int updateTest(BaseEntity row)
        {
            DataProduct.updateProductTable(row.id, row);
            return 0;
        }
        public bool deleteTest(BaseEntity row)
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
        public object findAllTest()
        {
            return DataProduct.selectTable("product");
        }
        public object findById(int id)
        {
            int n = DataProduct.ListProducts().Count;
            for (int i = 0; i < n; i++)
            {
                if (id == DataProduct.ListProducts()[i].id)
                {
                    return DataProduct.ListProducts()[i];
                }
                return null;
            }
        }
        public object findByNameTest(string name)
        {
            int n = DataProduct.ListProducts().Count;
            for (int i = 0; i < n; i++)
            {
                if (name == DataProduct.ListProducts()[i].name)
                {
                    return DataProduct.ListProducts()[i];
                }
                return null;
            }
        }
    }
}
