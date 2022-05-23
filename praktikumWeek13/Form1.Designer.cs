namespace praktikumWeek13
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lID = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lBirth = new System.Windows.Forms.Label();
            this.lNation = new System.Windows.Forms.Label();
            this.lTeam = new System.Windows.Forms.Label();
            this.lTeamNumb = new System.Windows.Forms.Label();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxNation = new System.Windows.Forms.ComboBox();
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.lavailable = new System.Windows.Forms.Label();
            this.numTeamNumb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(111, 39);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(231, 39);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 23);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(379, 39);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(505, 39);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(111, 119);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(62, 16);
            this.lID.TabIndex = 4;
            this.lID.Text = "Player ID";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(111, 159);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(86, 16);
            this.lName.TabIndex = 5;
            this.lName.Text = "Player Name";
            // 
            // lBirth
            // 
            this.lBirth.AutoSize = true;
            this.lBirth.Location = new System.Drawing.Point(111, 198);
            this.lBirth.Name = "lBirth";
            this.lBirth.Size = new System.Drawing.Size(62, 16);
            this.lBirth.TabIndex = 6;
            this.lBirth.Text = "BirthDate";
            // 
            // lNation
            // 
            this.lNation.AutoSize = true;
            this.lNation.Location = new System.Drawing.Point(111, 241);
            this.lNation.Name = "lNation";
            this.lNation.Size = new System.Drawing.Size(70, 16);
            this.lNation.TabIndex = 7;
            this.lNation.Text = "Nationality";
            // 
            // lTeam
            // 
            this.lTeam.AutoSize = true;
            this.lTeam.Location = new System.Drawing.Point(111, 279);
            this.lTeam.Name = "lTeam";
            this.lTeam.Size = new System.Drawing.Size(43, 16);
            this.lTeam.TabIndex = 8;
            this.lTeam.Text = "Team";
            // 
            // lTeamNumb
            // 
            this.lTeamNumb.AutoSize = true;
            this.lTeamNumb.Location = new System.Drawing.Point(111, 318);
            this.lTeamNumb.Name = "lTeamNumb";
            this.lTeamNumb.Size = new System.Drawing.Size(94, 16);
            this.lTeamNumb.TabIndex = 9;
            this.lTeamNumb.Text = "Team Number";
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(273, 112);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(200, 22);
            this.tBoxID.TabIndex = 10;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(273, 153);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(200, 22);
            this.tBoxName.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(273, 191);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 22);
            this.BirthDate.TabIndex = 17;
            // 
            // cBoxNation
            // 
            this.cBoxNation.FormattingEnabled = true;
            this.cBoxNation.Location = new System.Drawing.Point(273, 241);
            this.cBoxNation.Name = "cBoxNation";
            this.cBoxNation.Size = new System.Drawing.Size(200, 24);
            this.cBoxNation.TabIndex = 18;
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(273, 276);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(200, 24);
            this.cBoxTeam.TabIndex = 19;
            this.cBoxTeam.SelectedIndexChanged += new System.EventHandler(this.cBoxTeam_SelectedIndexChanged);
            // 
            // lavailable
            // 
            this.lavailable.AutoSize = true;
            this.lavailable.Location = new System.Drawing.Point(502, 318);
            this.lavailable.Name = "lavailable";
            this.lavailable.Size = new System.Drawing.Size(24, 16);
            this.lavailable.TabIndex = 20;
            this.lavailable.Text = "(...)";
            this.lavailable.Click += new System.EventHandler(this.lavailable_Click);
            // 
            // numTeamNumb
            // 
            this.numTeamNumb.Location = new System.Drawing.Point(273, 316);
            this.numTeamNumb.Name = "numTeamNumb";
            this.numTeamNumb.Size = new System.Drawing.Size(200, 22);
            this.numTeamNumb.TabIndex = 21;
            this.numTeamNumb.ValueChanged += new System.EventHandler(this.numTeamNumb_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTeamNumb);
            this.Controls.Add(this.lavailable);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.cBoxNation);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lTeamNumb);
            this.Controls.Add(this.lTeam);
            this.Controls.Add(this.lNation);
            this.Controls.Add(this.lBirth);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTeamNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lBirth;
        private System.Windows.Forms.Label lNation;
        private System.Windows.Forms.Label lTeam;
        private System.Windows.Forms.Label lTeamNumb;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.ComboBox cBoxNation;
        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.Label lavailable;
        private System.Windows.Forms.NumericUpDown numTeamNumb;
    }
}

