using Controller.Logic;
using Controller.Models;
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
        private readonly VehicleLogic vehicleLogic = new VehicleLogic();
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
                    dataGridViewWorkers.Columns.Clear();
                    dataGridViewWorkers.DataSource = list;
                    dataGridViewWorkers.Columns[0].Visible = false;
                    dataGridViewWorkers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewWorkers.Columns[3].Visible = false;
                    dataGridViewWorkers.MultiSelect = false;
                    dataGridViewWorkers.Columns.Add("VehicleName","VehicleName");
                }
               
                foreach (DataGridViewRow column in dataGridViewWorkers.Rows)
                {
                    column.Cells[4].Value = vehicleLogic.ReadById(Int32.Parse(column.Cells[3].Value.ToString())).Name;
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
            FormAddWorker formAddWorker = new FormAddWorker((int)dataGridViewWorkers.SelectedRows[0].Cells[0].Value);
            formAddWorker.ShowDialog();
            if (formAddWorker.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkers.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewWorkers.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        workerLogic.Delete(new Worker { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    loadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
