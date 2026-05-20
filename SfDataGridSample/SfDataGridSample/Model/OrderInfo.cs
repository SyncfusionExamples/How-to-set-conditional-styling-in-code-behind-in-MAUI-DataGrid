using System;
using System.Collections.Generic;
using System.Text;

namespace SfDataGridSample
{
    public class OrderInfo
    {
        private string orderID = string.Empty;
        private string customerID = string.Empty;
        private string customer = string.Empty;
        private string shipCity = string.Empty;
        private string shipCountry = string.Empty;

        public string OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; }
        }

        public bool IsDeleted { get; set; }

        public OrderInfo(string orderId, string customerId, string country, string customer, string shipCity, bool isDeleted = false)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
            this.IsDeleted = isDeleted;
        }
    }
}
