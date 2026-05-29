namespace DotNetFlix.Domain.Entities.UserData.Document
{
    public class DocumentEntity
    {
        public int DocumentId { get; private set; }
        public int DocumentTypeId { get; private set; }
        public int UserId { get; private set; }
        public string DocumentNumber{ get; private set; }
        public string DocumentInfo{ get; private set; }
        public string OtherDocumentInfo{ get; private set; }
        public DateTime DocumentDate { get; private set; }
        public DateTime DocumentExpireDate { get; private set; } = DateTime.MinValue;
    
    
        public DocumentEntity() { }
        public DocumentEntity(int documentId, int documentTypeId, int userId, string documentNumber, string documentInfo, string otherDocumentInfo, DateTime documentDate, DateTime documentExpireDate)
        {
            DocumentId = documentId;
            DocumentTypeId = documentTypeId;
            UserId = userId;
            DocumentNumber = documentNumber;
            DocumentInfo = documentInfo;
            OtherDocumentInfo = otherDocumentInfo;
            DocumentDate = documentDate;
            DocumentExpireDate = documentExpireDate;    
        }
        public DocumentEntity(int documentTypeId, int userId, string documentNumber, string documentInfo, string otherDocumentInfo, DateTime documentDate, DateTime documentExpireDate)
        {
            DocumentTypeId = documentTypeId;
            UserId = userId;
            DocumentNumber = documentNumber;
            DocumentInfo = documentInfo;
            OtherDocumentInfo = otherDocumentInfo;
            DocumentDate = documentDate;
            DocumentExpireDate = documentExpireDate;    
        }
    }
}