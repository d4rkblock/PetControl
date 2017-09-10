using Minicurso.Database.Models;
using Minicurso.Infra;
using SQLite.Net;
using System;
using Xamarin.Forms;

namespace Minicurso.Database
{
    public class Repository : IDisposable
    {
        private SQLiteConnection _conn;

        public Repository()
        {
            if (_conn == null)
            {
                _conn = DependencyService.Get<ISQLite>().GetConnection();
                CreateTables();
            }
        }

        private void CreateTables()
        {
            _conn.CreateTable<User>();
            _conn.CreateTable<Animal>();
            _conn.CreateTable<Specie>();
            _conn.CreateTable<AnimalVaccination>();
        }

        public bool CreateUser(User user)
        {
            if (_conn.Insert(user) > 0)
                return true;

            return false;
        }

        public void CreateAnimal(Animal animal)
        {
            _conn.Insert(animal);
        }

        public TableQuery<User> Login(string username, string password)
        {
            return _conn.Table<User>()
                        .Where(x => x.Username == username && x.Password == password);
        }

        public void Dispose()
        {
            if (_conn != null)
                _conn.Close();
        }
    }
}