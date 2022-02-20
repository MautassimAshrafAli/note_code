using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public partial class save_edit_note_code : Form
    {
        public save_edit_note_code()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            this.CenterToScreen();
        }


        private void close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close__MouseEnter(object sender, EventArgs e)
        {
            close_.ForeColor = Color.Silver;
        }

        private void close__MouseLeave(object sender, EventArgs e)
        {
            close_.ForeColor = Color.White;
        }

        private void form_opacty_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {

                form_opacty.Stop();

            }

            if (this.Opacity < 1)
            {

                this.Opacity += .29;
            }
            else
            {
                Application.OpenForms[this.Name].Focus();

                form_opacty.Stop();
            }
        }

        public bool in_out;

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            switch (in_out)
            {
                case false:

                    note_code_main.title.Text = "note code";
                    note_code_main.tableLayoutPanel1.Visible = false;
                    note_code_main.fctb.Visible = false;
                    note_code_main.list_min_note.Visible = false;
                    note_code_main.my_files.Visible = true;

                    this.Close();

                    break;

                case true:

                    Process currentProcess = Process.GetCurrentProcess();
                    string pid = (currentProcess.Id).ToString();

                    kill_procces.kill_pro_by_id(pid);

                    break;
            }

        }

        private void yes__Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            note_code_main.save_f();

            // note_code.Parse();

            note_code_main.loadFiles(@"C:\note_code",1);
            note_code_main.title.Text ="note code";
            note_code_main.tableLayoutPanel1.Visible = false;
            note_code_main.list_min_note.Visible = false;
            note_code_main.fctb.Visible = false;
            note_code_main.my_files.Visible = true;



            switch (in_out)
            {
                case false:
                   
                    this.Close();

                    break;

                case true:

                    Process currentProcess = Process.GetCurrentProcess();
                    string pid = (currentProcess.Id).ToString();

                    kill_procces.kill_pro_by_id(pid);

                    break;
            }

        }

    }
}
