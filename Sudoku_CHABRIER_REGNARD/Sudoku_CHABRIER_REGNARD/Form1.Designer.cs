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
            this.check = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
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
            // check
            // 
            this.check.Location = new System.Drawing.Point(687, 111);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(211, 62);
            this.check.TabIndex = 2;
            this.check.Text = "Validate Grid";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.message.Location = new System.Drawing.Point(687, 336);
            this.message.MinimumSize = new System.Drawing.Size(211, 62);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(211, 62);
            this.message.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 697);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.check);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.sudoku);
            this.Name = "Form1";
            this.Text = "The Amazing Fucking Great Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.sudoku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sudoku;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Splitter splitter1;
    }
}

