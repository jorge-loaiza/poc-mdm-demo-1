using MDM.Domain;

namespace MDM.Application
{
    public interface IDocumentService
    {
        Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest request);

        IEnumerable<Document> GetDocuments(string query = null);
    }
}