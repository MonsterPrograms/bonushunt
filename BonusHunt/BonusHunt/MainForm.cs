using System;
using System.Linq;
using System.Windows.Forms;

namespace BonusHunt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Bonuses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateBonuses();

            CalculateReturn();

            CalculateAverageRequired();

            CalculateRunningAverage();

            try
            {
                Bonuses.Rows[e.RowIndex].Cells[4].Value = Math.Round(Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[3].Value) / Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[2].Value), 2);
            }
            catch
            {
                // ignored
            }
        }

        private void Bonuses_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateBonuses();

            CalculateReturn();

            CalculateAverageRequired();

            CalculateRunningAverage();
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            CalculateReturn();

            CalculateAverageRequired();
        }

        private void CalculateBonuses()
        {
            try
            {
                int bonuses = 0;
                int bonusesRemaining = 0;

                foreach (DataGridViewRow dvr in Bonuses.Rows)
                {
                    if (!(dvr.Cells[0].Value == null && dvr.Cells[1].Value == null && dvr.Cells[2].Value == null && dvr.Cells[3].Value == null))
                    {
                        bonuses++;

                        if (dvr.Cells[2].Value != null && dvr.Cells[3].Value == null)
                        {
                            bonusesRemaining++;
                        }
                    }
                }

                lblBonuses.Text = $"Bonuses Collected: {bonuses}";
                lblBonusesRemaining.Text = $"Bonuses Remaining: {bonusesRemaining}";
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateReturn()
        {
            try
            {
                decimal amountWon = Bonuses.Rows.Cast<DataGridViewRow>()
                                .Sum(t => Convert.ToDecimal(t.Cells[3].Value));

                lblAmountWon.Text = $"Amount Won: {amountWon}";
                lblReturn.Text = $"Return: {amountWon - Convert.ToDecimal(txtStart.Text)}";
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateAverageRequired()
        {
            try
            {
                decimal LHS = 0;
                decimal RHS = Convert.ToDecimal(txtStart.Text);

                foreach (DataGridViewRow row in Bonuses.Rows)
                {
                    if (Convert.ToDecimal(row.Cells[2].Value) > 0 && row.Cells[3].Value != null)
                    {
                        RHS = RHS - Convert.ToDecimal(row.Cells[3].Value);
                    }
                    else if (Convert.ToDecimal(row.Cells[2].Value) > 0 && row.Cells[3].Value == null)
                    {
                        LHS = LHS + Convert.ToDecimal(row.Cells[2].Value);
                    }
                }

                if (LHS == 0)
                {
                    lblAverageRequired.Text = $"Average Required: End Of Opening";
                }
                else
                {
                    decimal averageRequired = RHS / LHS;
                    lblAverageRequired.Text = $"Average Required: {Math.Round(averageRequired, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateRunningAverage()
        {
            decimal multiTotal = 0;
            int bonusesOpened = 0;

            try
            {
                foreach (DataGridViewRow row in Bonuses.Rows)
                {
                    if (Convert.ToDecimal(row.Cells[2].Value) > 0 && row.Cells[3].Value != null)
                    {
                        multiTotal = multiTotal + (Convert.ToDecimal(Bonuses.Rows[row.Index].Cells[3].Value) / Convert.ToDecimal(Bonuses.Rows[row.Index].Cells[2].Value));
                        bonusesOpened++;
                    }
                }

                if (bonusesOpened == 0)
                {
                    lblRunningAverage.Text = $"Running Average: 0";
                }
                else
                {
                    decimal runningAverage = multiTotal / bonusesOpened;
                    lblRunningAverage.Text = $"Running Average: {Math.Round(runningAverage, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
