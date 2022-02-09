using System.Collections.Generic;
using TextbookManagement.Domain;

namespace TextbookManagement.Mvc.Models
{
    public class IndexViewModel
    {
        private IndexViewModel(List<Order> orders, List<Textbook> textbooks)
        {
            Orders = orders;
            Textbooks = textbooks;
        }
        
        public List<Textbook> Textbooks { get; }
        public List<Order> Orders { get; }
        
        public static IndexViewModel Create(List<Order> orders, List<Textbook> textbooks)
        {
            return new IndexViewModel(orders, textbooks);
        }
    }
}