using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public class kill_procces
    {

        public static string kill_pro(string procces)
        {


            System.Diagnostics.Process f_r = new System.Diagnostics.Process();
            f_r.StartInfo.FileName = "cmd.exe";
            f_r.StartInfo.RedirectStandardInput = true;
            f_r.StartInfo.RedirectStandardOutput = true;
            f_r.StartInfo.CreateNoWindow = true;
            f_r.StartInfo.UseShellExecute = false;
            f_r.Start();

            f_r.StandardInput.WriteLine("cd/ & cd windows & cd system32 & TASKKILL.exe /F /IM " + procces);
            f_r.StandardInput.Flush();
            f_r.StandardInput.Close();

            return procces;

        }

        public static void kill_pro_and_start(ref string procces_kill, ref string start_procces)
        {


            System.Diagnostics.Process f_r = new System.Diagnostics.Process();
            f_r.StartInfo.FileName = "cmd.exe";
            f_r.StartInfo.RedirectStandardInput = true;
            f_r.StartInfo.RedirectStandardOutput = true;
            f_r.StartInfo.CreateNoWindow = true;
            f_r.StartInfo.UseShellExecute = false;
            f_r.Start();

            f_r.StandardInput.WriteLine("cd/ & cd windows & cd system32 & TASKKILL.exe /F /IM " + procces_kill + "&cd / &" + start_procces);
            f_r.StandardInput.Flush();
            f_r.StandardInput.Close();

        }

        public static string kill_pro_by_id(string id)
        {

            System.Diagnostics.Process f_r4 = new System.Diagnostics.Process();
            f_r4.StartInfo.FileName = "cmd.exe";
            f_r4.StartInfo.RedirectStandardInput = true;
            f_r4.StartInfo.RedirectStandardOutput = true;
            f_r4.StartInfo.CreateNoWindow = true;
            f_r4.StartInfo.UseShellExecute = false;
            f_r4.Start();


            f_r4.StandardInput.WriteLine("cd/ & cd windows & cd system32 & TASKKILL.exe /F /pid " + id);
            f_r4.StandardInput.Flush();
            f_r4.StandardInput.Close();

            return id;
        }
    }
}
