namespace Food_Tracking_System
{
    partial class application
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.personal_info = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.combo_activity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Calories_Macros = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_targetWeight = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCaloriesTotal = new System.Windows.Forms.TextBox();
            this.plan = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbLose = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbGain = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.personal_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Calories_Macros.SuspendLayout();
            this.gb_targetWeight.SuspendLayout();
            this.plan.SuspendLayout();
            this.gbLose.SuspendLayout();
            this.gbGain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(283, 36);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(416, 37);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome To Food System";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.personal_info);
            this.tabs.Controls.Add(this.Calories_Macros);
            this.tabs.Controls.Add(this.plan);
            this.tabs.Location = new System.Drawing.Point(9, 106);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(880, 369);
            this.tabs.TabIndex = 1;
            // 
            // personal_info
            // 
            this.personal_info.BackColor = System.Drawing.Color.Silver;
            this.personal_info.BackgroundImage = global::Food_Tracking_System.Properties.Resources.login_back;
            this.personal_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personal_info.Controls.Add(this.label18);
            this.personal_info.Controls.Add(this.txt_lname);
            this.personal_info.Controls.Add(this.groupBox1);
            this.personal_info.Controls.Add(this.combo_activity);
            this.personal_info.Controls.Add(this.label6);
            this.personal_info.Controls.Add(this.button1);
            this.personal_info.Controls.Add(this.txt_age);
            this.personal_info.Controls.Add(this.txt_weight);
            this.personal_info.Controls.Add(this.txt_height);
            this.personal_info.Controls.Add(this.label5);
            this.personal_info.Controls.Add(this.label4);
            this.personal_info.Controls.Add(this.label3);
            this.personal_info.Controls.Add(this.label2);
            this.personal_info.Controls.Add(this.txt_fname);
            this.personal_info.Controls.Add(this.label1);
            this.personal_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_info.Location = new System.Drawing.Point(4, 22);
            this.personal_info.Margin = new System.Windows.Forms.Padding(2);
            this.personal_info.Name = "personal_info";
            this.personal_info.Padding = new System.Windows.Forms.Padding(2);
            this.personal_info.Size = new System.Drawing.Size(872, 343);
            this.personal_info.TabIndex = 0;
            this.personal_info.Text = "Personal information";
            this.personal_info.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(15, 56);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Enter your LastName";
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(142, 56);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(120, 19);
            this.txt_lname.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Location = new System.Drawing.Point(124, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.Location = new System.Drawing.Point(26, 17);
            this.radioMale.Margin = new System.Windows.Forms.Padding(2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 21);
            this.radioMale.TabIndex = 9;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.Location = new System.Drawing.Point(105, 17);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(78, 21);
            this.radioFemale.TabIndex = 10;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // combo_activity
            // 
            this.combo_activity.FormattingEnabled = true;
            this.combo_activity.Items.AddRange(new object[] {
            "Sedentary",
            "Lightly active",
            "Moderately active ",
            "Active",
            "Very active "});
            this.combo_activity.Location = new System.Drawing.Point(142, 244);
            this.combo_activity.Margin = new System.Windows.Forms.Padding(2);
            this.combo_activity.Name = "combo_activity";
            this.combo_activity.Size = new System.Drawing.Size(120, 21);
            this.combo_activity.TabIndex = 13;
            this.combo_activity.SelectedIndexChanged += new System.EventHandler(this.combo_activity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Your Activity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(673, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 81);
            this.button1.TabIndex = 11;
            this.button1.Text = "Press Here To Get Your Calories";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(142, 193);
            this.txt_age.Margin = new System.Windows.Forms.Padding(2);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(120, 19);
            this.txt_age.TabIndex = 8;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(142, 139);
            this.txt_weight.Margin = new System.Windows.Forms.Padding(2);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(120, 19);
            this.txt_weight.TabIndex = 7;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(142, 90);
            this.txt_height.Margin = new System.Windows.Forms.Padding(2);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(120, 19);
            this.txt_height.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter your gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter your age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter your weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your height";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(142, 21);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(120, 19);
            this.txt_fname.TabIndex = 1;
            this.txt_fname.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your FirstName";
            // 
            // Calories_Macros
            // 
            this.Calories_Macros.BackColor = System.Drawing.Color.Silver;
            this.Calories_Macros.BackgroundImage = global::Food_Tracking_System.Properties.Resources.caloriesAndMacros;
            this.Calories_Macros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calories_Macros.Controls.Add(this.button2);
            this.Calories_Macros.Controls.Add(this.gb_targetWeight);
            this.Calories_Macros.Controls.Add(this.label8);
            this.Calories_Macros.Controls.Add(this.label7);
            this.Calories_Macros.Controls.Add(this.textCaloriesTotal);
            this.Calories_Macros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calories_Macros.Location = new System.Drawing.Point(4, 22);
            this.Calories_Macros.Margin = new System.Windows.Forms.Padding(2);
            this.Calories_Macros.Name = "Calories_Macros";
            this.Calories_Macros.Padding = new System.Windows.Forms.Padding(2);
            this.Calories_Macros.Size = new System.Drawing.Size(872, 343);
            this.Calories_Macros.TabIndex = 1;
            this.Calories_Macros.Text = "Calories And Macros";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Food_Tracking_System.Properties.Resources.caloriesAndMacros1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(744, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Generate Target Calories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // gb_targetWeight
            // 
            this.gb_targetWeight.BackColor = System.Drawing.Color.Transparent;
            this.gb_targetWeight.Controls.Add(this.radioButton1);
            this.gb_targetWeight.Controls.Add(this.radioButton2);
            this.gb_targetWeight.Location = new System.Drawing.Point(492, 173);
            this.gb_targetWeight.Margin = new System.Windows.Forms.Padding(2);
            this.gb_targetWeight.Name = "gb_targetWeight";
            this.gb_targetWeight.Padding = new System.Windows.Forms.Padding(2);
            this.gb_targetWeight.Size = new System.Drawing.Size(256, 48);
            this.gb_targetWeight.TabIndex = 15;
            this.gb_targetWeight.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(13, 17);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gain Weight";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(132, 16);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lose Weight";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(260, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Whats Your Target :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Your Total Amount of Calories To Maintain Weight ";
            // 
            // textCaloriesTotal
            // 
            this.textCaloriesTotal.Location = new System.Drawing.Point(537, 50);
            this.textCaloriesTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textCaloriesTotal.Name = "textCaloriesTotal";
            this.textCaloriesTotal.ReadOnly = true;
            this.textCaloriesTotal.Size = new System.Drawing.Size(149, 19);
            this.textCaloriesTotal.TabIndex = 0;
            // 
            // plan
            // 
            this.plan.BackColor = System.Drawing.Color.Silver;
            this.plan.BackgroundImage = global::Food_Tracking_System.Properties.Resources.plan;
            this.plan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plan.Controls.Add(this.btn_exit);
            this.plan.Controls.Add(this.gbLose);
            this.plan.Controls.Add(this.gbGain);
            this.plan.Controls.Add(this.textBox1);
            this.plan.Controls.Add(this.label9);
            this.plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plan.Location = new System.Drawing.Point(4, 22);
            this.plan.Margin = new System.Windows.Forms.Padding(2);
            this.plan.Name = "plan";
            this.plan.Padding = new System.Windows.Forms.Padding(2);
            this.plan.Size = new System.Drawing.Size(872, 343);
            this.plan.TabIndex = 2;
            this.plan.Text = "Plan";
            this.plan.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(772, 271);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 62);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gbLose
            // 
            this.gbLose.BackColor = System.Drawing.Color.White;
            this.gbLose.Controls.Add(this.label14);
            this.gbLose.Controls.Add(this.label15);
            this.gbLose.Controls.Add(this.label16);
            this.gbLose.Controls.Add(this.label17);
            this.gbLose.Location = new System.Drawing.Point(277, 55);
            this.gbLose.Margin = new System.Windows.Forms.Padding(2);
            this.gbLose.Name = "gbLose";
            this.gbLose.Padding = new System.Windows.Forms.Padding(2);
            this.gbLose.Size = new System.Drawing.Size(296, 223);
            this.gbLose.TabIndex = 3;
            this.gbLose.TabStop = false;
            this.gbLose.Text = "Macros";
            this.gbLose.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 138);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "25% Fats";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 67);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "30% Carbs";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 103);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "45% Proteins";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(276, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "To Lose Weight You Should Follow These Percentages";
            // 
            // gbGain
            // 
            this.gbGain.BackColor = System.Drawing.Color.White;
            this.gbGain.Controls.Add(this.label13);
            this.gbGain.Controls.Add(this.label12);
            this.gbGain.Controls.Add(this.label11);
            this.gbGain.Controls.Add(this.label10);
            this.gbGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGain.Location = new System.Drawing.Point(277, 55);
            this.gbGain.Margin = new System.Windows.Forms.Padding(2);
            this.gbGain.Name = "gbGain";
            this.gbGain.Padding = new System.Windows.Forms.Padding(2);
            this.gbGain.Size = new System.Drawing.Size(296, 223);
            this.gbGain.TabIndex = 2;
            this.gbGain.TabStop = false;
            this.gbGain.Text = "Macros";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "25% Fats";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "30% Proteins";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "45% Carbs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "To Gain Weight You Should Follow These Percentages";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 19);
            this.textBox1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(34, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Your Target Calories is";
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 484);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "application";
            this.Text = "application";
            this.Load += new System.EventHandler(this.application_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.personal_info.ResumeLayout(false);
            this.personal_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Calories_Macros.ResumeLayout(false);
            this.Calories_Macros.PerformLayout();
            this.gb_targetWeight.ResumeLayout(false);
            this.gb_targetWeight.PerformLayout();
            this.plan.ResumeLayout(false);
            this.plan.PerformLayout();
            this.gbLose.ResumeLayout(false);
            this.gbLose.PerformLayout();
            this.gbGain.ResumeLayout(false);
            this.gbGain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage personal_info;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Calories_Macros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_activity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCaloriesTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_targetWeight;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage plan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbGain;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbLose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Button btn_exit;
    }
}