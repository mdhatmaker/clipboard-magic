using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMagic
{
    public partial class MainForm : Form
    {
        private ClipBoardMonitor _cbm = null;

        private List<string> _imageTexts = new List<string>();

        PythonScriptForm _pythonForm;

        private PythonScriptForm pyForm
        {
            get
            {
                if (_pythonForm == null)
                {
                    _pythonForm = new PythonScriptForm();
                    _pythonForm.Show();
                }
                return _pythonForm;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _cbm = new ClipBoardMonitor();
            _cbm.OnClipboardTextUpdate += cbm_ClipboardTextContent;
            _cbm.OnClipboardUrlUpdate += cbm_ClipboardUrlContent;
            _cbm.OnClipboardImageUpdate += cbm_ClipboardImageContent;
            _cbm.OnClipboardAudioUpdate += cbm_ClipboardAudioContent;

        }
        
        private void cbm_ClipboardTextContent(string txt)
        {
            Console.WriteLine("Text: {0}", txt);
            listClipboardSnippets.Items.Add(txt);
        }

        private void cbm_ClipboardUrlContent(string url)
        {
            Console.WriteLine("URL: {0}", url);
            listUrls.Items.Add(url);
        }

        private void cbm_ClipboardImageContent(Image img)
        {
            Console.WriteLine("Image: {0}x{1}", img.Width, img.Height);
            imageList1.Images.Add(img);
            //listClipboardSnippets.Items.Add(txt);
        }

        private void cbm_ClipboardAudioContent(System.IO.Stream audioStream)
        {
            Console.WriteLine("Audio: {0}", audioStream.Length);
            //listClipboardSnippets.Items.Add(txt);
        }

        private void openUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                displayText(e.Message, Color.Salmon);   // error opening URL
            }
        }

        private string getSelected(ListBox listbox)
        {
            int ix = listbox.SelectedIndex;
            if (ix >= 0)
            {
                return listbox.Items[ix].ToString();
            }
            else
                return "";
        }

        private void displayText(string txt, Color? backColor = null)
        {
            if (backColor == null)
                lblText.BackColor = SystemColors.Control;
            else
                lblText.BackColor = backColor.Value;

            lblText.Text = txt;
        }

        private void displayUrl(string url)
        {
            displayText(url, Color.SpringGreen);
        }

        private void listClipboardSnippets_Click(object sender, EventArgs e)
        {
            displayText(getSelected(listClipboardSnippets));
        }

        private void listUrls_Click(object sender, EventArgs e)
        {
            displayUrl(getSelected(listUrls));
        }
        
        private void listUrls_DoubleClick(object sender, EventArgs e)
        {
            var url = getSelected(listUrls);
            if (url == "") return;
            displayUrl(url);
            openUrl(url);
        }

        private void tsbtnPython_Click(object sender, EventArgs e)
        {
            pyForm.Show();
        }

        private void filterAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scopeDict = new Dictionary<string, string>();
            scopeDict.Add("__text", lblText.Text);
            pyForm.RunPythonFile(@"../../FilterA.py", scopeDict);
        }


        private void AddImagesToListview()
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\pic");
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            this.lviewImages.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);
            this.lviewImages.LargeImageList = this.imageList1;
            //or
            //this.listView1.View = View.SmallIcon;
            //this.listView1.SmallImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                /*ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.ImageKey = file.Name;*/
                item.ImageIndex = j;
                this.lviewImages.Items.Add(item);
            }    
        }
    } // end of class ClipboardMonitorForm


} // end of namespace




// https://codeblog.jonskeet.uk/2015/01/30/clean-event-handlers-invocation-with-c-6/
// https://www.csharpcodi.com/csharp-examples/System.Windows.Clipboard.GetData(string)/






