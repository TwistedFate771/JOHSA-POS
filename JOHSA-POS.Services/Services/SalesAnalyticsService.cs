using System.Data;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public class SalesAnalyticsService
    {
        private SalesAnalyticsRepository repository;

        public SalesAnalyticsService()
        {
            repository = new SalesAnalyticsRepository();
        }

        public DataTable GetSalesSummary()
        {
            return repository.GetSalesSummary();
        }

        public DataTable GetDailySales()
        {
            return repository.GetDailySales();
        }

        public DataTable GetMonthlySales()
        {
            return repository.GetMonthlySales();
        }

        public DataTable GetSalesByPaymentMethod()
        {
            return repository.GetSalesByPaymentMethod();
        }

        public DataTable GetTopSellingProducts()
        {
            return repository.GetTopSellingProducts();
        }
    }
}