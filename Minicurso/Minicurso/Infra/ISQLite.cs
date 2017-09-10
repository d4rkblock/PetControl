using SQLite.Net;

namespace Minicurso.Infra
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}