
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.Dao;
using OOP_Tam.LeNgocTai.entity;

namespace OOP_Tam.LeNgocTai.demo
{
    public class DatabaseDemo 
    {
        DatabaseDemo instants = new DatabaseDemo();
        Database database = new Database();
        
        public void insertTableTest(string name, BaseEntity row)
        {
            database.insertTable(name, row);
        }
        public object selectTableTest(string name)
        {
            return database.selectTable(name); 
        }
        public void updateTableTest(string name, BaseEntity row)
        {
            database.updateTable(name, row);
        }
        public void deleteTableTest(string name, BaseEntity row)
        {
            database.deleteTable(name, row);
        }
        public void truncateTablTest(string name)
        {
            database.truncateTable(name);
        }
        public void updateTableByIdTest(int Id, BaseEntity row)
        {
            database.updateTableById(Id, row);
        }
    }
}
