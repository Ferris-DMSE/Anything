using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using StudentDataViewer.Models;
using StudentDataViewer.Services;

namespace StudentDataViewer
{
    //added System.Runtime.Serializer reference to access DataContractSerializer classes
    //DataCantractSerializer contains the reading and editing logic for XML files





    class Program
    {



        static void Main(string[] args)
        {
            var ds = new DataStore();
            ProgramIndex programData = ds.LoadData();
            Console.WriteLine(programData);
        }
    }
}
