using MySqlConnector;

namespace StringGenerator
{
    public partial class StringGeneratorForm : Form
    {
        private readonly Worker _worker;
        public StringGeneratorForm()
        {
            InitializeComponent();
            _worker = new Worker();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _worker.StartThreads((int)ThreadAmount.Value, stringList);

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _worker.StopThreads();
        }
    }
}