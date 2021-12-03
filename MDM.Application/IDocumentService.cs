using MDM.Domain;

namespace MDM.Application
{
    public interface IDocumentService
    {
        Task<Document> CreateDocument(CreateDocumentRequest request);

        IEnumerable<Document> GetDocuments();
    }
}