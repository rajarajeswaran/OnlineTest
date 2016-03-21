using Couchbase.Lite;
using OT.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.Data
{
    public class Repository
    {
        private Manager Manager { get; set; }
        public Database Database { get; set; }
        public Repository()
        {
            Manager = Manager.SharedInstance;
            Database = Manager.GetDatabase("OTDB");
        }
        public void  Add<E>(E entity) where E : Entity
        {
            
            var id = Database.CreateDocument();
            Database.PutLocalDocument(id.Id, new Dictionary<string, Object>() { { entity.Title, entity } });
        }
    }
}
