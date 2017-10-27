using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace ClaseDiecinueve.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            Persona personita1 = new Persona("Luis", "Suarez");
            Persona personita2 = new Persona("Pepe", "Ramirez");
            Persona personita3 = new Persona("Ana", "Marlon");
            Alumno alumno1 = new Alumno(1, "Jose", "Rox");
            Alumno alumno2 = new Alumno(2, "Damian", "Wayne");

            personas.Add(personita1);
            personas.Add(alumno1);
            personas.Add(personita2);
            personas.Add(personita3);
            personas.Add(alumno2);
            /*
            StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\personas.txt",true);

            file.Write(personita);

            file.Close();

            StreamReader fileReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\personas.txt");

            string auxData="";

            while (!fileReader.EndOfStream)
            {
                auxData += fileReader.ReadLine()+"\n";
            }

            using (fileReader)
            {
 
            }
           
            Console.WriteLine(auxData);
            */

            XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));

            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\personas.xml");

            
            serializador.Serialize(writer, personas);
            
           

            writer.Close();

            TextReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\personas.xml");

            List<Persona> personas2 =(List<Persona>)serializador.Deserialize(reader);

            foreach (Persona i in personas2)
            {
                Console.Write(i);
            }
            
            reader.Close();

            Console.ReadKey();
        }
    }
}
