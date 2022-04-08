using Controller.Logic;
using Controller.Models;
using Models.Models;
using Models.VehiclesList;
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
    public partial class MainForm : Form
    {
        private readonly VehicleLogic vehicleLogic = new VehicleLogic();
        private readonly WorkerLogic workerLogic = new WorkerLogic();
        private readonly OrderLogic orderLogic = new OrderLogic();
        private readonly CargoLogic cargoLogic = new CargoLogic();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            FormWorkers formWorkers = new FormWorkers();
            formWorkers.Show();
        }
        private void loadData()
        {
            Vehicles veh = new Vehicles();
            foreach (var vehicle in veh.getVehicle.Values.ToList())
            {
                Vehicle model = new Vehicle();
                model.Name = vehicle.Item1;
                model.Speed = vehicle.Item2;
                model.Carrying = vehicle.Item3;
                vehicleLogic.CreateOrUpdate(model);
            }
            txtWorkers.Text = workerLogic.Read(null).Count.ToString();
            var list = orderLogic.Read(null);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(txtWorkers.Text)>0)
            {
                FormOrder form = new FormOrder();
                form.Show();
            }
        }

        private void btnUpdOrd_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnOrdReady_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            orderLogic.CreateOrUpdate(new OrderModel { Id=id,orderEnum=Models.Enums.OrderEnum.Доставлен});
        }

        private void btnDelOrd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        orderLogic.Delete(new OrderModel { Id = id });
                        cargoLogic.Delete();
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
    }
}
