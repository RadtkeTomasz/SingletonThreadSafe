namespace Singleton
{
    class SingletonExample
    {
        private SingletonExample() { }

        private static SingletonExample _instance;

        private static readonly object _lock = new object();

        public static SingletonExample GetInstance(string value)
        {

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonExample();
                    }
                }
            }
            return _instance;
        }
    }
}