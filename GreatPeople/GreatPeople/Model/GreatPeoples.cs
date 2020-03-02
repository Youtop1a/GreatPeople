using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatPeople.Model
{
    public class GreatPeoples
    {
        public int IDGreatPeople { get; set; }
        public string FIO { get; set; }
        public int IDFieldOfActivity { get; set; }
        public int YearOfBitrh { get; set; }
        public string Country { get; set; }
        public int Lifespan { get; set; }

        public GreatPeoples(int idGreatPeople, string fio, int idFieldOfActivity, int yearOfBitrh, string country, int lifespan)
        {
            IDGreatPeople = idGreatPeople;
            FIO = fio;
            IDFieldOfActivity = idFieldOfActivity;
            YearOfBitrh = yearOfBitrh;
            Country = country;
            Lifespan = lifespan;
        }
        public GreatPeoples()
        { }
    }
}
