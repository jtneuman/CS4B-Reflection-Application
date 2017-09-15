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


        // @"C:\Users\jtneuman\Documents\Visual Studio 2017\Projects\CS4B\Reflection Application\TestAssembly\bin\Debug\TestAssembly.dll";
        // @"E:\Documents\Visual Studio 2017\Projects\CS4B-Reflection-Application\TestAssembly\bin\Debug\TestAssembly.dll";
        const string assemblyPath =
            @"E:\Documents\Visual Studio 2017\Projects\CS4B-Reflection-Application\TestAssembly\bin\Debug\TestAssembly.dll";

        Assembly assembly;
        private object instance;

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            assembly = LoadAssembly.LoadReflectionOnly(assemblyPath);

            cboTypes.DataSource = Members.GetTypeNames(assembly);
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Members.GetType(assembly, cboTypes.Text);
            lstInfo.Items.Clear();
            lstInfo.Items.Add("--- Constructors ---");
            lstInfo.Items.AddRange(Members.GetConstructors(type).ToArray());
            // empty item as separator
            lstInfo.Items.Add("");
            // adding fields
            lstInfo.Items.Add("--- Fields ---");
            lstInfo.Items.AddRange(Members.GetFields(type).ToArray());
            lstInfo.Items.Add("");
            // adding properties
            lstInfo.Items.Add("--- Properties ---");
            lstInfo.Items.AddRange(Members.GetProperties(type).ToArray());
            lstInfo.Items.Add("");
            // adding methods
            lstInfo.Items.Add("--- Methods ---");
            lstInfo.Items.AddRange(Members.GetMethods(type).ToArray());
        
        }

        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            try
            {
                assembly = LoadAssembly.LoadExecutable(assemblyPath);
                var type = Members.GetType(assembly, cboTypes.Text);
                var instance = Members.CreateWithSpecificConstructor(type,
                    new DateTime(1970, 5, 4));
                lblResult.Text = Members.ExecuteMethod(instance, "GetAge").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetProperty_Click(object sender, EventArgs e)
        {
            try
            {
                assembly = LoadAssembly.LoadExecutable(assemblyPath);
                var type = Members.GetType(assembly, cboTypes.Text);
                instance = Members.CreateWithDefaultConstructor(type);
                Members.SetProperty(instance, "FirstName", txtValue.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetProperty_Click(object sender, EventArgs e)
        {
            try
            {
                
                lblResult.Text = Members.GetProperty(instance, "FirstName").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
