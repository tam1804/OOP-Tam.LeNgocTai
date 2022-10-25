using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.dao;

namespace OOP_Tam.LeNgocTai.Dao
{
    public class CategoryDao : BaseDao
    {
        Database DataCategory = new Database();

        public bool insert(Category row)
        { 
            try
            {
                DataCategory.insertTable("category", row);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}   
