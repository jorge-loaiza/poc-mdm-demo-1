using MDM.Domain;

namespace MDM.Application
{
    public class DocumentService : IDocumentService
    {
        public async Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest request)
        {
            // Validate request

            // Create Document
            Document document = request;

            // Create Document Properties
            var documentProperties = request.DocumentProperties;

            // Save changes

            // Publish creation

            // Return created object
            return (CreateDocumentResponse) document;
        }

        public IEnumerable<Document> GetDocuments(string query = null)
        {
            var documents = new List<Document>()
            {
                new Document() {
                    DocumentId = GetDocumentGuid1(),
                    Title = "Document 1",
                    Description = "Description for this document",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Source = "govwin",
                    DocumentProperties = new List<DocumentPropertyValue>()
                    {
                        new DocumentPropertyValue()
                        {
                            DocumentId = GetDocumentGuid1(),
                            DocumentPropertyId = new Guid("2D215EF3-7514-4FF2-B95E-E65ABA6D8D27"),
                            Value = DateTimeOffset.Now.ToString()
                        },
                        new DocumentPropertyValue()
                        {
                            DocumentId = GetDocumentGuid1(),
                            DocumentPropertyId = new Guid("87262B42-2639-4EDD-95F7-DD5F933085B1"),
                            Value = Boolean.TrueString
                        }
                    }
                },
                new Document() {
                    DocumentId = GetDocumentGuid2(),
                    Title = "Document 2",
                    Description = "Description for this document",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Source = "govwin",
                    DocumentProperties = new List<DocumentPropertyValue>()
                    {
                        new DocumentPropertyValue()
                        {
                            DocumentId = GetDocumentGuid2(),
                            DocumentPropertyId = new Guid("776CA162-2EE6-4D55-83E8-609C22D5FBF2"),
                            Value = "RFQ123456789"
                        },
                        new DocumentPropertyValue()
                        {
                            DocumentId = GetDocumentGuid2(),
                            DocumentPropertyId = new Guid("71FC18A2-4FAA-4A89-BB02-E3A52FDEE3D0"),
                            Value = "Healthcare"
                        },
                        new DocumentPropertyValue()
                        {
                            DocumentId = GetDocumentGuid2(),
                            DocumentPropertyId = new Guid("87262B42-2639-4EDD-95F7-DD5F933085B1"),
                            Value = Boolean.TrueString
                        }
                    }
                }
            };

            if (!string.IsNullOrEmpty(query))
            {
                return documents.Where(d =>
                {
                    return d.DocumentProperties != null && d.DocumentProperties.Any(p => p.Value.Contains(query, StringComparison.OrdinalIgnoreCase));
                });
            }

            return documents;
        }

        private static Guid GetDocumentGuid1()
        {
            return new Guid("8F448B01-3E09-4689-90EE-EFE8BEBDDB9D");
        }

        private static Guid GetDocumentGuid2()
        {
            return new Guid("A73F6E91-E05E-4BB0-A652-3737D08EDE18");
        }
    }
}