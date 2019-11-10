namespace GUIApp1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtData_RecTxt = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnMovePrev = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.lblHeader_RecID = new System.Windows.Forms.Label();
            this.lblData_RecID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader_Stat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(262, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Tag = "Edit";
            this.btnSave.Text = "Edit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtData_RecTxt
            // 
            this.txtData_RecTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData_RecTxt.Enabled = false;
            this.txtData_RecTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData_RecTxt.Location = new System.Drawing.Point(113, 60);
            this.txtData_RecTxt.Multiline = true;
            this.txtData_RecTxt.Name = "txtData_RecTxt";
            this.txtData_RecTxt.Size = new System.Drawing.Size(258, 28);
            this.txtData_RecTxt.TabIndex = 1;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditCancel.Location = new System.Drawing.Point(319, 119);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(66, 23);
            this.btnEditCancel.TabIndex = 3;
            this.btnEditCancel.Tag = "Ok";
            this.btnEditCancel.Text = "Ok";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovePrev.Location = new System.Drawing.Point(69, 119);
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.Size = new System.Drawing.Size(29, 23);
            this.btnMovePrev.TabIndex = 4;
            this.btnMovePrev.Tag = "<";
            this.btnMovePrev.Text = "<";
            this.btnMovePrev.UseVisualStyleBackColor = true;
            this.btnMovePrev.Click += new System.EventHandler(this.btnMovePrev_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveFirst.Location = new System.Drawing.Point(34, 119);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(29, 23);
            this.btnMoveFirst.TabIndex = 5;
            this.btnMoveFirst.Tag = "<<";
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveLast.Location = new System.Drawing.Point(224, 119);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(29, 23);
            this.btnMoveLast.TabIndex = 7;
            this.btnMoveLast.Tag = ">>";
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveNext.Location = new System.Drawing.Point(189, 119);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(29, 23);
            this.btnMoveNext.TabIndex = 6;
            this.btnMoveNext.Tag = ">";
            this.btnMoveNext.Text = ">";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // lblHeader_RecID
            // 
            this.lblHeader_RecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader_RecID.Location = new System.Drawing.Point(32, 31);
            this.lblHeader_RecID.Name = "lblHeader_RecID";
            this.lblHeader_RecID.Size = new System.Drawing.Size(75, 26);
            this.lblHeader_RecID.TabIndex = 8;
            this.lblHeader_RecID.Text = "Record ID:";
            this.lblHeader_RecID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblData_RecID
            // 
            this.lblData_RecID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblData_RecID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData_RecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_RecID.ForeColor = System.Drawing.Color.Lime;
            this.lblData_RecID.Location = new System.Drawing.Point(113, 31);
            this.lblData_RecID.Name = "lblData_RecID";
            this.lblData_RecID.Size = new System.Drawing.Size(80, 26);
            this.lblData_RecID.TabIndex = 9;
            this.lblData_RecID.Text = "0";
            this.lblData_RecID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Record Data:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader_Stat
            // 
            this.lblHeader_Stat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHeader_Stat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader_Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader_Stat.Location = new System.Drawing.Point(105, 119);
            this.lblHeader_Stat.Name = "lblHeader_Stat";
            this.lblHeader_Stat.Size = new System.Drawing.Size(78, 23);
            this.lblHeader_Stat.TabIndex = 11;
            this.lblHeader_Stat.Text = "1 of 1";
            this.lblHeader_Stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 154);
            this.Controls.Add(this.lblHeader_Stat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData_RecID);
            this.Controls.Add(this.lblHeader_RecID);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.btnMovePrev);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.txtData_RecTxt);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Record Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtData_RecTxt;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnMovePrev;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Label lblHeader_RecID;
        private System.Windows.Forms.Label lblData_RecID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader_Stat;
    }
}

