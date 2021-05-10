using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
    }
}
