namespace TypographZhoskyStyle
{
    public partial class TypographZhoskyStyle : Form
    {
        public string res = String.Empty;
        public TypographZhoskyStyle()
        {
            InitializeComponent();
        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_txt.Text))
            {
                string text = text_txt.Text;
                res = ClassOfRules.FirstRule(text);
                res = ClassOfRules.SecondRule(res);
                res = ClassOfRules.NinthRule(res);
                res = ClassOfRules.ThirteenthRule(res);
                res = ClassOfRules.SalamRule(res);
                res = ClassOfRules.TheBestRule(res);
                text_txt.Text = res;
            }
            else
            {
                MessageBox.Show("Вы ничё не ввели.");
            }
        }
    }
}
