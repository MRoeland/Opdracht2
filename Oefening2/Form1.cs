namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeluid_Click(object sender, EventArgs e)
        {
            if(cbKoe.Checked == true)
            {
                Koe koe = new Koe(80);
                MessageBox.Show(koe.uitspraak + " | File: " + koe.Zegt());
            }
            if (cbSlang.Checked)
            {
                Slang slang = new Slang(10);
                MessageBox.Show(slang.uitspraak + " | File: " + slang.Zegt());
            }
            if (cbVarken.Checked)
            {
                Varken varken = new Varken(50);
                MessageBox.Show(varken.uitspraak + " | File: " + varken.Zegt());
            }
        }
    }
}