// -----------------------------------------------------------------------
// <copyright file="SingletonClass.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DesignPatternsSample.Creational
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public sealed class LazyThreadSafeSingleton
    {
        private LazyThreadSafeSingleton() { }

        private static Lazy<LazyThreadSafeSingleton> lazyInstance =
            new Lazy<LazyThreadSafeSingleton>(() => new LazyThreadSafeSingleton());

        public static LazyThreadSafeSingleton Instance
        {
            get { return lazyInstance.Value; }
        }
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SingletonClass
    {
        private static object _lockObj = new object();
        private static SingletonClass _instance;

        private SingletonClass() { }
        
        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                    }
                }
            }

            return _instance;
        }
    }

    
}
