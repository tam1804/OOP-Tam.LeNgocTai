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

    public interface IDao
    {
        bool insertDao(BaseEntity row, String name);
        int updateDao(string name, BaseEntity row);
        bool deleteDao(string name, BaseEntity row);
        object findAllDao(string name);
        object findByIdDao(int id, string nameTable);
        object findByNameDao(string name, string nameTable, BaseEntity row);
    }
    public class BaseDao : IDao
    {
        /// <summary>
        /// input data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="row">chooce one of three table(product, category, accessotion)</param>
        /// <param name="name"></param>
        /// <returns>true if if successful false if failed</returns>
        public bool insertDao(BaseEntity row, String name)
        {
            try
            {
                Database.Instaint.insertTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// update data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="name">choose one of three table(product, category, acessotion)</param>
        /// <param name="row">data from one of three table(product,category, accessotion)</param>
        /// <returns>1 if successful</returns>
        public int updateDao(string name, BaseEntity row)
        {
            Database.Instaint.updateTable(name, row);
            return 0;
        }
        /// <summary>
        /// delete one of three table
        /// </summary>
        /// <param name="name">choose one of three table(product, category, acessotion)</param>
        /// <param name="row">location to be delete</param>
        /// <returns></returns>
        public bool deleteDao(string name, BaseEntity row)
        {
            try
            {
                Database.Instaint.deleteTable(name, row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        ///return one of three table(product, category, acessotion)
        /// </summary>
        /// <param name="name">choose one of three table(product, category, acessotion)</param>
        /// <returns>one of three table(product, category, acessotion)</returns>
        public object findAllDao(string name)
        {
            return Database.Instaint.selectTable(name);
        }
        /// <summary>
        /// Search for an object in the map by id        
        /// </summary>
        /// <param name="id">location to be choice</param>
        /// <param name="nameTable">choose one of three table(product, category, acessotion)</param>
        /// <returns>an object in one of three table(product, category, accessotion)</returns>
        public object findByIdDao(int id, string nameTable)
        {
            if(nameTable == "product")
            {
                for(int i = 0; i < Database.Instaint.ListProducts().Count; i++)
                {
                    if(id == Database.Instaint.ListProducts()[i].id)
                    {
                        return Database.Instaint.ListProducts()[i];
                    }
                }
            }
            if(nameTable == "category")
            {
                for (int i = 0; i < Database.Instaint.ListCategory().Count; i++)
                {
                    if (id == Database.Instaint.ListCategory()[i].id)
                    {
                        return Database.Instaint.ListCategory()[i];
                    }
                }
            }
            if(nameTable == "accessotion")
            {
                for (int i = 0; i < Database.Instaint.ListAccessotions().Count; i++)
                {
                    if (id == Database.Instaint.ListAccessotions()[i].id)
                    {
                        return Database.Instaint.ListAccessotions()[i];
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Search for an object in the map by name
        /// </summary>
        /// <param name="name">name to be choice</param>
        /// <param name="nameTable">choose one of three table(product, category, acessotion)</param>
        /// <param name="row">alternative counterpart</param>
        /// <returns>an object in one of three table(product, category, accessotion)</returns>
        public object findByNameDao(string name, string nameTable, BaseEntity row)
        {
            if (nameTable == "product")
            {
                for (int i = 0; i < Database.Instaint.ListProducts().Count; i++)
                {
                    if (name == Database.Instaint.ListProducts()[i].name)
                    {
                        return Database.Instaint.ListProducts()[i];
                    }
                }
            }
            if (nameTable == "category")
            {
                for (int i = 0; i < Database.Instaint.ListCategory().Count; i++)
                {
                    if (name == Database.Instaint.ListCategory()[i].name)
                    {
                        return Database.Instaint.ListCategory()[i];
                    }
                }
            }
            if (nameTable == "accessotion")
            {
                for (int i = 0; i < Database.Instaint.ListAccessotions().Count; i++)
                {
                    if (name == Database.Instaint.ListAccessotions()[i].name)
                    {
                        return Database.Instaint.ListAccessotions()[i];
                    }
                }
            }
            return null;
        }
    }
}
