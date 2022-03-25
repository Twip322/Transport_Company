﻿using Controller.Logic;
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
        private readonly WorkerLogic workerLogic = new WorkerLogic();
        private readonly VehicleLogic vehicleLogic = new VehicleLogic();
        private int CargoWeight = 0;
        public FormOrder()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            List<Worker> list = workerLogic.Read(null);
            comboBoxWorkers.DisplayMember = "Name";
            comboBoxWorkers.ValueMember = "Id";
            comboBoxWorkers.DataSource = list;
            comboBoxWorkers.SelectedIndex = 0;

        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxWorkerWeight.Text = vehicleLogic.ReadById(workerLogic.ReadById(comboBoxWorkers.SelectedIndex+1).VehicleId)
                .Carrying.ToString();
        }

        private void buttonAddCargo_Click(object sender, EventArgs e)
        {
            if (!((maskedTextBoxCargo.Text == "" || maskedTextBoxCargo.Text.Equals(null)) && (maskedTextBoxWeight.Text == "" || maskedTextBoxWeight.Text.Equals(null))))
            {
                if(CargoWeight+Int32.Parse(maskedTextBoxWeight.Text)< Int32.Parse(textBoxWorkerWeight.Text))
                {
                    listBoxCargos.Items.Add(maskedTextBoxCargo.Text);
                    CargoWeight += Int32.Parse(maskedTextBoxWeight.Text);
                }
                else
                {
                    MessageBox.Show("Вес груза превышает грузоподъёмность");
                }
            }
            else
            {
                MessageBox.Show("Заполните название и вес груза");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxCargos.Items.RemoveAt(listBoxCargos.SelectedIndex);
        }

    }
}
