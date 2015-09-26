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
using System.Xml;

namespace Silver.Option
{
    public partial class OptionDataBase : Form
    {
        private XmlTextWriter write;

        private XmlTextReader read;

        private const string XMLPath = @".\ConfigXML.xml"; 

        public OptionDataBase()
        {
            InitializeComponent();
            getXMLExecute();
        }

        private void getXMLExecute()
        {
            if (File.Exists(XMLPath))
            {
                getConnectionToXML();
            }
            else
            {
                createXMLFile();
            }
        }

        private void getConnectionToXML()
        {
            read = new XmlTextReader();
        }

        private void createXMLFile()
        {
            write = new XmlTextWriter(XMLPath, Encoding.UTF8);
        }



     
    }
}
