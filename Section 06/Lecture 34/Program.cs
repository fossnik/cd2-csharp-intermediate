
namespace Lecture34
{
    class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"/tmp/log.txt"));
            dbMigrator.Migrate();
        }
    }
}
