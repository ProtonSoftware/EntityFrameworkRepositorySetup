namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public abstract class BaseEntity<TypeForId>
    {
        public TypeForId Id { get; set; }
    }
}
