using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatPeople.Model
{
    class FieldOfActivity
    {
        public int IDFieldOfActivity { get; set; }
        public string Name { get; set; }

        public FieldOfActivity(int idFieldOfActivity, string name)
        {
            IDFieldOfActivity = idFieldOfActivity;
            Name = name;
        }
        public FieldOfActivity()
        { }
    }
}
