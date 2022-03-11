using Controller.Logic;
using Controller.Models;
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
    }
}
