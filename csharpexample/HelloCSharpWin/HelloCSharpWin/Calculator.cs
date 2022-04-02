namespace HelloCSharpWin
{
    /* April 2nd 2022
    * author: Thomas Lee
    * C# practice from Alongside Y's youtube.
    */

    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = " Hello C#";

            /*
            int number1 =10;
            string operator1 = "+";
            bool isCorrect = true; // it's either true or false

            int sum = 1 + 2;

            */

            //practice2.

            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }
    }
}