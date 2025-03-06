namespace DriverManager__OOAD_1_
{
    partial class Form1
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
            this.listBoxTransport = new System.Windows.Forms.ListBox();
            this.listBoxDrivers = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAddTransport = new System.Windows.Forms.Label();
            this.labelAddDriver = new System.Windows.Forms.Label();
            this.textBoxTransportName = new System.Windows.Forms.TextBox();
            this.comboBoxTransportType = new System.Windows.Forms.ComboBox();
            this.labelTransportName = new System.Windows.Forms.Label();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.buttonAddTransport = new System.Windows.Forms.Button();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.labelDriverLicenses = new System.Windows.Forms.Label();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.checkedListBoxDriverLicenses = new System.Windows.Forms.CheckedListBox();
            this.labelTransportSize = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewPairs = new System.Windows.Forms.ListView();
            this.labelPairs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTransport
            // 
            this.listBoxTransport.FormattingEnabled = true;
            this.listBoxTransport.Location = new System.Drawing.Point(12, 310);
            this.listBoxTransport.Name = "listBoxTransport";
            this.listBoxTransport.Size = new System.Drawing.Size(152, 238);
            this.listBoxTransport.TabIndex = 1;
            // 
            // listBoxDrivers
            // 
            this.listBoxDrivers.FormattingEnabled = true;
            this.listBoxDrivers.Location = new System.Drawing.Point(462, 310);
            this.listBoxDrivers.Name = "listBoxDrivers";
            this.listBoxDrivers.Size = new System.Drawing.Size(152, 238);
            this.listBoxDrivers.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Location = new System.Drawing.Point(139, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(374, 25);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Панель управления транспортом";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAddTransport
            // 
            this.labelAddTransport.AutoSize = true;
            this.labelAddTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddTransport.Location = new System.Drawing.Point(9, 68);
            this.labelAddTransport.Name = "labelAddTransport";
            this.labelAddTransport.Size = new System.Drawing.Size(170, 18);
            this.labelAddTransport.TabIndex = 4;
            this.labelAddTransport.Text = "Добавить транспорт";
            // 
            // labelAddDriver
            // 
            this.labelAddDriver.AutoSize = true;
            this.labelAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddDriver.Location = new System.Drawing.Point(449, 69);
            this.labelAddDriver.Name = "labelAddDriver";
            this.labelAddDriver.Size = new System.Drawing.Size(164, 18);
            this.labelAddDriver.TabIndex = 5;
            this.labelAddDriver.Text = "Добавить водителя";
            // 
            // textBoxTransportName
            // 
            this.textBoxTransportName.Location = new System.Drawing.Point(12, 116);
            this.textBoxTransportName.Name = "textBoxTransportName";
            this.textBoxTransportName.Size = new System.Drawing.Size(152, 20);
            this.textBoxTransportName.TabIndex = 6;
            // 
            // comboBoxTransportType
            // 
            this.comboBoxTransportType.FormattingEnabled = true;
            this.comboBoxTransportType.Location = new System.Drawing.Point(13, 160);
            this.comboBoxTransportType.Name = "comboBoxTransportType";
            this.comboBoxTransportType.Size = new System.Drawing.Size(152, 21);
            this.comboBoxTransportType.TabIndex = 7;
            // 
            // labelTransportName
            // 
            this.labelTransportName.AutoSize = true;
            this.labelTransportName.Location = new System.Drawing.Point(46, 100);
            this.labelTransportName.Name = "labelTransportName";
            this.labelTransportName.Size = new System.Drawing.Size(83, 13);
            this.labelTransportName.TabIndex = 8;
            this.labelTransportName.Text = "Наименование";
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Location = new System.Drawing.Point(44, 144);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(87, 13);
            this.labelTransportType.TabIndex = 9;
            this.labelTransportType.Text = "Тип транспорта";
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTransport.Location = new System.Drawing.Point(12, 239);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Size = new System.Drawing.Size(152, 48);
            this.buttonAddTransport.TabIndex = 10;
            this.buttonAddTransport.Text = "Добавить";
            this.buttonAddTransport.UseVisualStyleBackColor = false;
            this.buttonAddTransport.Click += new System.EventHandler(this.buttonAddTransport_Click);
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDriver.Location = new System.Drawing.Point(462, 239);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(153, 48);
            this.buttonAddDriver.TabIndex = 15;
            this.buttonAddDriver.Text = "Добавить";
            this.buttonAddDriver.UseVisualStyleBackColor = false;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // labelDriverLicenses
            // 
            this.labelDriverLicenses.AutoSize = true;
            this.labelDriverLicenses.Location = new System.Drawing.Point(495, 153);
            this.labelDriverLicenses.Name = "labelDriverLicenses";
            this.labelDriverLicenses.Size = new System.Drawing.Size(87, 13);
            this.labelDriverLicenses.TabIndex = 14;
            this.labelDriverLicenses.Text = "Категории прав";
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Location = new System.Drawing.Point(497, 101);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(83, 13);
            this.labelDriverName.TabIndex = 13;
            this.labelDriverName.Text = "Наименование";
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(461, 117);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(152, 20);
            this.textBoxDriverName.TabIndex = 11;
            // 
            // checkedListBoxDriverLicenses
            // 
            this.checkedListBoxDriverLicenses.FormattingEnabled = true;
            this.checkedListBoxDriverLicenses.Location = new System.Drawing.Point(462, 172);
            this.checkedListBoxDriverLicenses.Name = "checkedListBoxDriverLicenses";
            this.checkedListBoxDriverLicenses.Size = new System.Drawing.Size(153, 49);
            this.checkedListBoxDriverLicenses.TabIndex = 16;
            // 
            // labelTransportSize
            // 
            this.labelTransportSize.AutoSize = true;
            this.labelTransportSize.Location = new System.Drawing.Point(46, 193);
            this.labelTransportSize.Name = "labelTransportSize";
            this.labelTransportSize.Size = new System.Drawing.Size(76, 13);
            this.labelTransportSize.TabIndex = 18;
            this.labelTransportSize.Text = "Вместимость";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 17;
            // 
            // listViewPairs
            // 
            this.listViewPairs.HideSelection = false;
            this.listViewPairs.Location = new System.Drawing.Point(187, 310);
            this.listViewPairs.Name = "listViewPairs";
            this.listViewPairs.Size = new System.Drawing.Size(254, 238);
            this.listViewPairs.TabIndex = 19;
            this.listViewPairs.UseCompatibleStateImageBehavior = false;
            // 
            // labelPairs
            // 
            this.labelPairs.AutoSize = true;
            this.labelPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPairs.Location = new System.Drawing.Point(206, 269);
            this.labelPairs.Name = "labelPairs";
            this.labelPairs.Size = new System.Drawing.Size(217, 18);
            this.labelPairs.TabIndex = 20;
            this.labelPairs.Text = "Распределение водителей";
            this.labelPairs.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 564);
            this.Controls.Add(this.labelPairs);
            this.Controls.Add(this.listViewPairs);
            this.Controls.Add(this.labelTransportSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBoxDriverLicenses);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.labelDriverLicenses);
            this.Controls.Add(this.labelDriverName);
            this.Controls.Add(this.textBoxDriverName);
            this.Controls.Add(this.buttonAddTransport);
            this.Controls.Add(this.labelTransportType);
            this.Controls.Add(this.labelTransportName);
            this.Controls.Add(this.comboBoxTransportType);
            this.Controls.Add(this.textBoxTransportName);
            this.Controls.Add(this.labelAddDriver);
            this.Controls.Add(this.labelAddTransport);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxDrivers);
            this.Controls.Add(this.listBoxTransport);
            this.Name = "Form1";
            this.Text = "TransportPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTransport;
        private System.Windows.Forms.ListBox listBoxDrivers;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAddTransport;
        private System.Windows.Forms.Label labelAddDriver;
        private System.Windows.Forms.TextBox textBoxTransportName;
        private System.Windows.Forms.ComboBox comboBoxTransportType;
        private System.Windows.Forms.Label labelTransportName;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.Button buttonAddTransport;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Label labelDriverLicenses;
        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.CheckedListBox checkedListBoxDriverLicenses;
        private System.Windows.Forms.Label labelTransportSize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listViewPairs;
        private System.Windows.Forms.Label labelPairs;
    }
}

