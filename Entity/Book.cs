using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Book:BaseModel
    {
        public int ISBN { get; set; }
        public string? Description { get; set; }
        public int TotalPages { get; set; }
        public string? Image { get; set; }

        public string Language { get; set; }

        public int PublicationDate { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
        public int TotalCopy { get; set; }
        public List<BookBarcode>? BookBarcodes { get; set; }
    }
}
