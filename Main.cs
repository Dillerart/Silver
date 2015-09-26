using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Silver.Option;

namespace Silver
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            informer(true);
        }

        private void informer(bool info)
        {
           if(info){
               textBoxInform.ForeColor = System.Drawing.Color.Green;
               textBoxInform.Text = "Состояние подключения к БД: Покдлючено.";
               treeView.Enabled = true;
           }
           else
           {
               textBoxInform.ForeColor = System.Drawing.Color.Red;
               textBoxInform.Text = "Состояние подключения к БД: Отсутствует.";
               treeView.Enabled = false;
           }
           
        }

        private void настройкиСоединияСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new OptionDataBase().ShowDialog();
        }

    }
}
