using System;
using System.Drawing;
using System.Windows.Forms;

namespace RBG_For_Semilab
{
    public partial class Base_Form : Form
    {
        private int RedDec;
        private int GreenDec;
        private int BlueDec;
        private int CurrentRowId;

        public Base_Form()
        {
            InitializeComponent();
        }

        /*************************************************************FormEvents**************************************************************************/

        private void Base_Form_Load(object sender, EventArgs e)
        {
            this.AddButton_Click(null, null); //create the first row in the datagridview
        }

        /*********************************************************ScrollBarEvents**************************************************************************/

        private void RedScrollBar_ValueChanged(object sender, EventArgs e)
        {
            this.RedDec = this.RedScrollBar.Value;

            this.RgbDataGridView.Rows[this.CurrentRowId].Cells["RedColumn"].Value = this.RedDec.ToString("X");

            this.Color_Label.BackColor = Color.FromArgb(this.RedDec, this.GreenDec, this.BlueDec);

            this.RedScrollBarValueLabel.Text = (this.RedDec / 2.55 / 100).ToString("N2");
        }

        private void GreenScrollBar_ValueChanged(object sender, EventArgs e)
        {
            this.GreenDec = this.GreenScrollBar.Value;

            this.RgbDataGridView.Rows[this.CurrentRowId].Cells["GreenColumn"].Value = this.GreenDec.ToString("X");

            this.Color_Label.BackColor = Color.FromArgb(this.RedDec, this.GreenDec, this.BlueDec);

            this.GreenScrollBarValueLabel.Text = (this.GreenDec / 2.55 / 100).ToString("N2");
        }

        private void BlueScrollBar_ValueChanged(object sender, EventArgs e)
        {
            this.BlueDec = this.BlueScrollBar.Value;

            this.RgbDataGridView.Rows[this.CurrentRowId].Cells["BlueColumn"].Value = this.BlueDec.ToString("X");

            this.Color_Label.BackColor = Color.FromArgb(this.RedDec, this.GreenDec, this.BlueDec);

            this.BlueScrollBarValueLabel.Text = (this.BlueDec / 2.55 / 100).ToString("N2");
        }

        /*********************************************************DataGridViewEvent**************************************************************************/

        private void RgbDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentRowId = this.RgbDataGridView.CurrentRow.Index;

            if (this.RgbDataGridView.Rows[this.CurrentRowId].Cells["RedColumn"].Value == null
                || this.RgbDataGridView.Rows[this.CurrentRowId].Cells["GreenColumn"].Value == null
                || this.RgbDataGridView.Rows[this.CurrentRowId].Cells["BlueColumn"].Value == null)
            {
                this.RgbDataGridView.Rows[this.CurrentRowId].Cells["RedColumn"].Value = 0;
                this.RgbDataGridView.Rows[this.CurrentRowId].Cells["GreenColumn"].Value = 0;
                this.RgbDataGridView.Rows[this.CurrentRowId].Cells["BlueColumn"].Value = 0;
                return;
            }

            this.RedScrollBar.Value = Convert.ToInt32(this.RgbDataGridView.Rows[this.CurrentRowId].Cells["RedColumn"].Value.ToString(), 16);
            this.GreenScrollBar.Value = Convert.ToInt32(this.RgbDataGridView.Rows[this.CurrentRowId].Cells["GreenColumn"].Value.ToString(), 16);
            this.BlueScrollBar.Value = Convert.ToInt32(this.RgbDataGridView.Rows[this.CurrentRowId].Cells["BlueColumn"].Value.ToString(), 16);
        }

        /*********************************************************ButtonEvents*****************************************************************************/

        private void AddButton_Click(object sender, EventArgs e)
        {
            int rowId = this.RgbDataGridView.Rows.Add();
            this.RgbDataGridView.CurrentCell = this.RgbDataGridView.Rows[rowId].Cells[0];

            this.RedScrollBar.Value = 0;
            this.GreenScrollBar.Value = 0;
            this.BlueScrollBar.Value = 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
