using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using CarFactoryClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentNHibernate.Automapping;
using MappingClasses;
using NHibernate.Criterion;
using Order = CarFactoryClasses.Order;

namespace FactoryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
      
        
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void FactoryTest()
        {
            using (var Session = NHibernateClass.OpenSession())  
            {
                using (var Transaction = Session.BeginTransaction())
                {
                    Item i1 = new Item()
                    {
                        Name = "Glass",
                        Price = 2500
                    };
                    Item i2 = new Item()
                    {
                        Name = "Plater",
                        Price = 3000
                    };

                    Customer c1 = new Customer()
                    {
                        FName = "Ali",
                        LName = "Pourahrab",
                        Phone = "09122708441"
                    };

                    OrderItem ot1 = new OrderItem()
                    {
                        Qty = 2,
                        Price = i1.Price
                        
                    };
                    ot1.Items.Add(i1);
                    ot1.Items.Add(i2);
                    OrderItem ot2 = new OrderItem()
                    {
                        Qty = 2,
                        Price = i1.Price

                    };
                    ot2.Items.Add(i1);
                    var p = i1.Price;
                    
                    

                    Order o1 = new Order()
                    {
                        Date = DateTime.Now,
                        customer = c1,
                    };

                    o1.OrderItems.Add(ot1);
                    o1.OrderItems.Add(ot2);
                    

                   

                    Session.Save(o1);
                    //Session.Save(b2);

                    Transaction.Commit();

                    var res = Session.Get<Order>(o1.Id);
                    Assert.IsNotNull(res);
                    Assert.AreEqual(o1.Id, res.Id);
                    Assert.AreEqual(o1.customer, res.customer);


                    



                    //Console.WriteLine(" Done Done Done Done Done Done Done Done Done Done Done Done ");

                }
            }
        }


    }
}
