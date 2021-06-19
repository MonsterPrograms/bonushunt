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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bonuses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblBonusesCollected = new System.Windows.Forms.Label();
            this.lblAmountWon = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblAverageXRequired = new System.Windows.Forms.Label();
            this.lblRunningAverageX = new System.Windows.Forms.Label();
            this.lblAverageWinRequired = new System.Windows.Forms.Label();
            this.lblRunningAverageWin = new System.Windows.Forms.Label();
            this.lblBonusesRemaining = new System.Windows.Forms.Label();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mutli = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Bonus,
            this.Slot,
            this.Provider,
            this.Bet,
            this.Result,
            this.Mutli});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bonuses.DefaultCellStyle = dataGridViewCellStyle8;
            this.Bonuses.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bonuses.EnableHeadersVisualStyles = false;
            this.Bonuses.Location = new System.Drawing.Point(0, 0);
            this.Bonuses.Name = "Bonuses";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bonuses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Bonuses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Bonuses.Size = new System.Drawing.Size(581, 450);
            this.Bonuses.TabIndex = 0;
            this.Bonuses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Bonuses_CellValidating);
            this.Bonuses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bonuses_CellValueChanged);
            this.Bonuses.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Bonuses_RowsRemoved);
            this.Bonuses.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.Bonuses_SortCompare);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtStart.Location = new System.Drawing.Point(590, 30);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(151, 24);
            this.txtStart.TabIndex = 2;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // lblBonusesCollected
            // 
            this.lblBonusesCollected.AutoSize = true;
            this.lblBonusesCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBonusesCollected.Location = new System.Drawing.Point(587, 62);
            this.lblBonusesCollected.Name = "lblBonusesCollected";
            this.lblBonusesCollected.Size = new System.Drawing.Size(149, 18);
            this.lblBonusesCollected.TabIndex = 3;
            this.lblBonusesCollected.Text = "Bonuses Collected: 0";
            // 
            // lblAmountWon
            // 
            this.lblAmountWon.AutoSize = true;
            this.lblAmountWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAmountWon.Location = new System.Drawing.Point(587, 108);
            this.lblAmountWon.Name = "lblAmountWon";
            this.lblAmountWon.Size = new System.Drawing.Size(111, 18);
            this.lblAmountWon.TabIndex = 4;
            this.lblAmountWon.Text = "Amount Won: 0";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProfit.Location = new System.Drawing.Point(587, 131);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(59, 18);
            this.lblProfit.TabIndex = 5;
            this.lblProfit.Text = "Profit: 0";
            // 
            // lblAverageXRequired
            // 
            this.lblAverageXRequired.AutoSize = true;
            this.lblAverageXRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAverageXRequired.Location = new System.Drawing.Point(587, 177);
            this.lblAverageXRequired.Name = "lblAverageXRequired";
            this.lblAverageXRequired.Size = new System.Drawing.Size(154, 18);
            this.lblAverageXRequired.TabIndex = 6;
            this.lblAverageXRequired.Text = "Average X Required: 0";
            // 
            // lblRunningAverageX
            // 
            this.lblRunningAverageX.AutoSize = true;
            this.lblRunningAverageX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRunningAverageX.Location = new System.Drawing.Point(587, 223);
            this.lblRunningAverageX.Name = "lblRunningAverageX";
            this.lblRunningAverageX.Size = new System.Drawing.Size(149, 18);
            this.lblRunningAverageX.TabIndex = 8;
            this.lblRunningAverageX.Text = "Running Average X: 0";
            // 
            // lblAverageWinRequired
            // 
            this.lblAverageWinRequired.AutoSize = true;
            this.lblAverageWinRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAverageWinRequired.Location = new System.Drawing.Point(587, 154);
            this.lblAverageWinRequired.Name = "lblAverageWinRequired";
            this.lblAverageWinRequired.Size = new System.Drawing.Size(170, 18);
            this.lblAverageWinRequired.TabIndex = 9;
            this.lblAverageWinRequired.Text = "Average Win Required: 0";
            // 
            // lblRunningAverageWin
            // 
            this.lblRunningAverageWin.AutoSize = true;
            this.lblRunningAverageWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRunningAverageWin.Location = new System.Drawing.Point(587, 200);
            this.lblRunningAverageWin.Name = "lblRunningAverageWin";
            this.lblRunningAverageWin.Size = new System.Drawing.Size(165, 18);
            this.lblRunningAverageWin.TabIndex = 10;
            this.lblRunningAverageWin.Text = "Running Average Win: 0";
            // 
            // lblBonusesRemaining
            // 
            this.lblBonusesRemaining.AutoSize = true;
            this.lblBonusesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBonusesRemaining.Location = new System.Drawing.Point(587, 85);
            this.lblBonusesRemaining.Name = "lblBonusesRemaining";
            this.lblBonusesRemaining.Size = new System.Drawing.Size(157, 18);
            this.lblBonusesRemaining.TabIndex = 12;
            this.lblBonusesRemaining.Text = "Bonuses Remaining: 0";
            // 
            // Bonus
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Bonus.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bonus.HeaderText = "#";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.Width = 35;
            // 
            // Slot
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Slot.DefaultCellStyle = dataGridViewCellStyle3;
            this.Slot.HeaderText = "Slot";
            this.Slot.Name = "Slot";
            this.Slot.Width = 150;
            // 
            // Provider
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Provider.DefaultCellStyle = dataGridViewCellStyle4;
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            this.Provider.Width = 135;
            // 
            // Bet
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Bet.DefaultCellStyle = dataGridViewCellStyle5;
            this.Bet.HeaderText = "Bet";
            this.Bet.Name = "Bet";
            this.Bet.Width = 69;
            // 
            // Result
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Result.DefaultCellStyle = dataGridViewCellStyle6;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.Width = 69;
            // 
            // Mutli
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Mutli.DefaultCellStyle = dataGridViewCellStyle7;
            this.Mutli.HeaderText = "Multi";
            this.Mutli.Name = "Mutli";
            this.Mutli.ReadOnly = true;
            this.Mutli.Width = 69;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.lblBonusesRemaining);
            this.Controls.Add(this.lblRunningAverageWin);
            this.Controls.Add(this.lblAverageWinRequired);
            this.Controls.Add(this.lblRunningAverageX);
            this.Controls.Add(this.lblAverageXRequired);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblAmountWon);
            this.Controls.Add(this.lblBonusesCollected);
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
        private System.Windows.Forms.Label lblBonusesCollected;
        private System.Windows.Forms.Label lblAmountWon;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblAverageXRequired;
        private System.Windows.Forms.Label lblRunningAverageX;
        private System.Windows.Forms.Label lblAverageWinRequired;
        private System.Windows.Forms.Label lblRunningAverageWin;
        private System.Windows.Forms.Label lblBonusesRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mutli;
    }
}

