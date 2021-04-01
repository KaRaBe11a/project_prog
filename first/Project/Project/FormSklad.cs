using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormSklad : Form
    {
        public FormSklad()
        {
            InitializeComponent();
        }

       

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            List<Classes.Request> requests = new List<Classes.Request>();
            requests = WorkWithSql.Test.DownloadRequests();
            listBoxRequests.Items.Clear();
            comboBoxRequests.Items.Clear();
            for(int i = 0; i<requests.Count; i++)
            {
                listBoxRequests.Items.Add(requests[i].MakeString());
                comboBoxRequests.Items.Add(i.ToString() +";"+ requests[i].MakeString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string str = comboBoxRequests.Text;
            string[] words = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Classes.Request req = new Classes.Request(Convert.ToInt32(words[1]), Convert.ToInt32(words[2]), Convert.ToInt32(words[3]), Convert.ToInt32(words[4]));
            WorkWithSql.Test.AllowRequests(req);
        }
    }
}
