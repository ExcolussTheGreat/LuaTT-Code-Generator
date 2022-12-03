namespace LuaTT_Code_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radV5 = new System.Windows.Forms.RadioButton();
            this.radV3 = new System.Windows.Forms.RadioButton();
            this.radV4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radRefill = new System.Windows.Forms.RadioButton();
            this.radVehandWeap = new System.Windows.Forms.RadioButton();
            this.radCharandWeap = new System.Windows.Forms.RadioButton();
            this.radWeap = new System.Windows.Forms.RadioButton();
            this.radChar = new System.Windows.Forms.RadioButton();
            this.radVeh = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cmbWeap = new System.Windows.Forms.ComboBox();
            this.cmbChar = new System.Windows.Forms.ComboBox();
            this.cmbVeh = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSay = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCost2 = new System.Windows.Forms.TextBox();
            this.txtPerM2 = new System.Windows.Forms.TextBox();
            this.txtPerM1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.cmbPerMType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnAddTo5 = new System.Windows.Forms.Button();
            this.btnAddTo4 = new System.Windows.Forms.Button();
            this.btnAddTo3 = new System.Windows.Forms.Button();
            this.btnAddTo2 = new System.Windows.Forms.Button();
            this.btnAddTo1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddTo6 = new System.Windows.Forms.Button();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(638, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCommand);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 41);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Command name:";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(98, 14);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(243, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "!command";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(187, 24);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(283, 29);
            this.Label1.TabIndex = 99;
            this.Label1.Text = "LuaTT Code Generator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radV5);
            this.groupBox1.Controls.Add(this.radV3);
            this.groupBox1.Controls.Add(this.radV4);
            this.groupBox1.Location = new System.Drawing.Point(140, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 49);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LuaTT version:";
            // 
            // radV5
            // 
            this.radV5.AutoSize = true;
            this.radV5.Checked = true;
            this.radV5.Location = new System.Drawing.Point(265, 22);
            this.radV5.Margin = new System.Windows.Forms.Padding(6);
            this.radV5.Name = "radV5";
            this.radV5.Size = new System.Drawing.Size(38, 17);
            this.radV5.TabIndex = 78;
            this.radV5.TabStop = true;
            this.radV5.Text = "V5";
            this.radV5.UseVisualStyleBackColor = true;
            // 
            // radV3
            // 
            this.radV3.AutoSize = true;
            this.radV3.Location = new System.Drawing.Point(85, 22);
            this.radV3.Margin = new System.Windows.Forms.Padding(6);
            this.radV3.Name = "radV3";
            this.radV3.Size = new System.Drawing.Size(38, 17);
            this.radV3.TabIndex = 80;
            this.radV3.Text = "V3";
            this.radV3.UseVisualStyleBackColor = true;
            // 
            // radV4
            // 
            this.radV4.AutoSize = true;
            this.radV4.Location = new System.Drawing.Point(175, 22);
            this.radV4.Margin = new System.Windows.Forms.Padding(6);
            this.radV4.Name = "radV4";
            this.radV4.Size = new System.Drawing.Size(38, 17);
            this.radV4.TabIndex = 79;
            this.radV4.Text = "V4";
            this.radV4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radRefill);
            this.groupBox4.Controls.Add(this.radVehandWeap);
            this.groupBox4.Controls.Add(this.radCharandWeap);
            this.groupBox4.Controls.Add(this.radWeap);
            this.groupBox4.Controls.Add(this.radChar);
            this.groupBox4.Controls.Add(this.radVeh);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 164);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 2:";
            // 
            // radRefill
            // 
            this.radRefill.AutoSize = true;
            this.radRefill.Location = new System.Drawing.Point(6, 134);
            this.radRefill.Name = "radRefill";
            this.radRefill.Size = new System.Drawing.Size(73, 17);
            this.radRefill.TabIndex = 0;
            this.radRefill.Text = "Give Refill";
            this.radRefill.UseVisualStyleBackColor = true;
            this.radRefill.CheckedChanged += new System.EventHandler(this.radRefill_CheckedChanged);
            // 
            // radVehandWeap
            // 
            this.radVehandWeap.AutoSize = true;
            this.radVehandWeap.Location = new System.Drawing.Point(6, 111);
            this.radVehandWeap.Name = "radVehandWeap";
            this.radVehandWeap.Size = new System.Drawing.Size(150, 17);
            this.radVehandWeap.TabIndex = 0;
            this.radVehandWeap.Text = "Give Vehicle and Weapon";
            this.radVehandWeap.UseVisualStyleBackColor = true;
            this.radVehandWeap.CheckedChanged += new System.EventHandler(this.radVehandWeap_CheckedChanged);
            // 
            // radCharandWeap
            // 
            this.radCharandWeap.AutoSize = true;
            this.radCharandWeap.Location = new System.Drawing.Point(6, 65);
            this.radCharandWeap.Name = "radCharandWeap";
            this.radCharandWeap.Size = new System.Drawing.Size(161, 17);
            this.radCharandWeap.TabIndex = 0;
            this.radCharandWeap.Text = "Give Character and Weapon";
            this.radCharandWeap.UseVisualStyleBackColor = true;
            this.radCharandWeap.CheckedChanged += new System.EventHandler(this.radCharandWeap_CheckedChanged);
            // 
            // radWeap
            // 
            this.radWeap.AutoSize = true;
            this.radWeap.Location = new System.Drawing.Point(6, 88);
            this.radWeap.Name = "radWeap";
            this.radWeap.Size = new System.Drawing.Size(91, 17);
            this.radWeap.TabIndex = 0;
            this.radWeap.Text = "Give Weapon";
            this.radWeap.UseVisualStyleBackColor = true;
            this.radWeap.CheckedChanged += new System.EventHandler(this.radWeap_CheckedChanged);
            // 
            // radChar
            // 
            this.radChar.AutoSize = true;
            this.radChar.Location = new System.Drawing.Point(7, 42);
            this.radChar.Name = "radChar";
            this.radChar.Size = new System.Drawing.Size(96, 17);
            this.radChar.TabIndex = 0;
            this.radChar.Text = "Give Character";
            this.radChar.UseVisualStyleBackColor = true;
            this.radChar.CheckedChanged += new System.EventHandler(this.radChar_CheckedChanged);
            // 
            // radVeh
            // 
            this.radVeh.AutoSize = true;
            this.radVeh.Location = new System.Drawing.Point(6, 19);
            this.radVeh.Name = "radVeh";
            this.radVeh.Size = new System.Drawing.Size(85, 17);
            this.radVeh.TabIndex = 0;
            this.radVeh.Text = "Give Vehicle";
            this.radVeh.UseVisualStyleBackColor = true;
            this.radVeh.CheckedChanged += new System.EventHandler(this.radVeh_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(219, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 164);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Label7);
            this.groupBox5.Controls.Add(this.txtCost);
            this.groupBox5.Controls.Add(this.cmbWeap);
            this.groupBox5.Controls.Add(this.cmbChar);
            this.groupBox5.Controls.Add(this.cmbVeh);
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 164);
            this.groupBox5.TabIndex = 102;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 3:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(58, 115);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 104;
            this.Label7.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(89, 112);
            this.txtCost.Margin = new System.Windows.Forms.Padding(6);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(53, 20);
            this.txtCost.TabIndex = 105;
            this.txtCost.Text = "0";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbWeap
            // 
            this.cmbWeap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeap.FormattingEnabled = true;
            this.cmbWeap.Items.AddRange(new object[] {
            "Weapon_AutoRifle_Player",
            "Weapon_AutoRifle_Player_Nod",
            "Weapon_Shotgun_Player",
            "Weapon_Flamethrower_Player",
            "Weapon_GrenadeLauncher_Player",
            "Weapon_RepairGun_Player",
            "CnC_Weapon_RepairGun_Player_Special",
            "Weapon_Chaingun_Player",
            "Weapon_Chaingun_Player_Nod",
            "Weapon_RocketLauncher_Player",
            "CnC_Weapon_RocketLauncher_Player",
            "Weapon_ChemSprayer_Player",
            "Weapon_TiberiumAutoRifle_Player",
            "Weapon_SniperRifle_Player",
            "Weapon_LaserChaingun_Player",
            "Weapon_LaserRifle_Player",
            "Weapon_TiberiumFlechetteGun_Player",
            "Weapon_PersonalIonCannon_Player",
            "Weapon_Railgun_Player",
            "Weapon_RamjetRifle_Player",
            "CnC_Weapon_RamjetRifle_Player",
            "Weapon_VoltAutoRifle_Player",
            "Weapon_VoltAutoRifle_Player_Nod",
            "Weapon_MineRemote_Player",
            "Weapon_MineTimed_Player",
            "Weapon_MineProximity_Player",
            "Weapon_IonCannonBeacon_Player",
            "CnC_Weapon_IonCannonBeacon_Player",
            "Weapon_NukeBeacon_Player",
            "CnC_Weapon_NukeBeacon_Player",
            "Weapon_AGT_Missile",
            "MX0_Weapon_Obelisk",
            "Weapon_UltimateWeapon",
            "Weapon_Obelisk"});
            this.cmbWeap.Location = new System.Drawing.Point(5, 73);
            this.cmbWeap.Name = "cmbWeap";
            this.cmbWeap.Size = new System.Drawing.Size(190, 21);
            this.cmbWeap.TabIndex = 87;
            this.cmbWeap.Visible = false;
            // 
            // cmbChar
            // 
            this.cmbChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChar.FormattingEnabled = true;
            this.cmbChar.Items.AddRange(new object[] {
            "CnC_GDI_Engineer_0",
            "CnC_GDI_Engineer_2SF",
            "CnC_GDI_Grenadier_0",
            "CnC_GDI_Grenadier_2SF",
            "CnC_Ignatio_Mobius",
            "CnC_Ignatio_Mobius_ALT2",
            "CnC_GDI_MiniGunner_0",
            "CnC_GDI_MiniGunner_1Off",
            "CnC_GDI_MiniGunner_2SF",
            "CnC_GDI_MiniGunner_3Boss",
            "CnC_GDI_MiniGunner_3Boss_ALT2",
            "CnC_GDI_MiniGunner_3Boss_ALT3",
            "CnC_GDI_MiniGunner_3Boss_ALT4",
            "CnC_GDI_RocketSoldier_0",
            "CnC_GDI_RocketSoldier_1Off",
            "CnC_GDI_RocketSoldier_2SF",
            "CnC_Sydney_PowerSuit",
            "CnC_Sydney_PowerSuit_ALT2",
            "CnC_Sydney",
            "CnC_Nod_Engineer_0",
            "CnC_Nod_FlameThrower_0",
            "CnC_Nod_FlameThrower_1Off",
            "CnC_Nod_FlameThrower_2SF",
            "CnC_Nod_FlameThrower_3Boss",
            "CnC_Nod_FlameThrower_3Boss_ALT2",
            "CnC_Nod_Minigunner_0",
            "CnC_Nod_Minigunner_1Off",
            "CnC_Nod_Minigunner_2SF",
            "CnC_Nod_Minigunner_3Boss",
            "CnC_Nod_MiniGunner_3Boss_ALT2",
            "CnC_Nod_RocketSoldier_0",
            "CnC_Nod_RocketSoldier_1Off",
            "CnC_Nod_RocketSoldier_2SF",
            "CnC_Nod_RocketSoldier_3Boss",
            "CnC_Nod_RocketSoldier_3Boss_ALT2",
            "CnC_Nod_Technician_0",
            "Walk-Thru",
            "CnC_Visceroid"});
            this.cmbChar.Location = new System.Drawing.Point(6, 46);
            this.cmbChar.Name = "cmbChar";
            this.cmbChar.Size = new System.Drawing.Size(189, 21);
            this.cmbChar.TabIndex = 86;
            this.cmbChar.Visible = false;
            // 
            // cmbVeh
            // 
            this.cmbVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Items.AddRange(new object[] {
            "CnC_GDI_APC",
            "CnC_GDI_Humm-vee",
            "CnC_GDI_Mammoth_Tank",
            "CnC_GDI_Medium_Tank",
            "CnC_GDI_MRLS",
            "CnC_GDI_Orca",
            "CnC_GDI_Transport",
            "CnC_Civilian_Pickup01_Secret",
            "CnC_Civilian_Sedan01_Secret",
            "CnC_Nod_Apache",
            "CnC_Nod_APC",
            "CnC_Nod_Buggy",
            "CnC_Nod_Flame_Tank",
            "CnC_Nod_Light_Tank",
            "CnC_Nod_Mobile_Artillery",
            "CnC_Nod_Recon_Bike",
            "CnC_Nod_Stealth_Tank",
            "CnC_Nod_Transport",
            "Nod_SSM_Launcher_Player",
            "Nod_Chameleon"});
            this.cmbVeh.Location = new System.Drawing.Point(6, 19);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(189, 21);
            this.cmbVeh.TabIndex = 85;
            this.cmbVeh.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(426, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(201, 164);
            this.groupBox6.TabIndex = 103;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "for creating LuaTT Code Generator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Credit for ExcolussTheGreat";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSay);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.txtCost2);
            this.groupBox7.Controls.Add(this.txtPerM2);
            this.groupBox7.Controls.Add(this.txtPerM1);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.Label8);
            this.groupBox7.Controls.Add(this.cmbPerMType);
            this.groupBox7.Location = new System.Drawing.Point(97, 354);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(451, 59);
            this.groupBox7.TabIndex = 104;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Step 4:";
            // 
            // txtSay
            // 
            this.txtSay.Location = new System.Drawing.Point(136, 32);
            this.txtSay.Margin = new System.Windows.Forms.Padding(6);
            this.txtSay.Name = "txtSay";
            this.txtSay.Size = new System.Drawing.Size(296, 20);
            this.txtSay.TabIndex = 86;
            this.txtSay.Text = "Has bought a <Put Item Name here>.";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(111, 32);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(19, 20);
            this.textBox5.TabIndex = 86;
            this.textBox5.Text = "%s";
            // 
            // txtCost2
            // 
            this.txtCost2.Location = new System.Drawing.Point(285, 9);
            this.txtCost2.Name = "txtCost2";
            this.txtCost2.Size = new System.Drawing.Size(40, 20);
            this.txtCost2.TabIndex = 87;
            this.txtCost2.Text = "0";
            // 
            // txtPerM2
            // 
            this.txtPerM2.Location = new System.Drawing.Point(331, 9);
            this.txtPerM2.Name = "txtPerM2";
            this.txtPerM2.Size = new System.Drawing.Size(101, 20);
            this.txtPerM2.TabIndex = 87;
            this.txtPerM2.Text = "Credits to buy this!";
            // 
            // txtPerM1
            // 
            this.txtPerM1.Location = new System.Drawing.Point(198, 8);
            this.txtPerM1.Name = "txtPerM1";
            this.txtPerM1.Size = new System.Drawing.Size(81, 20);
            this.txtPerM1.TabIndex = 87;
            this.txtPerM1.Text = "You need";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Then say:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(48, 12);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 13);
            this.Label8.TabIndex = 87;
            this.Label8.Text = "Then say:";
            // 
            // cmbPerMType
            // 
            this.cmbPerMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerMType.FormattingEnabled = true;
            this.cmbPerMType.Items.AddRange(new object[] {
            "Personal Message",
            "Admin Message",
            "Page Player"});
            this.cmbPerMType.Location = new System.Drawing.Point(111, 8);
            this.cmbPerMType.Name = "cmbPerMType";
            this.cmbPerMType.Size = new System.Drawing.Size(81, 21);
            this.cmbPerMType.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(501, 488);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = ".lua";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(161, 485);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(340, 20);
            this.txtFileName.TabIndex = 110;
            this.txtFileName.Text = "example";
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 517);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 37);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "Save to LUA file";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnAddTo6);
            this.groupBox8.Controls.Add(this.btnAddTo5);
            this.groupBox8.Controls.Add(this.btnAddTo4);
            this.groupBox8.Controls.Add(this.btnAddTo3);
            this.groupBox8.Controls.Add(this.btnAddTo2);
            this.groupBox8.Controls.Add(this.btnAddTo1);
            this.groupBox8.Location = new System.Drawing.Point(192, 432);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(273, 44);
            this.groupBox8.TabIndex = 108;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Step 5:";
            // 
            // btnAddTo5
            // 
            this.btnAddTo5.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo5.Name = "btnAddTo5";
            this.btnAddTo5.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo5.TabIndex = 1;
            this.btnAddTo5.Text = "Add to Code";
            this.btnAddTo5.UseVisualStyleBackColor = true;
            this.btnAddTo5.Visible = false;
            this.btnAddTo5.Click += new System.EventHandler(this.btnAddTo5_Click);
            // 
            // btnAddTo4
            // 
            this.btnAddTo4.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo4.Name = "btnAddTo4";
            this.btnAddTo4.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo4.TabIndex = 97;
            this.btnAddTo4.Text = "Add to Code";
            this.btnAddTo4.UseVisualStyleBackColor = true;
            this.btnAddTo4.Visible = false;
            this.btnAddTo4.Click += new System.EventHandler(this.btnAddTo4_Click);
            // 
            // btnAddTo3
            // 
            this.btnAddTo3.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo3.Name = "btnAddTo3";
            this.btnAddTo3.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo3.TabIndex = 96;
            this.btnAddTo3.Text = "Add to Code";
            this.btnAddTo3.UseVisualStyleBackColor = true;
            this.btnAddTo3.Visible = false;
            this.btnAddTo3.Click += new System.EventHandler(this.btnAddTo3_Click);
            // 
            // btnAddTo2
            // 
            this.btnAddTo2.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo2.Name = "btnAddTo2";
            this.btnAddTo2.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo2.TabIndex = 95;
            this.btnAddTo2.Text = "Add to Code";
            this.btnAddTo2.UseVisualStyleBackColor = true;
            this.btnAddTo2.Visible = false;
            this.btnAddTo2.Click += new System.EventHandler(this.btnAddTo2_Click);
            // 
            // btnAddTo1
            // 
            this.btnAddTo1.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo1.Name = "btnAddTo1";
            this.btnAddTo1.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo1.TabIndex = 94;
            this.btnAddTo1.Text = "Add to Code";
            this.btnAddTo1.UseVisualStyleBackColor = true;
            this.btnAddTo1.Visible = false;
            this.btnAddTo1.Click += new System.EventHandler(this.btnAddTo1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 488);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "File Name:";
            // 
            // btnAddTo6
            // 
            this.btnAddTo6.Location = new System.Drawing.Point(92, 9);
            this.btnAddTo6.Name = "btnAddTo6";
            this.btnAddTo6.Size = new System.Drawing.Size(87, 29);
            this.btnAddTo6.TabIndex = 113;
            this.btnAddTo6.Text = "Add to Code";
            this.btnAddTo6.UseVisualStyleBackColor = true;
            this.btnAddTo6.Visible = false;
            this.btnAddTo6.Click += new System.EventHandler(this.btnAddTo6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 563);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LuaTT Code Generator";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radV5;
        private System.Windows.Forms.RadioButton radV3;
        private System.Windows.Forms.RadioButton radV4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radRefill;
        private System.Windows.Forms.RadioButton radVehandWeap;
        private System.Windows.Forms.RadioButton radCharandWeap;
        private System.Windows.Forms.RadioButton radWeap;
        private System.Windows.Forms.RadioButton radChar;
        private System.Windows.Forms.RadioButton radVeh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbChar;
        private System.Windows.Forms.ComboBox cmbVeh;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cmbWeap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.TextBox txtSay;
        internal System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtCost2;
        private System.Windows.Forms.TextBox txtPerM2;
        private System.Windows.Forms.TextBox txtPerM1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.ComboBox cmbPerMType;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox8;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddTo1;
        private System.Windows.Forms.Button btnAddTo2;
        private System.Windows.Forms.Button btnAddTo3;
        private System.Windows.Forms.Button btnAddTo4;
        private System.Windows.Forms.Button btnAddTo5;
        private System.Windows.Forms.Button btnAddTo6;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
    }
}

