namespace Robert_Collier_CPT_206_Lab_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.stateInfobtn = new System.Windows.Forms.Button();
            this.stateSearchSortbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.state_infoDataSet = new Robert_Collier_CPT_206_Lab_2.State_infoDataSet();
            this.stateinfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new Robert_Collier_CPT_206_Lab_2.State_infoDataSetTableAdapters.Table1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.state_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateinfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a State.";
            // 
            // stateInfobtn
            // 
            this.stateInfobtn.AutoSize = true;
            this.stateInfobtn.Location = new System.Drawing.Point(209, 123);
            this.stateInfobtn.Name = "stateInfobtn";
            this.stateInfobtn.Size = new System.Drawing.Size(97, 23);
            this.stateInfobtn.TabIndex = 2;
            this.stateInfobtn.Text = "State Information";
            this.stateInfobtn.UseVisualStyleBackColor = true;
            this.stateInfobtn.Click += new System.EventHandler(this.stateInfobtn_Click);
            // 
            // stateSearchSortbtn
            // 
            this.stateSearchSortbtn.AutoSize = true;
            this.stateSearchSortbtn.Location = new System.Drawing.Point(196, 152);
            this.stateSearchSortbtn.Name = "stateSearchSortbtn";
            this.stateSearchSortbtn.Size = new System.Drawing.Size(120, 23);
            this.stateSearchSortbtn.TabIndex = 3;
            this.stateSearchSortbtn.Text = "Search and Sort Data";
            this.stateSearchSortbtn.UseVisualStyleBackColor = true;
            this.stateSearchSortbtn.Click += new System.EventHandler(this.stateSearchSortbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table1BindingSource, "State", true));
            this.comboBox1.DataSource = this.table1BindingSource;
            this.comboBox1.DisplayMember = "State";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "State";
            // 
            // state_infoDataSet
            // 
            this.state_infoDataSet.DataSetName = "State_infoDataSet";
            this.state_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateinfoDataSetBindingSource
            // 
            this.stateinfoDataSetBindingSource.DataSource = this.state_infoDataSet;
            this.stateinfoDataSetBindingSource.Position = 0;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.stateinfoDataSetBindingSource;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 278);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stateSearchSortbtn);
            this.Controls.Add(this.stateInfobtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.state_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateinfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stateInfobtn;
        private System.Windows.Forms.Button stateSearchSortbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource stateinfoDataSetBindingSource;
        private State_infoDataSet state_infoDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private State_infoDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
    }
}

