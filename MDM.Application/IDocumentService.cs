using MDM.Domain;

namespace MDM.Application
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetDocuments();
    }
}