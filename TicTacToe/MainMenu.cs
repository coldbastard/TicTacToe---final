using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        #region Stałe sterujące uruchamianiem
        // przechowuje wartości bool sterujące logiką uruchamiania gry:
        private const bool AgainstComputer = true; // gra przeciwko komputerowi
        private const bool AgainstHuman = false;  // gra przeciwko człowiekowi
        private const bool HintMode = true; // gra w trybie z podpowiedziami
        private const bool NormalMode = false; // gra w trybie bez podpowiedzi
        private const string WindowNamePvP = "gracz vs gracz";
        private const string WindowNamePvC = "gracz vs komputer";
        #endregion

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            // uruchamia grę z drugim graczem
            frmBoard form_1 = new frmBoard(AgainstHuman, WindowNamePvP, NormalMode);
            form_1.ShowDialog();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            // uruchamia grę z komputerem w trybie bez podpowiedzi
            frmBoard form_1 = new frmBoard(AgainstComputer, WindowNamePvC, NormalMode);
            form_1.ShowDialog();
        }

        private void btnSP_PM_Click(object sender, EventArgs e)
        {
            //jeden gracz kontra komputer, tryb z podpowiedziami
            frmBoard form_1 = new frmBoard(AgainstComputer, WindowNamePvC, HintMode);
            form_1.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            string wiadomosc = "Gra \"kółko i krzyżyk\".\nTryby gry:\n"
                             + " - gra z komputerem\n - gra z komputerem z podpowiedziami\n - gracz kontra gracz"
                             + "\n ~ by: B.Zimny & A.Szulc";
            MessageBox.Show(wiadomosc, "O grze");
        }
    }
}
