using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Name", "Description", "555-555-5555");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
    string name = "Vendor Name";
    string description = "Description";
    string phoneNumber = "555-555-5555";
    Vendor newVendor = new Vendor(name, description, phoneNumber);
    string result = newVendor.Name;
    Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
    string name = "Vendor Name";
    string description = "Description";
    string phoneNumber = "555-555-5555";
    Vendor newVendor = new Vendor(name, description, phoneNumber);
    string result = newVendor.Description;
    Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetVendorPhoneNumber_ReturnsVendorPhoneNumber_Int()
    {
    string name = "Vendor Name";
    string description = "Description";
    string phoneNumber = "555-555-5555";
    Vendor newVendor = new Vendor(name, description, phoneNumber);
    string result = newVendor.PhoneNumber;
    Assert.AreEqual(phoneNumber, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      string name = "Vendor Name";
      string description = "Description";
      string phoneNumber = "555-555-5555";
      Vendor newVendor = new Vendor(name, description, phoneNumber);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("Name1", "Description1", "444-444-4444");
      Vendor newVendor2 = new Vendor("Name2", "Description2", "555-555-5555");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Name1", "Description1", "444-444-4444");
      Vendor newVendor2 = new Vendor("Name2", "Description2", "555-555-5555");
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor1, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("Baguette Order", "4 Plain Baguettes & 3 Seeded Baguettes", "$40.00", "3/15/21");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("Name1", "Description1", "444-444-4444");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}