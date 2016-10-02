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
    public class DataStore
    {
        DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(ProgramIndex));

        public ProgramIndex LoadData()
        {
            var stream = File.OpenRead("XMLtestfile.xml");
            ProgramIndex data = (ProgramIndex)dataContractSerializer.ReadObject(stream);
            stream.Close();
            return data;
        }
    }
}
