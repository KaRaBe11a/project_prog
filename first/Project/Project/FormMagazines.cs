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
    public partial class FormMagazines : Form
    {
        public FormMagazines()
        {
            InitializeComponent();
        }

        private void FormMagazines_Load(object sender, EventArgs e)
        {
            List<Classes.Magazine> magazines = new List<Classes.Magazine>();
            magazines = WorkWithSql.Test.DownloadMagazines();
            for (int i = 0; i<magazines.Count; i++)
            {
                comboBoxMagazines.Items.Add(magazines[i].magName + ";" + magazines[i].magId.ToString());
            }
            List<Classes.Product> products = new List<Classes.Product>();
            products = WorkWithSql.Test.DownloadProducts();
            for(int i = 0; i<products.Count; i++)
            {
                comboBoxProducts.Items.Add(products[i].MakeString());
            }

        }

        private void comboBoxMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = comboBoxMagazines.Text;
            
            string[] strs = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Classes.Prod> prod = new List<Classes.Prod>();
            prod = WorkWithSql.Test.DownloadProdFromMagazine(Convert.ToInt32(strs[1]));

            List<Classes.Request> requests = new List<Classes.Request>();
            requests = WorkWithSql.Test.DownloadTransits(Convert.ToInt32(strs[1]));
            for(int i = 0; i<requests.Count; i++)
            {
                comboBoxReceiveRequest.Items.Add(requests[i].MakeString());
            }
            for(int i = 0; i<prod.Count; i++)
            {
                Classes.Product product;
                product = WorkWithSql.Test.ConvertProdInProduct(prod[i].articule);
                listBoxProducts.Items.Add(product.MakeString());
            }
        }

        private void buttonMakeRequest_Click(object sender, EventArgs e)
        {
            string strMag = comboBoxMagazines.Text;
            string[] strsMag = strMag.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string strProd = comboBoxProducts.Text;
            string[] strsProd = strProd.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            WorkWithSql.Test.MakeRequest(Convert.ToInt32(strsMag[1]), Convert.ToInt32(strsProd[1]), Convert.ToInt32(textBoxCount.Text));

        }

        private void buttonReceiveRequest_Click(object sender, EventArgs e)
        {
            string str = comboBoxReceiveRequest.Text;
            string[] strs = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Classes.Request request = new Classes.Request(strs[0], strs[1], strs[2], strs[3]);
            WorkWithSql.Test.ReceaveTransit(request);
        }
    }
}
