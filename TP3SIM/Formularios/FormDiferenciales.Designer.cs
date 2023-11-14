
namespace TP5SIM.Formularios
{
    partial class FormDiferenciales
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
            this.dgvLectura = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLectura
            // 
            this.dgvLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.P,
            this.dPdt,
            this.t1,
            this.P1});
            this.dgvLectura.Location = new System.Drawing.Point(0, -1);
            this.dgvLectura.Name = "dgvLectura";
            this.dgvLectura.Size = new System.Drawing.Size(543, 506);
            this.dgvLectura.TabIndex = 0;
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // dPdt
            // 
            this.dPdt.HeaderText = "dP/dt";
            this.dPdt.Name = "dPdt";
            this.dPdt.ReadOnly = true;
            // 
            // t1
            // 
            this.t1.HeaderText = "t+1";
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            // 
            // P1
            // 
            this.P1.HeaderText = "P+1";
            this.P1.Name = "P1";
            this.P1.ReadOnly = true;
            // 
            // FormDiferenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 511);
            this.Controls.Add(this.dgvLectura);
            this.Name = "FormDiferenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiferenciales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P1;
    }
}