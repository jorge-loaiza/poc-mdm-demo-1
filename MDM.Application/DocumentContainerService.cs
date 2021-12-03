using MDM.Domain;

namespace MDM.Application
{
    public class DocumentContainerService : IDocumentContainerService
    {
        public IEnumerable<DocumentProperty> GetDocumentContainer()
        {
            return new List<DocumentProperty>()
            {
                new DocumentProperty()
                {
                    PropertyId = new Guid("71FC18A2-4FAA-4A89-BB02-E3A52FDEE3D0"),
                    Name = "DOCUMENT_PROPERTY_SECTOR",
                    DocumentPropertyType = DocumentPropertyType.String
                },
                new DocumentProperty()
                {
                    PropertyId = new Guid("2D215EF3-7514-4FF2-B95E-E65ABA6D8D27"),
                    Name = "DOCUMENT_PROPERTY_GOVWIN_IQ_CREATE_DATE",
                    DocumentPropertyType = DocumentPropertyType.DateTime
                },
                new DocumentProperty()
                {
                    PropertyId = new Guid("87262B42-2639-4EDD-95F7-DD5F933085B1"),
                    Name = "DOCUMENT_PROPERTY_IS_FROM_EMAIL",
                    DocumentPropertyType = DocumentPropertyType.Boolean
                },
                new DocumentProperty()
                {
                    PropertyId = new Guid("776CA162-2EE6-4D55-83E8-609C22D5FBF2"),
                    Name = "DOCUMENT_PROPERTY_SOLICITATION_NUMBER",
                    DocumentPropertyType = DocumentPropertyType.String
                },
                new DocumentProperty()
                {
                    PropertyId = new Guid("5D10EA35-002E-41F5-88EF-9516F20A97B5"),
                    Name = "DOCUMENT_PROPERTY_MAIN_POC",
                    DocumentPropertyType = DocumentPropertyType.String
                }
            };
        }

        public IDictionary<int, string> GetContainerTypes()
        {
            return new Dictionary<int, string>()
            {
                { (int)DocumentPropertyType.String, DocumentPropertyType.String.ToString() },
                { (int)DocumentPropertyType.DateTime, DocumentPropertyType.DateTime.ToString() },
                { (int)DocumentPropertyType.Boolean, DocumentPropertyType.Boolean.ToString() }
            };
        }
    }
}
