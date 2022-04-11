namespace baze_de_date
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.deleteFacultyButton = new System.Windows.Forms.Button();
            this.deleteUniButton = new System.Windows.Forms.Button();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFacultati = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUniv = new System.Windows.Forms.ListBox();
            this.addUnivButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridViewButton = new System.Windows.Forms.Button();
            this.groupBoxAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.dataGridViewButton);
            this.groupBoxAll.Controls.Add(this.deleteFacultyButton);
            this.groupBoxAll.Controls.Add(this.deleteUniButton);
            this.groupBoxAll.Controls.Add(this.textBoxCod);
            this.groupBoxAll.Controls.Add(this.label4);
            this.groupBoxAll.Controls.Add(this.textBoxOras);
            this.groupBoxAll.Controls.Add(this.label3);
            this.groupBoxAll.Controls.Add(this.listBoxFacultati);
            this.groupBoxAll.Controls.Add(this.label2);
            this.groupBoxAll.Controls.Add(this.label1);
            this.groupBoxAll.Controls.Add(this.listBoxUniv);
            this.groupBoxAll.Location = new System.Drawing.Point(45, 43);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(539, 492);
            this.groupBoxAll.TabIndex = 0;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Exemplu DB";
            // 
            // deleteFacultyButton
            // 
            this.deleteFacultyButton.Location = new System.Drawing.Point(312, 422);
            this.deleteFacultyButton.Name = "deleteFacultyButton";
            this.deleteFacultyButton.Size = new System.Drawing.Size(174, 50);
            this.deleteFacultyButton.TabIndex = 10;
            this.deleteFacultyButton.Text = "Delete Selected Faculty";
            this.deleteFacultyButton.UseVisualStyleBackColor = true;
            this.deleteFacultyButton.Click += new System.EventHandler(this.deleteFacultyButton_Click);
            // 
            // deleteUniButton
            // 
            this.deleteUniButton.Location = new System.Drawing.Point(35, 423);
            this.deleteUniButton.Name = "deleteUniButton";
            this.deleteUniButton.Size = new System.Drawing.Size(183, 49);
            this.deleteUniButton.TabIndex = 9;
            this.deleteUniButton.Text = "Delete Selected University";
            this.deleteUniButton.UseVisualStyleBackColor = true;
            this.deleteUniButton.Click += new System.EventHandler(this.deleteUniButton_Click);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(332, 331);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.ReadOnly = true;
            this.textBoxCod.Size = new System.Drawing.Size(174, 27);
            this.textBoxCod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cod Univ: ";
            // 
            // textBoxOras
            // 
            this.textBoxOras.Location = new System.Drawing.Point(332, 295);
            this.textBoxOras.Name = "textBoxOras";
            this.textBoxOras.ReadOnly = true;
            this.textBoxOras.Size = new System.Drawing.Size(174, 27);
            this.textBoxOras.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oras:";
            // 
            // listBoxFacultati
            // 
            this.listBoxFacultati.FormattingEnabled = true;
            this.listBoxFacultati.ItemHeight = 20;
            this.listBoxFacultati.Location = new System.Drawing.Point(259, 112);
            this.listBoxFacultati.Name = "listBoxFacultati";
            this.listBoxFacultati.Size = new System.Drawing.Size(274, 164);
            this.listBoxFacultati.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Facultati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universitati";
            // 
            // listBoxUniv
            // 
            this.listBoxUniv.FormattingEnabled = true;
            this.listBoxUniv.ItemHeight = 20;
            this.listBoxUniv.Location = new System.Drawing.Point(6, 112);
            this.listBoxUniv.Name = "listBoxUniv";
            this.listBoxUniv.Size = new System.Drawing.Size(238, 264);
            this.listBoxUniv.TabIndex = 0;
            this.listBoxUniv.SelectedIndexChanged += new System.EventHandler(this.listBoxUniv_SelectedIndexChanged);
            // 
            // addUnivButton
            // 
            this.addUnivButton.Location = new System.Drawing.Point(63, 563);
            this.addUnivButton.Name = "addUnivButton";
            this.addUnivButton.Size = new System.Drawing.Size(183, 49);
            this.addUnivButton.TabIndex = 8;
            this.addUnivButton.Text = "Add university";
            this.addUnivButton.UseVisualStyleBackColor = true;
            this.addUnivButton.Click += new System.EventHandler(this.addUnivButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(337, 563);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(197, 49);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Change university data";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dataGridViewButton
            // 
            this.dataGridViewButton.Location = new System.Drawing.Point(332, 26);
            this.dataGridViewButton.Name = "dataGridViewButton";
            this.dataGridViewButton.Size = new System.Drawing.Size(174, 48);
            this.dataGridViewButton.TabIndex = 10;
            this.dataGridViewButton.Text = "Data Grid View";
            this.dataGridViewButton.UseVisualStyleBackColor = true;
            this.dataGridViewButton.Click += new System.EventHandler(this.dataGridViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 639);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addUnivButton);
            this.Controls.Add(this.groupBoxAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAll;
        private TextBox textBoxCod;
        private Label label4;
        private TextBox textBoxOras;
        private Label label3;
        private ListBox listBoxFacultati;
        private Label label2;
        private Label label1;
        private ListBox listBoxUniv;
        private Button addUnivButton;
        private Button deleteUniButton;
        private Button updateButton;
        private Button deleteFacultyButton;
        private Button dataGridViewButton;
    }
}