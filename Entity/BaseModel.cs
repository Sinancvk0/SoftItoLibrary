using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BaseModel
    {
        public int Id { get; set; }

        public string Name  { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDelete  { get; set; }
        public DateTime DataCreate { get; set; }= DateTime.Now;
    }
}
