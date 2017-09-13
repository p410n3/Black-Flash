using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

//Gamestate Integration
using CSGSI;

//Http stuff to make post request to NegativeScreen
using System.Net;
using System.Runtime.CompilerServices;

namespace BlackFlash
{
    public partial class MainForm : Form
    {
        //Global Vars
        private int _flashed;
        private readonly WebClient _web = new WebClient();

        //POST requests
        private readonly byte[] _enable = Encoding.UTF8.GetBytes("ENABLE");
        private readonly byte[] _disable = Encoding.UTF8.GetBytes("DISABLE");

        private readonly Model _model;

        public MainForm()
        {
            InitializeComponent();

            _model = new Model {ToggleSetting = 150};

            txtToggleValue.Text = _model.ToggleSetting.ToString();

            // register data binding for current value label
            lblCurrentValue.DataBindings.Add("Text", _model, "ToggleSetting");
        }
    
        private void MainForm_Load(object sender, EventArgs e)
        {
            GameStateListener gsl = new GameStateListener(3000);
            gsl.NewGameState += OnNewGameState;
            if (!gsl.Start())
            {
                MessageBox.Show("Failed to start GameStateListener", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            void OnNewGameState(GameState gs)
            {
                _flashed = gs.Player.State.Flashed;
                lblFlashState.Text = Convert.ToString(_flashed);

                if (_flashed >= _model.ToggleSetting)
                {
                    _web.UploadData("http://localhost:8990", "POST", _enable);
                }
                else if(_flashed <= _model.ToggleSetting)
                {
                    _web.UploadData("http://localhost:8990", "POST", _disable);
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtToggleValue.Text, out int value))
            {
                if (value > 255 || value < 0)
                {
                    MessageBox.Show("Value should be between 0 and 255");
                }
                else
                {
                    _model.ToggleSetting = value;
                }
            }
            else
            {
                MessageBox.Show("Not a number!");
            }
        }

        private class Model : INotifyPropertyChanged
        {
            private int _toggleSetting;

            public int ToggleSetting
            {
                get => _toggleSetting;
                set
                {
                    _toggleSetting = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
