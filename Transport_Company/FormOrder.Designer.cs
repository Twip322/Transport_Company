namespace Transport_Company
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSurName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCargo = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddCargo = new System.Windows.Forms.Button();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.textBoxWorkerWeight = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewCargos = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxAddress = new System.Windows.Forms.MaskedTextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelAllWeight = new System.Windows.Forms.Label();
            this.maskedTextBoxAllWeight = new System.Windows.Forms.MaskedTextBox();
            this.labelWorkerWeight = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Location = new System.Drawing.Point(12, 24);
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(270, 20);
            this.maskedTextBoxName.TabIndex = 0;
            // 
            // maskedTextBoxSurName
            // 
            this.maskedTextBoxSurName.Location = new System.Drawing.Point(12, 71);
            this.maskedTextBoxSurName.Name = "maskedTextBoxSurName";
            this.maskedTextBoxSurName.Size = new System.Drawing.Size(270, 20);
            this.maskedTextBoxSurName.TabIndex = 1;
            // 
            // maskedTextBoxCargo
            // 
            this.maskedTextBoxCargo.Location = new System.Drawing.Point(12, 160);
            this.maskedTextBoxCargo.Name = "maskedTextBoxCargo";
            this.maskedTextBoxCargo.Size = new System.Drawing.Size(163, 20);
            this.maskedTextBoxCargo.TabIndex = 2;
            // 
            // buttonAddCargo
            // 
            this.buttonAddCargo.Location = new System.Drawing.Point(288, 158);
            this.buttonAddCargo.Name = "buttonAddCargo";
            this.buttonAddCargo.Size = new System.Drawing.Size(132, 23);
            this.buttonAddCargo.TabIndex = 3;
            this.buttonAddCargo.Text = "Добавить";
            this.buttonAddCargo.UseVisualStyleBackColor = true;
            this.buttonAddCargo.Click += new System.EventHandler(this.buttonAddCargo_Click);
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(15, 366);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(243, 21);
            this.comboBoxWorkers.TabIndex = 5;
            this.comboBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkers_SelectedIndexChanged);
            // 
            // textBoxWorkerWeight
            // 
            this.textBoxWorkerWeight.Location = new System.Drawing.Point(288, 366);
            this.textBoxWorkerWeight.Name = "textBoxWorkerWeight";
            this.textBoxWorkerWeight.Size = new System.Drawing.Size(140, 20);
            this.textBoxWorkerWeight.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 55);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Груз";
            // 
            // maskedTextBoxWeight
            // 
            this.maskedTextBoxWeight.Location = new System.Drawing.Point(181, 160);
            this.maskedTextBoxWeight.Name = "maskedTextBoxWeight";
            this.maskedTextBoxWeight.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBoxWeight.TabIndex = 10;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(12, 393);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(160, 23);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(268, 393);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewCargos
            // 
            this.dataGridViewCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargos.Location = new System.Drawing.Point(12, 187);
            this.dataGridViewCargos.Name = "dataGridViewCargos";
            this.dataGridViewCargos.Size = new System.Drawing.Size(270, 150);
            this.dataGridViewCargos.TabIndex = 14;
            // 
            // maskedTextBoxAddress
            // 
            this.maskedTextBoxAddress.Location = new System.Drawing.Point(12, 121);
            this.maskedTextBoxAddress.Name = "maskedTextBoxAddress";
            this.maskedTextBoxAddress.Size = new System.Drawing.Size(270, 20);
            this.maskedTextBoxAddress.TabIndex = 15;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 105);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Адрес";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(178, 144);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(98, 13);
            this.labelWeight.TabIndex = 17;
            this.labelWeight.Text = "Вес(Килограммы)";
            // 
            // labelAllWeight
            // 
            this.labelAllWeight.AutoSize = true;
            this.labelAllWeight.Location = new System.Drawing.Point(285, 301);
            this.labelAllWeight.Name = "labelAllWeight";
            this.labelAllWeight.Size = new System.Drawing.Size(135, 13);
            this.labelAllWeight.TabIndex = 19;
            this.labelAllWeight.Text = "Общий вес(Килограммы)";
            // 
            // maskedTextBoxAllWeight
            // 
            this.maskedTextBoxAllWeight.Location = new System.Drawing.Point(288, 317);
            this.maskedTextBoxAllWeight.Name = "maskedTextBoxAllWeight";
            this.maskedTextBoxAllWeight.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxAllWeight.TabIndex = 18;
            // 
            // labelWorkerWeight
            // 
            this.labelWorkerWeight.AutoSize = true;
            this.labelWorkerWeight.Location = new System.Drawing.Point(285, 350);
            this.labelWorkerWeight.Name = "labelWorkerWeight";
            this.labelWorkerWeight.Size = new System.Drawing.Size(104, 13);
            this.labelWorkerWeight.TabIndex = 20;
            this.labelWorkerWeight.Text = "Грузоподъёмность";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Location = new System.Drawing.Point(12, 350);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(48, 13);
            this.labelMachine.TabIndex = 21;
            this.labelMachine.Text = "Машина";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 428);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.labelWorkerWeight);
            this.Controls.Add(this.labelAllWeight);
            this.Controls.Add(this.maskedTextBoxAllWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.maskedTextBoxAddress);
            this.Controls.Add(this.dataGridViewCargos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.maskedTextBoxWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxWorkerWeight);
            this.Controls.Add(this.comboBoxWorkers);
            this.Controls.Add(this.buttonAddCargo);
            this.Controls.Add(this.maskedTextBoxCargo);
            this.Controls.Add(this.maskedTextBoxSurName);
            this.Controls.Add(this.maskedTextBoxName);
            this.Name = "FormOrder";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSurName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCargo;
        private System.Windows.Forms.Button buttonAddCargo;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.TextBox textBoxWorkerWeight;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeight;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewCargos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelAllWeight;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAllWeight;
        private System.Windows.Forms.Label labelWorkerWeight;
        private System.Windows.Forms.Label labelMachine;
    }
}