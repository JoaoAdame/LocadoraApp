namespace LocadoraApp
{
    public partial class LocadoraApp : Form
    {
        public LocadoraApp()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaLocacao frmNovaLocacao = new FrmNovaLocacao();
            frmNovaLocacao.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaLocacao frmListaLocacao = new FrmListaLocacao();
            frmListaLocacao.Show();
        }
    }
}