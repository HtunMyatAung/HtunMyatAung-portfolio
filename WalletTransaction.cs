using System;
using System.Collections.Generic;
using Kispanadi.Common.Ddd.Objects;

namespace UabPay.InternationalRemittance.Domain
{   

    public class WalletTransaction : IDomainObject
    {
        public DateTime TransactionDate { get; }
        public string TransactionId { get; }
        public string MobileNumber { get; }          
        public string TransactionDescription { get; } 
        public decimal Amount { get; }
        public decimal Discount { get; }
        public decimal Charges { get; }
        public decimal NetAmount { get; }
        public string TransferTo { get; }
        public string ReceiverAppType { get; }

        public WalletTransaction(
            DateTime transactionDate,
            string transactionId,
            string mobileNumber,
            string transactionDescription,
            decimal amount,
            decimal discount,
            decimal charges,
            decimal netAmount,
            string transferTo,
            string receiverAppType)
        {
            TransactionDate = transactionDate;
            TransactionId = transactionId;
            MobileNumber = mobileNumber;
            TransactionDescription = transactionDescription;
            Amount = amount;
            Discount = discount;
            Charges = charges;
            NetAmount = netAmount;
            TransferTo = transferTo;
            ReceiverAppType = receiverAppType;
        }
    }


    public class PaginatedWalletTransDomain : IDomainObject
    {
        public List<WalletTransaction> Transactions { get; set; } = new List<WalletTransaction>();
        public int Skip { get; set; }
        public int Limit { get; set; }
        public int TotalCount { get; set; }
    }

    public class WalletTransReqDomain
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string TransactionId { get; set; }
        public int TransactionType { get; set; }
        public string MobileNumber { get; set; }
    }
}
