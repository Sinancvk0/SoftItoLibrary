using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BookBarcode
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BarcodeNo { get; set; }

   
        public List<Hire> Hire { get; set; }

    }
}
