using System;
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
        private ClipBoardMonitor cbm = null;

        private List<string> imageTexts = new List<string>();

        PythonScriptForm pythonForm;
        private Form pyForm
        {
            get
            {
                if (pythonForm == null)
                {
                    pythonForm = new PythonScriptForm();
                    pythonForm.Show();
                }
                return pythonForm;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            cbm = new ClipBoardMonitor();
            cbm.OnClipboardTextUpdate += cbm_ClipboardTextContent;
            cbm.OnClipboardUrlUpdate += cbm_ClipboardUrlContent;
            cbm.OnClipboardImageUpdate += cbm_ClipboardImageContent;
            cbm.OnClipboardAudioUpdate += cbm_ClipboardAudioContent;

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
            picImages.Image = img;
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
    } // end of class ClipboardMonitorForm


 


} // end of namespace




// https://codeblog.jonskeet.uk/2015/01/30/clean-event-handlers-invocation-with-c-6/
// https://www.csharpcodi.com/csharp-examples/System.Windows.Clipboard.GetData(string)/






