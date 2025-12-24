using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Commands;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Handlers
{
    public class SellProductCommandHandler
    {
        private readonly ISaleService _saleService;

        public SellProductCommandHandler(ISaleService saleService)
        {
            _saleService = saleService ?? throw new ArgumentNullException(nameof(saleService));
        }

        public void Handle(SellProductCommand command)
        {
            ArgumentNullException.ThrowIfNull(command);

            ValidationTool.Validate(new SellProductCommandValidator(), command);

            var sale = new Sale
            {
                ProductId = command.ProductId,
                Quantity = command.Quantity,
                CustomerId = command.CustomerId.GetValueOrDefault() == 0 ? null : command.CustomerId
            };

            _saleService.Add(sale);
        }
    }
}
