using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Structural
{
    /*
     Provide a unified interface to a set of interfaces in a subsystem. 
     Façade defines a higher-level interface that makes the subsystem easier to use.
     */

    #region Example1
    public class SubSystem1
    {
        public void Method1()
        {
            Console.WriteLine("Subsystem1 method1.");
        }
        public void Method2()
        {
            Console.WriteLine("Subsystem1 method2.");
        }
    }
    public class SubSystem2
    {
        public void Method1()
        {
            Console.WriteLine("Subsystem2 method1.");
        }
    }
    public class SubSystem3
    {
        public void Method1()
        {
            Console.WriteLine("Subsystem3 method1.");
        }
        public void Method2()
        {
            Console.WriteLine("Subsystem3 method2.");
        }
    }
    public class Facade
    {
        private SubSystem1 subSystem1;
        private SubSystem2 subSystem2;
        private SubSystem3 subSystem3;

        public Facade()
        {
            subSystem1 = new SubSystem1();
            subSystem2 = new SubSystem2();
            subSystem3 = new SubSystem3();
        }

        public void MethodA()
        {
            Console.WriteLine("Facade MethodA");
            subSystem1.Method1();
            subSystem2.Method1();
            subSystem3.Method1();
        }
        public void MethodB()
        {
            Console.WriteLine("Facade MethodB");
            subSystem1.Method2();
            subSystem3.Method2();
        }
    }
    #endregion

    #region Example2
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }

    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }

    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string _name;

        // Constructor
        public Customer(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
              cust.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
    #endregion
}
