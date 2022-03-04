using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public int InvoiceNumber { get; set; }
        public string Description { get; set; }
        public string Total { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(int invoiceNumber, string description, string total)
        {
            InvoiceNumber = invoiceNumber;
            Description = description;
            Total = total;
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