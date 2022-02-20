using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            this.CenterToScreen();

            pl.Items.Add("C#");
            pl.Items.Add("VB");
            pl.Items.Add("HTML");
            pl.Items.Add("XML");
            pl.Items.Add("SQL");
            pl.Items.Add("PHP");
            pl.Items.Add("JS");
            pl.Items.Add("Lue");
            pl.Items.Add("JSON");

            pl.SelectedIndex = 0 ;

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

        private void file_name_text_MouseEnter(object sender, EventArgs e)
        {
            if(file_name_text.Text == "file name")
            {
                file_name_text.Text = string.Empty;
                file_name_text.ForeColor = Color.White;
            }
        }

        private void file_name_text_MouseLeave(object sender, EventArgs e)
        {
            if (file_name_text.Text == string.Empty)
            {
                file_name_text.Text = "file name";
                file_name_text.ForeColor = Color.DimGray;
            }
        }
        string my_path;
        private void get_icon_b_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "png (*.png)|*.png|jpg (*.jpg)|*.jpg";
            openFileDialog.Title = "note_code";
            openFileDialog.FileName = "";
            openFileDialog.FilterIndex = 1;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_icon.ImageLocation = openFileDialog.FileName;
                icon_path_text.Text = openFileDialog.FileName;
                my_path = openFileDialog.FileName;
            }
        }

        public static string sizeF_S_C(ulong d)
        {

            double GB = d / 1024 / 1024 / 1024;
            if (GB > 0.999) { return GB.ToString() + " GB"; }
            double MB = d / 1024 / 1024;
            if (MB > 0.999) { return MB.ToString() + " MB"; }
            double KB = d / 1024;
            if (KB > 0.999) { return KB.ToString() + " KB"; }
            return d.ToString() + " bytes";

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((icon_path_text.Text == string.Empty) || (file_name_text.Text == string.Empty) ||
                (icon_path_text.Text == "iocn path") || (file_name_text.Text == "file name"))
            {
                error.Visible = true;
            }
            else {


                error.Visible = false;

                

                if (File.Exists(@"C:\note_code_note\" + file_name_text.Text + ".txt"))
                {
                    error.Visible = true;
                    error.Text = "note_code file is already exists";
                }
                else
                {

                    error.Visible = false;

                    string time = DateTime.Now.ToString("hh:ss:mm tt");

                    System.IO.File.WriteAllText(@"C:\note_code\" + file_name_text.Text + ".txt", "[+]" + my_path + "\n" + "[+]" + time + "\n" + "[+]" + @"C:\note_code\" + file_name_text.Text + ".txt" + "\n[+]"+pl.Text + "\n" + "\n" + "\n");


                    FileInfo file = new FileInfo(@"C:\note_code\" + file_name_text.Text + ".txt"); // GET ALL THE FILES

                    note_code_main.loadFiles(@"C:\note_code", 1);

                    this.Close();
                }
            }


        }
    }
}
