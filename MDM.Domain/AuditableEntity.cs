namespace MDM.Domain
{
    public abstract class AuditableEntity
    {
        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset ModifiedDate { get; set; }
    }
}
