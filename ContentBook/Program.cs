using System;
using System.IO;
using System.Xml.Linq;

 

namespace ContactsXMLReader
{
    class Program
    {
        static void Main(string[] args)
        {



            StreamReader sr = new StreamReader(@"C:\Users\opilane\source\repos\ContentBook\ContentBook\kontaktid.xml");
            XElement contactBook = XElement.Load(sr);



            var people = contactBook.Elements("person");
            foreach (var person in people)
            {
                Console.Write(person.Element("name").Value);
                var contacts = person.Element("contacts").Elements();
                foreach (var contact in contacts)
                {
                    Console.Write(String.Format(
                        " {1} on {0}",
                        contact.Value,
                        contact.Attribute("type").Value
                    ));
                }
                Console.WriteLine();
            }
        }
    }
}