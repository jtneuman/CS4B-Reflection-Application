using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReflectionLibrary;

namespace ReflectionApplication
{
    public partial class EntryForm : Form
    {
        const string assemblyPath =
            @"C:\Users\jtneuman\Documents\Visual Studio 2017\Projects\CS4B\Reflection Application\TestAssembly\";
        Assembly assembly;

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            assembly = LoadAssembly.LoadReflectionOnly(assemblyPath);

            cboTypes.DataSource = Members.GetTypeNames(assembly);
        }
    }
}
