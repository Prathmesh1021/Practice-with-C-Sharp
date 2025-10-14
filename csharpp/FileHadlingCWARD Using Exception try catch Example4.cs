using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class FileHadlingCWARD_Using_Exception_try_catch_Example4
    {

        String path = "E://helloDONTNET.txt";

        internal void createfile()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        internal void addContentOnFile()
        {
            try
            {
                StreamWriter fw = new StreamWriter(path);
                fw.WriteLine("Welcome in file handling concept");
                fw.Close();

                Console.WriteLine("Data save Sucussfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
        internal void appendContentOnFile()
        {
            try
            {
                StreamWriter fw = new StreamWriter(path, true);
                fw.WriteLine("Now File Working on Append Mode");
                fw.Close();
                Console.WriteLine("Data Append Sucussfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        internal void readFileOperation()
        {
            try
            {

                StreamReader fr = new StreamReader(path);
                String str = fr.ReadToEnd();
                Console.WriteLine(str);
                fr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());

            }
        }
        internal void deleteFileOperation()
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("File Deleted Sucussfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
