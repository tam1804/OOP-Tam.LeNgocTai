using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public void insertProductTable(baseEntity row)
        {
            var product = row as Product;
            productTable.Add(product);
        }
        public void insertAccessotionTable(baseEntity row)
        {
            var accessotion = row as Accessotion;
            accessotionTable.Add(accessotion);
        }
        public void insertCategoryTable(baseEntity row)
        {
            var category = row as Category;
            categoryTable.Add(category);
        }
        public void insertTable(string name, baseEntity row)
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



            /* public static void Main() {


             }*/





        }
        public void updateTable(string name, baseEntity row)
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
        public void updateProductTable(int id,baseEntity row)
        {
            for(int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].id == id)
                {
                    productTable[i].name =row.name;
                    productTable[i].categoryId = id;
                }
            }
        }
        public void updateAccessotionTable(int id, baseEntity row)
        {
            for( int i = 0; i < accessotionTable.Count; i++)
            {
                if (accessotionTable[i].id == id)
                {
                    accessotionTable[i].name =row.name;
                }
            }
        }
        public void updateCategoryTable(int id, baseEntity row)
        {
            for(int i = 0; i < categoryTable.Count; i++)
            {
                if(categoryTable[i].id == id) 
                { categoryTable[i].name =row.name; }
            }
        }
        public void deleteTable(string name, baseEntity row)
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
        public void updateTableById(int Id,baseEntity row)
        {
            
        }
    }
}
