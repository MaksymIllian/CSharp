using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lecture4
{
    class Program
    {
        static void Serialization(XmlSerializer formatter, List<Employee> persons,string name)
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, persons);

                Console.WriteLine("Объект сериализован");
            }
        }
        static List<Employee> Deserialization(XmlSerializer formatter,string name)
        {
            List<Employee> newPersons;
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                newPersons = (List<Employee>)formatter.Deserialize(fs);
                foreach (Employee p in newPersons)
                {
                    p.EmployeeID = p.LastName + p.FirstName;
                }
            }
            return  newPersons;
        }
        static void Main(string[] args)
        {
            Employee person = new Employee("Ivan","Michalkov",29,"Finansical","Rogan street 1");
            Employee person2 = new Employee("Vasil", "Oloshko", 32, "Finansical", "Rogan street 5");
            Employee person3 = new Employee("SerGay", "Kolesnikov", 25, "Net", "Pavlovo Pole 56");
            Employee person4 = new Employee("Ygor", "Shnur", 23, "C++", "Kievska 7");
            List<Employee> persons = new List<Employee> { person, person2, person3, person4 };
            Console.WriteLine("Объекты создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>), new XmlRootAttribute("Employees"));

            // получаем поток, куда будем записывать сериализованный объект

            Console.WriteLine("Хотите предсериализовать объекты?");
            string ans = Console.ReadLine();
            if (ans == "да" || ans == "yes" )
            {
                Serialization(formatter, persons, "persons.xml");
            }

            List<Employee> newPersons = Deserialization(formatter, "persons.xml");
            List<Employee> electPersons = new List<Employee>();
            int i = 1;
            foreach (Employee p in newPersons)
            {

                Console.WriteLine(i + ":");
                Console.WriteLine("FirstName: \t{0} \nLastName: \t{1} \nAge: \t\t{2} \nDepartment: \t{3} \nAddress: \t{4} \nid: \t\t{5}",
                    p.FirstName, p.LastName, p.Age, p.Department,
                    typeof(Employee).GetProperty("Address", BindingFlags.Public | BindingFlags.Instance).GetValue(p, null),
                    typeof(Employee).GetField("employeeID", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(p));
                if (p.Age >= 25 && p.Age <= 35)
                {
                    electPersons.Add(p);
                }
                i++;
            }
            electPersons.Sort((a, b) => a.EmployeeID.CompareTo(b.EmployeeID));
            Serialization(formatter, electPersons, "electPersons.xml");
            
        }
    }
}
