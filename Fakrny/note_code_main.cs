using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Threading;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;

namespace note_code
{
    public partial class note_code_main : Form
    {

        static string lang = "C#";//defult program lang

        //defult browser search
        string search_in = "https://stackoverflow.com/search?q=";

        //styles
        static MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        static ChromiumWebBrowser chrom;

        public note_code_main()
        {
            InitializeComponent();

            #region control 


            title = new System.Windows.Forms.Label();
            my_files = new System.Windows.Forms.FlowLayoutPanel();
            this.top_tableLayoutPanel.Controls.Add(title, 2, 1);
            //title
            title.Anchor = System.Windows.Forms.AnchorStyles.None;
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.ForeColor = System.Drawing.Color.White;
            title.Location = new System.Drawing.Point(1059, 123);
            title.Name = "title";
            title.Size = new System.Drawing.Size(181, 39);
            title.TabIndex = 5;
            title.Text = "Note Code";
            // my_files
            my_files.AutoScroll = true;
            my_files.Dock = System.Windows.Forms.DockStyle.Fill;
            my_files.Location = new System.Drawing.Point(109, 284);
            my_files.Name = "my_files";
            my_files.Padding = new System.Windows.Forms.Padding(145, 60, 3, 10);
            my_files.Size = new System.Drawing.Size(2072, 1319);
            my_files.TabIndex = 2;
            my_files.Visible = false;

            Controls.Add(my_files);

            tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);

            #endregion

            my_files.Visible = true;

            if (!Directory.Exists(@"C:\note_code_cache\Cache"))
            {
                Directory.CreateDirectory(@"C:\note_code_cache\Cache");
            }

            //Initialized cef
            Task.Factory.StartNew(() =>
            {
                if (Cef.IsInitialized == false)
                {

                    CefSettings settings = new CefSettings();
                    settings.UserAgent = "Mozilla/5.0(Macintosh; Intel Mac OS X 12_0_1) AppleWebKit/537.36(KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36";
                    settings.CachePath = @"C:\note_code_cache\Cache";
                    settings.CefCommandLineArgs.Add("disable-gpu", "1");
                    Cef.Initialize(settings);


                }
            }).Wait();

            p_site1.BackColor = Color.FromArgb(100, 88, 255);

            SetDoubleBuffering.SetDoubleBuffering_(my_files, true);

            user_img.ImageLocation = @"C:\ProgramData\Microsoft\User Account Pictures\user.png";


            WindowState = FormWindowState.Maximized;

            if (!Directory.Exists(@"C:\note_code"))
            {
                Directory.CreateDirectory(@"C:\note_code");
            }

            if (!Directory.Exists(@"C:\note_code\favorit"))
            {

                Directory.CreateDirectory(@"C:\note_code\favorit");

            }
            if (!Directory.Exists(@"C:\note_code\icon"))
            {

                Directory.CreateDirectory(@"C:\note_code\icon");

            }

            refrech.Enabled = false;
            forward.Enabled = false;
            backforward.Enabled = false;
            favorit.Enabled = false;
            split_screen_btn.Enabled = false;
            full_screen.Enabled = false;

            statuse.Text = char.ConvertFromUtf32(0xE001);
            statuse.ForeColor = Color.GreenYellow;

            pl_f(lang);

        }

        #region ide

        private static void InitStylesPriority()
        {
            //add this style explicitly for drawing under other styles
            fctb.AddStyle(SameWordsStyle);
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (fctb.Text.Trim().StartsWith("<?xml"))
            {
                fctb.Language = Language.XML;

                fctb.ClearStylesBuffer();
                fctb.Range.ClearStyle(StyleIndex.All);
                InitStylesPriority();

                fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.ShowReplaceDialog();
        }

        private void miLanguage_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem mi in miLanguage.DropDownItems)
                mi.Checked = mi.Text == lang;
        }

        //funcation to chose the program language
        public static void pl_f(string my_pl)
        {

            //set language
            lang = my_pl;
            fctb.ClearStylesBuffer();
            fctb.Range.ClearStyle(StyleIndex.All);
            InitStylesPriority();
            //
            switch (lang)
            {
                //For example, we will highlight the syntax of C# manually, although could use built-in highlighter

                case "C#": fctb.Language = Language.CSharp; break;
                case "VB": fctb.Language = Language.VB; break;
                case "HTML": fctb.Language = Language.HTML; break;
                case "XML": fctb.Language = Language.XML; break;
                case "SQL": fctb.Language = Language.SQL; break;
                case "PHP": fctb.Language = Language.PHP; break;
                case "JS": fctb.Language = Language.JS; break;
                case "Lua": fctb.Language = Language.Lua; break;
                case "JSON": fctb.Language = Language.JSON; break;
            }
            fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));

        }

        //get the program language text in click on the fild in the menu
        private void miCSharp_Click(object sender, EventArgs e)
        {
            //set language

            pl_f((sender as ToolStripMenuItem).Text);
        }

        private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.CollapseBlock(fctb.Selection.Start.iLine, fctb.Selection.End.iLine);
        }

        private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to collapse all #region blocks (C#)
            if (!lang.StartsWith("C#")) return;
            for (int iLine = 0; iLine < fctb.LinesCount; iLine++)
            {
                if (fctb[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    fctb.CollapseFoldingBlock(iLine);
            }
        }

        private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to expand all #region blocks (C#)
            if (!lang.StartsWith("C#")) return;
            for (int iLine = 0; iLine < fctb.LinesCount; iLine++)
            {
                if (fctb[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    fctb.ExpandFoldedBlock(iLine);
            }
        }

        private void increaseIndentSiftTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.IncreaseIndent();
        }

        private void decreaseIndentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.DecreaseIndent();
        }

        private void hTMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string html = "";

                if (sfd.FilterIndex == 1)
                {
                    html = fctb.Html;
                }
                if (sfd.FilterIndex == 2)
                {

                    ExportToHTML exporter = new ExportToHTML();
                    exporter.UseBr = true;
                    exporter.UseNbsp = false;
                    exporter.UseForwardNbsp = true;
                    exporter.UseStyleTag = true;
                    html = exporter.GetHtml(fctb);
                }
                File.WriteAllText(sfd.FileName, html);
            }
        }

        private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
        {
            fctb.VisibleRange.ClearStyle(SameWordsStyle);
            if (!fctb.Selection.IsEmpty)
                return;//user selected diapason

            //get fragment around caret
            var fragment = fctb.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = fctb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(SameWordsStyle);
        }

        private void goForwardCtrlShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.NavigateForward();
        }

        private void goBackwardCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.NavigateBackward();
        }

        private void autoIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.DoAutoIndent();
        }

        const int maxBracketSearchIterations = 2000;

        void GoLeftBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            Range range = tb.Selection.Clone();//need to clone because we will move caret
            int counter = 0;
            int maxIterations = maxBracketSearchIterations;
            while (range.GoLeftThroughFolded())//move caret left
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == 1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            }
            tb.Invalidate();
        }

        void GoRightBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            var range = tb.Selection.Clone();//need clone because we will move caret
            int counter = 0;
            int maxIterations = maxBracketSearchIterations;
            do
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == -1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.Selection.GoRightThroughFolded();
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            } while (range.GoRightThroughFolded());//move caret right

            tb.Invalidate();
        }

        private void goLeftBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLeftBracket(fctb, '{', '}');
        }

        private void goRightBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoRightBracket(fctb, '{', '}');
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            fctb.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
        }

        Random rnd = new Random();

        private void miChangeColors_Click(object sender, EventArgs e)
        {
            var styles = new Style[] { fctb.SyntaxHighlighter.BlueBoldStyle, fctb.SyntaxHighlighter.BlueStyle, fctb.SyntaxHighlighter.BoldStyle, fctb.SyntaxHighlighter.BrownStyle, fctb.SyntaxHighlighter.GrayStyle, fctb.SyntaxHighlighter.GreenStyle, fctb.SyntaxHighlighter.MagentaStyle, fctb.SyntaxHighlighter.MaroonStyle, fctb.SyntaxHighlighter.RedStyle };
            fctb.SyntaxHighlighter.AttributeStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.ClassNameStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.CommentStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.CommentTagStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.KeywordStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.NumberStyle = styles[rnd.Next(styles.Length)];
            fctb.SyntaxHighlighter.StringStyle = styles[rnd.Next(styles.Length)];

            fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));
        }

        private void setSelectedAsReadonlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.Selection.ReadOnly = true;
        }

        private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.Selection.ReadOnly = false;
        }

        private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.MacrosManager.IsRecording = !fctb.MacrosManager.IsRecording;
        }

        private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.MacrosManager.ExecuteMacros();
        }

        private void changeHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HotkeysEditorForm(fctb.HotkeysMapping);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                fctb.HotkeysMapping = form.GetHotkeys();
        }

        private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rtf = fctb.Rtf;
                File.WriteAllText(sfd.FileName, rtf);
            }
        }

        private void fctb_CustomAction(object sender, CustomActionEventArgs e)
        {
            MessageBox.Show(e.Action.ToString());
        }

        private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.InsertLinePrefix(fctb.CommentPrefix);
        }

        private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fctb.RemoveLinePrefix(fctb.CommentPrefix);
        }

        #endregion

        #region animation_opacty

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

                loadFiles(@"C:\note_code", 1);

                form_opacty.Stop();
            }
        }

        #endregion

        #region function
        //funcation check if the form is open or not
        private void check_if_is_open(string form_name, Action action_open) {

            bool f1 = false;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Form n = Application.OpenForms[i];
                if (n.Name == form_name)
                {

                    n.Close();
                    f1 = true;

                }
            }
            if (!f1)
            {
                action_open();
            }

        }

        //funcation to get the size of txt file
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

        //function to load all txt files
        static string new_name;
        public async static void loadFiles(string filePath, int sleeptime)
        {
            my_files.Controls.Clear();
            my_files.Refresh();
            my_files.BringToFront();

            list_min_note.Controls.Clear();
            list_min_note.Refresh();
            list_min_note.BringToFront();

            DirectoryInfo fileList;
            try
            {

                fileList = new DirectoryInfo(filePath);
                DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE
                FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES

                for (int i = 0; i < files.Length; i++)
                {

                    my_note_code my_Code_note_code = new my_note_code();
                    min_list min_List = new min_list();

                    string img = File.ReadLines(files[i].FullName).ElementAtOrDefault(0).Replace("[+]", null);
                    if (img == "Enter you image path here")
                    {
                        my_Code_note_code.icon_file_as_img = Properties.Resources.icons8_developer_100px;
                        min_List.icon_file_as_img = Properties.Resources.icons8_developer_100px;
                    }
                    else
                    {
                        my_Code_note_code.icon_file = img;
                        min_List.icon_ = img;
                    }
                    string name = files[i].Name.Replace(".txt", null);
                    if (name.Length >= 18)
                    {
                        new_name = name.Substring(0, 18) + "...";
                        my_Code_note_code.file_name_ = new_name;
                        min_List.file_name_ = new_name;
                    }
                    else
                    {
                        my_Code_note_code.file_name_ = files[i].Name.Replace(".txt", null);
                        min_List.file_name_ = files[i].Name.Replace(".txt", null);
                    }
                    string time = File.ReadLines(files[i].FullName).ElementAtOrDefault(1).Replace("[+]", null);
                    my_Code_note_code.edit_time_ = time;
                    my_Code_note_code.file_size_ = sizeF_S_C((ulong)files[i].Length);
                    string path = File.ReadLines(files[i].FullName).ElementAtOrDefault(2).Replace("[+]", null);
                    my_Code_note_code.file_path_ = path;
                    min_List.file_path_ = path;
                    string pl = File.ReadLines(files[i].FullName).ElementAtOrDefault(3).Replace("[+]", null);
                    my_Code_note_code.program_language = pl;
                    min_List.pl_ = pl;

                    list_min_note.Controls.Add(min_List);
                    my_files.Controls.Add(my_Code_note_code);

                    await Task.Delay(sleeptime);

                }

                add_form_temp add_Form_Temp = new add_form_temp();
                my_files.Controls.Add(add_Form_Temp);



            }
            catch (Exception)
            { }

        }

        //funcation read from txt and show in the ide
        public static void get_note_code_note(string path)
        {


            fctb.Text = string.Empty;

            foreach (string line in System.IO.File.ReadLines(path))
            {
                fctb.SelectedText += line + "\r\n";
            }

        }

        #endregion

        #region close_app

        private void close__Click(object sender, EventArgs e)
        {
            if (title.Text.Contains("*"))
            {
                save_edit_note_code save_Edit_note_code = new save_edit_note_code();
                save_Edit_note_code.Show();
                save_Edit_note_code.in_out = true;

            }
            else
            {

                Process currentProcess = Process.GetCurrentProcess();
                string pid = (currentProcess.Id).ToString();

                kill_procces.kill_pro_by_id(pid);
            }



        }

        private void close__MouseEnter(object sender, EventArgs e)
        {
            close_.ForeColor = Color.Silver;
            l_close.Visible = true;
        }

        private void close__MouseLeave(object sender, EventArgs e)
        {
            close_.ForeColor = Color.White;
            l_close.Visible = false;
        }

        #endregion

        #region remove

        //open remove txt file form

        private void open_remove_form()
        {

            remove_form remove_Form = new remove_form();
            remove_Form.Show();

        }

        private void remove__Click(object sender, EventArgs e)
        {
            check_if_is_open("remove_form", open_remove_form);
        }

        private void remove__MouseEnter(object sender, EventArgs e)
        {
            remove_.ForeColor = Color.Silver;
            l_remove.Visible = true;
        }

        private void remove__MouseLeave(object sender, EventArgs e)
        {
            remove_.ForeColor = Color.White;
            l_remove.Visible = false;
        }

        #endregion

        #region add

        //open add txt file form

        private void action_open_add_form() {

            add_form add_note_code = new add_form();
            add_note_code.Show();

        }

        private void add__Click(object sender, EventArgs e)
        {
            check_if_is_open("add_form", action_open_add_form);
           
        }

        private void add__MouseEnter(object sender, EventArgs e)
        {
            add_.ForeColor = Color.Silver;
            l_add.Visible = true;
        }

        private void add__MouseLeave(object sender, EventArgs e)
        {
            add_.ForeColor = Color.White;
            l_add.Visible = false;
        }

        #endregion    

        #region search

        //search in cef 

        private enum chrome_button_switch
        {

            back,
            forward,
            reload

        }

        private static chrome_button_switch chrom_chose(chrome_button_switch type)
        {

            switch (type)
            {
                case chrome_button_switch.back:
                    chrom.Back();
                    break;
                case chrome_button_switch.forward:
                    chrom.Forward();
                    break;
                case chrome_button_switch.reload:
                    chrom.Reload();
                    break;
                default:
                    break;
            }

            return type;

        }

        public static void reload_and_search(string search_in, bool is_url)
        {

            if (Cef.IsInitialized == true)
            {

                if (is_split == true)
                {

                    backforward.Enabled = true;
                    forward.Enabled = true;
                    refrech.Enabled = true;
                    favorit.Enabled = true;
                    my_site.Visible = true;
                    split_screen_btn.Enabled = true;
                    full_screen.Enabled = true;
                    list_min_note.Visible = true;
                    my_files.Visible = false;
                    
                }
                else
                {
                    backforward.Enabled = true;
                    forward.Enabled = true;
                    refrech.Enabled = true;
                    favorit.Enabled = true;
                    my_site.Visible = true;
                    split_screen_btn.Enabled = true;
                    full_screen.Enabled = true;
                    my_files.Visible = false;
                    list_min_note.Visible = false;
                    fctb.Visible = false;
                    tableLayoutPanel1.Visible = false;
                }

                try
                {
                    chrom_chose(chrome_button_switch.reload);


                }
                catch (Exception)
                {
                }

                if (is_url == false)
                {
                    switch (search_in)
                    {
                        case "https://stackoverflow.com/search?q=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://github.com/search?q=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://www.quora.com/search?q=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://stackexchange.com/search?q=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://www.tutorialspoint.com/search/":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://www.codeproject.com/search.aspx?q=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        case "https://www.youtube.com/results?search_query=":
                            chrom = new ChromiumWebBrowser(search_in + search_text.Text);
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                    chrom = new ChromiumWebBrowser(search_in);
                }
            }

            my_site.BackColor = Color.FromArgb(21, 21, 21);
            my_site.Controls.Clear();
            my_site.Controls.Add(chrom);
            chrom.Dock = DockStyle.Fill;

            url_img.Start();

        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            search_text.ForeColor = Color.White;
        }

        private void search_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                reload_and_search(search_in, false);
            }
        }

        private void search_text_MouseEnter(object sender, EventArgs e)
        {
            if (search_text.Text == "Search for code")
            {

                search_text.Text = string.Empty;
                search_text.ForeColor = Color.White;
                d.ForeColor = Color.White;
                search_b.ForeColor = Color.White;

            }
        }

        private void search_text_MouseLeave(object sender, EventArgs e)
        {
            if (search_text.Text == string.Empty)
            {
                search_text.Text = "Search for code";
                search_text.ForeColor = Color.DimGray;
                d.ForeColor = Color.Silver;
                search_b.ForeColor = Color.DimGray;
            }
        }

        private void search_b_Click(object sender, EventArgs e)
        {
            reload_and_search(search_in, false);
        }

        private void search_b_MouseEnter(object sender, EventArgs e)
        {
            search_b.ForeColor = Color.White;
        }

        private void search_b_MouseLeave(object sender, EventArgs e)
        {
            search_b.ForeColor = Color.Silver;
        }

        #endregion

        #region save_txt_file

        public static bool is_change;
        static SaveFileDialog saveFileDialog = new SaveFileDialog();
        static bool save_btn;

        //function to save the update in txt file
        public static void save_f()
        {

            saveFileDialog.FileName = (title.Text + ".txt").Replace("*", null);
            saveFileDialog.InitialDirectory = @"C:\note_code";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fctb.Text);
                    sw.Close();

                }

                string time = "[+]" + DateTime.Now.ToString("hh:ss:mm tt");
                string[] lines = File.ReadAllLines(saveFileDialog.FileName);
                lines[1] = time;
                File.WriteAllLines(saveFileDialog.FileName, lines);



                title.Text = Path.GetFileName(saveFileDialog.FileName).Replace("*", null).Replace(".txt", null);

                //call the funation(get_note_code_note) becuse we uptade the time
                //the funcation relode the ide and show the new time in line 2
                //and the new uptade text
                get_note_code_note(saveFileDialog.FileName);

                if (save_btn == true)
                {
                    loadFiles(@"C:\note_code", 1);

                    save_btn = false;
                }

                is_change = false;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_btn = true;

            save_f();
        }

        private void fctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (is_change == false)
            {
                title.Text += "*";

                is_change = true;
            }
        }

        #endregion

        #region show_user_img

        private void user_img_Click(object sender, EventArgs e)
        {
            show_user_img show_User_Img = new show_user_img();
            show_User_Img.Show();
        }

        #endregion

        #region status

        private void url_img_Tick(object sender, EventArgs e)
        {
            try
            {

                chrom.FrameLoadStart += OnFrameLoadStart;
                chrom.FrameLoadEnd += endFrameLoadStart;
                chrom.LoadError += error_load;
                chrom.TitleChanged += titel_;
            }
            catch (Exception)
            { }
        }

        private void titel_(object sender, TitleChangedEventArgs e)
        {

            search_text.Text = chrom.Address;
            title.Text = e.Title;

            icon_.ImageLocation = "http://" + new Uri(chrom.Address.ToString()).Host + "/favicon.ico";
            icon_.ErrorImage = Properties.Resources.icons8_globe_35px;
            icon_.InitialImage = Properties.Resources.icons8_globe_35px;


        }

        private void endFrameLoadStart(object sender, FrameLoadEndEventArgs e)
        {

            statuse.Text = char.ConvertFromUtf32(0xE001);
            statuse.ForeColor = Color.GreenYellow;

        }

        private void OnFrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {

            statuse.Text = char.ConvertFromUtf32(0xE2AD);
            statuse.ForeColor = Color.Gold;


        }

        private void error_load(object sender, LoadErrorEventArgs e)
        {
            statuse.Text = char.ConvertFromUtf32(0xEB90);
            statuse.ForeColor = Color.Firebrick;
        }

        #endregion

        #region site_btn_op

        private void active_site(Color s1, Color s2, Color s3, Color s4, Color s5, Color s6, Color s7)
        {

            p_site1.BackColor = s1;
            p_site2.BackColor = s2;
            p_site3.BackColor = s3;
            p_site4.BackColor = s4;
            p_site5.BackColor = s5;
            p_site6.BackColor = s6;
            p_site7.BackColor = s7;

        }

        private void site1_Click(object sender, EventArgs e)
        {
            active_site(Color.FromArgb(100, 88, 255), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70));

            search_in = "https://stackoverflow.com/search?q=";
        }

        private void site2_Click(object sender, EventArgs e)
        {
            active_site(Color.FromArgb(63, 63, 70), Color.FromArgb(100, 88, 255),
                            Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                            Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                            Color.FromArgb(63, 63, 70));

            search_in = "https://github.com/search?q=";
        }

        private void site3_Click(object sender, EventArgs e)
        {
            active_site(Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(100, 88, 255), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70));

            search_in = "https://www.quora.com/search?q=";
        }

        private void site4_Click(object sender, EventArgs e)
        {
            active_site(Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70), Color.FromArgb(100, 88, 255),
               Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
               Color.FromArgb(63, 63, 70));

            search_in = "https://stackexchange.com/search?q=";
        }

        private void site5_Click(object sender, EventArgs e)
        {
            active_site(Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70), Color.FromArgb(63, 63, 70),
                Color.FromArgb(100, 88, 255),
                Color.FromArgb(63, 63, 70),
               Color.FromArgb(63, 63, 70));

            search_in = "https://www.tutorialspoint.com/search/";
        }

        private void site6_Click(object sender, EventArgs e)
        {
            active_site(
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(100, 88, 255),
                Color.FromArgb(63, 63, 70));

            search_in = "https://www.codeproject.com/search.aspx?q=";
        }

        private void my_site7_Click(object sender, EventArgs e)
        {
            active_site(
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(63, 63, 70),
                Color.FromArgb(100, 88, 255));

            search_in = "https://www.youtube.com/results?search_query=";
        }

        #endregion

        #region btn_browser

        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            url_img.Stop();
            statuse.Text = char.ConvertFromUtf32(0xE001);
            statuse.ForeColor = Color.GreenYellow;
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (title.Text.Contains("*"))
            {
                save_edit_note_code save_Edit_note_code = new save_edit_note_code();
                save_Edit_note_code.Show();
            }
            else
            {
                icon_.Image = Properties.Resources.icons8_globe_35px;
                title.Text = "Note Code";
                search_text.Text = "Search for code";
                search_text.ForeColor = Color.DimGray;
                fctb.Visible = false;
                list_min_note.Visible = false;
                backforward.Enabled = false;
                forward.Enabled = false;
                refrech.Enabled = false;
                favorit.Enabled = false;
                my_files.Visible = true;
                tableLayoutPanel1.Visible = false;
                my_site.Visible = false;
                split_screen_btn.Enabled = false;
                full_screen.Enabled = false;

                // loadFiles(@"C:\note_code", 1);
            }
        }

        private void backforward_Click(object sender, EventArgs e)
        {
            chrom_chose(chrome_button_switch.back);
        }

        private void forward_Click(object sender, EventArgs e)
        {
            chrom_chose(chrome_button_switch.forward);

        }

        private void refrech_Click(object sender, EventArgs e)
        {
            chrom_chose(chrome_button_switch.reload);

        }

        #endregion

        #region favorit

        private void favorit_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"C:\note_code\favorit\urls.txt", true, Encoding.UTF8);
            wr.Write(title.Text + "~" + search_text.Text + "\r\n");
            wr.Close();


        }

        private void open_favorite_form() {
            favorit_pages favorit_Pages = new favorit_pages();
            favorit_Pages.Show();
        }

        private void favorite_list_Click(object sender, EventArgs e)
        {
            check_if_is_open("favorit_pages", open_favorite_form);

        }

        #endregion

        #region control_d

        public static Label title;
        public static FlowLayoutPanel my_files;

        #endregion

        #region screen

        static bool is_split;
        private void split_screen_btn_Click(object sender, EventArgs e)
        {
            is_split = true;

            fctb.Text = string.Empty;

            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.BringToFront();

            fctb.SelectedText = "[+]" + "Enter you image path here" + "\n" + "[+]" + DateTime.Now.ToString("hh:ss:mm tt") + "\n" + "[+]" + @"C:\note_code\" + (((title.Text.Replace("*", null)).Replace("-","_")).Replace(" ","_")).Replace("'",null) + "\n" + "[+]" + "C#" + "\n";

            fctb.Visible = true;         
            fctb.Size = new Size(1100, 1444);
            fctb.Dock = DockStyle.Right;
            list_min_note.BringToFront();
            fctb.BringToFront();
            my_site.BringToFront();
            list_min_note.Visible = true;
            
        }

        private void full_screen_Click(object sender, EventArgs e)
        {
            is_split = false;

            fctb.Visible = false;
            tableLayoutPanel1.Visible = false;
            list_min_note.Visible = false;
        }

        #endregion
    }
}
