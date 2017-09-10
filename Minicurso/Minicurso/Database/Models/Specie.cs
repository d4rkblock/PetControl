using SQLite.Net.Attributes;

namespace Minicurso.Database.Models
{
    public class Specie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}