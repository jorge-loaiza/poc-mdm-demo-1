namespace MDM.Domain
{
    public class Document : AuditableEntity
    {
        public Guid DocumentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public DateTimeOffset PostedDate { get; set; }

        public ICollection<DocumentPropertyValue>? DocumentProperties { get; set; }

        public IDictionary<string, string> ExternalURLs { get; set; }
    }
}