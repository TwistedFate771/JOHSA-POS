
using System.Collections.Generic;
using JOHSA_POS.Domain;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public class OrderService
    {
        private OrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public int CompleteSale(
            int userId,
            int? customerId,
            string paymentMethod,
            decimal discountAmount,
            decimal taxRate,
            decimal amountPaid,
            List<CartItem> items)
        {
            return orderRepository.CreateOrder(
                userId,
                customerId,
                paymentMethod,
                discountAmount,
                taxRate,
                amountPaid,
                items);
        }
    }
}
