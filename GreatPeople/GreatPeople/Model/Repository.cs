using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace GreatPeople.Model
{
    class Repository
    {
        //Код для использования репозитория:
        //Repository rep = new Repository();
        //Далее просто вызываете нужный вам метод. Пример получения списка объектов:
        //List<Users> users=rep.GetUsers();
        //После этого делаете что нужно со списком и есть он изменился и нужно сохранить эти изм. в файле, просто пишете:
        //rep.WriteUsers(users);
        public static List<EditionRequest> GetEditionRequests()
        {
            List<EditionRequest> requests = new List<EditionRequest>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<EditionRequest>));
            using (FileStream fs = new FileStream("../../DataLevel/EditionRequests.xml", FileMode.OpenOrCreate))
                requests = (List<EditionRequest>)formatter.Deserialize(fs);
            return requests;
        }

        public static List<FieldOfActivity> GetFieldOfActivities()
        {
            List<FieldOfActivity> fields = new List<FieldOfActivity>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<FieldOfActivity>));
            using (FileStream fs = new FileStream("../../DataLevel/FieldsOfActivity.xml", FileMode.OpenOrCreate))
                fields = (List<FieldOfActivity>)formatter.Deserialize(fs);
            return fields;
        }
        
        public static List<GreatPeoples> GetGreatPeoples()
        {
            List<GreatPeoples> people = new List<GreatPeoples>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<GreatPeoples>));
            using (FileStream fs = new FileStream("../../DataLevel/GreatPeople.xml", FileMode.OpenOrCreate))
                people = (List<GreatPeoples>)formatter.Deserialize(fs);
            return people;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("../../DataLevel/Users.xml", FileMode.OpenOrCreate))
                users = (List<User>)formatter.Deserialize(fs);
            return users;
        }

        //Все функции выше на выходе дадут вам список объектов из файлов, потом делайте с ними что угодно. 
        //Но сначала само собой эти объекты надо туда 

        public static void WriteRequests(List<EditionRequest> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<EditionRequest>));
            using (FileStream fs = new FileStream("../../DataLevel/EditionRequests.xml", FileMode.Create))
                formatter.Serialize(fs, list);
        }

        public static void WriteFields(List<FieldOfActivity> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<FieldOfActivity>));
            using (FileStream fs = new FileStream("../../DataLevel/FieldsOfActivity.xml", FileMode.Create))
                formatter.Serialize(fs, list);
        }

        public static void WritePeople(List<GreatPeoples> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<GreatPeoples>));
            using (FileStream fs = new FileStream("../../DataLevel/GreatPeople.xml", FileMode.Create))
                formatter.Serialize(fs, list);
        }

        public static void WriteUsers(List<User> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("../../DataLevel/Users.xml", FileMode.Create))
                formatter.Serialize(fs, list);
        }
        //Эти функции записи можно юзать и для редактирования. Просто делаете все нужные манипуляции с List<какой-то класс>, а 
        // потом вызываете фунцкию WriteКакой-то класс и передаёте новую версию списка
    }
}
