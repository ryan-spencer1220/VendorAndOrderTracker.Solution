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

    [TestMethod]
    public void SetNewInvoiceNumber_SetInvoiceNumber_Int()
    {
      int invoiceNumber = 001;
      string description = "Baguette Order";
      string total = "$40.00";
      Order newOrder = new Order(invoiceNumber, description, total);
      int updatedInvoiceNumber = 004;
      newOrder.InvoiceNumber = updatedInvoiceNumber;
      int result = newOrder.InvoiceNumber;
      Assert.AreEqual(updatedInvoiceNumber, result);
    }

    [TestMethod]
    public void SetNewOrderDescription_SetOrderDescription_String()
    {
      int invoiceNumber = 001;
      string description = "Baguette Order";
      string total = "$40.00";
      Order newOrder = new Order(invoiceNumber, description, total);
      string updatedIDescription = "Baguette + Croissant Order";
      newOrder.Description = updatedIDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedIDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      int invoiceNumber01 = 009;
      int invoiceNumber02 = 007;
      string description01 = "Croissant Order";
      string description02 = "Baguette Order";
      string total01 = "$50.00";
      string total02 = "$25.00";
      Order newOrder1 = new Order(invoiceNumber01, description01, total01);
      Order newOrder2 = new Order(invoiceNumber02, description02, total02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}