using assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Entity
{

    internal class BookItem : Book
    {
        //item id is the primary key of individual book
        public int ItemId { get; set; }
        public DateOnly? IssueDate{ get; set; }
        public BookStatus Status { get; set; }

    }
}
