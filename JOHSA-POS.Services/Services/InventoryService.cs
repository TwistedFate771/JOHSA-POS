using System.Collections.Generic;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public sealed class InventoryService
    {
        private readonly InventoryRepository inventoryRepository;

        public InventoryService()
        {
            inventoryRepository = new InventoryRepository();
        }

        public List<JOHSA_POS.Domain.Product> GetInventory()
        {
            return inventoryRepository.GetInventory();
        }

        public void AddStock(
            int productId,
            int quantity,
            string reason,
            int userId)
        {
            inventoryRepository.ChangeStock(
                productId,
                quantity,
                reason,
                userId);
        }

        public void RemoveStock(
            int productId,
            int quantity,
            string reason,
            int userId)
        {
            inventoryRepository.ChangeStock(
                productId,
                -quantity,
                reason,
                userId);
        }
    }
}