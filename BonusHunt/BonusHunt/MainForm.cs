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
            try
            {
                foreach (DataGridViewRow dvr in Bonuses.Rows)
                {
                    dvr.Cells[0].Value = dvr.Index + 1;
                }
            }
            catch
            {
                // ignored
            }

            CalculateBonuses();

            CalculateProfit();

            CalculateAverageXRequired();

            CalculateRunningAverageX();

            CalculateAverageWinRequired();

            CalculateRunningAverageWin();

            try
            {
                Bonuses.Rows[e.RowIndex].Cells[5].Value = Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[3].Value) == 0 ? 0 : Math.Round(Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[4].Value) / Convert.ToDecimal(Bonuses.Rows[e.RowIndex].Cells[3].Value), 2);
            }
            catch
            {
                // ignored
            }
        }

        private void Bonuses_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dvr in Bonuses.Rows)
                {
                    dvr.Cells[0].Value = dvr.Index + 1;
                }
            }
            catch
            {
                // ignored
            }

            CalculateBonuses();

            CalculateProfit();

            CalculateAverageXRequired();

            CalculateRunningAverageX();

            CalculateAverageWinRequired();

            CalculateRunningAverageWin();
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();

            CalculateAverageXRequired();

            CalculateAverageWinRequired();
        }

        private void CalculateBonuses()
        {
            try
            {
                var bonuses = 0;
                var bonusesRemaining = 0;

                foreach (DataGridViewRow dvr in Bonuses.Rows)
                {
                    if (dvr.Cells[3].Value == null) continue;
                    bonuses++;

                    if (dvr.Cells[4].Value == null)
                    {
                        bonusesRemaining++;
                    }
                }

                lblBonusesCollected.Text = $"Bonuses Collected: {bonuses}";
                lblBonusesRemaining.Text = $"Bonuses Remaining: {bonusesRemaining}";
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateProfit()
        {
            try
            {
                var amountWon = Bonuses.Rows.Cast<DataGridViewRow>().Where(t => t.Cells[3].Value != null).Sum(t => Convert.ToDecimal(t.Cells[4].Value));

                lblAmountWon.Text = $"Amount Won: {amountWon}";
                lblProfit.Text = $"Profit: {amountWon - Convert.ToDecimal(txtStart.Text)}";
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateAverageXRequired()
        {
            try
            {
                decimal LHS = 0;
                var RHS = Convert.ToDecimal(txtStart.Text);

                foreach (DataGridViewRow row in Bonuses.Rows)
                {
                    if (row.Cells[3].Value != null && row.Cells[4].Value != null)
                    {
                        RHS -= Convert.ToDecimal(row.Cells[4].Value);
                    }
                    else if (row.Cells[3].Value != null && row.Cells[4].Value == null)
                    {
                        LHS += Convert.ToDecimal(row.Cells[3].Value);
                    }
                }

                if (LHS == 0)
                {
                    lblAverageXRequired.Text = $"Average X Required: End Of Opening";
                }
                else
                {
                    var averageXRequired = RHS / LHS;
                    lblAverageXRequired.Text = $"Average X Required: {Math.Round(averageXRequired, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateRunningAverageX()
        {
            decimal multiTotal = 0;
            var bonusesOpened = 0;

            try
            {
                foreach (DataGridViewRow row in Bonuses.Rows)
                {
                    if (row.Cells[3].Value == null || row.Cells[4].Value == null) continue;
                    multiTotal += (Convert.ToDecimal(Bonuses.Rows[row.Index].Cells[4].Value) / Convert.ToDecimal(Bonuses.Rows[row.Index].Cells[3].Value));
                    bonusesOpened++;
                }

                if (bonusesOpened == 0)
                {
                    lblRunningAverageX.Text = $"Running Average X: 0";
                }
                else
                {
                    var runningXAverage = multiTotal / bonusesOpened;
                    lblRunningAverageX.Text = $"Running Average X: {Math.Round(runningXAverage, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateAverageWinRequired()
        {
            try
            {
                var startingBalance = Convert.ToDecimal(txtStart.Text);
                var amountWon = Bonuses.Rows.Cast<DataGridViewRow>().Where(t => t.Cells[3].Value != null).Sum(t => Convert.ToDecimal(t.Cells[4].Value));
                var bonusesRemaining = Bonuses.Rows.Cast<DataGridViewRow>().Count(dvr => dvr.Cells[3].Value != null && dvr.Cells[4].Value == null);

                if (bonusesRemaining == 0)
                {
                    lblAverageWinRequired.Text = $"Average Win Required: End Of Opening";
                }
                else
                {
                    startingBalance -= amountWon;
                    var averageWinRequired = startingBalance / bonusesRemaining;
                    lblAverageWinRequired.Text = $"Average Win Required: {Math.Round(averageWinRequired, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void CalculateRunningAverageWin()
        {
            try
            {
                var winTotal = Bonuses.Rows.Cast<DataGridViewRow>().Where(t => t.Cells[3].Value != null).Sum(t => Convert.ToDecimal(t.Cells[4].Value));
                var bonusesOpened = Bonuses.Rows.Cast<DataGridViewRow>().Count(row => row.Cells[3].Value != null && row.Cells[4].Value != null);

                if (bonusesOpened == 0)
                {
                    lblRunningAverageWin.Text = $"Running Average Win: 0";
                }
                else
                {
                    var runningWinAverage = winTotal / bonusesOpened;
                    lblRunningAverageWin.Text = $"Running Average Win: {Math.Round(runningWinAverage, 2)}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void Bonuses_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                if (e.Column.Index != 0 && e.Column.Index != 3 && e.Column.Index != 4 && e.Column.Index != 5) return;
                e.SortResult = decimal.Parse(e.CellValue1.ToString()).CompareTo(decimal.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
            catch
            {
                // ignored
            }
        }

        private void Bonuses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Bonuses.Rows[e.RowIndex].ErrorText = "";
            decimal newDecimal;

            if (Bonuses.Rows[e.RowIndex].IsNewRow || e.FormattedValue.ToString() == "") { return; }

            switch (e.ColumnIndex)
            {
                case 3 when decimal.TryParse(e.FormattedValue.ToString(),
                    out newDecimal) && newDecimal > 0:
                    return;
                case 3:
                    e.Cancel = true;
                    Bonuses.Rows[e.RowIndex].ErrorText = "the value must be greater than 0";
                    break;
                case 4 when decimal.TryParse(e.FormattedValue.ToString(),
                    out newDecimal) && newDecimal >= 0:
                    return;
                case 4:
                    e.Cancel = true;
                    Bonuses.Rows[e.RowIndex].ErrorText = "the value must be 0 or greater";
                    break;
            }
        }
    }
}
