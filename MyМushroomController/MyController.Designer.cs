namespace MyМushroomController
{
    partial class MyController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyController));
            this.ArdunioComTX = new System.Windows.Forms.Label();
            this.MyComPortsCB = new System.Windows.Forms.ComboBox();
            this.ConformComBT = new System.Windows.Forms.Button();
            this.IndicatorCOMBT = new System.Windows.Forms.Button();
            this.COMBaudRateCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RellatCoonect1TB = new System.Windows.Forms.Button();
            this.RelayList1CB = new System.Windows.Forms.ComboBox();
            this.IndicatorRELAY1BT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestRelay1BT = new System.Windows.Forms.Button();
            this.RelayDisconnect1TB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestRelay3BT = new System.Windows.Forms.Button();
            this.TestRelay2BT = new System.Windows.Forms.Button();
            this.RelayList3CB = new System.Windows.Forms.ComboBox();
            this.RelayDisconnect3TB = new System.Windows.Forms.Button();
            this.RelayList2CB = new System.Windows.Forms.ComboBox();
            this.RelayDisconnect2TB = new System.Windows.Forms.Button();
            this.RellatCoonect3TB = new System.Windows.Forms.Button();
            this.RellatCoonect2TB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IndicatorRELAY3BT = new System.Windows.Forms.Button();
            this.IndicatorRELAY2BT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArdunioComTX
            // 
            this.ArdunioComTX.AutoSize = true;
            this.ArdunioComTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArdunioComTX.Location = new System.Drawing.Point(15, 41);
            this.ArdunioComTX.Name = "ArdunioComTX";
            this.ArdunioComTX.Size = new System.Drawing.Size(180, 24);
            this.ArdunioComTX.TabIndex = 1;
            this.ArdunioComTX.Text = "Arduino COM Port";
            // 
            // MyComPortsCB
            // 
            this.MyComPortsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MyComPortsCB.FormattingEnabled = true;
            this.MyComPortsCB.Location = new System.Drawing.Point(211, 43);
            this.MyComPortsCB.Name = "MyComPortsCB";
            this.MyComPortsCB.Size = new System.Drawing.Size(121, 26);
            this.MyComPortsCB.Sorted = true;
            this.MyComPortsCB.TabIndex = 2;
            // 
            // ConformComBT
            // 
            this.ConformComBT.BackColor = System.Drawing.Color.FloralWhite;
            this.ConformComBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConformComBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConformComBT.Location = new System.Drawing.Point(491, 37);
            this.ConformComBT.Name = "ConformComBT";
            this.ConformComBT.Size = new System.Drawing.Size(301, 33);
            this.ConformComBT.TabIndex = 3;
            this.ConformComBT.Text = "Conform COM Port";
            this.ConformComBT.UseVisualStyleBackColor = false;
            this.ConformComBT.Click += new System.EventHandler(this.ConformComBT_Click);
            // 
            // IndicatorCOMBT
            // 
            this.IndicatorCOMBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IndicatorCOMBT.Enabled = false;
            this.IndicatorCOMBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IndicatorCOMBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndicatorCOMBT.Location = new System.Drawing.Point(466, 37);
            this.IndicatorCOMBT.Name = "IndicatorCOMBT";
            this.IndicatorCOMBT.Size = new System.Drawing.Size(19, 33);
            this.IndicatorCOMBT.TabIndex = 4;
            this.IndicatorCOMBT.UseVisualStyleBackColor = false;
            this.IndicatorCOMBT.Visible = false;
            // 
            // COMBaudRateCB
            // 
            this.COMBaudRateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBaudRateCB.FormattingEnabled = true;
            this.COMBaudRateCB.Location = new System.Drawing.Point(339, 43);
            this.COMBaudRateCB.Name = "COMBaudRateCB";
            this.COMBaudRateCB.Size = new System.Drawing.Size(121, 26);
            this.COMBaudRateCB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(336, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM BaudRate";
            // 
            // RellatCoonect1TB
            // 
            this.RellatCoonect1TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RellatCoonect1TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RellatCoonect1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RellatCoonect1TB.Location = new System.Drawing.Point(646, 54);
            this.RellatCoonect1TB.Name = "RellatCoonect1TB";
            this.RellatCoonect1TB.Size = new System.Drawing.Size(149, 33);
            this.RellatCoonect1TB.TabIndex = 7;
            this.RellatCoonect1TB.Text = "Relay Connect";
            this.RellatCoonect1TB.UseVisualStyleBackColor = false;
            this.RellatCoonect1TB.Click += new System.EventHandler(this.RellatCoonect1TB_Click);
            // 
            // RelayList1CB
            // 
            this.RelayList1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelayList1CB.FormattingEnabled = true;
            this.RelayList1CB.Location = new System.Drawing.Point(110, 57);
            this.RelayList1CB.Name = "RelayList1CB";
            this.RelayList1CB.Size = new System.Drawing.Size(225, 26);
            this.RelayList1CB.TabIndex = 8;
            // 
            // IndicatorRELAY1BT
            // 
            this.IndicatorRELAY1BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IndicatorRELAY1BT.Enabled = false;
            this.IndicatorRELAY1BT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IndicatorRELAY1BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndicatorRELAY1BT.Location = new System.Drawing.Point(469, 54);
            this.IndicatorRELAY1BT.Name = "IndicatorRELAY1BT";
            this.IndicatorRELAY1BT.Size = new System.Drawing.Size(19, 33);
            this.IndicatorRELAY1BT.TabIndex = 4;
            this.IndicatorRELAY1BT.UseVisualStyleBackColor = false;
            this.IndicatorRELAY1BT.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rellay 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(153, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Relay List";
            // 
            // TestRelay1BT
            // 
            this.TestRelay1BT.BackColor = System.Drawing.Color.Orange;
            this.TestRelay1BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestRelay1BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestRelay1BT.Location = new System.Drawing.Point(346, 59);
            this.TestRelay1BT.Name = "TestRelay1BT";
            this.TestRelay1BT.Size = new System.Drawing.Size(117, 23);
            this.TestRelay1BT.TabIndex = 9;
            this.TestRelay1BT.Text = "Test Relay";
            this.TestRelay1BT.UseVisualStyleBackColor = false;
            this.TestRelay1BT.Click += new System.EventHandler(this.TestRelay1BT_Click);
            // 
            // RelayDisconnect1TB
            // 
            this.RelayDisconnect1TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RelayDisconnect1TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelayDisconnect1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelayDisconnect1TB.Location = new System.Drawing.Point(495, 54);
            this.RelayDisconnect1TB.Name = "RelayDisconnect1TB";
            this.RelayDisconnect1TB.Size = new System.Drawing.Size(149, 33);
            this.RelayDisconnect1TB.TabIndex = 7;
            this.RelayDisconnect1TB.Text = "Relay DisConnect";
            this.RelayDisconnect1TB.UseVisualStyleBackColor = false;
            this.RelayDisconnect1TB.Click += new System.EventHandler(this.RelayDisconnect1TB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TestRelay3BT);
            this.groupBox1.Controls.Add(this.TestRelay2BT);
            this.groupBox1.Controls.Add(this.RelayList3CB);
            this.groupBox1.Controls.Add(this.TestRelay1BT);
            this.groupBox1.Controls.Add(this.RelayDisconnect3TB);
            this.groupBox1.Controls.Add(this.RelayList2CB);
            this.groupBox1.Controls.Add(this.RelayDisconnect2TB);
            this.groupBox1.Controls.Add(this.RellatCoonect3TB);
            this.groupBox1.Controls.Add(this.RelayList1CB);
            this.groupBox1.Controls.Add(this.RellatCoonect2TB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RelayDisconnect1TB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IndicatorRELAY3BT);
            this.groupBox1.Controls.Add(this.RellatCoonect1TB);
            this.groupBox1.Controls.Add(this.IndicatorRELAY2BT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.IndicatorRELAY1BT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relays";
            // 
            // TestRelay3BT
            // 
            this.TestRelay3BT.BackColor = System.Drawing.Color.Orange;
            this.TestRelay3BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestRelay3BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestRelay3BT.Location = new System.Drawing.Point(346, 172);
            this.TestRelay3BT.Name = "TestRelay3BT";
            this.TestRelay3BT.Size = new System.Drawing.Size(117, 23);
            this.TestRelay3BT.TabIndex = 9;
            this.TestRelay3BT.Text = "Test Relay";
            this.TestRelay3BT.UseVisualStyleBackColor = false;
            this.TestRelay3BT.Click += new System.EventHandler(this.TestRelay3BT_Click);
            // 
            // TestRelay2BT
            // 
            this.TestRelay2BT.BackColor = System.Drawing.Color.Orange;
            this.TestRelay2BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestRelay2BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestRelay2BT.Location = new System.Drawing.Point(346, 115);
            this.TestRelay2BT.Name = "TestRelay2BT";
            this.TestRelay2BT.Size = new System.Drawing.Size(117, 23);
            this.TestRelay2BT.TabIndex = 9;
            this.TestRelay2BT.Text = "Test Relay";
            this.TestRelay2BT.UseVisualStyleBackColor = false;
            this.TestRelay2BT.Click += new System.EventHandler(this.TestRelay2BT_Click);
            // 
            // RelayList3CB
            // 
            this.RelayList3CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelayList3CB.FormattingEnabled = true;
            this.RelayList3CB.Location = new System.Drawing.Point(110, 170);
            this.RelayList3CB.Name = "RelayList3CB";
            this.RelayList3CB.Size = new System.Drawing.Size(225, 26);
            this.RelayList3CB.TabIndex = 8;
            // 
            // RelayDisconnect3TB
            // 
            this.RelayDisconnect3TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RelayDisconnect3TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelayDisconnect3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelayDisconnect3TB.Location = new System.Drawing.Point(495, 167);
            this.RelayDisconnect3TB.Name = "RelayDisconnect3TB";
            this.RelayDisconnect3TB.Size = new System.Drawing.Size(149, 33);
            this.RelayDisconnect3TB.TabIndex = 7;
            this.RelayDisconnect3TB.Text = "Relay DisConnect";
            this.RelayDisconnect3TB.UseVisualStyleBackColor = false;
            this.RelayDisconnect3TB.Click += new System.EventHandler(this.RelayDisconnect3TB_Click);
            // 
            // RelayList2CB
            // 
            this.RelayList2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelayList2CB.FormattingEnabled = true;
            this.RelayList2CB.Location = new System.Drawing.Point(110, 113);
            this.RelayList2CB.Name = "RelayList2CB";
            this.RelayList2CB.Size = new System.Drawing.Size(225, 26);
            this.RelayList2CB.TabIndex = 8;
            // 
            // RelayDisconnect2TB
            // 
            this.RelayDisconnect2TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RelayDisconnect2TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelayDisconnect2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RelayDisconnect2TB.Location = new System.Drawing.Point(495, 110);
            this.RelayDisconnect2TB.Name = "RelayDisconnect2TB";
            this.RelayDisconnect2TB.Size = new System.Drawing.Size(149, 33);
            this.RelayDisconnect2TB.TabIndex = 7;
            this.RelayDisconnect2TB.Text = "Relay DisConnect";
            this.RelayDisconnect2TB.UseVisualStyleBackColor = false;
            this.RelayDisconnect2TB.Click += new System.EventHandler(this.RelayDisconnect2TB_Click);
            // 
            // RellatCoonect3TB
            // 
            this.RellatCoonect3TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RellatCoonect3TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RellatCoonect3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RellatCoonect3TB.Location = new System.Drawing.Point(646, 167);
            this.RellatCoonect3TB.Name = "RellatCoonect3TB";
            this.RellatCoonect3TB.Size = new System.Drawing.Size(149, 33);
            this.RellatCoonect3TB.TabIndex = 7;
            this.RellatCoonect3TB.Text = "Relay Connect";
            this.RellatCoonect3TB.UseVisualStyleBackColor = false;
            this.RellatCoonect3TB.Click += new System.EventHandler(this.RellatCoonect3TB_Click);
            // 
            // RellatCoonect2TB
            // 
            this.RellatCoonect2TB.BackColor = System.Drawing.Color.FloralWhite;
            this.RellatCoonect2TB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RellatCoonect2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RellatCoonect2TB.Location = new System.Drawing.Point(646, 110);
            this.RellatCoonect2TB.Name = "RellatCoonect2TB";
            this.RellatCoonect2TB.Size = new System.Drawing.Size(149, 33);
            this.RellatCoonect2TB.TabIndex = 7;
            this.RellatCoonect2TB.Text = "Relay Connect";
            this.RellatCoonect2TB.UseVisualStyleBackColor = false;
            this.RellatCoonect2TB.Click += new System.EventHandler(this.RellatCoonect2TB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(153, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Relay List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(153, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Relay List";
            // 
            // IndicatorRELAY3BT
            // 
            this.IndicatorRELAY3BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IndicatorRELAY3BT.Enabled = false;
            this.IndicatorRELAY3BT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IndicatorRELAY3BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndicatorRELAY3BT.Location = new System.Drawing.Point(469, 167);
            this.IndicatorRELAY3BT.Name = "IndicatorRELAY3BT";
            this.IndicatorRELAY3BT.Size = new System.Drawing.Size(19, 33);
            this.IndicatorRELAY3BT.TabIndex = 4;
            this.IndicatorRELAY3BT.UseVisualStyleBackColor = false;
            this.IndicatorRELAY3BT.Visible = false;
            // 
            // IndicatorRELAY2BT
            // 
            this.IndicatorRELAY2BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IndicatorRELAY2BT.Enabled = false;
            this.IndicatorRELAY2BT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IndicatorRELAY2BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IndicatorRELAY2BT.Location = new System.Drawing.Point(469, 110);
            this.IndicatorRELAY2BT.Name = "IndicatorRELAY2BT";
            this.IndicatorRELAY2BT.Size = new System.Drawing.Size(19, 33);
            this.IndicatorRELAY2BT.TabIndex = 4;
            this.IndicatorRELAY2BT.UseVisualStyleBackColor = false;
            this.IndicatorRELAY2BT.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rellay 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rellay 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.COMBaudRateCB);
            this.groupBox2.Controls.Add(this.IndicatorCOMBT);
            this.groupBox2.Controls.Add(this.ConformComBT);
            this.groupBox2.Controls.Add(this.MyComPortsCB);
            this.groupBox2.Controls.Add(this.ArdunioComTX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Connect";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyМushroomController.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MyController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G&A Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ArdunioComTX;
        private System.Windows.Forms.ComboBox ComPortsCB;
        private System.Windows.Forms.ComboBox MyComPortsCB;
        private System.Windows.Forms.Button ConformComBT;
        private System.Windows.Forms.Button IndicatorCOMBT;
        private System.Windows.Forms.ComboBox COMBaudRateCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RellatCoonect1TB;
        private System.Windows.Forms.ComboBox RelayList1CB;
        private System.Windows.Forms.Button IndicatorRELAY1BT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestRelay1BT;
        private System.Windows.Forms.Button RelayDisconnect1TB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TestRelay3BT;
        private System.Windows.Forms.Button TestRelay2BT;
        private System.Windows.Forms.ComboBox RelayList3CB;
        private System.Windows.Forms.Button RelayDisconnect3TB;
        private System.Windows.Forms.ComboBox RelayList2CB;
        private System.Windows.Forms.Button RelayDisconnect2TB;
        private System.Windows.Forms.Button RellatCoonect3TB;
        private System.Windows.Forms.Button RellatCoonect2TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button IndicatorRELAY3BT;
        private System.Windows.Forms.Button IndicatorRELAY2BT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

