// -----------------------------------------------------------------------
// <copyright file="FactoryClass.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DesignPatternsSample.Creational
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IImposition
    {
        void Impose();
    }

    public class CNS : IImposition
    {
        public void Impose()
        {
            Console.WriteLine("Cut And Stack imposition");
        }
    }

    public class SS : IImposition
    {
        public void Impose()
        {
            Console.WriteLine("Saddle stich imposition");
        }
    }

    //public abstract class ImpsoitionObject
    //{
    //    public abstract IImposition GetImpositionObject(string impositionType);
    //}

    public static class ImposeFactory //: ImpsoitionObject
    {
        public static IImposition GetImpositionObject(string impositionType)
        {
            IImposition imposeObj = null; 

            switch (impositionType)
            {
                case "CNS":
                    imposeObj = new CNS();
                    break;
                case "SS":
                    imposeObj = new SS();
                    break;
                //case default:
                //    imposeObj = null;
                //    break;
            }
            return imposeObj;
        }
    }
}
