namespace Lecture18
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            Logger.Log("We are migrating blah blah..");
        }
    }
}