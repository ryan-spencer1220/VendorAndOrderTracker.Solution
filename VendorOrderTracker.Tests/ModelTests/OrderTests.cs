using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(001, "Baguette Order", "$40.00");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetInvoiceNumber_ReturnsInvoiceNumber_Int()
    {
      int invoiceNumber = 001;
      string description = "Baguette Order";
      string total = "$40.00";
      Order newOrder = new Order(invoiceNumber, description, total);
      int result = newOrder.InvoiceNumber;
      Assert.AreEqual(invoiceNumber, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      int invoiceNumber = 001;
      string description = "Baguette Order";
      string total = "$40.00";
      Order newOrder = new Order(invoiceNumber, description, total);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetInvoiceTotal_ReturnsInvoiceTotal_String()
    {
      int invoiceNumber = 001;
      string description = "Baguette Order";
      string total = "$40.00";
      Order newOrder = new Order(invoiceNumber, description, total);
      string result = newOrder.Total;
      Assert.AreEqual(total, result);
    }
  }
}