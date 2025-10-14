using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class FileHandlingExample2_Append
    {
        
        
            String path = "E://helloDONTNET.txt";

            internal void createfile()
            {

                if (File.Exists(path))
                {

                    Console.WriteLine("File Already Exist");
                }
                else
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                    Console.WriteLine("New File Created");
                }
            }
            internal void addContentOnFile()
            {
                StreamWriter fw = new StreamWriter(path);
                fw.WriteLine("Welcome in file handling concept");
                fw.Close();

                Console.WriteLine("Data save Sucussfully");
                // File.WriteAllText(path, "Welcome in file handling concept");
            }
            internal void appendContentOnFile()
            {
                StreamWriter fw = new StreamWriter(path, true);
                fw.WriteLine("Now File Working on Append Mode");
                fw.Close();
                Console.WriteLine("Data Append Sucussfully");
                // File.WriteAllText(path, "Welcome in file handling concept"); 

            }
        }
    } 


