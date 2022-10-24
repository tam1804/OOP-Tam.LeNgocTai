using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.entity;

namespace OOP_Tam.LeNgocTai.demo
{
    public class CategoryDaoDemo
    {
        Database DataCategory = new Database();
        public bool insertTest(BaseEntity row)
        {
            try
            {
                DataCategory.insertCategoryTable(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object findAllTest()
        {
           return DataCategory.selectTable("category");
        }
        public void updateTest(BaseEntity row)
        {
            DataCategory.updateCategoryTable(row.id, row); 
        }
    }
}
