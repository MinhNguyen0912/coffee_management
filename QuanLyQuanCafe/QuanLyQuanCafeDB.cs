using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    internal class QuanLyQuanCafeDB
    {
        private static QuanLyQuanCafeEntities db;

        public static QuanLyQuanCafeEntities Db
        {
            get
            {
                if (db == null)
                {
                    db = new QuanLyQuanCafeEntities();
                }
                return db;
            }
            set => db = value;
        }
        private QuanLyQuanCafeDB()
        {

        }
    }
}
