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
        private bool _isFlashed;
        private readonly WebClient _web = new WebClient();

        //POST requests
        private readonly byte[] _enable = Encoding.UTF8.GetBytes("ENABLE");
        private readonly byte[] _disable = Encoding.UTF8.GetBytes("DISABLE");

        //model
        private readonly Model _model;

        public MainForm()
        {
            InitializeComponent();

            _model = new Model {ToggleSetting = 150};

            txtToggleValue.Text = _model.ToggleSetting.ToString();

            // register data binding for current value label
            lblCurrentValue.DataBindings.Add("Text", _model, "ToggleSetting");

            // register data binding for flashed value label
            lblFlashState.DataBindings.Add("Text", _model, "Flashed");
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
        }

        private void OnNewGameState(GameState gs)
        {
            _model.Flashed = gs.Player.State.Flashed;

            if (!_isFlashed && _model.Flashed >= _model.ToggleSetting)
            {
                _web.UploadData("http://localhost:8990", "POST", _enable);
                _isFlashed = true;
            }
            else if (_isFlashed && _model.Flashed <= _model.ToggleSetting)
            {
                _web.UploadData("http://localhost:8990", "POST", _disable);
                _isFlashed = false;
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
            private int _flashed;
            public int Flashed
            {
                get => _flashed;
                set
                {
                    _flashed = value;
                    OnPropertyChanged();
                }
            }

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
