using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.Data.Model
{
    public class Question:Entity
    {
        public ICollection<Answer> Options { get; set; }
        public Answer Answer { get; set; }

    }
}
