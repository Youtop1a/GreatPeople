using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatPeople.Model
{
    class EditionRequest
    {
        public int IDEditionRequest { get; set; }
        public int IDModerator { get; set; }
        public int IDUser { get; set; }
        public int IDPerson { get; set; }
        public DateTime EditionData { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public EditionRequest(int iDEditionRequest, int iDModerator, int iDUser, int iDPerson, DateTime editionData, DateTime date, string status)
        {
            IDEditionRequest = iDEditionRequest;
            IDModerator = iDModerator;
            IDUser = iDUser;
            IDPerson = iDPerson;
            EditionData = editionData;
            Date = date;
            Status = status;
        }
        public EditionRequest()
        { }
    }
}
