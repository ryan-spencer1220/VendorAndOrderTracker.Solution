using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Total { get; set; }
        public string Date { get; set; }

        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, string total, string date)
        {
            Title = title;
            Description = description;
            Total = total;
            Date = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}