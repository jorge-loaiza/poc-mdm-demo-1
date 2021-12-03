namespace MDM.Domain
{
    public class DocumentPropertyValue
    {
        public Guid DocumentId { get; set; }

        public Guid DocumentPropertyId { get; set; }

        public string Value { get; set; }
    }
}
