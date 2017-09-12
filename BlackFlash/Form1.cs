using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Gamestate Integration
using CSGSI;
using CSGSI.Nodes;

//Http stuff to make post request to NegativeScreen
using System.Net;
using System.Collections.Specialized;

namespace BlackFlash
{
    public partial class Form1 : Form
    {
        //Global Vars
        int flashed;
        WebClient web = new WebClient();
        int toggleSetting = 150;

        //POST requests
        byte[] enable = Encoding.UTF8.GetBytes("ENABLE");
        byte[] disable = Encoding.UTF8.GetBytes("DISABLE");


        public Form1()
        {
            InitializeComponent();            
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

            GameStateListener gsl = new GameStateListener(3000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                Environment.Exit(0);
            }

            void OnNewGameState(GameState gs)
            {
                flashed = gs.Player.State.Flashed;
                lblFlashState.Text = Convert.ToString(flashed);
                if (flashed >= toggleSetting)
                {
                    web.UploadData("http://localhost:8990", "POST", enable);
                }
                else if(flashed <= toggleSetting)
                {
                    web.UploadData("http://localhost:8990", "POST", disable);
                }
            }
        }

        private void toggleValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtToggleValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Not a number!");
                txtToggleValue.Text = "1";
            }

            if (((Convert.ToInt32(txtToggleValue.Text) > 255) || (Convert.ToInt32(txtToggleValue.Text) < 0)))
            {
                MessageBox.Show("Not a Number between 0 and 255");
                txtToggleValue.Text = "1";
            }

            toggleSetting = Convert.ToInt32(txtToggleValue.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFlashed_Click(object sender, EventArgs e)
        {

        }
    }
}
