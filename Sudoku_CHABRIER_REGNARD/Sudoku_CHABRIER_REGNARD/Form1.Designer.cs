namespace Sudoku_CHABRIER_REGNARD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sudoku = new System.Windows.Forms.DataGridView();
            this.gen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // sudoku
            // 
            this.sudoku.AllowUserToAddRows = false;
            this.sudoku.AllowUserToDeleteRows = false;
            this.sudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sudoku.ColumnHeadersVisible = false;
            this.sudoku.Location = new System.Drawing.Point(1, 1);
            this.sudoku.Name = "sudoku";
            this.sudoku.RowHeadersVisible = false;
            this.sudoku.Size = new System.Drawing.Size(633, 633);
            this.sudoku.TabIndex = 0;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(687, 12);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(211, 62);
            this.gen.TabIndex = 1;
            this.gen.Text = "Generate grid";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.sudoku);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sudoku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sudoku;
        private System.Windows.Forms.Button gen;
    }
}

