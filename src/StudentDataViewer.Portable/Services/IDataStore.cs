using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataViewer.Models;

namespace StudentDataViewer.Services
{
    /// <summary>
    /// Defines an interface that represents a data store.
    /// </summary>
    public interface IDataStore
    {
        /// <summary>
        /// Loads the data currently in XMLtestfile.xml into a new <see cref="ProgramIndex"/> object, and
        /// returns it.
        /// </summary>
        /// <returns>Returns a new <see cref="ProgramIndex"/> object with all of the data from XMLtestfile.xml prepopulated.</returns>
        ProgramIndex LoadData();
    }
}
