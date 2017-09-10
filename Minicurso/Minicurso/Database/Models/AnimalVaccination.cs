using SQLite.Net.Attributes;
using System;

namespace Minicurso.Database.Models
{
    public class AnimalVaccination
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool AlreadyTook { get; set; }
    }
}