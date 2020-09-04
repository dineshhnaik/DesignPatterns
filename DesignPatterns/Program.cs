using Singleton;
using System;

namespace DesignPatterns
{
    /// <summary>
    /// I have referred Jon Skeet's website for implementing the Singleton pattern - https://csharpindepth.com/articles/singleton
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SingletonV1 v1Instance1 = SingletonV1.Instance;
            SingletonV1 v1Instance2 = SingletonV1.Instance;
            SingletonV1 v1Instance3 = SingletonV1.Instance;

            Console.WriteLine($"v1Instance1 is equal to v1Instance2: {ReferenceEquals(v1Instance1, v1Instance2)}");
            Console.WriteLine($"v1Instance2 is equal to v1Instance3: {ReferenceEquals(v1Instance2, v1Instance3)}");

            SingletonV2 v2Instance1 = SingletonV2.Instance;
            SingletonV2 v2Instance2 = SingletonV2.Instance;
            SingletonV2 v2Instance3 = SingletonV2.Instance;

            Console.WriteLine($"v2Instance1 is equal to v2Instance2: {ReferenceEquals(v2Instance1, v2Instance2)}");
            Console.WriteLine($"v2Instance2 is equal to v2Instance3: {ReferenceEquals(v2Instance2, v2Instance3)}");

            SingletonV3 v3Instance1 = SingletonV3.Instance;
            SingletonV3 v3Instance2 = SingletonV3.Instance;
            SingletonV3 v3Instance3 = SingletonV3.Instance;

            Console.WriteLine($"v3Instance1 is equal to v3Instance2: {ReferenceEquals(v3Instance1, v3Instance2)}");
            Console.WriteLine($"v3Instance2 is equal to v3Instance3: {ReferenceEquals(v3Instance2, v3Instance3)}");

            Console.WriteLine("Press <Enter> to exit...");
            Console.Read();
        }
    }
}
