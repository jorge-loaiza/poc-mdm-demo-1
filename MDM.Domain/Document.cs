namespace MDM.Domain
{
    public class Document : Auditable
    {
        public Guid DocumentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public DateTimeOffset PostedDate { get; set; }

        public ICollection<DocumentPropertyValue>? DocumentProperties { get; set; }
    }
}