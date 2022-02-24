
namespace Allatkorhaz
{
    partial class frmKezelesTipus
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
            this.btnModositas = new System.Windows.Forms.Button();
            this.dgvKezelesTipusok = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelleg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTipus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesTipusok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(36, 449);
            this.btnModositas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(91, 35);
            this.btnModositas.TabIndex = 0;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // dgvKezelesTipusok
            // 
            this.dgvKezelesTipusok.AllowUserToAddRows = false;
            this.dgvKezelesTipusok.AllowUserToDeleteRows = false;
            this.dgvKezelesTipusok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKezelesTipusok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.jelleg});
            this.dgvKezelesTipusok.Location = new System.Drawing.Point(36, 43);
            this.dgvKezelesTipusok.MultiSelect = false;
            this.dgvKezelesTipusok.Name = "dgvKezelesTipusok";
            this.dgvKezelesTipusok.ReadOnly = true;
            this.dgvKezelesTipusok.RowHeadersVisible = false;
            this.dgvKezelesTipusok.Size = new System.Drawing.Size(445, 300);
            this.dgvKezelesTipusok.TabIndex = 1;
            this.dgvKezelesTipusok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKezelesTipusok_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // jelleg
            // 
            this.jelleg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jelleg.DataPropertyName = "jelleg";
            this.jelleg.HeaderText = "Kezelés típusa";
            this.jelleg.Name = "jelleg";
            this.jelleg.ReadOnly = true;
            // 
            // tbTipus
            // 
            this.tbTipus.Enabled = false;
            this.tbTipus.Location = new System.Drawing.Point(182, 372);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(299, 26);
            this.tbTipus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kezlés típusa:";
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(290, 449);
            this.btnMentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(92, 35);
            this.btnMentes.TabIndex = 0;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Enabled = false;
            this.btnMegsem.Location = new System.Drawing.Point(390, 449);
            this.btnMegsem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(91, 35);
            this.btnMegsem.TabIndex = 0;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(145, 449);
            this.btnUj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(91, 35);
            this.btnUj.TabIndex = 0;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // frmKezelesTipus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTipus);
            this.Controls.Add(this.dgvKezelesTipusok);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnModositas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKezelesTipus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelés típusa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKezelesTipus_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKezelesTipusok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.DataGridView dgvKezelesTipusok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelleg;
        private System.Windows.Forms.TextBox tbTipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Button btnUj;
    }
}

