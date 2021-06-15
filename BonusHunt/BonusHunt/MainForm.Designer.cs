namespace BonusHunt
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bonuses = new System.Windows.Forms.DataGridView();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BetSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mutli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblBonuses = new System.Windows.Forms.Label();
            this.lblAmountWon = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblAverageRequired = new System.Windows.Forms.Label();
            this.lblBonusesRemaining = new System.Windows.Forms.Label();
            this.lblRunningAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bonuses)).BeginInit();
            this.SuspendLayout();
            // 
            // Bonuses
            // 
            this.Bonuses.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bonuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Bonuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bonuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Slot,
            this.Provider,
            this.BetSize,
            this.Payout,
            this.Mutli});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bonuses.DefaultCellStyle = dataGridViewCellStyle7;
            this.Bonuses.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bonuses.EnableHeadersVisualStyles = false;
            this.Bonuses.Location = new System.Drawing.Point(0, 0);
            this.Bonuses.Name = "Bonuses";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bonuses.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Bonuses.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Bonuses.Size = new System.Drawing.Size(507, 450);
            this.Bonuses.TabIndex = 0;
            this.Bonuses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bonuses_CellValueChanged);
            this.Bonuses.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Bonuses_RowsRemoved);
            // 
            // Slot
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Slot.DefaultCellStyle = dataGridViewCellStyle2;
            this.Slot.HeaderText = "Slot";
            this.Slot.Name = "Slot";
            this.Slot.Width = 150;
            // 
            // Provider
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Provider.DefaultCellStyle = dataGridViewCellStyle3;
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            // 
            // BetSize
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BetSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.BetSize.HeaderText = "Bet Size";
            this.BetSize.Name = "BetSize";
            this.BetSize.Width = 69;
            // 
            // Payout
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Payout.DefaultCellStyle = dataGridViewCellStyle5;
            this.Payout.HeaderText = "Payout";
            this.Payout.Name = "Payout";
            this.Payout.Width = 69;
            // 
            // Mutli
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Mutli.DefaultCellStyle = dataGridViewCellStyle6;
            this.Mutli.HeaderText = "Multi";
            this.Mutli.Name = "Mutli";
            this.Mutli.ReadOnly = true;
            this.Mutli.Width = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtStart.Location = new System.Drawing.Point(516, 30);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(154, 24);
            this.txtStart.TabIndex = 2;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // lblBonuses
            // 
            this.lblBonuses.AutoSize = true;
            this.lblBonuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBonuses.Location = new System.Drawing.Point(513, 62);
            this.lblBonuses.Name = "lblBonuses";
            this.lblBonuses.Size = new System.Drawing.Size(149, 18);
            this.lblBonuses.TabIndex = 3;
            this.lblBonuses.Text = "Bonuses Collected: 0";
            // 
            // lblAmountWon
            // 
            this.lblAmountWon.AutoSize = true;
            this.lblAmountWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAmountWon.Location = new System.Drawing.Point(513, 85);
            this.lblAmountWon.Name = "lblAmountWon";
            this.lblAmountWon.Size = new System.Drawing.Size(111, 18);
            this.lblAmountWon.TabIndex = 4;
            this.lblAmountWon.Text = "Amount Won: 0";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblReturn.Location = new System.Drawing.Point(513, 108);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(68, 18);
            this.lblReturn.TabIndex = 5;
            this.lblReturn.Text = "Return: 0";
            // 
            // lblAverageRequired
            // 
            this.lblAverageRequired.AutoSize = true;
            this.lblAverageRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAverageRequired.Location = new System.Drawing.Point(513, 154);
            this.lblAverageRequired.Name = "lblAverageRequired";
            this.lblAverageRequired.Size = new System.Drawing.Size(140, 18);
            this.lblAverageRequired.TabIndex = 6;
            this.lblAverageRequired.Text = "Average Required: 0";
            // 
            // lblBonusesRemaining
            // 
            this.lblBonusesRemaining.AutoSize = true;
            this.lblBonusesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBonusesRemaining.Location = new System.Drawing.Point(513, 131);
            this.lblBonusesRemaining.Name = "lblBonusesRemaining";
            this.lblBonusesRemaining.Size = new System.Drawing.Size(157, 18);
            this.lblBonusesRemaining.TabIndex = 7;
            this.lblBonusesRemaining.Text = "Bonuses Remaining: 0";
            // 
            // lblRunningAverage
            // 
            this.lblRunningAverage.AutoSize = true;
            this.lblRunningAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRunningAverage.Location = new System.Drawing.Point(513, 177);
            this.lblRunningAverage.Name = "lblRunningAverage";
            this.lblRunningAverage.Size = new System.Drawing.Size(135, 18);
            this.lblRunningAverage.TabIndex = 8;
            this.lblRunningAverage.Text = "Running Average: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.lblRunningAverage);
            this.Controls.Add(this.lblBonusesRemaining);
            this.Controls.Add(this.lblAverageRequired);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblAmountWon);
            this.Controls.Add(this.lblBonuses);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bonuses);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Bonus Hunt";
            ((System.ComponentModel.ISupportInitialize)(this.Bonuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Bonuses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblBonuses;
        private System.Windows.Forms.Label lblAmountWon;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblAverageRequired;
        private System.Windows.Forms.Label lblBonusesRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn BetSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mutli;
        private System.Windows.Forms.Label lblRunningAverage;
    }
}

