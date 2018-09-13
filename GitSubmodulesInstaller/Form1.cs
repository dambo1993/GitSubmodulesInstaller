using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;

// XML editor online: https://www.tutorialspoint.com/online_xml_editor.htm
// XML C# tutorial: https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_13
namespace GitSubmodulesInstaller
{
    public partial class Form1 : Form
    {
        private void ui_load_xml_file(string path)
        {
            TreeNode NewXmlNode;

            XmlDocument XmlDoc = new XmlDocument();
            tv_XML.Nodes.Clear();

            try
            {
                XmlDoc.Load(path);
                int Count = XmlDoc.GetElementsByTagName("Submodule").Count;

                for (int i = 0; i < Count; i++)
                {
                    NewXmlNode = tv_XML.Nodes.Add(XmlDoc.GetElementsByTagName("Name").Item(i).InnerText);

                    NewXmlNode.Nodes.Add(
                        XmlDoc.GetElementsByTagName("URL").Item(i).InnerText);
                    NewXmlNode.Nodes.Add("Description: " +
                        XmlDoc.GetElementsByTagName("Description").Item(i).InnerText);
                    NewXmlNode.Nodes.Add(
                        XmlDoc.GetElementsByTagName("Path").Item(i).InnerText);
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string nodeTextSeparate(String text)
        {
            string[] array = text.Split(':');

            return array[1].Trim();
        }

        private string generate_single_submodule_command(TreeNode node)
        {
            string command = "git submodule add ";

            try
            {
                string url = node.Nodes[0].Text;

                string path = node.Nodes[2].Text;
                
                command += url + " " + path;
            }
            catch
            {

            }

            return command;
        }

        private string ui_generate_git_command()
        {
            string command = "";

            foreach(TreeNode node in tv_XML.Nodes)
            {
                Console.WriteLine(node.Text); // test - only main nodes
                if(node.Checked)
                {
                    command += generate_single_submodule_command(node) + Environment.NewLine;
                }
            }
            Console.WriteLine(command);

            return command;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tv_XML.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            tv_XML.CheckBoxes = true;

            tv_XML.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            tv_XML.DrawNode += xmlStructureTree_DrawNode;
        }

        // disable checkboxes for children nodes in TV
        private void xmlStructureTree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                e.Node.Checked = false;
            }
            e.DrawDefault = true;
        }

        private void b_load_file_Click(object sender, EventArgs e)
        {
            ui_load_xml_file("mySubmodules.xml");
        }

        protected void ClipboardSetText(string inTextToCopy)
        {
            var clipboardThread = new Thread(() => ClipBoardThreadWorker(inTextToCopy));
            clipboardThread.SetApartmentState(ApartmentState.STA);
            clipboardThread.IsBackground = false;
            clipboardThread.Start();
        }

        private void ClipBoardThreadWorker(string inTextToCopy)
        {
            System.Windows.Forms.Clipboard.SetText(inTextToCopy);
        }

        private void b_generate_command_Click(object sender, EventArgs e)
        {
            string command = ui_generate_git_command();
            if(command != "")
            {
                MessageBox.Show("Your submodules init command:" + Environment.NewLine +
                command +
                "Copied to Your clipboard"
                );

                // from https://stackoverflow.com/questions/930219/how-to-handle-blocked-clipboard-and-other-oddities
                Clipboard.SetDataObject(
                    command,     //text to store in clipboard
                    false,       //do not keep after our app exits
                    5,           //retry 5 times
                    200);        //200ms delay between retries
            }            
        }
    }
}
