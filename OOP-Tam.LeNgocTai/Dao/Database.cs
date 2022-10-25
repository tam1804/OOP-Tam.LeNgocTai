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
    public sealed class Database : BaseDao
    {
        private Database() { }
        List<Product> productTable = new List<Product>();
        List<Accessotion> accessotionTable = new List<Accessotion>();
        List<Category> categoryTable = new List<Category>();
        Database instants = new Database();
        protected const string PRODUCT = "product";
        protected const string CATEGORY = "category";
        protected const string ACCESOTION = "accessotion";
 /*       public sealed class Singleton
        {
            private Singleton() { }
            static readonly Singleton _instance = new Singleton();
            public static Singleton Instance => _instance;
            private int _count = 0;
            public void Increase() => _count++;
            public int Count => _count;
        }*/
        protected void insertProductTable(BaseEntity row)
        {
            var product = row as Product;
            productTable.Add(product);
        }
        protected void insertAccessotionTable(BaseEntity row)
        {
            var accessotion = row as Accessotion;
            accessotionTable.Add(accessotion);
        }
        protected void insertCategoryTable(BaseEntity row)
        {
            var category = row as Category;
            categoryTable.Add(category);
        }
        protected void insertTable(string name, BaseEntity row)
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
        public List<Product> ListProducts()
        {
            return productTable;
        }
        public List<Accessotion> ListAccessotions()
        {
            return accessotionTable;
        }
        public List<Category> ListCategory()
        {
            return categoryTable;
        }
        protected object selectTable(string name)
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
        protected void updateTable(string name, BaseEntity row)
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
        protected void updateProductTable(int id,BaseEntity row)
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
        protected void updateAccessotionTable(int id, BaseEntity row)
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
        protected void updateCategoryTable(int id, BaseEntity row)
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
        protected void deleteTable(string name, BaseEntity row)
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
        protected void deleteProduct(int id)
        {
            for(int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].id == id)
                {
                    productTable.RemoveAt(i);
                }
            }
        }
        protected void deleteCategory(int id)
        {
            for(int i = 0; i < categoryTable.Count; i++)
            {
                if (categoryTable[i].id == id)
                {
                    categoryTable.RemoveAt(i);
                }
            }
        }
        protected void deleteAccessotion(int id)
        {
            for(int i = 0; i < accessotionTable.Count; i++)
            {
                if (accessotionTable[i].id == id)
                {
                    accessotionTable.RemoveAt(i);
                }
            }
        }
        protected void truncateTable(string name)
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
        protected void updateTableById(int Id, BaseEntity row)
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
