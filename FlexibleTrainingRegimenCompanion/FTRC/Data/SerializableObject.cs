using SQLite;

namespace FTRC.Data
{
    public class SerializableObject
    {
        protected SerializableObject()
        {
            Id = 0;
            Name = string.Empty;
        }

        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
