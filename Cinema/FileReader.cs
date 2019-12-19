using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Cinema
{
    class FileReader
    {
        try
            {
                StreamReader read = new StreamReader(@"C:\Users\LENOVO\source\repos\ChangeNick420\Cinema");
        line = read.ReadLine();
                while (line != null)
                {
                    line = read.ReadLine();
                }
    read.Close();
            }
            catch(Exception e)
            {

            }
            finally
            {

            }
    }
}
