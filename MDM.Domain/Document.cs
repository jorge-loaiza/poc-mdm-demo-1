namespace MDM.Domain
{
    public class Document : Auditable
    {
        public Guid DocumentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        ICollection<DocumentProperty> Properties { get; set; }
    }
}