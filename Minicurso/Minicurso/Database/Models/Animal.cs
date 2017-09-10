using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Minicurso.Database.Models
{
    public class Animal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
        [ForeignKey(typeof(Specie))]
        public int SpecieId { get; set; }
        [ForeignKey(typeof(AnimalVaccination))]
        public int AnimalVaccinationId { get; set; }

        public string ImageURL { get; set; }

        [Ignore]
        public string SpecieName { get; set; }
    }
}