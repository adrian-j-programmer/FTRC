using SQLite;
using Utilities;

namespace FTRC.Data
{
    public class SerializableObject
    {
        protected SerializableObject()
        {
            Id = 0;
            Name = string.Empty;
            Color = Vector.Zero();
        }

        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public Vector Color { get; set; }
    }
}
