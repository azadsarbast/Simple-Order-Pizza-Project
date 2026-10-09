namespace Pizza_Project
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
            this.labMainOne = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbtopping = new System.Windows.Forms.GroupBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatose = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPrppers = new System.Windows.Forms.CheckBox();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rbthinCrust = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.gpPlacetoeat = new System.Windows.Forms.GroupBox();
            this.rbtakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labSize = new System.Windows.Forms.Label();
            this.labTopping = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblcurstType = new System.Windows.Forms.Label();
            this.lblWhereToeat = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbtopping.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gpPlacetoeat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMainOne
            // 
            this.labMainOne.AutoSize = true;
            this.labMainOne.Font = new System.Drawing.Font("Verdana", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainOne.ForeColor = System.Drawing.Color.Red;
            this.labMainOne.Location = new System.Drawing.Point(219, 9);
            this.labMainOne.Name = "labMainOne";
            this.labMainOne.Size = new System.Drawing.Size(542, 67);
            this.labMainOne.TabIndex = 0;
            this.labMainOne.Text = "Make Your Pizza";
            this.labMainOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbbSmall);
            this.gbSize.Location = new System.Drawing.Point(39, 95);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 171);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbbSmall
            // 
            this.rbbSmall.AutoSize = true;
            this.rbbSmall.Location = new System.Drawing.Point(35, 41);
            this.rbbSmall.Name = "rbbSmall";
            this.rbbSmall.Size = new System.Drawing.Size(73, 23);
            this.rbbSmall.TabIndex = 0;
            this.rbbSmall.TabStop = true;
            this.rbbSmall.Tag = "20";
            this.rbbSmall.Text = "Small";
            this.rbbSmall.UseVisualStyleBackColor = true;
            this.rbbSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(35, 82);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(90, 23);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "40";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(38, 124);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "60";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gbtopping
            // 
            this.gbtopping.Controls.Add(this.chkGreenPrppers);
            this.gbtopping.Controls.Add(this.chkOlives);
            this.gbtopping.Controls.Add(this.chkOnion);
            this.gbtopping.Controls.Add(this.chkTomatose);
            this.gbtopping.Controls.Add(this.chkMushrooms);
            this.gbtopping.Controls.Add(this.chkExtraChees);
            this.gbtopping.Location = new System.Drawing.Point(296, 95);
            this.gbtopping.Name = "gbtopping";
            this.gbtopping.Size = new System.Drawing.Size(311, 186);
            this.gbtopping.TabIndex = 3;
            this.gbtopping.TabStop = false;
            this.gbtopping.Text = "Toppings";
            this.gbtopping.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(21, 42);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(118, 23);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.ckbExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(21, 71);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 23);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.ckbMushrooms_CheckedChanged);
            // 
            // chkTomatose
            // 
            this.chkTomatose.AutoSize = true;
            this.chkTomatose.Location = new System.Drawing.Point(21, 100);
            this.chkTomatose.Name = "chkTomatose";
            this.chkTomatose.Size = new System.Drawing.Size(105, 23);
            this.chkTomatose.TabIndex = 2;
            this.chkTomatose.Tag = "5";
            this.chkTomatose.Text = "Tomatose";
            this.chkTomatose.UseVisualStyleBackColor = true;
            this.chkTomatose.CheckedChanged += new System.EventHandler(this.ckbTomatose_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(171, 42);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(78, 23);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.ckbOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(171, 71);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(78, 23);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkGreenPrppers
            // 
            this.chkGreenPrppers.AutoSize = true;
            this.chkGreenPrppers.Location = new System.Drawing.Point(171, 100);
            this.chkGreenPrppers.Name = "chkGreenPrppers";
            this.chkGreenPrppers.Size = new System.Drawing.Size(138, 23);
            this.chkGreenPrppers.TabIndex = 5;
            this.chkGreenPrppers.Tag = "5";
            this.chkGreenPrppers.Text = "Green Peppers";
            this.chkGreenPrppers.UseVisualStyleBackColor = true;
            this.chkGreenPrppers.CheckedChanged += new System.EventHandler(this.ckbGreenPrppers_CheckedChanged);
            // 
            // gbcrust
            // 
            this.gbcrust.Controls.Add(this.rbthinCrust);
            this.gbcrust.Controls.Add(this.rbThinkCrust);
            this.gbcrust.Location = new System.Drawing.Point(39, 287);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Size = new System.Drawing.Size(200, 151);
            this.gbcrust.TabIndex = 3;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust";
            // 
            // rbthinCrust
            // 
            this.rbthinCrust.AutoSize = true;
            this.rbthinCrust.Location = new System.Drawing.Point(35, 82);
            this.rbthinCrust.Name = "rbthinCrust";
            this.rbthinCrust.Size = new System.Drawing.Size(108, 23);
            this.rbthinCrust.TabIndex = 1;
            this.rbthinCrust.TabStop = true;
            this.rbthinCrust.Tag = "0";
            this.rbthinCrust.Text = "Thin Crust";
            this.rbthinCrust.UseVisualStyleBackColor = true;
            this.rbthinCrust.CheckedChanged += new System.EventHandler(this.rdthinCrust_CheckedChanged);
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(35, 41);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(116, 23);
            this.rbThinkCrust.TabIndex = 0;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // gpPlacetoeat
            // 
            this.gpPlacetoeat.Controls.Add(this.rbtakeOut);
            this.gpPlacetoeat.Controls.Add(this.rbEatIn);
            this.gpPlacetoeat.Location = new System.Drawing.Point(296, 287);
            this.gpPlacetoeat.Name = "gpPlacetoeat";
            this.gpPlacetoeat.Size = new System.Drawing.Size(311, 83);
            this.gpPlacetoeat.TabIndex = 4;
            this.gpPlacetoeat.TabStop = false;
            this.gpPlacetoeat.Text = "Where To Eat";
            // 
            // rbtakeOut
            // 
            this.rbtakeOut.AutoSize = true;
            this.rbtakeOut.Location = new System.Drawing.Point(171, 41);
            this.rbtakeOut.Name = "rbtakeOut";
            this.rbtakeOut.Size = new System.Drawing.Size(99, 23);
            this.rbtakeOut.TabIndex = 1;
            this.rbtakeOut.TabStop = true;
            this.rbtakeOut.Text = "Take Out";
            this.rbtakeOut.UseVisualStyleBackColor = true;
            this.rbtakeOut.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(35, 41);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(74, 23);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Order Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCost);
            this.groupBox5.Controls.Add(this.lblWhereToeat);
            this.groupBox5.Controls.Add(this.lblcurstType);
            this.groupBox5.Controls.Add(this.lblTopping);
            this.groupBox5.Controls.Add(this.lblSize);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.labTopping);
            this.groupBox5.Controls.Add(this.labSize);
            this.groupBox5.Location = new System.Drawing.Point(659, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 365);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(21, 35);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(59, 24);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size:";
            // 
            // labTopping
            // 
            this.labTopping.AutoSize = true;
            this.labTopping.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTopping.Location = new System.Drawing.Point(21, 80);
            this.labTopping.Name = "labTopping";
            this.labTopping.Size = new System.Drawing.Size(109, 24);
            this.labTopping.TabIndex = 1;
            this.labTopping.Text = "Toppings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Curst Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where To Eat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(101, 41);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 19);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "label1";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(27, 113);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(51, 19);
            this.lblTopping.TabIndex = 10;
            this.lblTopping.Text = "label1";
            // 
            // lblcurstType
            // 
            this.lblcurstType.AutoSize = true;
            this.lblcurstType.Location = new System.Drawing.Point(158, 165);
            this.lblcurstType.Name = "lblcurstType";
            this.lblcurstType.Size = new System.Drawing.Size(51, 19);
            this.lblcurstType.TabIndex = 11;
            this.lblcurstType.Text = "label1";
            // 
            // lblWhereToeat
            // 
            this.lblWhereToeat.AutoSize = true;
            this.lblWhereToeat.Location = new System.Drawing.Point(186, 197);
            this.lblWhereToeat.Name = "lblWhereToeat";
            this.lblWhereToeat.Size = new System.Drawing.Size(51, 19);
            this.lblWhereToeat.TabIndex = 12;
            this.lblWhereToeat.Text = "label1";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(101, 298);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 19);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "label1";
            this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 472);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpPlacetoeat);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.gbtopping);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.labMainOne);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbtopping.ResumeLayout(false);
            this.gbtopping.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gpPlacetoeat.ResumeLayout(false);
            this.gpPlacetoeat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMainOne;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbbSmall;
        private System.Windows.Forms.GroupBox gbtopping;
        private System.Windows.Forms.CheckBox chkGreenPrppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatose;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.RadioButton rbthinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.GroupBox gpPlacetoeat;
        private System.Windows.Forms.RadioButton rbtakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labTopping;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblWhereToeat;
        private System.Windows.Forms.Label lblcurstType;
    }
}

