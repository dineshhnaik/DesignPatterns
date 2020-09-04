using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   /// <summary>
   /// Singleton implementation using Lazy Load
   /// </summary>
    public sealed class SingletonV3
    {
        private static readonly Lazy<SingletonV3> _lazy = new Lazy<SingletonV3>(() => new SingletonV3());

        private SingletonV3()
        {

        }

        public static SingletonV3 Instance
        {
            get; set;
        }
    }
}
