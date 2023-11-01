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
 
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public  int BarcodeId { get; set; }
        public BookBarcode bookBarcode { get; set; }
     

    }
}
