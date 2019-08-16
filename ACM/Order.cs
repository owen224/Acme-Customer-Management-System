using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Saves the curent order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the Order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
