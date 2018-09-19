using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Behavioural
{
    public abstract class Approver
    {
        protected Approver successor;
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract string ProcessRequest(Purchase purchase);
    }

    public class Director : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount <= 10000.0)
            {
                return $"{this.GetType().Name} approved request# {purchase.RequestID}";
            }
            else if (successor != null)
            {
                return successor.ProcessRequest(purchase);
            }

            return $"Couldn't process request# {purchase.RequestID}";
        }
    }

    public class VicePresident : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount <= 25000.0)
            {
                return $"{this.GetType().Name} approved request# {purchase.RequestID}";
            }
            else if (successor != null)
            {
                return successor.ProcessRequest(purchase);
            }

            return $"Couldn't process request# {purchase.RequestID}";
        }
    }

    public class President : Approver
    {
        public override string ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount <= 100000.0)
            {
                return $"{this.GetType().Name} approved request# {purchase.RequestID}";
            }

            return $"Request# {purchase.RequestID} requires an executive meeting!";
        }
    }

    public class Purchase
    {
        public Purchase(int requestID, double amount, string purpose)
        {
            this.requestID = requestID;
            this.amount = amount;
            this.purpose = purpose;
        }

        private int requestID;
        public int RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }

        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string purpose;
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}
