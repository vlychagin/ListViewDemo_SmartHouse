namespace SmartHouse
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }


        private void ApplicationExit_Action(object sender, EventArgs e) =>
            Application.Exit();
    }
}
