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
    public partial class FormOrder : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly OrderLogic orderLogic = new OrderLogic();
        private readonly WorkerLogic workerLogic = new WorkerLogic();
        private readonly VehicleLogic vehicleLogic = new VehicleLogic();
        public FormOrder()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            List<Worker> list = workerLogic.ReadByIsFree(true);
            comboBoxWorkers.DisplayMember = "Name";
            comboBoxWorkers.ValueMember = "Id";
            comboBoxWorkers.DataSource = list;
            comboBoxWorkers.SelectedIndex = 0;
            dataGridViewCargos.Columns.Add("Name", "Название");
            dataGridViewCargos.Columns.Add("Weight", "Вес");
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxWorkerWeight.Text = vehicleLogic.ReadById(workerLogic.ReadById(comboBoxWorkers.SelectedIndex + 1).VehicleId)
                .Carrying.ToString();
        }

        private void buttonAddCargo_Click(object sender, EventArgs e)
        {
            if (!((maskedTextBoxCargo.Text == "" || maskedTextBoxCargo.Text.Equals(null)) && (maskedTextBoxWeight.Text == "" || maskedTextBoxWeight.Text.Equals(null))))
            {
                dataGridViewCargos.Rows.Add(new string[] { maskedTextBoxCargo.Text, maskedTextBoxWeight.Text });
                int AllWeight=0;
                for(int i =0;i<dataGridViewCargos.Rows.Count;i++)
                {
                    AllWeight += (int)dataGridViewCargos.Rows[i].Cells[1].Value;
                }
                maskedTextBoxAllWeight.Text = AllWeight.ToString();
            }
            else
            {
                MessageBox.Show("Заполните название и вес груза");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridViewCargos.Rows.Remove(dataGridViewCargos.SelectedRows[0]);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(maskedTextBoxAllWeight.Text)<=Int32.Parse(textBoxWorkerWeight.Text))
            {
                List<string> cargo=new List<string>();
                List<int> cargoWeight = new List<int>();
                for (int i = 0; i < dataGridViewCargos.Rows.Count; i++)
                {
                    cargo.Add((string)dataGridViewCargos.Rows[i].Cells[1].Value);
                }
                try
                {
                    orderLogic.CreateOrUpdate(new Order
                    {
                        Id = id,
                        CustomerName = maskedTextBoxName.Text,
                        CustomerSurName = maskedTextBoxSurName.Text,
                        Address = maskedTextBoxAddress.Text,
                        WorkerId = (int)comboBoxWorkers.SelectedValue,
                        startTime = DateTime.Now,
                    });
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
