using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp1
{
    public partial class Form1 : Form
    {
        //variables
        private String[] saRecData = new String[10] { "Record One", "Record Two", "Record Three", "Record Four", "Record Five", "Record Six", "Record Seven", "Record Eight", "Record Nine", "Record Ten" };
        private int iCurrentRec = 0;
       
        public Form1()
        {
            //initialFormSetupStuff
            InitializeComponent();
            InitialMain();
        }

        public static int Sum(int num1, int num2)
        {
            //Add to Numbers together
            return num1 + num2;
        }

        private void SaveRecord()
        {
            //Store Edited Text
            this.saRecData[iCurrentRec] = txtData_RecTxt.Text;
        }

        private void EnableNavButtons(bool pTrueFalse)
        {
            //Use control loop to set control properties
            foreach (Control con in this.Controls) {
                if (con is Button)
                {
                    //If type of controll is button and is contains btnMove in the name
                    //then do stuff
                    if (con.Name.Contains("btnMove"))
                    {
                        con.Enabled = pTrueFalse;
                        con.Refresh();
                    }
                }
            } 
        }

        private void NavRecord() {
            //Set the navigation record screen
            lblData_RecID.Text = Sum(this.iCurrentRec, 1).ToString();
            txtData_RecTxt.Text = this.saRecData[iCurrentRec].ToString();
            lblHeader_Stat.Text = lblData_RecID.Text + " of " + saRecData.Count().ToString();
            //update the controls so you can see the changes
            lblHeader_Stat.Refresh();
            lblData_RecID.Refresh();
            txtData_RecTxt.Refresh();
        }
        private void InitialMain()
        {
            //Default state
            this.iCurrentRec = 0;
            this.NavRecord();
            this.EnableNavButtons(true);
        }
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            //Depeneding on button state perform the actions needed (Cancel/Ok)
            switch (btnEditCancel.Tag.ToString())
            {
                case "Cancel":
                    //Reset back to View State
                    btnEditCancel.Text = "Ok";
                    btnEditCancel.Tag = "Ok";
                    btnSave.Text = "Edit";
                    btnSave.Tag = "Edit";
                    txtData_RecTxt.Enabled = false;
                    this.EnableNavButtons(true);
                    //MessageBox.Show("Cancelling Edit Mode", "Action Outcome Popup", MessageBoxButtons.OK);
                    NavRecord();
                    break;
                case "Ok":
                    //Close Application window
                    MessageBox.Show("Ok Closing Program", "Action Outcome Popup", MessageBoxButtons.OK);
                    Application.Exit();
                    break;
            }
            //Refresh Control Buttons
            btnSave.Refresh();
            btnEditCancel.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Depeneding on button state perform the actions needed (Save/Edit)
            switch (btnSave.Tag.ToString())
            {
                case "Save":
                    //Save record return to View State
                    MessageBox.Show("Saving Entry", "Action Outcome Popup", MessageBoxButtons.OK);
                    btnEditCancel.Text = "Ok";
                    btnEditCancel.Tag = "Ok";
                    btnSave.Text = "Edit";
                    btnSave.Tag = "Edit";
                    txtData_RecTxt.Enabled = false;
                    SaveRecord();
                    this.EnableNavButtons(true);
                    break;
                case "Edit":
                    //Change View State to Edit Mode (Disables Nav Buttons and Enabled Edit)
                    btnEditCancel.Text = "Cancel";
                    btnEditCancel.Tag = "Cancel";
                    btnSave.Text = "Save";
                    btnSave.Tag = "Save";
                    this.EnableNavButtons(false);
                    txtData_RecTxt.Enabled = true;
                    //MessageBox.Show("In Edit Mode", "Action Outcome Popup", MessageBoxButtons.OK);
                    break;
            }
            btnSave.Refresh();
            btnEditCancel.Refresh(); 
        }


        private void btnMovePrev_Click(object sender, EventArgs e)
        {
            //Record Nave to Previous Record
            if (this.iCurrentRec > 0)
            { this.iCurrentRec--;}
            else { this.iCurrentRec = 0;}
            this.NavRecord();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            //Record Nave to First Record
            this.iCurrentRec = 0;
            this.NavRecord();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            //Record Nave to Last Record
            this.iCurrentRec = saRecData.Count()-1;
            this.NavRecord();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            //Record Nave to Next Record
            if (this.iCurrentRec < this.saRecData.Count()-1 )
            { this.iCurrentRec++; }
            else { this.iCurrentRec = this.saRecData.Count() - 1; }
            this.NavRecord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //As the form loads setup my defaults and view state
            InitialMain(); 
        }
    }
}
