using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;

// XML editor online: https://www.tutorialspoint.com/online_xml_editor.htm
// XML C# tutorial: https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_13

namespace GitSubmodulesInstaller
{
    public partial class Form1 : Form
    {

        XmlDocument XmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void b_load_file_Click(object sender, EventArgs e)
        {
            TreeNode NewXmlNode;

            XmlDocument XmlDoc = new XmlDocument();
            tv_XML.Nodes.Clear();

            try
            {
                XmlDoc.Load("mySubmodules.xml");
                int Count = XmlDoc.GetElementsByTagName("Submodule").Count;

                for (int i = 0; i < Count; i++)
                {
                    NewXmlNode = tv_XML.Nodes.Add(XmlDoc.GetElementsByTagName("Name").Item(i).InnerText);

                    NewXmlNode.Nodes.Add("URL: " +
                        XmlDoc.GetElementsByTagName("URL").Item(i).InnerText);
                    NewXmlNode.Nodes.Add("Description: " +
                        XmlDoc.GetElementsByTagName("Description").Item(i).InnerText);
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
