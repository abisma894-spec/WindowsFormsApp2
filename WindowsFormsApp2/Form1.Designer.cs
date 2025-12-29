namespace WindowsFormsApp2
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
            this.panelShaft = new System.Windows.Forms.Panel();
            this.panelDoorRight = new System.Windows.Forms.Panel();
            this.panelElevator = new System.Windows.Forms.Panel();
            this.panelDoorLeft = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.btnDoor = new System.Windows.Forms.Button();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.timerElevator = new System.Windows.Forms.Timer(this.components);
            this.panelShaft2 = new System.Windows.Forms.Panel();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblOverload = new System.Windows.Forms.Label();
            this.timerElevator2 = new System.Windows.Forms.Timer(this.components);
            this.lblFloor2 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblDoor2 = new System.Windows.Forms.Label();
            this.panelDoorLeft2 = new System.Windows.Forms.Panel();
            this.panelElevator2 = new System.Windows.Forms.Panel();
            this.panelDoorRight2 = new System.Windows.Forms.Panel();
            this.btnDoor2 = new System.Windows.Forms.Button();
            this.btn1Floor = new System.Windows.Forms.Button();
            this.btn2Floor = new System.Windows.Forms.Button();
            this.btn3Floor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelShaft.SuspendLayout();
            this.panelElevator.SuspendLayout();
            this.panelShaft2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.panelElevator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShaft
            // 
            this.panelShaft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelShaft.Controls.Add(this.panelElevator);
            this.panelShaft.Location = new System.Drawing.Point(39, 153);
            this.panelShaft.Name = "panelShaft";
            this.panelShaft.Size = new System.Drawing.Size(160, 330);
            this.panelShaft.TabIndex = 0;
            // 
            // panelDoorRight
            // 
            this.panelDoorRight.BackColor = System.Drawing.Color.LightGray;
            this.panelDoorRight.Location = new System.Drawing.Point(69, -1);
            this.panelDoorRight.Name = "panelDoorRight";
            this.panelDoorRight.Size = new System.Drawing.Size(70, 60);
            this.panelDoorRight.TabIndex = 3;
            // 
            // panelElevator
            // 
            this.panelElevator.BackColor = System.Drawing.Color.Blue;
            this.panelElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelElevator.Controls.Add(this.panelDoorRight);
            this.panelElevator.Controls.Add(this.panelDoorLeft);
            this.panelElevator.Location = new System.Drawing.Point(10, 270);
            this.panelElevator.Name = "panelElevator";
            this.panelElevator.Size = new System.Drawing.Size(140, 60);
            this.panelElevator.TabIndex = 1;
            // 
            // panelDoorLeft
            // 
            this.panelDoorLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelDoorLeft.Location = new System.Drawing.Point(-1, -1);
            this.panelDoorLeft.Name = "panelDoorLeft";
            this.panelDoorLeft.Size = new System.Drawing.Size(70, 60);
            this.panelDoorLeft.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.MistyRose;
            this.btnUp.Location = new System.Drawing.Point(357, 546);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(70, 30);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.MistyRose;
            this.btnDown.Location = new System.Drawing.Point(357, 584);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(70, 30);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnFloor1
            // 
            this.btnFloor1.BackColor = System.Drawing.Color.MistyRose;
            this.btnFloor1.ForeColor = System.Drawing.Color.Black;
            this.btnFloor1.Location = new System.Drawing.Point(253, 254);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(50, 30);
            this.btnFloor1.TabIndex = 6;
            this.btnFloor1.Text = "1";
            this.btnFloor1.UseVisualStyleBackColor = false;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // btnFloor2
            // 
            this.btnFloor2.BackColor = System.Drawing.Color.MistyRose;
            this.btnFloor2.Location = new System.Drawing.Point(250, 309);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(50, 30);
            this.btnFloor2.TabIndex = 7;
            this.btnFloor2.Text = "2";
            this.btnFloor2.UseVisualStyleBackColor = false;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
            // 
            // btnFloor3
            // 
            this.btnFloor3.BackColor = System.Drawing.Color.MistyRose;
            this.btnFloor3.Location = new System.Drawing.Point(250, 363);
            this.btnFloor3.Name = "btnFloor3";
            this.btnFloor3.Size = new System.Drawing.Size(50, 30);
            this.btnFloor3.TabIndex = 8;
            this.btnFloor3.Text = "3";
            this.btnFloor3.UseVisualStyleBackColor = false;
            this.btnFloor3.Click += new System.EventHandler(this.btnFloor3_Click);
            // 
            // btnDoor
            // 
            this.btnDoor.BackColor = System.Drawing.Color.MistyRose;
            this.btnDoor.Location = new System.Drawing.Point(240, 414);
            this.btnDoor.Name = "btnDoor";
            this.btnDoor.Size = new System.Drawing.Size(129, 36);
            this.btnDoor.TabIndex = 9;
            this.btnDoor.Text = "Open / Close";
            this.btnDoor.UseVisualStyleBackColor = false;
            this.btnDoor.Click += new System.EventHandler(this.btnDoor_Click);
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(246, 153);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(119, 20);
            this.lblFloor.TabIndex = 10;
            this.lblFloor.Text = "Current Floor: 1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(246, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status: Idle";
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(236, 463);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(101, 20);
            this.lblDoor.TabIndex = 12;
            this.lblDoor.Text = "Door: Closed";
            // 
            // timerElevator
            // 
            this.timerElevator.Interval = 50;
            this.timerElevator.Tick += new System.EventHandler(this.timerElevator_Tick);
            // 
            // panelShaft2
            // 
            this.panelShaft2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelShaft2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShaft2.Controls.Add(this.panelElevator2);
            this.panelShaft2.Location = new System.Drawing.Point(462, 153);
            this.panelShaft2.Name = "panelShaft2";
            this.panelShaft2.Size = new System.Drawing.Size(156, 330);
            this.panelShaft2.TabIndex = 13;
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(39, 565);
            this.numWeight.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 26);
            this.numWeight.TabIndex = 14;
            // 
            // lblOverload
            // 
            this.lblOverload.AutoSize = true;
            this.lblOverload.BackColor = System.Drawing.Color.Blue;
            this.lblOverload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverload.Location = new System.Drawing.Point(35, 594);
            this.lblOverload.Name = "lblOverload";
            this.lblOverload.Size = new System.Drawing.Size(47, 20);
            this.lblOverload.TabIndex = 15;
            this.lblOverload.Text = "label";
            // 
            // timerElevator2
            // 
            this.timerElevator2.Interval = 50;
            this.timerElevator2.Tick += new System.EventHandler(this.timerElevator2_Tick);
            // 
            // lblFloor2
            // 
            this.lblFloor2.AutoSize = true;
            this.lblFloor2.Location = new System.Drawing.Point(663, 153);
            this.lblFloor2.Name = "lblFloor2";
            this.lblFloor2.Size = new System.Drawing.Size(119, 20);
            this.lblFloor2.TabIndex = 16;
            this.lblFloor2.Text = "Current Floor :3";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(677, 183);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(94, 20);
            this.lblStatus2.TabIndex = 17;
            this.lblStatus2.Text = "Status : Idle";
            // 
            // lblDoor2
            // 
            this.lblDoor2.AutoSize = true;
            this.lblDoor2.Location = new System.Drawing.Point(663, 463);
            this.lblDoor2.Name = "lblDoor2";
            this.lblDoor2.Size = new System.Drawing.Size(105, 20);
            this.lblDoor2.TabIndex = 18;
            this.lblDoor2.Text = "Door : Closed";
            // 
            // panelDoorLeft2
            // 
            this.panelDoorLeft2.BackColor = System.Drawing.Color.LightGray;
            this.panelDoorLeft2.Location = new System.Drawing.Point(0, 0);
            this.panelDoorLeft2.Name = "panelDoorLeft2";
            this.panelDoorLeft2.Size = new System.Drawing.Size(70, 60);
            this.panelDoorLeft2.TabIndex = 14;
            // 
            // panelElevator2
            // 
            this.panelElevator2.BackColor = System.Drawing.Color.Blue;
            this.panelElevator2.Controls.Add(this.panelDoorRight2);
            this.panelElevator2.Controls.Add(this.panelDoorLeft2);
            this.panelElevator2.Location = new System.Drawing.Point(7, 271);
            this.panelElevator2.Name = "panelElevator2";
            this.panelElevator2.Size = new System.Drawing.Size(140, 60);
            this.panelElevator2.TabIndex = 16;
            this.panelElevator2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelElevator2_Paint);
            // 
            // panelDoorRight2
            // 
            this.panelDoorRight2.BackColor = System.Drawing.Color.LightGray;
            this.panelDoorRight2.Location = new System.Drawing.Point(70, 0);
            this.panelDoorRight2.Name = "panelDoorRight2";
            this.panelDoorRight2.Size = new System.Drawing.Size(70, 60);
            this.panelDoorRight2.TabIndex = 15;
            // 
            // btnDoor2
            // 
            this.btnDoor2.BackColor = System.Drawing.Color.MistyRose;
            this.btnDoor2.Location = new System.Drawing.Point(667, 414);
            this.btnDoor2.Name = "btnDoor2";
            this.btnDoor2.Size = new System.Drawing.Size(129, 36);
            this.btnDoor2.TabIndex = 19;
            this.btnDoor2.Text = "Open / Close";
            this.btnDoor2.UseVisualStyleBackColor = false;
            this.btnDoor2.Click += new System.EventHandler(this.btnDoor2_Click);
            // 
            // btn1Floor
            // 
            this.btn1Floor.BackColor = System.Drawing.Color.MistyRose;
            this.btn1Floor.Location = new System.Drawing.Point(667, 254);
            this.btn1Floor.Name = "btn1Floor";
            this.btn1Floor.Size = new System.Drawing.Size(50, 30);
            this.btn1Floor.TabIndex = 20;
            this.btn1Floor.Text = "1";
            this.btn1Floor.UseVisualStyleBackColor = false;
            this.btn1Floor.Click += new System.EventHandler(this.btn1Floor_Click);
            // 
            // btn2Floor
            // 
            this.btn2Floor.BackColor = System.Drawing.Color.MistyRose;
            this.btn2Floor.Location = new System.Drawing.Point(667, 309);
            this.btn2Floor.Name = "btn2Floor";
            this.btn2Floor.Size = new System.Drawing.Size(50, 30);
            this.btn2Floor.TabIndex = 2;
            this.btn2Floor.Text = "2";
            this.btn2Floor.UseVisualStyleBackColor = false;
            this.btn2Floor.Click += new System.EventHandler(this.btn2Floor_Click);
            // 
            // btn3Floor
            // 
            this.btn3Floor.BackColor = System.Drawing.Color.MistyRose;
            this.btn3Floor.Location = new System.Drawing.Point(667, 363);
            this.btn3Floor.Name = "btn3Floor";
            this.btn3Floor.Size = new System.Drawing.Size(50, 30);
            this.btn3Floor.TabIndex = 21;
            this.btn3Floor.Text = "3";
            this.btn3Floor.UseVisualStyleBackColor = false;
            this.btn3Floor.Click += new System.EventHandler(this.btn3Floor_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 46);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Elevator Control System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(811, 647);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn3Floor);
            this.Controls.Add(this.btn2Floor);
            this.Controls.Add(this.btn1Floor);
            this.Controls.Add(this.btnDoor2);
            this.Controls.Add(this.lblDoor2);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblFloor2);
            this.Controls.Add(this.lblOverload);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.panelShaft2);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.btnDoor);
            this.Controls.Add(this.btnFloor3);
            this.Controls.Add(this.btnFloor2);
            this.Controls.Add(this.btnFloor1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panelShaft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelShaft.ResumeLayout(false);
            this.panelElevator.ResumeLayout(false);
            this.panelShaft2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.panelElevator2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelShaft;
        private System.Windows.Forms.Panel panelElevator;
        private System.Windows.Forms.Panel panelDoorLeft;
        private System.Windows.Forms.Panel panelDoorRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor3;
        private System.Windows.Forms.Button btnDoor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.Timer timerElevator;
        private System.Windows.Forms.Panel panelShaft2;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblOverload;
        private System.Windows.Forms.Timer timerElevator2;
        private System.Windows.Forms.Label lblFloor2;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblDoor2;
        private System.Windows.Forms.Panel panelElevator2;
        private System.Windows.Forms.Panel panelDoorRight2;
        private System.Windows.Forms.Panel panelDoorLeft2;
        private System.Windows.Forms.Button btnDoor2;
        private System.Windows.Forms.Button btn1Floor;
        private System.Windows.Forms.Button btn2Floor;
        private System.Windows.Forms.Button btn3Floor;
        private System.Windows.Forms.TextBox textBox1;
    }
}

