using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobEnter
{
    class Create_Folder
    {
        private string saveLocation;
        private string folderName;

        public Create_Folder(string saveLocation, string folderName)
        {
            this.saveLocation = saveLocation;
            this.folderName = folderName;
        }


        public void createFolder()
        {
            // Specify a name for your top-level folder.
            string folderName1 = this.folderName;

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
            string pathString = System.IO.Path.Combine(saveLocation, folderName);

            // Create the subfolder. You can verify in File Explorer that you have this
            // structure in the C: drive.
            //    Local Disk (C:)
            //        Top-Level Folder
            //            SubFolder
            System.IO.Directory.CreateDirectory(pathString);

            /*
            // Create a file name for the file you want to create. 
            string fileName = "";

            // Use Combine again to add the file name to the path.
            string pathString1 = System.IO.Path.Combine(pathString, fileName);

            // Verify the path that you have constructed.
            Console.WriteLine("Path to my file: {0}\n", pathString1);

            // Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
            // DANGER: System.IO.File.Create will overwrite the file if it already exists.
            // This could happen even with random file names, although it is unlikely.
            if (!System.IO.File.Exists(pathString1))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString1))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                    fs.Close();
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return "";
            }
            
            // Read and display the data from your file.
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString1);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException eexcep)
            {
                Console.WriteLine("Creating Folder did not work: " + eexcep.Message);
            }
            
            return pathString;
            */
        }


    }
}
