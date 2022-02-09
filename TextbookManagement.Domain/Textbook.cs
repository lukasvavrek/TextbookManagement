using System;
using System.Collections.Generic;

namespace TextbookManagement.Domain
{
    public class Textbook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}