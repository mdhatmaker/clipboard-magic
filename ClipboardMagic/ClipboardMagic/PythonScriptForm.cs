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

// https://www.needfulsoftware.com/IronPython/IronPythonCS
// https://github.com/NeedfulSoftware/IronPythonTutorials


namespace ClipboardMagic
{
    public partial class PythonScriptForm : Form
    {
        Microsoft.Scripting.Hosting.ScriptEngine _pythonEngine = IronPython.Hosting.Python.CreateEngine();

        string _codeFileFilter = "python files (*.py)|*.py|All files (*.*)|*.*";

        public PythonScriptForm()
        {
            InitializeComponent();

            rtbScript.ScrollBars = RichTextBoxScrollBars.Both;
            rtbScript.WordWrap = false;

            UpdatePythonPaths();
        }

        // TODO: handle exceptions
        private void runPython(string pythonSourceCode)
        {
            var pythonScript = _pythonEngine.CreateScriptSourceFromString(pythonSourceCode);
            var results = pythonScript.Execute();
        }

        private string getSourceCode()
        {
            string sourceCode = rtbScript.Text;
            return sourceCode;
        }

        private void runSourceCode()
        {
            runPython(getSourceCode());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //runSourceCode();
            ScopeDemo();
        }

        private void tsbRun_Click(object sender, EventArgs e)
        {
            runSourceCode();
        }

        public void RunPythonFile(string filename, Dictionary<string,string> scopeDict)
        {
            // We execute this script from Visual Studio 
            // so the program will be executed from bin\Debug or bin\Release
            Microsoft.Scripting.Hosting.ScriptSource pythonScript =
                _pythonEngine.CreateScriptSourceFromFile(filename);
            //pythonEngine.CreateScriptSourceFromFile("..\\..\\HelloWorld.py");

            Microsoft.Scripting.Hosting.ScriptScope scope = _pythonEngine.CreateScope();
            //scope.SetVariable("externalString", "How do you do?");
            foreach (var kv in scopeDict)
            {
                scope.SetVariable(kv.Key, kv.Value);
            }
            pythonScript.Execute(scope);
        }

        private void PrintPythonPaths(ICollection<string> searchPaths)
        {
            // Print the default search paths
            System.Console.Out.WriteLine("Search paths:");
            foreach (string path in searchPaths)
            {
                System.Console.Out.WriteLine(path);
            }
            System.Console.Out.WriteLine();
        }

        private ICollection<string> GetPythonPaths()
        {
            // Print the default search paths
            ICollection<string> searchPaths = _pythonEngine.GetSearchPaths();
            PrintPythonPaths(searchPaths);
            return searchPaths;
        }

        private void UpdatePythonPaths()
        {
            var searchPaths = GetPythonPaths();

            // Now modify the search paths to include the directory from
            // which we execute the script...
            searchPaths.Add("..\\..");
            // ...and the Lib folder which contains all the python modules
            searchPaths.Add("..\\..\\Lib");
            _pythonEngine.SetSearchPaths(searchPaths);
            PrintPythonPaths(searchPaths);
        }

        // Demonstrate the creation and use of "scope" to share between C# and python
        private void ScopeDemo()
        {
            Microsoft.Scripting.Hosting.ScriptSource pythonScript = _pythonEngine.CreateScriptSourceFromString(
                "helloWorldString = 'Hello World!'\n" +
                "print helloWorldString\n" +
                "print externalString"
                );

            Microsoft.Scripting.Hosting.ScriptScope scope = _pythonEngine.CreateScope();
            scope.SetVariable("externalString", "How do you do?");

            pythonScript.Execute(scope);

            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("List of variables in the scope:");
            foreach (string name in scope.GetVariableNames())
            {
                System.Console.Out.Write(name + " ");
            }
            System.Console.Out.WriteLine();

            System.Console.Out.WriteLine();
            System.Console.Out.WriteLine("Variable values:");
            System.Console.Out.WriteLine("helloWorldString: " + scope.GetVariable("helloWorldString"));
            System.Console.Out.WriteLine("externalString: " + scope.GetVariable("externalString"));
        }

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = _codeFileFilter;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            var result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                rtbScript.Text = fileContent;
            }
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            Stream myStream;

            saveFileDialog1.Filter = _codeFileFilter;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "myscript.py";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream.
                    byte[] bytes = Encoding.ASCII.GetBytes(getSourceCode());
                    myStream.Write(bytes, 0, bytes.Length);
                    myStream.Close();
                }
            }
        }

    } // end of class PythonScriptForm

} // end of namespace
