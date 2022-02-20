using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public partial class show_user_img : Form
    {
        public show_user_img()
        {
            InitializeComponent();

            this.CenterToParent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            user_img.ImageLocation = @"C:\ProgramData\Microsoft\User Account Pictures\user.png";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
