using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiarsDice
{
    public class Account
    {
        private int AmountOfYears = 10;

        public void DeductYears()
        {
            AmountOfYears = AmountOfYears - 10;
        }

        public void AddYears()
        {
            AmountOfYears = AmountOfYears + 10;
        }

        public void AddYearsShop(int amount)
        {
            AmountOfYears = AmountOfYears + amount;
        }

        public int GetYears()
        {
            return AmountOfYears;
        }

        public void SetYears(int _AmountOfYears)
        {
            AmountOfYears = _AmountOfYears;
        }

        public int Check()
        {
            if(AmountOfYears > 100)
            {
                //Game Over
                return -1;

            }
            else if (AmountOfYears <= 0)
            {
                //Game Won
                AmountOfYears = 0;
                return 1;
            }
            return 0;
        }
    }
}
