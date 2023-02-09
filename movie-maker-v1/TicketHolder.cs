using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_maker_v1
{
    class TicketHolder
    {
        //attributes or fields
        private string Name;
        private int age;
        private int NumberTickects;
        private bool Credit;
        private List<string> SnackOrder = new List<string>();
        private List<int> SnackGuantity = new List<int>();
        private List<string> DrinkOrder = new List<string>();
        private List<int> DrinkQuantity = new List<int>();

        //Constructor - construts an object of this class
        public TicketHolder()
        {

        }
        //returns the value in the private age varibale
        public int GetAge()
        {
            return 0;
        }
        //sets the value in the private age varibale 
        public void SetAge(int NewAge)
        {

        }
        // Returns the total cost for the ticket holder
        public float CalculateTotalCost()
        {
            return 0.0f;
        }
        // retruns a string displaying the reciept for the puchased items
        public string GenerateReciept()
        {
            return "";
        }
        // returns a string collating all the values stored in the private varibale 
        public override string ToString()
        {
            return "";
        }

    }
}
