using System;
using System.Collections.Generic;

namespace TextbookManagement.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public User OrderedBy { get; set; }
        public ICollection<Textbook> Textbooks { get; set; }
        public DateTimeOffset OrderedAt { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}