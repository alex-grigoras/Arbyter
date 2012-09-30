using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbyter
{
    public class TransferLocations
    {
        
        public readonly string SourcePath;
        public readonly string DestinationPath;
        public readonly bool Logging;


        public TransferLocations(string sourcePath, string destinationPath, bool logging)
        {
            SourcePath = sourcePath;
            DestinationPath = destinationPath;
            Logging = logging;
        }
    }
}
