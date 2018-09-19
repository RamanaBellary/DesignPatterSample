using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Structural
{
    /*
     Provide a surrogate or placeholder for another object to control access to it.
     Provides a representative object (proxy) that controls access to another similar object.
     */

    public interface ISubject
    {
        void Request();
    }

    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Executing the Request inside RealSubject");
        }
    }

    public class Proxy : ISubject
    {
        private RealSubject Subject;
        public Proxy()
        {
            Subject = new Structural.RealSubject();
        }
        public void Request()
        {
            Subject.Request();
        }
    }
}
