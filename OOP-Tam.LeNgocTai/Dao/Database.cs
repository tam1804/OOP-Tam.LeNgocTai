using OOP_Tam.LeNgocTai.dao;
using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tam.LeNgocTai.Dao
{
    public sealed class Database
    {   
        private static Database _instain = null;
        private List<Product> productTable = new List<Product>();
        private List<Accessotion> accessotionTable = new List<Accessotion>();
        private List<Category> categoryTable = new List<Category>();
        protected const string PRODUCT = "product";
        protected const string CATEGORY = "category";
        protected const string ACCESOTION = "accessotion";
        /// <summary>
        /// create new Database
        /// </summary>
        public static Database Instaint
        {
            get
            {
                if( _instain == null)
                {
                    _instain = new Database();
                }
                return _instain;
            } 
        }
        /// <summary>
        /// input data from product table
        /// </summary>
        /// <param name="row">data of product table</param>
        public void insertProductTable(BaseEntity row)
        {
            var product = row as Product;
            productTable.Add(product);
        }
        /// <summary>
        /// input data from accessotion table
        /// </summary>
        /// <param name="row">data of accessotion table</param>
        public void insertAccessotionTable(BaseEntity row)
        {
            var accessotion = row as Accessotion;
            accessotionTable.Add(accessotion);
        }
        /// <summary>
        /// input data from category table
        /// </summary>
        /// <param name="row">data of category table</param>
        public void insertCategoryTable(BaseEntity row)
        {
            var category = row as Category;
            categoryTable.Add(category);
        }
        /// <summary>
        /// input data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="name">to choose one of three table (product, category, accessotion)</param>
        /// <param name="row">data of one of three table (product, category, accessotion)</param>
        public void insertTable(string name, BaseEntity row)
        {
            if (name == "product")
            {
                insertProductTable(row);
            }
            if (name == "accessotion")
            {
                insertAccessotionTable(row);    
            }
            if (name == "category")
            {
                insertCategoryTable(row);
            } 
        }
        /// <summary>
        /// return product table
        /// </summary>
        /// <returns>product table</returns>
        public List<Product> ListProducts()
        {
            return productTable;
        }
        /// <summary>
        /// return accessotion table
        /// </summary>
        /// <returns>accessotion table</returns>
        public List<Accessotion> ListAccessotions()
        {
            return accessotionTable;
        }
        /// <summary>
        /// return category table
        /// </summary>
        /// <returns>category table</returns>
        public List<Category> ListCategory()
        {
            return categoryTable;
        }
        /// <summary>
        /// return one of three table (product, category, accessotion)
        /// </summary>
        /// <param name="name">to choose one of three table (product, category, accessotion)</param>
        /// <returns>one of three table (product, category, accessotion)</returns>
        public object selectTable(string name)
        {
            if (name == PRODUCT)
            {
                return productTable;
            }
            if (name == CATEGORY)
            {
                return categoryTable;
            }
            if (name == ACCESOTION)
            {
                return accessotionTable;
            }
            return null;
        }
        /// <summary>
        /// update data from  one of three table (product, category, accessotion)
        /// </summary>
        /// <param name="name">choose one of three table (product, category, accessotion)</param>
        /// <param name="row">data from one of three table (product, category, accessotion)</param>
        public void updateTable(string name, BaseEntity row)
        {
            if(name == PRODUCT)
            {
                updateProductTable(row.id, row);
            } 
            if(name == ACCESOTION)
            {
                updateAccessotionTable(row.id, row);
            }
            if(name == CATEGORY)
            {
                updateCategoryTable(row.id, row);
            }
            
        }
        /// <summary>
        /// update data from product table
        /// </summary>
        /// <param name="id">location to be replaced</param>
        /// <param name="row">data from product table</param>
        public void updateProductTable(int id,BaseEntity row)
        {
            for(int i = 0; i < productTable.Count; i++)
            {
                var product = row as Product;
                if (productTable[i].id == id)
                {
                    productTable[i] = product;
                }
            }
        }
        /// <summary>
        /// update data from accessotion table
        /// </summary>
        /// <param name="id">location to be replaced</param>
        /// <param name="row">data from accessotion table</param>
        public void updateAccessotionTable(int id, BaseEntity row)
        {
            for( int i = 0; i < accessotionTable.Count; i++)
            {
                var accessotion = row as Accessotion;
                if (accessotionTable[i].id == id)
                {
                    accessotionTable[i] = accessotion;
                }
            }
        }
        /// <summary>
        /// update data from category table
        /// </summary>
        /// <param name="id">location to be replaced</param>
        /// <param name="row">data</param>
        public void updateCategoryTable(int id, BaseEntity row)
        {
            for(int i = 0; i < categoryTable.Count; i++)
            {
                var category = row as Category;
                if (categoryTable[i].id == id) 
                {
                    categoryTable[i] = category;
                }
            }
        }
        /// <summary>
        /// delete one row of one of three table
        /// </summary>
        /// <param name="name">to choose one of three table (product, category, accessotion)</param>
        /// <param name="row">location to be delete</param>
        public void deleteTable(string name, BaseEntity row)
        {
            if(name == PRODUCT)
            {
                deleteProduct(row.id);
            }
            if(name == CATEGORY)
            {
                deleteCategory(row.id);
            }
            if(name == ACCESOTION)
            {
                deleteAccessotion(row.id);
            }
        }
        /// <summary>
        /// delete one row of product table
        /// </summary>
        /// <param name="id">location to be delete</param>
        public void deleteProduct(int id)
        {
            for(int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].id == id)
                {
                    productTable.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// delete one row of category table
        /// </summary>
        /// <param name="id">location to be delete</param>
        public void deleteCategory(int id)
        {
            for(int i = 0; i < categoryTable.Count; i++)
            {
                if (categoryTable[i].id == id)
                {
                    categoryTable.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// delete one row of category
        /// </summary>
        /// <param name="id">location to be delete</param>
        public void deleteAccessotion(int id)
        {
            for(int i = 0; i < accessotionTable.Count; i++)
            {
                if (accessotionTable[i].id == id)
                {
                    accessotionTable.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// delete one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="name">choose one of three table(category, product, accessotion)</param>
        public void truncateTable(string name)
        {
            if(name == PRODUCT)
            {
                productTable.Clear();
            }
            if(name == CATEGORY)
            {
                categoryTable.Clear();
            }
            if(name == ACCESOTION)
            {
                accessotionTable.Clear();
            }
        }
        /// <summary>
        /// update data from one of three table(product, category, accessotion)
        /// </summary>
        /// <param name="Id">location to be delete</param>
        /// <param name="row">data update</param>
        public void updateTableById(int Id, BaseEntity row)
        {
            string name = row.name;
            if (name == PRODUCT)
            {
                updateProductTable(Id, row);
            }
            if (name == ACCESOTION)
            {
                updateAccessotionTable(Id, row);
            }
            if (name == CATEGORY)
            {
                updateCategoryTable(Id, row);
            }
        }
    }
}
