﻿namespace Meus_testes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAbrirArquivo = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ServerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ClientIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Verb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TimeSpend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "@C:\\";
            this.openFileDialog1.Title = "Abrir arquivo";
            // 
            // buttonAbrirArquivo
            // 
            this.buttonAbrirArquivo.Location = new System.Drawing.Point(12, 37);
            this.buttonAbrirArquivo.Name = "buttonAbrirArquivo";
            this.buttonAbrirArquivo.Size = new System.Drawing.Size(63, 22);
            this.buttonAbrirArquivo.TabIndex = 5;
            this.buttonAbrirArquivo.Text = "Abrir log";
            this.buttonAbrirArquivo.UseVisualStyleBackColor = true;
            this.buttonAbrirArquivo.Click += new System.EventHandler(this.buttonAbrirArquivo_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(81, 42);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(67, 13);
            this.labelFilePath.TabIndex = 7;
            this.labelFilePath.Text = "labelFilePath";
            this.labelFilePath.Visible = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 618);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 13);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "labelCount";
            this.labelCount.Visible = false;
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBox.DecimalPlaces = 2;
            this.timeBox.Location = new System.Drawing.Point(271, 12);
            this.timeBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(41, 20);
            this.timeBox.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(253, 13);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Tempo mínimo da duração do processo (segundos):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(954, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 36);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Datetime,
            this.Col_ServerIP,
            this.Col_ClientIP,
            this.Col_Port,
            this.Col_Verb,
            this.Col_Request,
            this.Col_Value,
            this.Col_TimeSpend});
            this.dataGridView1.Location = new System.Drawing.Point(15, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 538);
            this.dataGridView1.TabIndex = 16;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Width = 50;
            // 
            // Col_Datetime
            // 
            this.Col_Datetime.HeaderText = "Data-hora GWT";
            this.Col_Datetime.Name = "Col_Datetime";
            this.Col_Datetime.ReadOnly = true;
            this.Col_Datetime.Width = 120;
            // 
            // Col_ServerIP
            // 
            this.Col_ServerIP.HeaderText = "IP do servidor";
            this.Col_ServerIP.Name = "Col_ServerIP";
            this.Col_ServerIP.ReadOnly = true;
            this.Col_ServerIP.Width = 90;
            // 
            // Col_ClientIP
            // 
            this.Col_ClientIP.HeaderText = "IP do cliente";
            this.Col_ClientIP.Name = "Col_ClientIP";
            this.Col_ClientIP.ReadOnly = true;
            this.Col_ClientIP.Width = 90;
            // 
            // Col_Port
            // 
            this.Col_Port.HeaderText = "Porta";
            this.Col_Port.Name = "Col_Port";
            this.Col_Port.ReadOnly = true;
            this.Col_Port.Width = 60;
            // 
            // Col_Verb
            // 
            this.Col_Verb.HeaderText = "Verbo";
            this.Col_Verb.Name = "Col_Verb";
            this.Col_Verb.ReadOnly = true;
            this.Col_Verb.Width = 60;
            // 
            // Col_Request
            // 
            this.Col_Request.HeaderText = "Requisição";
            this.Col_Request.Name = "Col_Request";
            this.Col_Request.ReadOnly = true;
            this.Col_Request.Width = 380;
            // 
            // Col_Value
            // 
            this.Col_Value.HeaderText = "Valor";
            this.Col_Value.Name = "Col_Value";
            this.Col_Value.ReadOnly = true;
            // 
            // Col_TimeSpend
            // 
            this.Col_TimeSpend.HeaderText = "Duração do processo (segundos)";
            this.Col_TimeSpend.Name = "Col_TimeSpend";
            this.Col_TimeSpend.ReadOnly = true;
            this.Col_TimeSpend.Width = 90;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Enabled = false;
            this.button_Refresh.Location = new System.Drawing.Point(330, 10);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(59, 23);
            this.button_Refresh.TabIndex = 17;
            this.button_Refresh.Text = "Atualizar";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(1025, 613);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(59, 23);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(597, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aplicação:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1094, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.buttonAbrirArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vegeta";
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAbrirArquivo;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ServerIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ClientIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Verb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TimeSpend;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

