using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Author:BaseModel
    {
        public List<Book> Books { get; set; }
    }
}
