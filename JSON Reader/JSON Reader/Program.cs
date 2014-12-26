using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace JSON_Reader
{

    class Program
    {
        Assembly _assembly;
        StreamReader _textStreamReader = null;
       static void Main(string[] args)
        {
            Program program = new Program();
            program.readJsonFile(); 
       }
       private void readJsonFile()
        {
          try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("JSON_Reader.Resources.colors.json"));
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

        
           if (_textStreamReader != null)
           {
               try
               {
                   MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(_textStreamReader.ReadToEnd()));
                   stream.Position = 0;
                   DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Color>));
                   var obj = ser.ReadObject(stream);
                   Console.WriteLine("This is the end of program!!");
               }
               catch(Exception en)
               {
                   Console.WriteLine("Exception thrown you dumbo!!!"+en);
               }
               }
         
        }
    }
}
