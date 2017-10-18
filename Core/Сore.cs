using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Core
{
    [Serializable]
    public class Person
    {
        public string name, lastName, homePhone, mobile, group;
        public Person()
        { }
        public Person(string name, string lastName, string homePhone, string mobile, 
            string group)
        {
            this.name = name;
            this.lastName = lastName;
            this.homePhone = homePhone;
            this.mobile = mobile;
            this.group = group;
        }
    }
    public class Core
    {
        public System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();

        public static List<string> LoadToListTexBox()
        {
            //задаем путь к нашему рабочему файлу XML
            string fileName = "base.xml";
            //читаем данные из файла
            XDocument doc = XDocument.Load(fileName);
            //проходим по каждому элементу в найшей library
            //(этот элемент сразу доступен через свойство doc.Root)
            List<string> l = new List<string>();
            foreach (XElement el in doc.Root.Elements())
            {
                l.Add(el.Attribute("id").Value.ToString() + " " + el.Attribute("name").Value.ToString() 
                    + " " + el.Attribute("lastName").Value.ToString());
                //l.AddLast();//+" "+ el.Attribute("lastName").Value.ToString());
            }
            return l;
        }
        public static List<string> LoadToTextBoxes(string id)
        {
            string fileName = "base.xml";
            //читаем данные из файла
            XDocument doc = XDocument.Load(fileName);
            List<string> l = new List<string>();
            XElement root = doc.Element("persons");

            foreach (XElement xe in root.Elements("person").ToList())
            {
                
                if (xe.Attribute("id").Value == id)
                {
                    l.Add(xe.Attribute("name").Value.ToString());
                    l.Add(xe.Attribute("lastName").Value.ToString());
                    l.Add(xe.Attribute("homePhone").Value.ToString());
                    l.Add(xe.Attribute("mobile").Value.ToString());
                    l.Add(xe.Attribute("group").Value.ToString()); 
                }
            }
            return l;
         }
        public static Image LoadToPictureBox(string id)
        {
            string fileName = "base.xml";
            //читаем данные из файла
            XDocument doc = XDocument.Load(fileName);
            Image I = null;
            XElement root = doc.Element("persons");

            foreach (XElement xe in root.Elements("person").ToList())
            {
                if (xe.Attribute("picture").Value.ToString()!=null)
                    if (xe.Attribute("id").Value == id)
                        I = Base64ToImage(xe.Attribute("picture").Value.ToString());
            }
            return I;    
        }
        public static string ImageToBase64(Image image,
            System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms);
            return image;
        }
        public static void Add(string name, string lastName, string homePhone,
            string mobile, string group, string picture)
        {
            string fileName = "base.xml";
            XDocument doc = XDocument.Load(fileName);
            int maxId;
            try
            {
                maxId = doc.Root.Elements("person").Max(t => Int32.Parse(t.Attribute("id").Value));
            }
            catch (System.InvalidOperationException e)
            {
                maxId = 0;                               
            }
            maxId += 1;
            XElement person = new XElement("person",
                        new XAttribute("id", maxId),
                        new XAttribute("name", name),
                        new XAttribute("lastName", lastName),
                        new XAttribute("homePhone", homePhone),
                        new XAttribute("mobile", mobile),
                        new XAttribute("group", group),
                        new XAttribute("picture", picture));
            doc.Root.Add(person);
            doc.Save(fileName);
        }
        public static void Update(string id, string name, string lastName, 
            string homePhone, string mobile, string group, string picture)
        {
            XDocument doc = XDocument.Load("base.xml");
            XElement root = doc.Element("persons");

            foreach (XElement xe in root.Elements("person").ToList())
            {
                // изменяем название и цену
                if (xe.Attribute("id").Value == id)
                {
                    xe.Attribute("name").Value = name;
                    xe.Attribute("lastName").Value = lastName;
                    xe.Attribute("homePhone").Value = homePhone;
                    xe.Attribute("mobile").Value = mobile;
                    xe.Attribute("group").Value = group;
                    xe.Attribute("picture").Value = picture;
                }
            }
            doc.Save("base.xml");
        }
        public static void Delete(string id)
        {
            string fileName = "base.xml";
            XDocument doc = XDocument.Load(fileName);
            var xElement = (from elemet in doc.Elements("persons").Elements("person")
                            where elemet.Attribute("id").Value == id
                            select elemet);
            foreach (var e in xElement)
                e.Remove();
            doc.Save(fileName);
        }
        public static void Create()
        {
            //задаем путь к нашему рабочему файлу XML
            string fileName = "base.xml";

            //счетчик для номера композиции
            int id = 1;
            //Создание вложенными конструкторами.
            XDocument doc = new XDocument(
	            new XElement("persons",
		            new XElement("person",
			            new XAttribute("id", id++),
			            new XAttribute("name", "Ivan"),
			            new XAttribute("lastName", "Ivanov"),
			            new XAttribute("homePhone", "232-09-88"),
			            new XAttribute("mobile", "093-989-99-00"),
			            new XAttribute("group", "Friends"),
                        new XAttribute("picture", "null")),
		            new XElement("person",
			            new XAttribute("id", id++),
			            new XAttribute("name", "Vova"),
			            new XAttribute("lastName", "Kolesnik"),
			            new XAttribute("homePhone", "262-89-85"),
			            new XAttribute("mobile", "093-943-90-00"),
			            new XAttribute("group", "Friends"),
                        new XAttribute("picture", "null"))));
                    //сохраняем наш документ
                    doc.Save(fileName);
         }
        public static List<string> SortByNameLastName()
        {
            string fileName = "base.xml";
            XDocument doc = XDocument.Load(fileName);
            List<string> l = new List<string>();
            IEnumerable<XElement> persons = from t in doc.Root.Elements("person")
                                           orderby t.Attribute("name").Value,
                                           t.Attribute("lastName").Value
                                           select t;
            foreach (XElement el in persons)
            {
                l.Add(el.Attribute("id").Value.ToString() + " " + el.Attribute("name").Value.ToString()
                    + " " + el.Attribute("lastName").Value.ToString());

            }
            return l;
        }
        public static List<string> Group()
        {
            string fileName = "base.xml";
            XDocument doc = XDocument.Load(fileName);
            List<string> l = new List<string>();
            IEnumerable<XElement> persons = from t in doc.Root.Elements("person")
                                            orderby t.Attribute("group").Value
                                                select t;
            string pr="";                               
            foreach (XElement el in persons)
            {
                if (pr == "" || el.Attribute("group").Value.ToString() != pr)
                {
                    l.Add("------------");
                    l.Add(el.Attribute("group").Value.ToString());
                    
                }
                l.Add(el.Attribute("id").Value.ToString()
                   + " " + el.Attribute("name").Value.ToString()
                   + " " + el.Attribute("lastName").Value.ToString());
                pr = el.Attribute("group").Value.ToString();
            }
            return l;
        }
    }
}
