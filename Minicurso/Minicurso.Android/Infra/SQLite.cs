using Minicurso.Infra;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using System;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Dependency(typeof(Minicurso.Droid.Infra.SQLite))]
namespace Minicurso.Droid.Infra
{
    public class SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "PetControl.db3";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}