namespace DotNetFlix.Domain.Models
{
    public class CreditCardDataModel
    {
        public int CreditCardId { get; private set; }

        public string CreditCardName { get; private set; }

        public string CreditCardNumber { get; private set; }
        public string CreditCardCvv { get; private set; }
        public string CreditCardExpirationDate { get; private set; }
        public int UserId { get; private set; }

        public CreditCardDataModel() { }
        public CreditCardDataModel(int creditCardId, string creditCardName, string creditCardNumber, string creditCardCvv, string creditCardExpirationDate, int userId)
        {
            CreditCardId = creditCardId;
            CreditCardName = creditCardName;
            CreditCardNumber = creditCardNumber;
            CreditCardCvv = creditCardCvv;
            CreditCardExpirationDate = creditCardExpirationDate;
            UserId = userId;
        }
        public CreditCardDataModel(string creditCardName, string creditCardNumber, string creditCardCvv, string creditCardExpirationDate, int userId)
        {
            CreditCardName = creditCardName;
            CreditCardNumber = creditCardNumber;
            CreditCardCvv = creditCardCvv;
            CreditCardExpirationDate = creditCardExpirationDate;
            UserId = userId;
        }
    }
}