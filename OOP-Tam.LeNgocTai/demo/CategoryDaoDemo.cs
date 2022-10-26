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
        public bool insertTest(BaseEntity row)
        {
            try
            {
                Database.Instaint.insertCategoryTable(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object findAllTest()
        {
            return Database.Instaint.selectTable("category");
        }
        public void updateTest(BaseEntity row)
        {
            Database.Instaint.updateCategoryTable(row.id, row); 
        }
    }
}
