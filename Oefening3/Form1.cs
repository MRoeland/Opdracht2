namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbUSD_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbUSD.Text != "")
                {
                    double value = double.Parse(tbUSD.Text.ToString());
                    double valueBP = value * 0.88;
                    double valueEu = value * 1.02;
                    double valueY = value * 144.50;
                    double valueRu = value * 81.50;
                    double valueFr = value * 0.99;

                    tbBP.Text = valueBP.ToString();
                    tbEu.Text = valueEu.ToString();
                    tbY.Text = valueY.ToString();
                    tbRu.Text = valueRu.ToString();
                    tbFr.Text = valueFr.ToString();
                }
            }
        }

        private void tbBP_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbBP.Text != "")
                {
                    double value = double.Parse(tbBP.Text.ToString());
                    double valueUSD = value * 1.13;
                    double valueEu = value * 1.15;
                    double valueY = value * 163.79;
                    double valueRu = value * 92.32;
                    double valueFr = value * 1.12;

                    tbUSD.Text = valueUSD.ToString();
                    tbEu.Text = valueEu.ToString();
                    tbY.Text = valueY.ToString();
                    tbRu.Text = valueRu.ToString();
                    tbFr.Text = valueFr.ToString();
                }
            }
        }

        private void tbEu_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbEu.Text != "")
                {
                    double value = double.Parse(tbEu.Text.ToString());
                    double valueUSD = value * 0.98;
                    double valueBP = value * 0.87;
                    double valueY = value * 142.09;
                    double valueRu = value * 80.13;
                    double valueFr = value * 0.98;

                    tbUSD.Text = valueUSD.ToString();
                    tbBP.Text = valueBP.ToString();
                    tbY.Text = valueY.ToString();
                    tbRu.Text = valueRu.ToString();
                    tbFr.Text = valueFr.ToString();
                }
            }
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbY.Text != "")
                {
                    double value = double.Parse(tbY.Text.ToString());
                    double valueUSD = value * 0.0069;
                    double valueBP = value * 0.0061;
                    double valueEu = value * 0.0070;
                    double valueRu = value * 0.56;
                    double valueFr = value * 0.0069;

                    tbUSD.Text = valueUSD.ToString();
                    tbBP.Text = valueBP.ToString();
                    tbEu.Text = valueEu.ToString();
                    tbRu.Text = valueRu.ToString();
                    tbFr.Text = valueFr.ToString();
                }
            }
        }

        private void tbRu_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbRu.Text != "")
                {
                    double value = double.Parse(tbRu.Text.ToString());
                    double valueUSD = value * 0.012;
                    double valueBP = value * 0.011;
                    double valueEu = value * 0.012;
                    double valueY = value * 1.77;
                    double valueFr = value * 0.012;

                    tbUSD.Text = valueUSD.ToString();
                    tbBP.Text = valueBP.ToString();
                    tbEu.Text = valueEu.ToString();
                    tbY.Text = valueY.ToString();
                    tbFr.Text = valueFr.ToString();
                }
            }
        }

        private void tbFr_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                if (tbFr.Text != "")
                {
                    double value = double.Parse(tbFr.Text.ToString());
                    double valueUSD = value * 1.01;
                    double valueBP = value * 0.89;
                    double valueEu = value * 1.02;
                    double valueY = value * 145.60;
                    double valueRu = value * 82.12;

                    tbUSD.Text = valueUSD.ToString();
                    tbBP.Text = valueBP.ToString();
                    tbEu.Text = valueEu.ToString();
                    tbY.Text = valueY.ToString();
                    tbRu.Text = valueRu.ToString();
                }
            }
        }
    }
}