using Mill.Model;
using Mill.Persistence;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Mill
{
    public partial class GameForm : Form
    {
        #region Fields
        private IMillDataAccess _dataAccess;
        private MillGameModel _model;
        #endregion

        #region Constructors 
        public GameForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form event handlers
        private void GameForm_Load(Object sender, EventArgs e)
        {
            _dataAccess = new MillFileDataAccess();
            
            _model = new MillGameModel(_dataAccess);
            _model.GameAdvanced += new EventHandler<MillEventArgs>(Game_GameAdvanced);
            _model.GameOver += new EventHandler<MillEventArgs>(Game_GameOver);
            _model.PlayerHasToPass += new EventHandler<PassingEventArgs>(Game_PlayerHasToPass);

            SetupTable();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            
            int x1 = 50;
            int y1 = 50;
            int width1 = 600;
            int height1 = 600;

            int x2 = 150;
            int y2 = 150;
            int width2 = 400;
            int height2 = 400;

            int x3 = 250;
            int y3 = 250;
            int width3 = 200;
            int height3 = 200;

            int line1x1 = 350;
            int line1y1 = 50;
            int line1x2 = 350;
            int line1y2 = 250;

            int line2x1 = 450;
            int line2y1 = 350;
            int line2x2 = 650;
            int line2y2 = 350;

            int line3x1 = 350;
            int line3y1 = 450;
            int line3x2 = 350;
            int line3y2 = 650;

            int line4x1 = 50;
            int line4y1 = 350;
            int line4x2 = 250;
            int line4y2 = 350;

            e.Graphics.DrawRectangle(blackPen, x1, y1, width1, height1);
            e.Graphics.DrawRectangle(blackPen, x2, y2, width2, height2);
            e.Graphics.DrawRectangle(blackPen, x3, y3, width3, height3);

            e.Graphics.DrawLine(blackPen, line1x1, line1y1, line1x2, line1y2);
            e.Graphics.DrawLine(blackPen, line2x1, line2y1, line2x2, line2y2);
            e.Graphics.DrawLine(blackPen, line3x1, line3y1, line3x2, line3y2);
            e.Graphics.DrawLine(blackPen, line4x1, line4y1, line4x2, line4y2);
        }
        
        #endregion

        #region Menu event handlers
        private void _newGameMenuItem_Click(object sender, EventArgs e)
        {
            _saveGameMenuItem.Enabled = true;
            _model.NewGame();
            SetupTable();
        }

        private async void SaveGameMenuItem_Click(object sender, EventArgs e)
        {
            if (_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // save game
                    await _model.SaveGameAsync(_saveFileDialog.FileName);
                }
                catch (MillDataException)
                {
                    MessageBox.Show("Játék mentése sikertelen!" + Environment.NewLine + "Hibás az elérési út, vagy a könyvtár nem írható.", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void LoadGameMenuItem_Click(Object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // játék betöltése
                    await _model.LoadGameAsync(_openFileDialog.FileName);
                    _saveGameMenuItem.Enabled = true;
                }
                catch (MillDataException ex)
                {
                    MessageBox.Show("Játék betöltése sikertelen!" + Environment.NewLine + "Hibás az elérési út, vagy a fájlformátum." + Environment.NewLine + ex.Path, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _model.NewGame();
                    _saveGameMenuItem.Enabled = true;
                }
                SetupTable();
            }
        }
        #endregion

        #region Game event handlers
        private void Game_GameAdvanced(Object sender, MillEventArgs e)
        {
            string currentPlayer;
            if (e.CurrentPlayer == Player.Player1) currentPlayer = "Elsõ játékos";
            else currentPlayer = "Második játékos";
            _currentPlayerText.Text = currentPlayer;
            _talonNumberPlayer1.Text = e.Player1Talon.ToString();
            _talonNumberPlayer2.Text = e.Player2Talon.ToString();
            
            string nextStep = "";
            if (e.CurrentAction == Mill.Model.Action.Adding) nextStep = "Tegyél fel egy korongot!";
            if (e.CurrentAction == Mill.Model.Action.Removing) nextStep = "Vegyél le az ellenféltõl egy korongot!";
            if (e.CurrentAction == Mill.Model.Action.MoveDest) nextStep = "Jelöld ki mivel akarsz mozogni!";
            if (e.CurrentAction == Mill.Model.Action.MoveTarget) nextStep = "Jelöld ki hova akarsz mozogni!";
            _nextStepLabelText.Text = nextStep;
        }

        private void Game_GameOver(Object sender, MillEventArgs e)
        {
            _saveGameMenuItem.Enabled = false;
            foreach (Button button in tableLayoutPanel1.Controls) // turn off buttons
            {
                button.Enabled = false;
            }

            String strPlayer;
            if (e.CurrentPlayer == Player.Player1) strPlayer = "Elsõ játékos";
            else strPlayer = "Második játékos";

            MessageBox.Show("Gratulálok, gyõztél " + strPlayer + "!" + Environment.NewLine,
                                "Malom játék",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
        }

        private void Game_PlayerHasToPass(Object sender, PassingEventArgs e)
        {
            String strPlayer;
            String action;
            if (e.CurrentPlayer == Player.Player1) strPlayer = "Elsõ játékos";
            else strPlayer = "Második játékos";
            if (e.MoveToken == true) action = "mozogni";
            else action = "ellenséges bábut levenni";
            MessageBox.Show(strPlayer + " passzolnod kell, nem tusz " + action + "!" + Environment.NewLine,
                                "Passzolj!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
        }

        private void MenuFileExit_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Malom játék", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Field event handlers

        private void FieldButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int field = button.TabIndex;
            _model.Step(field);

            //refresh field in view
            if (_model.Table.Fields[field].Player == 0)
            {
                button.BackColor= Color.White;
            }
            if (_model.Table.Fields[field].Player == 1)
            {
                button.BackColor = Color.Blue;
            }
            if (_model.Table.Fields[field].Player == 2)
            {
                button.BackColor = Color.Red;
            }

            //when succesfully moved a token, delete the old place -- can be done with Game_GameAdvanced event or custom event
            if (_model.CurrentAction == Model.Action.MoveTarget)
            {
                int last = _model.LastField;
                foreach (Button lastButton in tableLayoutPanel1.Controls)
                {
                    if (lastButton.TabIndex == last) lastButton.BackColor = Color.White;
                }
            }
        }
        #endregion
        
        #region Private methods
        private void SetupTable()
        {
            for (int i = 0; i < _model.Table.Fields.Length; i++)
            {
                foreach (Button button in tableLayoutPanel1.Controls)
                {
                    if (button.TabIndex == i)
                    {
                        if (_model.Table.GetField(i).Player == 0) button.BackColor = Color.White;
                        if (_model.Table.GetField(i).Player == 1) button.BackColor = Color.Blue;
                        if (_model.Table.GetField(i).Player == 2) button.BackColor = Color.Red;
                    }
                }
            }
            
            string currentPlayer;
            int player1Talon = _model.Table.Player1UnusedToken;
            int player2Talon = _model.Table.Player2UnusedToken;
            if (_model.CurrentPlayer == Player.Player1) currentPlayer = "Elsõ játékos";
            else currentPlayer = "Második játékos";
            _currentPlayerText.Text = currentPlayer;
            _talonNumberPlayer1.Text = player1Talon.ToString();
            _talonNumberPlayer2.Text = player2Talon.ToString();

            string nextStep = "";
            if (_model.CurrentAction == Mill.Model.Action.Adding) nextStep = "Tegyél fel egy korongot!";
            if (_model.CurrentAction == Mill.Model.Action.Removing) nextStep = "Vegyél le az ellenféltõl egy korongot!";
            if (_model.CurrentAction == Mill.Model.Action.MoveDest) nextStep = "Jelöld ki mivel akarsz mozogni!";
            if (_model.CurrentAction == Mill.Model.Action.MoveTarget) nextStep = "Jelöld ki hova akarsz mozogni!";
            _nextStepLabelText.Text = nextStep;
        }
        #endregion
    
    }
}