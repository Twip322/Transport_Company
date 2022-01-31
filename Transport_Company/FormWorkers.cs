using Controller.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Company
{
    public partial class FormWorkers : Form
    {

        private readonly WorkerLogic workerLogic= new WorkerLogic();
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddWorker formAddWorker = new FormAddWorker(0);
            formAddWorker.ShowDialog();
            if (formAddWorker.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }
        private void loadData()
        {
            try
            {
                var list = workerLogic.Read(null);
                if (list != null)
                {
                    dataGridViewWorkers.DataSource = list;
                    dataGridViewWorkers.Columns[0].Visible = false;
                    dataGridViewWorkers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewWorkers.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }


        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormAddWorker formAddWorker = new FormAddWorker(dataGridViewWorkers.SelectedRows[0].Index);
            formAddWorker.ShowDialog();
            if (formAddWorker.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }
    }
}
