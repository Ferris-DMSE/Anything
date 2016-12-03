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
    /// <summary>
    /// Defines a class that is able to load our <see cref="ProgramIndex"/>
    /// data model from the XMLtestfile.xml file.
    /// </summary>
    public class DataStore : IDataStore
    {
        DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(ProgramIndex));

        /// <summary>
        /// Loads the data currently in XMLtestfile.xml into a new <see cref="ProgramIndex"/> object, and
        /// returns it.
        /// </summary>
        /// <returns>Returns a new <see cref="ProgramIndex"/> object with all of the data from XMLtestfile.xml prepopulated.</returns>
        public ProgramIndex LoadData()
        {
            using (var stream = File.OpenRead("XMLtestfile.xml"))
            {
                ProgramIndex data = (ProgramIndex)dataContractSerializer.ReadObject(stream);
                return data;
            }
        }
    }
}
