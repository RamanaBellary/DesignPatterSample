using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatternsSample.Behavioural
{
    /*
     In Strategy pattern, a class behavior or its algorithm can be changed at run time. 
     This type of design pattern comes under "BEHAVIOUR PATTERN".

     In Strategy pattern, we create objects which represent various strategies and a context object whose behavior varies as per its strategy object. 
     The strategy object changes the executing algorithm of the context object.
     */
    #region Example1
    public abstract class SortStrategy
    {
       public abstract void Sort<T>(List<T> lstToSort);
    }

    public class QuickSort : SortStrategy
    {
        public override void Sort<T>(List<T> lstToSort)
        {
            lstToSort.Sort();
            MessageBox.Show("Sorted using Qucik Sort");
        }
    }

    public class ShellSort : SortStrategy
    {
        public override void Sort<T>(List<T> lstToSort)
        {
            //Implement the sort
            MessageBox.Show("Sorted using Shell Sort");
        }
    }

    public class MergeSort : SortStrategy
    {
        public override void Sort<T>(List<T> lstToSort)
        {
            //Implement the sort
            MessageBox.Show("Sorted using Merge Sort");
        }
    }

    public class SortContext
    {
        private SortStrategy sortStrategy;

        public SortContext(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Sort<T>(List<T> lstToSort)
        {
            sortStrategy.Sort(lstToSort);
        }
    }
    #endregion

    #region Example2
    public interface fly
    {
        void fly();
    }

    public class ItFlys : fly
    {
        public void fly()
        {
            MessageBox.Show("It can fly..");
        }
    }

    public class CantFly : fly
    {
        public void fly()
        {
            MessageBox.Show("It can't fly..");
        }
    }

    public class Animal
    {
        public fly FlyType;

        public void TryToFly()
        {
            FlyType.fly();
        }

        public void SetFlyType(fly flyType)
        {
            FlyType = flyType;
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            FlyType = new CantFly();
        }
    }

    public class Eagle : Animal
    {
        public Eagle()
        {
            FlyType = new ItFlys();
        }
    }
    #endregion

    #region Example3
    public interface IOperation
    {
        int DoOperation(int a, int b);
    }

    public class Add : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }

    public class Multiply : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }

    public class Subtract : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a - b;
        }
    }

    public class Context
    {
        private IOperation operate;

        public Context(IOperation opt)
        {
            this.operate = opt;
        }

        public int PerformOperation(int a, int b)
        {
            if(operate != null)
                return operate.DoOperation(a, b);

            throw new Exception("Valid Operate type should be set");
        }
    }
    #endregion
}
