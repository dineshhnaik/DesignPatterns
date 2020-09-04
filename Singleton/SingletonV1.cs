namespace Singleton
{
    /// <summary>
    /// Implementation of Singleton using lock object.
    /// </summary>
    public sealed class SingletonV1
    {
        private static SingletonV1 _instance;
        private static readonly object _lockObj = new object();

        private SingletonV1()
        {

        }

        public static SingletonV1 Instance
        {
            get
            {
                lock (_lockObj)
                {
                    if (_instance == null)
                        _instance = new SingletonV1();
                }
                return _instance;

            }
        }
    }
}
