namespace LocadoraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarMídiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaMidia frmnovamidia = new FrmNovaMidia();
            frmnovamidia.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaMidias frmlistamidias = new frmListaMidias();
            frmlistamidias.Show();
        }
    }
}