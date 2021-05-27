using NewsWebSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Services.Common
{
     public class ContextManagment
    {
        private static DatabaseContext _databasContext;
   

        private ContextManagment() { }

        public static DatabaseContext GetContext()
        {
            if (_databasContext == null)
                _databasContext = new DatabaseContext(); 
            return _databasContext;
        }

        public static int Save()
        {
            if (_databasContext == null)
                throw new ArgumentNullException("Önce Context Oluşturulmalı");
            return _databasContext.SaveChanges();
        }

        public static void Disposing()
        {
            if (_databasContext == null)
                throw new ArgumentNullException("Önce Context Oluşturulmalı");
            _databasContext.Dispose();
            _databasContext = null;
        }
    }
}
