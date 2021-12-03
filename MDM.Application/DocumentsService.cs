using MDM.Domain;

namespace MDM.Application
{
    public class DocumentsService : IDocumentsService
    {
        public IEnumerable<Document> GetDocuments()
        {
            return new List<Document>()
            {
                new Document() {
                    DocumentId = Guid.NewGuid(),
                    Title = "Document 1",
                    Description = "Description for this document",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Source = "api.sam.gov"
                }
            };
        }
    }
}