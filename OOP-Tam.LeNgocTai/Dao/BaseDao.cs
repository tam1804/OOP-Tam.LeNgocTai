using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP_Tam.LeNgocTai.dao
{
    public class BaseDao
    {
        Database DatabaseDao = new Database();
        public bool insertDao(BaseEntity row, String name)
        {
            try
            {
                DatabaseDao.insertTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int updateDao(string name, BaseEntity row)
        {
            DatabaseDao.updateTable(name, row);
            return 0;
        }
        public bool deleteDao(string name, BaseEntity row)
        {
            try
            {
                DatabaseDao.deleteTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object findAllDao(string name)
        {
            return DatabaseDao.selectTable(name);
        }
        public object findByIdDao(int id, string nameTable)
        {
            if(NameTable == "product")
            {
                for(int i = 0; i < DatabaseDao.ListProducts().Count; i++)
                {
                    if(id == DatabaseDao.ListProducts()[i].id)
                    {
                        return DatabaseDao.ListProducts()[i];
                    }
                }
            }
            if(nameTable == "category")
            {
                for (int i = 0; i < DatabaseDao.ListCategory().Count; i++)
                {
                    if (id == DatabaseDao.ListCategory()[i].id)
                    {
                        return DatabaseDao.ListCategory()[i];
                    }
                }
            }
            if(nameTable == "accessotion")
            {
                for (int i = 0; i < DatabaseDao.ListAccessotions().Count; i++)
                {
                    if (id == DatabaseDao.ListAccessotions()[i].id)
                    {
                        return DatabaseDao.ListAccessotions()[i];
                    }
                }
            }
            return null;
        }
        public object findByNameDao(string name, string nameTable, BaseEntity row)
        {
            if (NameTable == "product")
            {
                for (int i = 0; i < DatabaseDao.ListProducts().Count; i++)
                {
                    if (name == DatabaseDao.ListProducts()[i].name)
                    {
                        return DatabaseDao.ListProducts()[i];
                    }
                }
            }
            if (nameTable == "category")
            {
                for (int i = 0; i < DatabaseDao.ListCategory().Count; i++)
                {
                    if (name == DatabaseDao.ListCategory()[i].name)
                    {
                        return DatabaseDao.ListCategory()[i];
                    }
                }
            }
            if (nameTable == "accessotion")
            {
                for (int i = 0; i < DatabaseDao.ListAccessotions().Count; i++)
                {
                    if (name == DatabaseDao.ListAccessotions()[i].name)
                    {
                        return DatabaseDao.ListAccessotions()[i];
                    }
                }
            }
            return null;
        }
    }
}
