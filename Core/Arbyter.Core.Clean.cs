using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Arbyter
{
    public partial class ArbyterCore
    {
        private int _deletedFileCount;
        //checks if file should be deleted
        private bool ShouldDeleteFile(string filename, TransferLocations transferLocations)
        {
            //do not delete the log
            if (filename.Equals("Arbyter_Log.txt")) return false;
            FileInfo sourceFile = new FileInfo(transferLocations.SourcePath + "\\" + filename);
            FileInfo destinationFile = new FileInfo(transferLocations.DestinationPath + "\\" + filename);
            if (!sourceFile.Exists && destinationFile.Exists) return true;
            return false;
        }
        //deletes the necessay files from current folder
        private void DeleteExtraFiles(TransferLocations transferLocations)
        {
            var destinationDirectory = new DirectoryInfo(transferLocations.DestinationPath);

            foreach (var fileInfo in destinationDirectory.GetFiles())
            {
                if (ShouldDeleteFile(fileInfo.Name, transferLocations))
                {
                    if (transferLocations.Logging) LogFile.WriteLine("[{0}] Deleting {1}\\{2}", DateTime.Now,
                                                                 transferLocations.DestinationPath, fileInfo.Name);

                    _deletedFileCount++;
                    //copy overwriting existing file, if necessary
                    fileInfo.Delete();
                }
            }

        }
        //copies necessary files from source folder hierarchy
        private void DeleteExtraContent(TransferLocations transferLocations)
        {
            var destinationDirectory = new DirectoryInfo(transferLocations.DestinationPath);
            var childDirectories = destinationDirectory.GetDirectories();

            foreach (var childDirectory in childDirectories)
            {
                var sourceChildDir = new DirectoryInfo(transferLocations.SourcePath + "\\" + childDirectory.Name);
                if (!sourceChildDir.Exists)
                {
                    _deletedFileCount += childDirectory.GetFiles("*", SearchOption.AllDirectories).Count();
                    childDirectory.Delete(true);
                    continue;
                }
                              
                DeleteExtraContent(new TransferLocations(
                                             sourceChildDir.FullName,
                                            childDirectory.FullName,
                                            transferLocations.Logging));
            }
            DeleteExtraFiles(transferLocations);
        }

        //starts the run
        public ActionReport RunClean(TransferLocations transferLocations)
        {
            try
            {
                _copiedFileCount = 0;
                if (transferLocations.Logging)
                {
                    LogFile = new StreamWriter(transferLocations.DestinationPath + "\\Arbyter_Log.txt", true);
                    LogFile.WriteLine("[{0}] Arbyter Clean Run Started", DateTime.Now);
                }
                DeleteExtraContent(transferLocations);
                if (transferLocations.Logging)
                {
                    LogFile.WriteLine("{0} file(s) deleted", _deletedFileCount);
                    LogFile.Close();
                }

                return new ActionReport(_deletedFileCount, ActionResult.Success, null);
            }
            catch (Exception exception)
            {
                return new ActionReport(null, ActionResult.Failure, exception);
            }
        }


    }
}