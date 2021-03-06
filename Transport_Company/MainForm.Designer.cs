namespace Transport_Company
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrd = new System.Windows.Forms.Button();
            this.btnUpdOrd = new System.Windows.Forms.Button();
            this.btnInDelivery = new System.Windows.Forms.Button();
            this.btnDelOrd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkers = new System.Windows.Forms.TextBox();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.btnPayed = new System.Windows.Forms.Button();
            this.btnCheckCargo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(81, 20);
            this.help.Text = "toolTipHelp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Актуальные грузоперевозки";
            // 
            // btnAddOrd
            // 
            this.btnAddOrd.Location = new System.Drawing.Point(742, 67);
            this.btnAddOrd.Name = "btnAddOrd";
            this.btnAddOrd.Size = new System.Drawing.Size(202, 23);
            this.btnAddOrd.TabIndex = 3;
            this.btnAddOrd.Text = "Добавить новый заказ";
            this.btnAddOrd.UseVisualStyleBackColor = true;
            this.btnAddOrd.Click += new System.EventHandler(this.btnAddOrd_Click);
            // 
            // btnUpdOrd
            // 
            this.btnUpdOrd.Location = new System.Drawing.Point(742, 96);
            this.btnUpdOrd.Name = "btnUpdOrd";
            this.btnUpdOrd.Size = new System.Drawing.Size(202, 23);
            this.btnUpdOrd.TabIndex = 4;
            this.btnUpdOrd.Text = "Обновить заказы";
            this.btnUpdOrd.UseVisualStyleBackColor = true;
            this.btnUpdOrd.Click += new System.EventHandler(this.btnUpdOrd_Click);
            // 
            // btnInDelivery
            // 
            this.btnInDelivery.Location = new System.Drawing.Point(742, 266);
            this.btnInDelivery.Name = "btnInDelivery";
            this.btnInDelivery.Size = new System.Drawing.Size(202, 23);
            this.btnInDelivery.TabIndex = 5;
            this.btnInDelivery.Text = "Заказ в доставке";
            this.btnInDelivery.UseVisualStyleBackColor = true;
            this.btnInDelivery.Click += new System.EventHandler(this.btnInDelivery_Click);
            // 
            // btnDelOrd
            // 
            this.btnDelOrd.Location = new System.Drawing.Point(742, 125);
            this.btnDelOrd.Name = "btnDelOrd";
            this.btnDelOrd.Size = new System.Drawing.Size(202, 23);
            this.btnDelOrd.TabIndex = 6;
            this.btnDelOrd.Text = "Удалить заказ";
            this.btnDelOrd.UseVisualStyleBackColor = true;
            this.btnDelOrd.Click += new System.EventHandler(this.btnDelOrd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Свободные работники";
            // 
            // txtWorkers
            // 
            this.txtWorkers.Location = new System.Drawing.Point(461, 37);
            this.txtWorkers.Name = "txtWorkers";
            this.txtWorkers.ReadOnly = true;
            this.txtWorkers.Size = new System.Drawing.Size(100, 20);
            this.txtWorkers.TabIndex = 8;
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(567, 35);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(103, 23);
            this.btnWorker.TabIndex = 9;
            this.btnWorker.Text = "Добавить работника";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnAccepted
            // 
            this.btnAccepted.Location = new System.Drawing.Point(742, 237);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(202, 23);
            this.btnAccepted.TabIndex = 10;
            this.btnAccepted.Text = "Заказ принят";
            this.btnAccepted.UseVisualStyleBackColor = true;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // btnDelivered
            // 
            this.btnDelivered.Location = new System.Drawing.Point(742, 295);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(202, 23);
            this.btnDelivered.TabIndex = 11;
            this.btnDelivered.Text = "Заказ доставлен";
            this.btnDelivered.UseVisualStyleBackColor = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnPayed
            // 
            this.btnPayed.Location = new System.Drawing.Point(742, 324);
            this.btnPayed.Name = "btnPayed";
            this.btnPayed.Size = new System.Drawing.Size(202, 23);
            this.btnPayed.TabIndex = 12;
            this.btnPayed.Text = "Заказ Оплачен";
            this.btnPayed.UseVisualStyleBackColor = true;
            this.btnPayed.Click += new System.EventHandler(this.btnPayed_Click);
            // 
            // btnCheckCargo
            // 
            this.btnCheckCargo.Location = new System.Drawing.Point(742, 180);
            this.btnCheckCargo.Name = "btnCheckCargo";
            this.btnCheckCargo.Size = new System.Drawing.Size(202, 23);
            this.btnCheckCargo.TabIndex = 13;
            this.btnCheckCargo.Text = "Посмотреть груз";
            this.btnCheckCargo.UseVisualStyleBackColor = true;
            this.btnCheckCargo.Click += new System.EventHandler(this.btnCheckCargo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.btnCheckCargo);
            this.Controls.Add(this.btnPayed);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnAccepted);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.txtWorkers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelOrd);
            this.Controls.Add(this.btnInDelivery);
            this.Controls.Add(this.btnUpdOrd);
            this.Controls.Add(this.btnAddOrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrd;
        private System.Windows.Forms.Button btnUpdOrd;
        private System.Windows.Forms.Button btnInDelivery;
        private System.Windows.Forms.Button btnDelOrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkers;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnAccepted;
        private System.Windows.Forms.Button btnDelivered;
        private System.Windows.Forms.Button btnPayed;
        private System.Windows.Forms.Button btnCheckCargo;
    }
}

