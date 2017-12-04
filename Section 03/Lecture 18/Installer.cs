namespace Lecture18
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            Logger.Log("We are installing the application");
        }
    }
}