using Minicurso.Infra;
using SQLite.Net;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Minicurso.UWP.Infra.SQLitePhone))]
namespace Minicurso.UWP.Infra
{
    public class SQLitePhone : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "PetControl.db3";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
            var platfrom = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
            var connection = new SQLiteConnection(platfrom, path);
            return connection;
        }
    }
}