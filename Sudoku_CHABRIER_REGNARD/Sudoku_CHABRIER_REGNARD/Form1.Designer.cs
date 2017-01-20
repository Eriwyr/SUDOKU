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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sudoku = new System.Windows.Forms.DataGridView();
            this.gen = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // sudoku
            // 
            this.sudoku.AllowUserToAddRows = false;
            this.sudoku.AllowUserToDeleteRows = false;
            this.sudoku.BackgroundColor = System.Drawing.Color.White;
            this.sudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sudoku.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sudoku.DefaultCellStyle = dataGridViewCellStyle2;
            this.sudoku.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sudoku.Location = new System.Drawing.Point(2, 1);
            this.sudoku.Margin = new System.Windows.Forms.Padding(0);
            this.sudoku.Name = "sudoku";
            this.sudoku.RowHeadersVisible = false;
            this.sudoku.Size = new System.Drawing.Size(633, 633);
            this.sudoku.TabIndex = 0;
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.DarkGray;
            this.gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.ForeColor = System.Drawing.Color.White;
            this.gen.Location = new System.Drawing.Point(687, 12);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(211, 62);
            this.gen.TabIndex = 1;
            this.gen.Text = "Generate grid";
            this.gen.UseVisualStyleBackColor = false;
            this.gen.Click += new System.EventHandler(this.gen_Click_1);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.DarkGray;
            this.check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(687, 111);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(211, 62);
            this.check.TabIndex = 2;
            this.check.Text = "Validate Grid";
            this.check.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(687, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.check);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.sudoku);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Chabrier Regnard";
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
        private System.Windows.Forms.Button button1;
    }
}

