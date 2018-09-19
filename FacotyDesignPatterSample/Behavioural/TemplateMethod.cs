using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesignPatternsSample.Behavioural
{
    /*
     Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
     Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    */

    public abstract class DataAccessRetriever
    {
        protected SqlConnection con;
        protected DataSet dataSet;
        
        protected void Connect()
        {
            //Open the connection
            //con = new SqlConnection("");
            //con.Open();
        }

        protected void DisConnect()
        {
            //Close the connection
            //con.Close();
        }

        protected abstract void Select();
        protected abstract void Process();

        //Template Method
        public void Run()
        {
            Connect();
            Select();
            Process();
            DisConnect();
        }
    }

    public class CategoriesRetriever : DataAccessRetriever
    {
        protected override void Process()
        {
            //Convert the categories into local Entity stucture or do some other processing..
        }

        protected override void Select()
        {
            //Select the categories from the categories table
        }
    }

    public class ProductRetriever : DataAccessRetriever
    {
        protected override void Process()
        {
            //Convert the Products into local Entity stucture or do some other processing..
        }

        protected override void Select()
        {
            //Select the Products from the Products table
        }
    }
}
