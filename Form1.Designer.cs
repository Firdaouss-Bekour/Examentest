namespace Examentest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.examenDataSet = new Examentest.ExamenDataSet();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter = new Examentest.ExamenDataSetTableAdapters.examenTableAdapter();
            this.examenDataSet1 = new Examentest.ExamenDataSet1();
            this.examenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter1 = new Examentest.ExamenDataSet1TableAdapters.examenTableAdapter();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reponseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intituleDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.datefinDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.reponseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examenBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(277, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(829, 302);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 26);
            this.textBox4.TabIndex = 4;
            // 
            // examenDataSet
            // 
            this.examenDataSet.DataSetName = "ExamenDataSet";
            this.examenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "examen";
            this.examenBindingSource.DataSource = this.examenDataSet;
            // 
            // examenTableAdapter
            // 
            this.examenTableAdapter.ClearBeforeFill = true;
            // 
            // examenDataSet1
            // 
            this.examenDataSet1.DataSetName = "ExamenDataSet1";
            this.examenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource1
            // 
            this.examenBindingSource1.DataMember = "examen";
            this.examenBindingSource1.DataSource = this.examenDataSet1;
            // 
            // examenTableAdapter1
            // 
            this.examenTableAdapter1.ClearBeforeFill = true;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "intitule";
            this.intituleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            this.dateDebutDataGridViewTextBoxColumn.Width = 150;
            // 
            // datefinDataGridViewTextBoxColumn
            // 
            this.datefinDataGridViewTextBoxColumn.DataPropertyName = "Datefin";
            this.datefinDataGridViewTextBoxColumn.HeaderText = "Datefin";
            this.datefinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datefinDataGridViewTextBoxColumn.Name = "datefinDataGridViewTextBoxColumn";
            this.datefinDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 150;
            // 
            // reponseDataGridViewTextBoxColumn
            // 
            this.reponseDataGridViewTextBoxColumn.DataPropertyName = "reponse";
            this.reponseDataGridViewTextBoxColumn.HeaderText = "reponse";
            this.reponseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reponseDataGridViewTextBoxColumn.Name = "reponseDataGridViewTextBoxColumn";
            this.reponseDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAjt_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(31, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 26);
            this.textBox5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private ExamenDataSet examenDataSet;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private ExamenDataSetTableAdapters.examenTableAdapter examenTableAdapter;
        private ExamenDataSet1 examenDataSet1;
        private System.Windows.Forms.BindingSource examenBindingSource1;
        private ExamenDataSet1TableAdapters.examenTableAdapter examenTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reponseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
    }
}

