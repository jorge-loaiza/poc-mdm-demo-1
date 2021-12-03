namespace MDM.Domain
{
    public abstract class Auditable
    {
        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset ModifiedDate { get; set; }
    }
}
