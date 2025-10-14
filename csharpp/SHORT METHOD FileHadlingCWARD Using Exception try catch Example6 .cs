using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class SHORT_METHOD_FileHadlingCWARD_Using_Exception_try_catch_Example6
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
                String data;
                Console.WriteLine("Enter Content ");
                data = Console.ReadLine();
                File.WriteAllText(path, data);

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
                File.AppendAllText(path, " Now File Working on Append Mode");
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
                File.ReadAllText(path);
                String data = File.ReadAllText(path);
                Console.WriteLine(data);
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
