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

        private Dictionary<int?, (string, int?)> orderCargoses=new Dictionary<int?, (string, int?)>();


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
                    int?[] ids=new int?[dataGridViewCargos.Rows.Count - 1];
                    for (int i = 0; i < dataGridViewCargos.Rows.Count - 1; i++)
                    {
                        cargoLogic.CreateOrUpdate(new CargoModel
                        {
                            Name = (string)dataGridViewCargos.Rows[i].Cells[0].Value,
                            Weight = Int32.Parse(dataGridViewCargos.Rows[i].Cells[1].Value.ToString())
                        });
                        ids[i]=(cargoLogic.ReadLast().Id);
                    }
                    foreach(int? id in ids)
                    {
                        var cargo = cargoLogic.ReadById(id);
                        orderCargoses.Add(id, (cargo.Name, cargo.Weight));
                    }

                    orderLogic.CreateOrUpdate(new OrderModel
                    {
                        Id=id,
                        CustomerName = maskedTextBoxName.Text,
                        CustomerSurName = maskedTextBoxSurName.Text,
                        Address = maskedTextBoxAddress.Text,
                        WorkerId = (int)comboBoxWorkers.SelectedValue,
                        startTime = DateTime.Now,
                        orderEnum=OrderEnum.Заказ_оформлен,
                        orderCargo=orderCargoses
                    });
                    

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
    }
}
