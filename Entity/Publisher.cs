using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Publisher:BaseModel 
    {
        public List<Book> Books { get; set; }
    }
}
