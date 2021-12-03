namespace MDM.Domain
{
    public class DocumentProperty
    {
        public Guid PropertyId { get; set; }

        public DocumentPropertyType DocumentPropertyType { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public virtual Document Document { get; set; }
    }
}
