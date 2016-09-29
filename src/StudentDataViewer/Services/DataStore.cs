using StudentDataViewer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer.Services
{
    class DataStore
    {
        DataContractSerializer dcs = new DataContractSerializer(typeof(ProgramIndex));


        public DataStore()
        {



        }

        internal ProgramIndex LoadData()
        {
            var stream = File.OpenRead("data.xml");
            ProgramIndex data = (ProgramIndex)dcs.ReadObject(stream);
            stream.Close();
            return data;

        }

    }
}
