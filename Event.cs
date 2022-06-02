using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting
{
    class Event
    {
        private double amount;   //How much money was used in the transaction
        private string type;    //Purchare or deposit
        private string date;   //When the transaction was made
        private string source; //Where the money came from/is going to
        private string category; //What type of purchase/deposit 
        
        public Event(string d, double a, string s)
        {
            date = d;
            amount = a;
            source = s;
            type = "";
            category = "";
        }
        public void setType()
        {
            if(amount < 0)
            {
                type = "purchase";
                amount = amount * -1;
            }
            else
            {
                type = "deposit";
            }
        } 
        public string getType()
        {
            return type;
        }
        public string getSource()
        {
            return source;
        }
        public double getAmount()
        {
            return amount;
        }
        public string getDate()
        {
            return date;
        }
        public void setCategory(string cat)
        {
            category = cat;
        }
    }
}
