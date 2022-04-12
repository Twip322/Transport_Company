using Controller.Logic;
using Controller.Models;
using Models.Enums;
using Models.Models;
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
        private readonly CargoLogic cargoLogic = new CargoLogic();
        private readonly OrderCargoLogic orderCargoLogic = new OrderCargoLogic();

        private Dictionary<int?, (string, int?)> orderCargoses=new Dictionary<int?, (string, int?)>();


        public FormOrder()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            List<WorkerModel> list = workerLogic.ReadByIsFree();
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
            
                textBoxWorkerWeight.Text = vehicleLogic.ReadById(workerLogic.ReadById((int)comboBoxWorkers.SelectedValue).VehicleId)
                .Carrying.ToString();
            
        }

        private void buttonAddCargo_Click(object sender, EventArgs e)
        {
            if (!((maskedTextBoxCargo.Text == "" || maskedTextBoxCargo.Text.Equals(null)) && (maskedTextBoxWeight.Text == "" || maskedTextBoxWeight.Text.Equals(null))))
            {
                dataGridViewCargos.Rows.Add(new string[] { maskedTextBoxCargo.Text, maskedTextBoxWeight.Text });
                int AllWeight=0;
                for(int i =0;i<dataGridViewCargos.Rows.Count-1;i++)
                {
                    AllWeight += Int32.Parse(dataGridViewCargos.Rows[i].Cells[1].Value.ToString());
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
                try
                {
                    List<Cargo> cargoses = new List<Cargo>(); 
                    for (int i = 0; i < dataGridViewCargos.Rows.Count - 1; i++)
                    {
                        cargoses.Add(new Cargo { 
                            Name=dataGridViewCargos.Rows[i].Cells[0].Value.ToString(),
                            Weight=Int32.Parse(dataGridViewCargos.Rows[i].Cells[1].Value.ToString()),
                        });
                    }
                    Order orderModel = new Order {
                        Id = id,
                        CustomerName = maskedTextBoxName.Text,
                        CustomerSurName = maskedTextBoxSurName.Text,
                        Address = maskedTextBoxAddress.Text,
                        WorkerId = (int)comboBoxWorkers.SelectedValue,
                        startTime = DateTime.Now,
                        orderEnum = OrderEnum.Заказ_оформлен,
                    };
                    foreach(Cargo cargo in cargoses)
                    {
                        cargo.Order = orderModel;
                    }
                    orderModel.orderCargo = cargoses;
                    orderCargoLogic.Create(orderModel,cargoses);
                    var worker=workerLogic.ReadById(orderModel.WorkerId);
                    workerLogic.CreateOrUpdate(new WorkerModel
                    {
                        Id = worker.Id,
                        Name = worker.Name,
                        Surname = worker.Surname,
                        IsFree = false,
                        VehicleId = worker.VehicleId
                    });
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Данные транспорт не сможет перевезти груз");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
