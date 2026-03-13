using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECommerceAPI
{

    // =========================
    // Order Entity
    // =========================
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
    }

    // =========================
    // OrderItem Entity
    // =========================
    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    // =========================
    // Order Service
    // =========================
    public class OrderService
    {
        public decimal CalculateTotal(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            decimal total = 0;

            foreach (var item in order.Items)
            {
                if (item.Quantity < 0 || item.UnitPrice < 0)
                    throw new ArgumentException("Quantity or Price cannot be negative");

                total += item.Quantity * item.UnitPrice;
            }

            // Apply discount
            if (total > 5000)
            {
                order.Discount = total * 0.10m;
            }
            else
            {
                order.Discount = 0;
            }

            order.TotalAmount = total - order.Discount;

            return order.TotalAmount;
        }
    }
}

namespace ECommerceAPI.Tests
{
    using ECommerceAPI;

    // =========================
    // MSTest Unit Tests
    // =========================
    [TestClass]
    public class OrderServiceTests
    {
        private OrderService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new OrderService();
        }

        // Test 1: No items
        [TestMethod]
        public void CalculateTotal_NoItems_ReturnsZero()
        {
            var order = new Order();

            var total = _service.CalculateTotal(order);

            Assert.AreEqual(0, total);
        }

        // Test 2: Total below 5000
        [TestMethod]
        public void CalculateTotal_Below5000_NoDiscount()
        {
            var order = new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName="Mouse", Quantity=2, UnitPrice=1000 }
                }
            };

            var total = _service.CalculateTotal(order);

            Assert.AreEqual(2000, total);
            Assert.AreEqual(0, order.Discount);
        }

        // Test 3: Total above 5000
        [TestMethod]
        public void CalculateTotal_Above5000_DiscountApplied()
        {
            var order = new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName="Laptop", Quantity=1, UnitPrice=6000 }
                }
            };

            var total = _service.CalculateTotal(order);

            Assert.AreEqual(5400, total); // 10% discount
            Assert.AreEqual(600, order.Discount);
        }

        // Test 4: Negative quantity
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateTotal_NegativeQuantity_ShouldThrowException()
        {
            var order = new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName="Phone", Quantity=-1, UnitPrice=5000 }
                }
            };

            _service.CalculateTotal(order);
        }

        // =========================
        // DataTestMethod Example
        // =========================
        [DataTestMethod]
        [DataRow(2, 1000, 2000)]
        [DataRow(3, 1500, 4500)]
        public void CalculateTotal_MultipleScenarios(int qty, decimal price, decimal expected)
        {
            var order = new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductName="Item", Quantity=qty, UnitPrice=price }
                }
            };

            var total = _service.CalculateTotal(order);

            Assert.AreEqual(expected, total);
        }
    }
}