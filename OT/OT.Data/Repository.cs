using Couchbase.Lite;
using OT.Data.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OT.Data
{
    public class Repository
    {
        private Manager Manager { get; set; }
        public Database Database { get; set; }
        public Repository()
        {
            Manager = Manager.SharedInstance;
            Database = Manager.GetDatabase("otb");
        }
        public string  Add<TE>(TE entity) where TE : Entity
        {
            
            var id = Database.CreateDocument();
            Database.PutLocalDocument(id.Id, new Dictionary<string, Object>() { { entity.Title, entity } });
            return id.Id;
        }


        public TE Query<TE>(string id , string title) where TE : Entity
        {
            var doc = Database.GetExistingLocalDocument(id);
            

            var docdata = doc[title];

            JsonSerializer serializer = new JsonSerializer();
            var sw = new StringWriter();

            serializer.Serialize(sw, docdata);

            var json = sw.GetStringBuilder().ToString();

            var te = serializer.Deserialize<TE>(new JsonTextReader(new StringReader(json)));

            return te;
        }
    }
}
