// -----------------------------------------------------------------------
// <copyright file="AbstractFactory.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DesignPatternsSample.Creational
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #region Example1 Mobile Facory
    public interface ISmart
    {
        string Name();
    }

    public interface INoraml
    {
        string Name();
    }

    public class Lumia : ISmart
    {
        public string Name()
        {
            return "Lumia";
        }
    }

    public class Asha : INoraml
    {
        public string Name()
        {
            return "Asha";
        }
    }

    public class Galaxy : ISmart
    {
        public string Name()
        {
            return "Galaxy";
        }
    }

    public class Guru : INoraml
    {
        public string Name()
        {
            return "Guru";
        }
    }

    public abstract class PhoneFactory
    {
        public abstract ISmart GetSmart();
        public abstract INoraml GetNoraml();
    }

    public class NokiaFactory : PhoneFactory
    {

        public override ISmart GetSmart()
        {
            return new Lumia();
        }

        public override INoraml GetNoraml()
        {
            return new Asha();
        }
    }

    public class SamsungFactory : PhoneFactory
    {

        public override ISmart GetSmart()
        {
            return new Galaxy();
        }

        public override INoraml GetNoraml()
        {
            return new Guru();
        }
    }
    #endregion

    #region Example2 Vehicle Factory
    public interface IBike
    {
        int Cost();
    }

    public interface IScooter
    {
        int Cost();
    }

    public abstract class VehicleFactory
    {
        public abstract IBike GetBike(string name);
        public abstract IScooter GetScooter(string name);
    }

    public class Shine : IBike
    {
        public int Cost()
        {
            return 66000;
        }
    }

    public class Activa : IScooter
    {
        public int Cost()
        {
            return 55000;
        }
    }

    public class HondaFacory : VehicleFactory
    {
        public override IBike GetBike(string name)
        {
            IBike bike = null;

            switch (name)
            {
                case "Shine":
                    bike = new Shine();
                    break;
            }

            return bike;
        }

        public override IScooter GetScooter(string name)
        {
            IScooter scooter = null;

            switch (name)
            {
                case "Activa":
                    scooter = new Activa();
                    break;
            }

            return scooter;
        }
    }

    public class TvsFactory : VehicleFactory
    {
        public override IBike GetBike(string name)
        {
            throw new NotImplementedException();
        }

        public override IScooter GetScooter(string name)
        {
            throw new NotImplementedException();
        }
    } 
    #endregion
}
