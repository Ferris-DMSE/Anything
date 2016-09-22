using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using StudentDataViewer.Models;

namespace StudentDataViewer
{
    //added System.Runtime.Serializer reference to access DataContractSerializer classes
    //DataCantractSerializer contains the reading and editing logic for XML files
    //public abstract class XmlObjectSerializer
    //{
        
    //}

    //public sealed class DataContractSerializer : XmlObjectSerializer
    //{

    //}




    //class ProgramIndex
    //{
    //    public void ReadXML ()
    //    {
    //        Stream s = File.OpenRead(“file.xml”);
    //        ProgramIndex data = (ProgramIndex)dcs.DeserializeObject(s);
    //        s.Close();
    //        return data;
    //    }
    //}



    class Program
    {



        static void Main(string[] args)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(ProgramIndex));

        }
    }
}
