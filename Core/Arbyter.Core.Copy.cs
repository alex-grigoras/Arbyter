using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Arbyter
{
    
    
    //Automated Resource Backup Assistent
    public partial class ArbyterCore
    {
       
        private int _copiedFileCount;
        private StreamWriter LogFile;
        
        //checks if file should be copied
        private bool ShouldCopyFile(string filename, TransferLocations transferLocations)
        {
            FileInfo sourceFile = new FileInfo(transferLocations.SourcePath + "\\" + filename);
            FileInfo destinationFile = new FileInfo(transferLocations.DestinationPath + "\\" + filename);
            if (!destinationFile.Exists ||
                destinationFile.LastWriteTime < sourceFile.LastWriteTime) return true;
            return false;
        }
        //copies the necessay files from current folder
        private void CopyModifiedFiles(TransferLocations transferLocations)
        {
            var sourceDirectory = new DirectoryInfo(transferLocations.SourcePath);

            foreach (var fileInfo in sourceDirectory.GetFiles())
            {
                if (ShouldCopyFile(fileInfo.Name, transferLocations))
                {
                    if (transferLocations.Logging) LogFile.WriteLine("[{0}] Copying {1}\\{2} to {3}\\{4}", DateTime.Now,
                                                                 transferLocations.SourcePath, fileInfo.Name,
                                                                 transferLocations.DestinationPath, fileInfo.Name);

                    _copiedFileCount++;
                    //copy overwriting existing file, if necessary
                    fileInfo.CopyTo(transferLocations.DestinationPath + "\\" + fileInfo.Name, true);
                }
            }

        }
        //copies necessary files from source folder hierarchy
        private void CopyModifiedContent(TransferLocations transferLocations)
        {
            var sourceDirectory = new DirectoryInfo(transferLocations.SourcePath);
            var childDirectories = sourceDirectory.GetDirectories();

            foreach (var childDirectory in childDirectories)
            {
                CopyModifiedContent(new TransferLocations(
                                            childDirectory.FullName,
                                            transferLocations.DestinationPath + "\\" + childDirectory.Name,
                                            transferLocations.Logging));
            }
            var destinationDirectory = new DirectoryInfo(transferLocations.DestinationPath);
            if (!destinationDirectory.Exists) destinationDirectory.Create();
            CopyModifiedFiles(transferLocations);
        }

        //starts the run
        public ActionReport RunCopy(TransferLocations transferLocations)
        {
            try
            {
                _copiedFileCount = 0;
                if (transferLocations.Logging)
                {
                    LogFile = new StreamWriter(transferLocations.DestinationPath + "\\Arbyter_Log.txt", true);
                    LogFile.WriteLine("[{0}] Arbyter Copy Run Started", DateTime.Now);
                }
                CopyModifiedContent(transferLocations);
                if (transferLocations.Logging)
                {
                    LogFile.WriteLine("{0} file(s) copied", _copiedFileCount);
                    LogFile.Close();
                }

                return new ActionReport(_copiedFileCount, ActionResult.Success, null);
            }
            catch (Exception exception)
            {
                return new ActionReport(null, ActionResult.Failure, exception);
            }
        }

        
    }
}