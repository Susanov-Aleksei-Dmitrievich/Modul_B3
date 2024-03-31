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
    public partial class OknoAdministrator : Form
    {
        public DataSet ds = new DataSet();
        public OknoAdministrator()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            OknoAvtorizacia oknoAvtorizacia = new OknoAvtorizacia();
            oknoAvtorizacia.Show();
            this.Close();
        }

        private void OknoAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet1.IstoriaVhoda". При необходимости она может быть перемещена или удалена.
            this.istoriaVhodaTableAdapter.Fill(this.uchetOborudovaniaDataSet1.IstoriaVhoda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetOborudovaniaDataSet.Oborudovanie". При необходимости она может быть перемещена или удалена.
            this.oborudovanieTableAdapter.Fill(this.uchetOborudovaniaDataSet.Oborudovanie);

            labelFIO.Text = ds.Tables[0].Rows[0][1].ToString();

        }
    }
}
