using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LuaTT_Code_Generator
{
    public partial class Form1 : Form
    {
        // Excoluss's LuaTT Code Generator v1.0
        // Created by ExcolussTheGreat COPYRIGHT (C) 2020-2022 
        private string header, luaType, ToSave, footer, ToAddTo, text;

        private void btnAddTo1_Click(object sender, EventArgs e)
        {
            if (cmbVeh.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Vehicle' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbVeh.Focus();
            }
            else if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "X = 10*math.cos(Get_Facing(Get_GameObj(pID))*(math.pi / 180))" + Environment.NewLine + Tab + Tab + Tab + "Y = 10*math.sin(Get_Facing(Get_GameObj(pID))*(math.pi / 180))" + Environment.NewLine + Tab + Tab + Tab + "local pos2 = Vector3(X+pos:GetX(), Y+pos:GetY(), pos:GetZ()+3)" + Environment.NewLine + Tab + Tab + Tab + "local veh = Create_Object(\"" + cmbVeh.SelectedItem + "\", pos2)" + Environment.NewLine + Tab + Tab + Tab + "Set_Facing(veh, Get_Facing(Get_GameObj(pID))-180)" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void radChar_CheckedChanged(object sender, EventArgs e)
        {
            if (radChar.Checked == true)
            {
                cmbChar.Visible = true;
                cmbChar.Enabled = true;
                // enable add to code
                btnAddTo2.Enabled = true;
                btnAddTo2.Visible = true;
            }
            if (radChar.Checked == false)
            {
                cmbChar.Visible = false;
                cmbChar.Enabled = false;
                // disable add to code
                btnAddTo2.Enabled = false;
                btnAddTo2.Visible = false;
            }
        }

        private void btnAddTo2_Click(object sender, EventArgs e)
        {
            if (cmbChar.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Character' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbChar.Focus();
            }
            else if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "Change_Character(Get_GameObj(pID), \"" + cmbChar.SelectedItem + "\")" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void radCharandWeap_CheckedChanged(object sender, EventArgs e)
        {
            if (radCharandWeap.Checked == true)
            {
                cmbWeap.Visible = true;
                cmbWeap.Enabled = true;
                cmbChar.Visible = true;
                cmbChar.Enabled = true;
                // enable add to code
                btnAddTo3.Enabled = true;
                btnAddTo3.Visible = true;
            }
            if (radCharandWeap.Checked == false)
            {
                cmbWeap.Visible = false;
                cmbWeap.Enabled = false;
                cmbChar.Visible = false;
                cmbChar.Enabled = false;
                // disable add to code
                btnAddTo3.Enabled = false;
                btnAddTo3.Visible = false;
            }
        }

        private void btnAddTo3_Click(object sender, EventArgs e)
        {
            if (cmbChar.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Character' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbChar.Focus();
            }
            else if (cmbWeap.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Weapon' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbWeap.Focus();
            }
            else if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "Change_Character(Get_GameObj(pID), \"" + cmbChar.SelectedItem + "\")" + Environment.NewLine + Tab + Tab + Tab + "Grant_Weapon(Get_GameObj(pID), \"" + cmbWeap.SelectedItem + "\", true, 999, false)" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void radWeap_CheckedChanged(object sender, EventArgs e)
        {
            if (radWeap.Checked == true)
            {
                cmbWeap.Visible = true;
                cmbWeap.Enabled = true;
                // enable add to code
                btnAddTo3.Enabled = true;
                btnAddTo3.Visible = true;
            }
            if (radWeap.Checked == false)
            {
                cmbWeap.Visible = false;
                cmbWeap.Enabled = false;
                // disable add to code
                btnAddTo3.Enabled = false;
                btnAddTo3.Visible = false;
            }
        }

        private void btnAddTo4_Click(object sender, EventArgs e)
        {
            if (cmbWeap.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Weapon' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbWeap.Focus();
            }
            else if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "Grant_Weapon(Get_GameObj(pID), \"" + cmbWeap.SelectedItem + "\", true, 999, false)" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void radVehandWeap_CheckedChanged(object sender, EventArgs e)
        {
            if (radVehandWeap.Checked == true)
            {
                cmbWeap.Visible = true;
                cmbWeap.Enabled = true;
                cmbVeh.Visible = true;
                cmbVeh.Enabled = true;
                // enable add to code
                btnAddTo5.Enabled = true;
                btnAddTo5.Visible = true;
            }
            if (radVehandWeap.Checked == false)
            {
                cmbWeap.Visible = false;
                cmbWeap.Enabled = false;
                cmbVeh.Visible = false;
                cmbVeh.Enabled = false;
                // disable add to code
                btnAddTo5.Enabled = false;
                btnAddTo5.Visible = false;
            }
        }

        private void btnAddTo5_Click(object sender, EventArgs e)
        {
            if (cmbVeh.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Vehicle' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbVeh.Focus();
            }
            else if (cmbWeap.SelectedItem == null)
            {
                MessageBox.Show("Please select a preset type from the 'Weapon' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbWeap.Focus();
            }
            else if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "X = 10*math.cos(Get_Facing(Get_GameObj(pID))*(math.pi / 180))" + Environment.NewLine + Tab + Tab + Tab + "Y = 10*math.sin(Get_Facing(Get_GameObj(pID))*(math.pi / 180))" + Environment.NewLine + Tab + Tab + Tab + "local pos2 = Vector3(X+pos:GetX(), Y+pos:GetY(), pos:GetZ()+3)" + Environment.NewLine + Tab + Tab + Tab + "local veh = Create_Object(\"" + cmbVeh.SelectedItem + "\", pos2)" + Environment.NewLine + Tab + Tab + Tab + "Grant_Weapon(veh, \"" + cmbWeap.SelectedItem + "\", true, 999, false)" + Environment.NewLine + Tab + Tab + Tab + "Select_Weapon(veh, \"" + cmbWeap.SelectedItem + "\")" + Environment.NewLine + Tab + Tab + Tab + "Set_Facing(veh, Get_Facing(Get_GameObj(pID))-180)" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void radRefill_CheckedChanged(object sender, EventArgs e)
        {
            if (radRefill.Checked == true)
            {
                btnAddTo6.Enabled = true;
                btnAddTo6.Visible = true;
            }
            if (radRefill.Checked == false)
            {
                btnAddTo6.Enabled = false;
                btnAddTo6.Visible = false;
            }
        }

        private void btnAddTo6_Click(object sender, EventArgs e)
        {
            if (cmbPerMType.SelectedItem == null)
            {
                MessageBox.Show("Please select a message type from the 'Message Type' box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPerMType.Focus();
            }
            else
            {
                switch (cmbPerMType.SelectedIndex)
                {
                    case 0:
                        {
                            PerMsgType = "page";
                            break;
                        }

                    case 1:
                        {
                            PerMsgType = "pamsg";
                            break;
                        }

                    case 2:
                        {
                            PerMsgType = "ppage";
                            break;
                        }
                }
                ToAddTo = ToAddTo + Tab + "if Message == \"" + txtCommand.Text + "\" then" + Environment.NewLine + Tab + Tab + "if Get_Money(pID) < " + txtCost.Text + " then" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"" + PerMsgType + " %d " + txtPerM1.Text + " " + txtCost.Text + " " + txtPerM2.Text + "\", pID))" + Environment.NewLine + Tab + Tab + "else" + Environment.NewLine + Tab + Tab + Tab + "local pos = Get_Position(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "Grant_Refill(Get_GameObj(pID))" + Environment.NewLine + Tab + Tab + Tab + "Grant_Powerup(Get_GameObj(pID), \"CnC_POW_Ammo_ClipMax\")" + Environment.NewLine + Tab + Tab + Tab + "Set_Money(pID, Get_Money(pID)-" + txtCost.Text + ")" + Environment.NewLine + Tab + Tab + Tab + "Console_Input(string.format(\"msg %s " + txtSay.Text + "\", Get_Player_Name_By_ID(pID)))" + Environment.NewLine + Tab + Tab + "end" + Environment.NewLine + Tab + "end" + Environment.NewLine;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Invalid File Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                FolderBrowserDialog1.Description = "Select a Folder to Save: " + txtFileName.Text + ".lua to.";
                header = "--Lua file generated by: Excoluss's LuaTT Creator v1.0" + Environment.NewLine + "--Very handy program for lua programmers." + Environment.NewLine + Environment.NewLine + "function OnChat(pID, Type, Message, Target)" + Environment.NewLine + Environment.NewLine;
                footer = Tab + "return 1;" + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + Environment.NewLine + "function OnPlayerJoin(pID, Nick)" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnPlayerLeave(pID)" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnHostMessage(ID, Type, Message)" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnLevelLoaded()" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnLevelEnded()" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnConsoleOutput(Message)" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnDDERecived(Message)" + Environment.NewLine + Environment.NewLine + "end" + Environment.NewLine + Environment.NewLine + "function OnObjectCreate(Object)" + Environment.NewLine + Environment.NewLine + "end";
                ToSave = header + ToAddTo + footer;
                if (radV4.Checked == true)
                    File.WriteAllText(FolderBrowserDialog1.SelectedPath + @"\" + txtFileName.Text + ".lua", ToSave);
                if (radV5.Checked == true)
                    File.WriteAllText(FolderBrowserDialog1.SelectedPath + @"\" + txtFileName.Text + ".lua", ToSave);
                if (radV3.Checked == true)
                    File.WriteAllText(FolderBrowserDialog1.SelectedPath + @"\" + txtFileName.Text + ".lua", ToSave);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radVeh_CheckedChanged(object sender, EventArgs e)
        {
            if (radVeh.Checked == true)
            {
                cmbVeh.Visible = true;
                cmbVeh.Enabled = true;
                // enable add to code
                btnAddTo1.Enabled = true;
                btnAddTo1.Visible = true;
            }
            if (radVeh.Checked == false)
            {
                cmbVeh.Visible = false;
                cmbVeh.Enabled = false;
                // disable add to code
                btnAddTo1.Enabled = false;
                btnAddTo1.Visible = false;
            }
        }
        private string Tab = "    ";
        private string PerMsgType;
    }
}
