using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Entity
{
    internal class Book
    {
        //treating id as primary key for book ( each book will have several book items )
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Author { get; set; }= string.Empty;
        public DateOnly PublishDate { get; set; }


    }
}
