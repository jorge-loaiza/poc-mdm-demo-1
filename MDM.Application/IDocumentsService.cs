using MDM.Domain;

namespace MDM.Application
{
    public interface IDocumentsService
    {
        IEnumerable<Document> GetDocuments();
    }
}