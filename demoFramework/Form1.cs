using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            var myAsm = typeof(Program).Assembly;
            sb.AppendLine("---Begin");
            sb.AppendLine($"Assembly: {myAsm.GetName().Name}, {myAsm.GetName().Version}");
            sb.AppendLine("-----------------------------------");
            //dotnet tool install -g nbgv
            sb.AppendLine($"ThisAssembly.AssemblyVersion: {ThisAssembly.AssemblyVersion}");
            sb.AppendLine($"ThisAssembly.AssemblyFileVersion: {ThisAssembly.AssemblyFileVersion}");
            sb.AppendLine($"ThisAssembly.AssemblyInformationalVersion: {ThisAssembly.AssemblyInformationalVersion}");
            sb.AppendLine($"ThisAssembly.AssemblyName: {ThisAssembly.AssemblyName}");
            //Console.WriteLine($"{ThisAssembly.PublicKey}");
            //Console.WriteLine($"{ThisAssembly.PublicKeyToken}");
            //NetCore only
            //sb.AppendLine($"ThisAssembly.AssemblyTitle: {ThisAssembly.AssemblyTitle}");
            sb.AppendLine($"ThisAssembly.AssemblyConfiguration: {ThisAssembly.AssemblyConfiguration}");
            sb.AppendLine($"ThisAssembly.RootNamespace: {ThisAssembly.RootNamespace}");
            sb.AppendLine("-----------------------------------");
            sb.AppendLine("Attributes:");
            foreach (var item in myAsm.CustomAttributes)
            {
                sb.AppendLine($"{item.AttributeType.Name}");
                if (item.ConstructorArguments.Count > 0) sb.AppendLine("  ConstructorArguments");
                foreach (var i1 in item.ConstructorArguments)
                {
                    sb.AppendLine($"   > {i1.Value}");
                }
                if (item.NamedArguments.Count > 0) sb.AppendLine("  NamedArguments");
                foreach (var i2 in item.NamedArguments)
                {
                    sb.AppendLine($"   > {i2.MemberName}:{i2.TypedValue.Value}");
                }
            }
            sb.AppendLine("End---\r\nEnter\r\n");
            sb.AppendLine();
            textBox1.Text = sb.ToString();
        }
    }
}
