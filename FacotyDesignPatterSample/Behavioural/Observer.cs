using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatternsSample.Behavioural
{
    public interface IInvestor
    {
        void Update(string stockName, int price);
    }

    public abstract class Stock
    {
        private string _name;
        private int _price;
        private List<IInvestor> _lstInvestors = new List<IInvestor>();

        public Stock(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        public void Register(IInvestor investor)
        {
            this._lstInvestors.Add(investor);
        }

        public void UnRegister(IInvestor investor)
        {
            this._lstInvestors.Remove(investor);
        }

        public int Price { get { return _price; }
            set
            {
                if(this._price!= value)
                {
                    this._price = value;
                    Notify();
                }
            }
        }

        public string Name
        {
            get { return this._name; }
        }

        private void Notify()
        {
            foreach (var i in _lstInvestors)
                i.Update(this._name, this._price);
        }
    }

    public class IBM : Stock
    {
        public IBM(string name, int price) : base(name, price)
        {
        }
    }

    public class MSFT : Stock
    {
        public MSFT(string name, int price) : base(name, price)
        {
        }
    }

    public class Investor : IInvestor
    {
        private string _name;
        public Investor(string name)
        {
            this._name = name;
        }
        public void Update(string stockName,int price)
        {
            MessageBox.Show("Update for inverstor '"+_name+"'"+Environment.NewLine+stockName + ":" + price);   
        }
    }

    #region Example2
    public interface Subject
    {
        void Register(Observer observer);
        void UnRegister(Observer observer);
        void Notify();
    }

    public interface Observer
    {
        void Update(double ibmPrice);
    }

    public class StockGrabber : Subject
    {
        private List<Observer> observers;
        private double ibmPrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }

        public void Register(Observer observer)
        {
            observers.Add(observer);
        }

        public void UnRegister(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer obs in observers)
            {
                obs.Update(ibmPrice);
            }
        }

        public void SetIBMPrice(double newPrice)
        {
            this.ibmPrice = newPrice;
            Notify();
        }
    }

    public class StockObserver : Observer
    {
        double ibmPrice;
        private static int observerId;
        private int CurrentObserverId;
        private Subject stockGrabber;

        public StockObserver(StockGrabber stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            CurrentObserverId = ++observerId;
            stockGrabber.Register(this);
        }
        public void Update(double ibmPrice)
        {
            this.ibmPrice = ibmPrice;
            MessageBox.Show("observer " + CurrentObserverId + ": Ibm price - " + ibmPrice);
        }
    } 
    #endregion
}
