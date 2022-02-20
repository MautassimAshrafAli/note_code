using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using SimpleWifi;

namespace note_code
{
    public partial class favorit_pages : Form
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        Wifi wifi_a;
        public favorit_pages()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            SetWindowTheme(this.urls_.Handle, "Explorer", null);

            this.CenterToScreen();

            wifi_a = new Wifi();

            if (File.Exists(@"C:\note_code\favorit\urls.txt"))
            {
                urls_.Visible = true;

                foreach (string line in File.ReadLines(@"C:\note_code\favorit\urls.txt"))
                {
                    

                    if (wifi_a.ConnectionStatus == WifiStatus.Connected)
                    {

                        HttpWebRequest requestPic = (HttpWebRequest)WebRequest.Create("http://" + new Uri(line.Substring(line.LastIndexOf("~") + 1)).Host + "/favicon.ico");
                        HttpWebResponse responsePic = (HttpWebResponse)requestPic.GetResponse();
                        Image webImage = Image.FromStream(responsePic.GetResponseStream());
                        webImage.Save(@"C:\note_code\icon\" + new Uri(line.Substring(line.LastIndexOf("~") + 1)).Host + ".png");

                    }

                    imageList1.Images.Add(new Uri(line.Substring(line.LastIndexOf("~") + 1)).Host, Image.FromFile(@"C:\note_code\icon\" + new Uri(line.Substring(line.LastIndexOf("~") + 1)).Host + ".png"));

                    ListViewItem listViewItem = new ListViewItem(line.Substring(0, line.LastIndexOf("~")), new Uri(line.Substring(line.LastIndexOf("~") + 1)).Host);
                    listViewItem.SubItems.Add(new Uri(line.Substring(line.LastIndexOf("~") + 1)).ToString());

                    urls_.Items.Add(listViewItem);

                }
            }
            else {

                urls_.Visible = false;
            
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int url_index;
        private void urls__ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            url_index = e.Item.Index;
        }

        private void urls__Click(object sender, EventArgs e)
        {
            string search_in = urls_.Items[url_index].SubItems[1].Text;
            note_code_main.reload_and_search(search_in, true);

            this.Close();
        }
    }
}
