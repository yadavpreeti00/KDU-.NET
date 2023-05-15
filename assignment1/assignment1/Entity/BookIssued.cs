using assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Entity
{
    internal class BookIssued
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }=string.Empty;
        public int BookItemId { get; set; }
        public string IssuerEmail { get; set; }

        public BookStatus Status { get; set; } = BookStatus.AVAILABLE;

        public BookIssued(int  id, string userEmail, int bookItemId,string issuerEmail,BookStatus status)
        {
            Id = id;
            UserEmail = userEmail;
            BookItemId = bookItemId;
            IssuerEmail = issuerEmail;
            Status = status;
        }
       

    }
}
