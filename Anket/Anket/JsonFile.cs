using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Anket
{
    internal class JsonFile
    {
        public static List<Type> readAsCollection<Type>(string fileName) where Type : new()
        {
            string json = File.ReadAllText(fileName);
            var collectionItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Type>>(json);
            return collectionItems;
        }
        public static void writeCollection<Type>(string fileName, List<Type> arr)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(arr);
            File.WriteAllText(fileName, json);
        }
        public static void addNewPersonToFile(Person user, string fileName) 
        {
            List<Person> list = new List<Person>();
            if (File.ReadAllLines(fileName).Length != 0)
                list = readAsCollection<Person>(fileName);

            list.Add(user);
            writeCollection<Person>(fileName, list);
        }
        public static Person findPerson(string fileName,string email)
        {
            List<Person> list = JsonFile.readAsCollection<Person>(fileName);

            foreach (var person in list)
            {
                if (person.Email == email) return person;
            }
            throw new Exception("User WAS NOT Found!");
        }

    }

}

