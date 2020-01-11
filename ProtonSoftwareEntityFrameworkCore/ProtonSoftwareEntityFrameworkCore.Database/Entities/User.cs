namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public class User : BaseEntity<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
