
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.entity;

namespace OOP_Tam.LeNgocTai.demo
{
    public class DatabaseDemo : Database
    {
        DatabaseDemo instants = new DatabaseDemo();
        Database database = new Database();

        public void insertTableTest(string name, baseEntity row)
        {   
            insertTable(name, row);
        }
        public object selectTableTest(string name)
        {
            return selectTable(name);
        }
        public void updateTableTest(string name, baseEntity row)
        {
            updateTable(name, row);
        }
        public void deleteTableTest(string name, baseEntity row)
        {
            deleteTable(name, row);
        }
        public void truncateTablTest(string name)
        {
            truncateTable(name);
        }
        public void updateTableByIdTest(int Id, baseEntity row)
        {
            updateTableById(Id, row);
        }
    }
}
