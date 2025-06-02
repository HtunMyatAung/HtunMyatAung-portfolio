using UabPay.InternationalRemittance.Domain;
using UabPay.InternationalRemittance.Infrastructure.Persistence.Data;

namespace UabPay.InternationalRemittance.Application.Mapper
{
    public class WalletTransactionMapper : IMapper<WalletTransaction, WalletTransactionDto>
    {
        public WalletTransaction ToDomain(WalletTransactionDto dbObject)
        {
            return dbObject is null ? null : new WalletTransaction(
                dbObject.TransactionDate,
                dbObject.TransactionId,
                dbObject.MobileNumber,
                dbObject.TransactionDescription,
                dbObject.Amount,
                dbObject.Discount,
                dbObject.Charges,
                dbObject.NetAmount,
                dbObject.TransferTo,
                dbObject.ReceiverAppType
            );
                
        }

        public WalletTransactionDto ToDbObject(WalletTransaction domainObject)
        {
            return domainObject is null ? null : new WalletTransactionDto
            {
                TransactionDate = domainObject.TransactionDate,
                TransactionId = domainObject.TransactionId,
                MobileNumber = domainObject.MobileNumber,
                TransactionDescription = domainObject.TransactionDescription,
                Amount = domainObject.Amount,
                Discount = domainObject.Discount,
                Charges = domainObject.Charges,
                NetAmount = domainObject.NetAmount,
                TransferTo = domainObject.TransferTo,
                ReceiverAppType = domainObject.ReceiverAppType
            };
        }

    }

}
