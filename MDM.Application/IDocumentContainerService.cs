using MDM.Domain;

namespace MDM.Application
{
    public interface IDocumentContainerService
    {
        IDictionary<int, string> GetContainerTypes();
        IEnumerable<DocumentProperty> GetDocumentContainer();
    }
}