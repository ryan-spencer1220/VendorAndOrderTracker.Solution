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
      Order newOrder = new Order("Baguette Order", "4 Plain Baguettes & 3 Seeded Baguettes", "$40.00", "3/15/21");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTtile_ReturnsOrderTitle_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetOrderTotal_ReturnsOrderTotal_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string result = newOrder.Total;
      Assert.AreEqual(total, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string result = newOrder.Date;
      Assert.AreEqual(total, result);
    }

    [TestMethod]
    public void SetNewOrderTitle_SetOrderTitle_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string updatedOrderTitle = "Croissant Order";
      newOrder.Title = updatedOrderTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void SetNewOrderDescription_SetOrderDescription_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string updatedOrderDescription = "1 Plain Baguettes & 6 Seeded Baguettes";
      newOrder.Description = updatedOrderDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedOrderDescription, result);
    }

    [TestMethod]
    public void SetNewOrderTotal_SetOrderTotal_String()
    {
      string title = "Baguette Order";
      string description = "4 Plain Baguettes & 3 Seeded Baguettes";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string updatedOrderTotal = "35.00";
      newOrder.Total = updatedOrderTotal;
      string result = newOrder.Total;
      Assert.AreEqual(updatedOrderTotal, result);
    }

    [TestMethod]
    public void SetNewOrderDate_SetOrderDate_String()
    {
      string title = "Baguette Order";
      string description = "Baguette Order";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      string updatedOrderDate = "2/12/21";
      newOrder.Total = updatedOrderDate;
      string result = newOrder.Total;
      Assert.AreEqual(updatedOrderDate, result);
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
      string title01 = "Baguette Order";
      string title02 = "Croissant Order";
      string description01 = "4 Plain Baguettes & 3 Seeded Baguettes";
      string description02 = "3 Croissants & 3 Chocolate Croissants";
      string total01 = "$50.00";
      string total02 = "$25.00";
      string date01 = "5/15/20";
      string date02 = "4/25/20";
      Order newOrder1 = new Order(title01, description01, total01, date01);
      Order newOrder2 = new Order(title02, description02, total02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Baguette Order";
      string description = "Baguette Order";
      string total = "$40.00";
      string date = "5/15/20";
      Order newOrder = new Order(title, description, total, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Baguette Order";
      string title02 = "Croissant Order";
      string description01 = "4 Plain Baguettes & 3 Seeded Baguettes";
      string description02 = "3 Croissants & 3 Chocolate Croissants";
      string total01 = "$50.00";
      string total02 = "$25.00";
      string date01 = "5/15/20";
      string date02 = "4/25/20";
      Order newOrder1 = new Order(title01, description01, total01, date01);
      Order newOrder2 = new Order(title02, description02, total02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}