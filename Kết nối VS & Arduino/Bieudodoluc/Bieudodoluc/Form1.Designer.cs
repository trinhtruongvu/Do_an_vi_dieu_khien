namespace Bieudodoluc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.butConnect = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.CommunicationgroupBox = new System.Windows.Forms.GroupBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.cboCOMPORT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Velocitylabel = new System.Windows.Forms.Label();
            this.VelocitytextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositiontextBox = new System.Windows.Forms.TextBox();
            this.SendvalueButtun = new System.Windows.Forms.Button();
            this.ControlgroupBox = new System.Windows.Forms.GroupBox();
            this.DirectioncomboBox = new System.Windows.Forms.ComboBox();
            this.Directionlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Homebutton = new System.Windows.Forms.Button();
            this.Stopmotorbutton = new System.Windows.Forms.Button();
            this.Setbutton = new System.Windows.Forms.Button();
            this.CommunicationgroupBox.SuspendLayout();
            this.ControlgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Pannel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butConnect.ForeColor = System.Drawing.Color.Lime;
            this.butConnect.Location = new System.Drawing.Point(107, 308);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(143, 50);
            this.butConnect.TabIndex = 1;
            this.butConnect.Text = "CONNECT";
            this.butConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butExit.ForeColor = System.Drawing.Color.Fuchsia;
            this.butExit.Location = new System.Drawing.Point(772, 308);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(140, 50);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // serCom
            // 
            this.serCom.PortName = "COM4";
            // 
            // CommunicationgroupBox
            // 
            this.CommunicationgroupBox.Controls.Add(this.cboBaudrate);
            this.CommunicationgroupBox.Controls.Add(this.cboCOMPORT);
            this.CommunicationgroupBox.Controls.Add(this.label3);
            this.CommunicationgroupBox.Controls.Add(this.label2);
            this.CommunicationgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CommunicationgroupBox.Location = new System.Drawing.Point(6, 56);
            this.CommunicationgroupBox.Name = "CommunicationgroupBox";
            this.CommunicationgroupBox.Size = new System.Drawing.Size(244, 209);
            this.CommunicationgroupBox.TabIndex = 2;
            this.CommunicationgroupBox.TabStop = false;
            this.CommunicationgroupBox.Text = "Communication";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(124, 84);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(97, 28);
            this.cboBaudrate.TabIndex = 1;
            this.cboBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboCOMPORT
            // 
            this.cboCOMPORT.FormattingEnabled = true;
            this.cboCOMPORT.Location = new System.Drawing.Point(124, 21);
            this.cboCOMPORT.Name = "cboCOMPORT";
            this.cboCOMPORT.Size = new System.Drawing.Size(97, 28);
            this.cboCOMPORT.TabIndex = 1;
            this.cboCOMPORT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Baudrate";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Com";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Velocitylabel
            // 
            this.Velocitylabel.AutoSize = true;
            this.Velocitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocitylabel.Location = new System.Drawing.Point(37, 25);
            this.Velocitylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Velocitylabel.Name = "Velocitylabel";
            this.Velocitylabel.Size = new System.Drawing.Size(72, 20);
            this.Velocitylabel.TabIndex = 3;
            this.Velocitylabel.Text = "Velocity";
            this.Velocitylabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // VelocitytextBox
            // 
            this.VelocitytextBox.Location = new System.Drawing.Point(124, 29);
            this.VelocitytextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VelocitytextBox.Name = "VelocitytextBox";
            this.VelocitytextBox.Size = new System.Drawing.Size(97, 26);
            this.VelocitytextBox.TabIndex = 4;
            this.VelocitytextBox.TextChanged += new System.EventHandler(this.VelocitytextBox_TextChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(37, 73);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(73, 20);
            this.PositionLabel.TabIndex = 5;
            this.PositionLabel.Text = "Position";
            // 
            // PositiontextBox
            // 
            this.PositiontextBox.Location = new System.Drawing.Point(124, 73);
            this.PositiontextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositiontextBox.Name = "PositiontextBox";
            this.PositiontextBox.Size = new System.Drawing.Size(97, 26);
            this.PositiontextBox.TabIndex = 6;
            this.PositiontextBox.TextChanged += new System.EventHandler(this.PositiontextBox_TextChanged);
            // 
            // SendvalueButtun
            // 
            this.SendvalueButtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendvalueButtun.ForeColor = System.Drawing.Color.Coral;
            this.SendvalueButtun.Location = new System.Drawing.Point(71, 169);
            this.SendvalueButtun.Margin = new System.Windows.Forms.Padding(2);
            this.SendvalueButtun.Name = "SendvalueButtun";
            this.SendvalueButtun.Size = new System.Drawing.Size(117, 35);
            this.SendvalueButtun.TabIndex = 7;
            this.SendvalueButtun.Text = "Send value";
            this.SendvalueButtun.UseVisualStyleBackColor = true;
            this.SendvalueButtun.Click += new System.EventHandler(this.SendvalueButtun_Click);
            // 
            // ControlgroupBox
            // 
            this.ControlgroupBox.Controls.Add(this.DirectioncomboBox);
            this.ControlgroupBox.Controls.Add(this.Directionlabel);
            this.ControlgroupBox.Controls.Add(this.SendvalueButtun);
            this.ControlgroupBox.Controls.Add(this.PositiontextBox);
            this.ControlgroupBox.Controls.Add(this.PositionLabel);
            this.ControlgroupBox.Controls.Add(this.VelocitytextBox);
            this.ControlgroupBox.Controls.Add(this.Velocitylabel);
            this.ControlgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlgroupBox.Location = new System.Drawing.Point(407, 56);
            this.ControlgroupBox.Name = "ControlgroupBox";
            this.ControlgroupBox.Size = new System.Drawing.Size(244, 209);
            this.ControlgroupBox.TabIndex = 8;
            this.ControlgroupBox.TabStop = false;
            this.ControlgroupBox.Text = "Control";
            // 
            // DirectioncomboBox
            // 
            this.DirectioncomboBox.FormattingEnabled = true;
            this.DirectioncomboBox.Items.AddRange(new object[] {
            "N",
            "P"});
            this.DirectioncomboBox.Location = new System.Drawing.Point(124, 119);
            this.DirectioncomboBox.Name = "DirectioncomboBox";
            this.DirectioncomboBox.Size = new System.Drawing.Size(97, 28);
            this.DirectioncomboBox.TabIndex = 2;
            this.DirectioncomboBox.SelectedIndexChanged += new System.EventHandler(this.DirectioncomboBox_SelectedIndexChanged);
            // 
            // Directionlabel
            // 
            this.Directionlabel.AutoSize = true;
            this.Directionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directionlabel.Location = new System.Drawing.Point(37, 123);
            this.Directionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Directionlabel.Name = "Directionlabel";
            this.Directionlabel.Size = new System.Drawing.Size(81, 20);
            this.Directionlabel.TabIndex = 8;
            this.Directionlabel.Text = "Direction";
            this.Directionlabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Setbutton);
            this.groupBox1.Controls.Add(this.Homebutton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(772, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functional Buttons";
            // 
            // Homebutton
            // 
            this.Homebutton.Location = new System.Drawing.Point(61, 29);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(136, 26);
            this.Homebutton.TabIndex = 0;
            this.Homebutton.Text = "Home";
            this.Homebutton.UseVisualStyleBackColor = true;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // Stopmotorbutton
            // 
            this.Stopmotorbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopmotorbutton.ForeColor = System.Drawing.Color.Crimson;
            this.Stopmotorbutton.Location = new System.Drawing.Point(440, 308);
            this.Stopmotorbutton.Name = "Stopmotorbutton";
            this.Stopmotorbutton.Size = new System.Drawing.Size(143, 50);
            this.Stopmotorbutton.TabIndex = 10;
            this.Stopmotorbutton.Text = "Stop Motor";
            this.Stopmotorbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Stopmotorbutton.UseVisualStyleBackColor = true;
            this.Stopmotorbutton.Click += new System.EventHandler(this.Stopmotorbutton_Click);
            // 
            // Setbutton
            // 
            this.Setbutton.Location = new System.Drawing.Point(54, 91);
            this.Setbutton.Name = "Setbutton";
            this.Setbutton.Size = new System.Drawing.Size(136, 26);
            this.Setbutton.TabIndex = 1;
            this.Setbutton.Text = "Set Home";
            this.Setbutton.UseVisualStyleBackColor = true;
            this.Setbutton.Click += new System.EventHandler(this.Setbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 555);
            this.Controls.Add(this.Stopmotorbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ControlgroupBox);
            this.Controls.Add(this.CommunicationgroupBox);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommunicationgroupBox.ResumeLayout(false);
            this.CommunicationgroupBox.PerformLayout();
            this.ControlgroupBox.ResumeLayout(false);
            this.ControlgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butExit;
        private System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.GroupBox CommunicationgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCOMPORT;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Velocitylabel;
        private System.Windows.Forms.TextBox VelocitytextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox PositiontextBox;
        private System.Windows.Forms.Button SendvalueButtun;
        private System.Windows.Forms.GroupBox ControlgroupBox;
        private System.Windows.Forms.Label Directionlabel;
        private System.Windows.Forms.ComboBox DirectioncomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Homebutton;
        private System.Windows.Forms.Button Stopmotorbutton;
        private System.Windows.Forms.Button Setbutton;
    }
}

