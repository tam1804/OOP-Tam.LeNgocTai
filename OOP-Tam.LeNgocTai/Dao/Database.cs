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
    public class Database
    {


        List<Product> productTable = new List<Product>();
        List<Accessotion> accessotionTable = new List<Accessotion>();
        List<Category> categoryTable = new List<Category>();
        Database instants = new Database();

        public void insertProductTable(BaseEntity row)
        {
            var product = row as Product;
            productTable.Add(product);
        }
        public void insertAccessotionTable(BaseEntity row)
        {
            var accessotion = row as Accessotion;
            accessotionTable.Add(accessotion);
        }
        public void insertCategoryTable(BaseEntity row)
        {
            var category = row as Category;
            categoryTable.Add(category);
        }
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
        public List<Product> ListProducts()
        {
            return productTable;
        }
        public object selectTable(string name)
        {
            if (name == "product")
            {
                return productTable;
            }
            if (name == "category")
            {
                return categoryTable;
            }
            if (name == "accessory")
            {
                return accessotionTable;
            }
            return null;

        }
        public void updateTable(string name, BaseEntity row)
        {
            if(name == "product")
            {
                updateProductTable(row.id, row);
            } 
            if(name == "accessotion")
            {
                updateAccessotionTable(row.id, row);
            }
            if(name == "category")
            {
                updateCategoryTable(row.id, row);
            }
            
        }
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
        public void deleteTable(string name, BaseEntity row)
        {
            if(name == "product")
            {
                deleteProduct(row.id);
            }
            if(name == "category")
            {
                deleteCategory(row.id);
            }
            if(name == "accessotion")
            {
                deleteAccessotion(row.id);
            }
        }
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
        public void truncateTable(string name)
        {
            if(name == "product")
            {
                productTable.Clear();
            }
            if(name == "category")
            {
                categoryTable.Clear();
            }
            if(name == "accessotion")
            {
                accessotionTable.Clear();
            }
        }
        public void updateTableById(int Id, BaseEntity row)
        {
            string name = row.name;
            if (name == "product")
            {
                updateProductTable(Id, row);
            }
            if (name == "accessotion")
            {
                updateAccessotionTable(Id, row);
            }
            if (name == "category")
            {
                updateCategoryTable(Id, row);
            }

        }
    }
}
