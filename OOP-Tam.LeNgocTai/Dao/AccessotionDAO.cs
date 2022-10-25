using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Tam.LeNgocTai.entity;
using OOP_Tam.LeNgocTai.Dao;

namespace OOP_Tam.LeNgocTai.dao
{
    public class AccessotionDAO : BaseDao
    {
        public int insert(BaseEntity row)
        {
            AccessotionDAODatabase.insertAccessotionTable(row);
            return 0;
        }
        public int updateDao(BaseEntity row)
        {
            AccessotionDAODatabase.updateAccessotionTable(row.id, row);
            return 0;
        }
        public bool deleteDao(BaseEntity row)
        {
            try
            {
                AccessotionDAODatabase.deleteAccessotion(row.id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Accessotion findByName(string name)
        {
            for(int i = 0; i < AccessotionDAODatabase.ListAccessotions().Count; i++)
            {
                if(AccessotionDAODatabase.ListAccessotions()[i].name == name)
                {
                    return AccessotionDAODatabase.ListAccessotions()[i];
                }
            }
            return null;
        }
        public Accessotion findById(int id)
        {
  
            for (int i = 0; i < AccessotionDAODatabase.ListAccessotions().Count; i++)
            {
                if (AccessotionDAODatabase.ListAccessotions()[i].id == id)
                {
                    return AccessotionDAODatabase.ListAccessotions()[i];
                }
                return null;
            }
        }
        public List<Accessotion> findAll()
        {
            return AccessotionDAODatabase.ListAccessotions();
        }
    }
}
