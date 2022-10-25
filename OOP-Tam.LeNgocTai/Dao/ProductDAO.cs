﻿using OOP_Tam.LeNgocTai.dao;
using OOP_Tam.LeNgocTai.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tam.LeNgocTai.Dao
{
    internal class ProductDAO : BaseDao
    {
        Database DataProduct = new Database();
        public bool insert(BaseEntity row)
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
        public int update(BaseEntity row)
        {
            DataProduct.updateProductTable(row.id, row);
            return 0;
        }
        public bool delete(BaseEntity row)
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
        public object findAll()
        {
            return DataProduct.selectTable("product");
        }
        public object findById(int id)
        {
            int n = DataProduct.ListProducts().Count;
            for(int i = 0; i < n; i++)
            {
                if(id == DataProduct.ListProducts()[i].id)
                {
                   return DataProduct.ListProducts()[i];
                }
                return null;
            } 
        }
        public object findByName(string name)
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
