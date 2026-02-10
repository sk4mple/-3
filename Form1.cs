namespace Модуль_3
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();

            double[] data = new double[16];
            for (int i = 0; i < 16; i++)
            {
                data[i] = Random.Shared.Next(1, 101);
            }
            formsPlot.Plot.Add.Signal(data);
            formsPlot.Refresh();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Автор: Тюфтин Егор Максимович . 10.02.2026",
                "О программе",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void opentoolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Фунция будет добавлена позже",
                "Информация",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void formsPlot_Load(object sender, EventArgs e)
        {

        }
    }
}
