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
        private readonly ChangeStatusLogic changeStatusLogic = new ChangeStatusLogic();

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
                VehicleModel model = new VehicleModel();
                model.Name = vehicle.Item1;
                model.Speed = vehicle.Item2;
                model.Carrying = vehicle.Item3;
                vehicleLogic.CreateOrUpdate(model);
            }
            txtWorkers.Text = workerLogic.Read(null).Count.ToString();
            var list = orderLogic.Read(null);
            var listTest = orderLogic.Read(null);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddOrd_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtWorkers.Text) > 0)
            {
                FormOrder form = new FormOrder();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        private void btnUpdOrd_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnInDelivery_Click(object sender, EventArgs e)
        {
            int? id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            changeStatusLogic.DeliveringStarted(new ChangeStatusBind { OrderId = id });
            loadData();
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

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            int? id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            changeStatusLogic.TakeOrderInWork(new ChangeStatusBind { OrderId = id });
            loadData();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            int? id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            changeStatusLogic.DeliveringEnded(new ChangeStatusBind { OrderId = id });
            loadData();
        }

        private void btnPayed_Click(object sender, EventArgs e)
        {
            int? id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            changeStatusLogic.DeliveryPayed(new ChangeStatusBind { OrderId = id });
            loadData();
        }

        private void btnCheckCargo_Click(object sender, EventArgs e)
        {
            int? id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FormCheckCargo form = new FormCheckCargo(id);
            form.ShowDialog();
        }
    }
}
