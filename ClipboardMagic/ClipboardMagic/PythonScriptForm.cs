using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMagic
{
    public partial class PythonScriptForm : Form
    {
        Microsoft.Scripting.Hosting.ScriptEngine pythonEngine = IronPython.Hosting.Python.CreateEngine();

        public PythonScriptForm()
        {
            InitializeComponent();


        }

        private void runPython(string pythonSourceCode)
        {
            var pythonScript = pythonEngine.CreateScriptSourceFromString(pythonSourceCode);
            var results = pythonScript.Execute();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string sourceCode = rtbScript.Text;
            runPython(sourceCode);
        }

    } // end of class PythonScriptForm

} // end of namespace
