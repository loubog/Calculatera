namespace EncrytpionDecryption
{
    partial class frmProbabilityScale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLettersEntropy = new System.Windows.Forms.DataGridView();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKnowingProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotKnowingProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInformationQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalEntropia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowDetail = new Glass.GlassButton();
            this.lblMinProbability = new System.Windows.Forms.Label();
            this.lblMaxProbability = new System.Windows.Forms.Label();
            this.lblAverageProbaility = new System.Windows.Forms.Label();
            this.lblMinEntropy = new System.Windows.Forms.Label();
            this.lblMaxEntropy = new System.Windows.Forms.Label();
            this.lblAverageEntropy = new System.Windows.Forms.Label();
            this.dgvDetailLetterEntropy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailLetterEntropy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLettersEntropy
            // 
            this.dgvLettersEntropy.AllowUserToAddRows = false;
            this.dgvLettersEntropy.AllowUserToDeleteRows = false;
            this.dgvLettersEntropy.AllowUserToOrderColumns = true;
            this.dgvLettersEntropy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLettersEntropy.BackgroundColor = System.Drawing.Color.Purple;
            this.dgvLettersEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLettersEntropy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWord,
            this.colFrequency,
            this.colProbability,
            this.colKnowingProbability,
            this.colNotKnowingProbability,
            this.colInformationQuantity,
            this.colFinalEntropia,
            this.colId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLettersEntropy.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLettersEntropy.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLettersEntropy.GridColor = System.Drawing.Color.Blue;
            this.dgvLettersEntropy.Location = new System.Drawing.Point(0, 0);
            this.dgvLettersEntropy.Name = "dgvLettersEntropy";
            this.dgvLettersEntropy.ReadOnly = true;
            this.dgvLettersEntropy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLettersEntropy.Size = new System.Drawing.Size(977, 331);
            this.dgvLettersEntropy.TabIndex = 17;
            // 
            // colWord
            // 
            this.colWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWord.DataPropertyName = "Word";
            this.colWord.HeaderText = "Word ";
            this.colWord.Name = "colWord";
            this.colWord.ReadOnly = true;
            // 
            // colFrequency
            // 
            this.colFrequency.DataPropertyName = "Frequency";
            this.colFrequency.HeaderText = "Frequency";
            this.colFrequency.Name = "colFrequency";
            this.colFrequency.ReadOnly = true;
            // 
            // colProbability
            // 
            this.colProbability.DataPropertyName = "Probability";
            this.colProbability.HeaderText = "Probability";
            this.colProbability.Name = "colProbability";
            this.colProbability.ReadOnly = true;
            // 
            // colKnowingProbability
            // 
            this.colKnowingProbability.DataPropertyName = "KnowingProbability";
            this.colKnowingProbability.HeaderText = "Knowing Probability ";
            this.colKnowingProbability.Name = "colKnowingProbability";
            this.colKnowingProbability.ReadOnly = true;
            // 
            // colNotKnowingProbability
            // 
            this.colNotKnowingProbability.DataPropertyName = "NotKnowingProbability";
            this.colNotKnowingProbability.HeaderText = "pd";
            this.colNotKnowingProbability.Name = "colNotKnowingProbability";
            this.colNotKnowingProbability.ReadOnly = true;
            // 
            // colInformationQuantity
            // 
            this.colInformationQuantity.DataPropertyName = "InformationQuantity";
            this.colInformationQuantity.HeaderText = "Information Quantity ";
            this.colInformationQuantity.Name = "colInformationQuantity";
            this.colInformationQuantity.ReadOnly = true;
            // 
            // colFinalEntropia
            // 
            this.colFinalEntropia.DataPropertyName = "FinalEntropia";
            this.colFinalEntropia.HeaderText = "Final Entropia";
            this.colFinalEntropia.Name = "colFinalEntropia";
            this.colFinalEntropia.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetail.Location = new System.Drawing.Point(2, 335);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(114, 28);
            this.btnShowDetail.TabIndex = 18;
            this.btnShowDetail.Text = "Show Detail";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // lblMinProbability
            // 
            this.lblMinProbability.AutoSize = true;
            this.lblMinProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProbability.ForeColor = System.Drawing.Color.White;
            this.lblMinProbability.Location = new System.Drawing.Point(12, 570);
            this.lblMinProbability.Name = "lblMinProbability";
            this.lblMinProbability.Size = new System.Drawing.Size(51, 20);
            this.lblMinProbability.TabIndex = 19;
            this.lblMinProbability.Text = "label1";
            this.lblMinProbability.Visible = false;
            // 
            // lblMaxProbability
            // 
            this.lblMaxProbability.AutoSize = true;
            this.lblMaxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxProbability.ForeColor = System.Drawing.Color.White;
            this.lblMaxProbability.Location = new System.Drawing.Point(12, 570);
            this.lblMaxProbability.Name = "lblMaxProbability";
            this.lblMaxProbability.Size = new System.Drawing.Size(51, 20);
            this.lblMaxProbability.TabIndex = 19;
            this.lblMaxProbability.Text = "label1";
            this.lblMaxProbability.Visible = false;
            // 
            // lblAverageProbaility
            // 
            this.lblAverageProbaility.AutoSize = true;
            this.lblAverageProbaility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageProbaility.ForeColor = System.Drawing.Color.White;
            this.lblAverageProbaility.Location = new System.Drawing.Point(12, 570);
            this.lblAverageProbaility.Name = "lblAverageProbaility";
            this.lblAverageProbaility.Size = new System.Drawing.Size(51, 20);
            this.lblAverageProbaility.TabIndex = 19;
            this.lblAverageProbaility.Text = "label1";
            this.lblAverageProbaility.Visible = false;
            // 
            // lblMinEntropy
            // 
            this.lblMinEntropy.AutoSize = true;
            this.lblMinEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinEntropy.ForeColor = System.Drawing.Color.White;
            this.lblMinEntropy.Location = new System.Drawing.Point(12, 559);
            this.lblMinEntropy.Name = "lblMinEntropy";
            this.lblMinEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblMinEntropy.TabIndex = 19;
            this.lblMinEntropy.Text = "label1";
            this.lblMinEntropy.Visible = false;
            // 
            // lblMaxEntropy
            // 
            this.lblMaxEntropy.AutoSize = true;
            this.lblMaxEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntropy.ForeColor = System.Drawing.Color.White;
            this.lblMaxEntropy.Location = new System.Drawing.Point(12, 570);
            this.lblMaxEntropy.Name = "lblMaxEntropy";
            this.lblMaxEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblMaxEntropy.TabIndex = 19;
            this.lblMaxEntropy.Text = "label1";
            this.lblMaxEntropy.Visible = false;
            // 
            // lblAverageEntropy
            // 
            this.lblAverageEntropy.AutoSize = true;
            this.lblAverageEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageEntropy.ForeColor = System.Drawing.Color.White;
            this.lblAverageEntropy.Location = new System.Drawing.Point(12, 570);
            this.lblAverageEntropy.Name = "lblAverageEntropy";
            this.lblAverageEntropy.Size = new System.Drawing.Size(51, 20);
            this.lblAverageEntropy.TabIndex = 19;
            this.lblAverageEntropy.Text = "label1";
            this.lblAverageEntropy.Visible = false;
            // 
            // dgvDetailLetterEntropy
            // 
            this.dgvDetailLetterEntropy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailLetterEntropy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailLetterEntropy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetailLetterEntropy.Location = new System.Drawing.Point(0, 368);
            this.dgvDetailLetterEntropy.Name = "dgvDetailLetterEntropy";
            this.dgvDetailLetterEntropy.Size = new System.Drawing.Size(977, 231);
            this.dgvDetailLetterEntropy.TabIndex = 20;
            // 
            // frmProbabilityScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::EncrytpionDecryption.Properties.Resources.bk_entropy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 599);
            this.Controls.Add(this.dgvDetailLetterEntropy);
            this.Controls.Add(this.lblMinEntropy);
            this.Controls.Add(this.lblAverageEntropy);
            this.Controls.Add(this.lblAverageProbaility);
            this.Controls.Add(this.lblMaxEntropy);
            this.Controls.Add(this.lblMaxProbability);
            this.Controls.Add(this.lblMinProbability);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dgvLettersEntropy);
            this.Name = "frmProbabilityScale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProbabilityScale";
            this.Load += new System.EventHandler(this.frmProbabilityScale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLettersEntropy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailLetterEntropy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLettersEntropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKnowingProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotKnowingProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInformationQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalEntropia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private Glass.GlassButton btnShowDetail;
        private System.Windows.Forms.Label lblMinProbability;
        private System.Windows.Forms.Label lblMaxProbability;
        private System.Windows.Forms.Label lblAverageProbaility;
        private System.Windows.Forms.Label lblMinEntropy;
        private System.Windows.Forms.Label lblMaxEntropy;
        private System.Windows.Forms.Label lblAverageEntropy;
        private System.Windows.Forms.DataGridView dgvDetailLetterEntropy;
    }
}