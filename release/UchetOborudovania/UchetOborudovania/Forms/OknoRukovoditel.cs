using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetOborudovania
{
    public partial class OknoRukovoditel : Form
    {
        public DataSet ds = new DataSet();
        public OknoRukovoditel()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            OknoAvtorizacia oknoAvtorizacia = new OknoAvtorizacia();
            oknoAvtorizacia.Show();
            this.Close();
        }

        private void OknoRukovoditel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet2.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.uchetOborudovaniaDataSet2.Sotrudniki);
            labelFIO.Text = ds.Tables[0].Rows[0][1].ToString();
        }
    }
}
