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

            CalculateBreakEven();

            try
            {
                Bonuses.Rows[e.RowIndex].Cells[4].Value = Math.Round(Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[3].Value) / Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[2].Value), 1);
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

            CalculateBreakEven();
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            CalculateReturn();

            CalculateBreakEven();
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

        private void CalculateBreakEven()
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
                    lblBreakEven.Text = $"Avg X Needed: End Of Opening";
                }
                else
                {
                    decimal breakEven = RHS / LHS;
                    lblBreakEven.Text = $"Avg X Needed: {Math.Round(breakEven)}";
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
