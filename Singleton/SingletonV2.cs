namespace Singleton
{
    /// <summary>
    /// Singleton implemenation using static constructor.
    /// </summary>
    public sealed class SingletonV2
    {
        private static readonly SingletonV2 _instance = new SingletonV2();
        static SingletonV2()
        {

        }

        private SingletonV2()
        {

        }

        public static SingletonV2 Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
