using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Controller.lib
{
    public class PyUtils
    {
        //private string pathScriptUpdate = "C:\\Users\\cesar\\SoftDev\\uoc\\dotnet\\HotelSol\\Script\\PythonOdooScript\\updateProduct.py";
        //private string scriptPath = "C:\\Users\\cesar\\SoftDev\\uoc\\dotnet\\HotelSol\\Script\\PythonOdooScript\\importOdoo.py";
        private string pathScriptUpdate;
        private string scriptPathPr;
        private string scriptPathCli;

        public PyUtils() {
            if (Debugger.IsAttached)
            {
                pathScriptUpdate = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\Script\PythonOdooScript\updateProduct.py");
                scriptPathPr = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\Script\PythonOdooScript\importOdoo.py");
                scriptPathCli = Path.Combine(Application.StartupPath, @"..\..\..\Script\PythonOdooScript\OdooScript.py");
            }
            else
            {
                pathScriptUpdate =  @".\Script\PythonOdooScript\updateProduct.py";
                scriptPathPr = @".\Script\PythonOdooScript\importOdoo.py";
                scriptPathCli = @".\Script\PythonOdooScript\OdooScript.py";
            }
        }


        public Boolean EjecutarScriptPython()
        {
            Boolean ok = true;
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{scriptPathPr}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                    process.WaitForExit();
                }

            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;  
        }

        /**
         * llama al script python pasando como parámetros
         */

        public string ActualizaQtyOdoo(string id, string qty)
        {
            string result = "0";            
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = string.Format("{0} {1} {2}", pathScriptUpdate, id, qty),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                    process.WaitForExit();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write(ex.StackTrace);   
                result = "-1";
            }
            return result;
        }


        public void EjecutarScriptPythonClientes()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{scriptPathCli}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el script de Python: " + ex.Message);
            }
        }

    }
}
