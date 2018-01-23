using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace HelloWorld.Persistence
{
    /*public interface ISave
    {
        Task SaveTextAsync(string filename, string contentType, MemoryStream s);
    }*/
    public interface ISave
    {
        void Save(string filename, string contentType, MemoryStream stream);
    }
}
