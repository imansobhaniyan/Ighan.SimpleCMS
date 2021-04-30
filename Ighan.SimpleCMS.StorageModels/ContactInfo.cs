namespace Ighan.SimpleCMS.StorageModels
{
    public class ContactInfo
    {
        public int Id { get; set; }

        public Type ContactInfoType { get; set; }

        public string Title { get; set; }

        public string Value { get; set; }

        public enum Type
        {
            Email = 1,
            Address = 2,
            Phone = 3,
            Fax = 4
        }
    }
}
