using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hire
    {
        public int Id { get; set; }

        public int UserId { get; set; }
 
        public DateTime StartingDate { get; set; }= DateTime.Now;
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public bool isActive { get; set; }
        public List< BookBarcode> BookBarcodes { get; set; }
     

    }
}
