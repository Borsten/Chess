using Chess.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {

        public List<Button> buttons = new List<Button> { };

        public Form1()
        {
            InitializeComponent();
            
            

            DrawBoard();
            
            
        }

        private void DrawBoard()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Button button = new Button();
                    button.Height = 60;
                    button.Width = 60;
                    button.Enabled = false;
                    button.Location = new Point(60 * i, 60 * j);

                    
                    this.Controls.Add(button);
                    button.Tag = new Point(i,j);
                    switch (j)
                    {
                        case 1:
                            switch (i)
                            {
                                case 1:
                                    button.Text = "Black Rook";                                    
                                    break;
                                case 2:
                                    button.Text = "Black Knight";
                                    break;
                                case 3:
                                    button.Text = "Black Bishop";
                                    break;
                                case 4:
                                    button.Text = "Black Queen";
                                    break;
                                case 5:
                                    button.Text = "Black King";
                                    break;
                                case 6:
                                    button.Text = "Black Bishop";
                                    break;
                                case 7:
                                    button.Text = "Black Knight";
                                    break;
                                case 8:
                                    button.Text = "Black Rook";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            button.Text = "Black Pawn";
                            break;
                        case 8:
                            switch (i)
                            {
                                case 1:
                                    button.Text = "White Rook";
                                    break;
                                case 2:
                                    button.Text = "White Knight";
                                    break;
                                case 3:
                                    button.Text = "White Bishop";
                                    break;
                                case 4:
                                    button.Text = "White Queen";
                                    break;
                                case 5:
                                    button.Text = "White King";
                                    break;
                                case 6:
                                    button.Text = "White Bishop";
                                    break;
                                case 7:
                                    button.Text = "White Knight";
                                    break;
                                case 8:
                                    button.Text = "White Rook";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 7:
                            button.Text = "White Pawn";
                            break;
                        default:
                            break;
                    }
                    button.Click += btn_Click;
                    button.Name = "btn_" + Convert.ToString(i) + Convert.ToString(j);
                    buttons.Add(button);                    
                }
            }
            ResetBoard();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ResetBoard();
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            foreach (Button button in buttons)
            {
                Point checkLocation = (Point)button.Tag;
                switch (clickedButton.Text)
                {
                    case "Black Rook":
                        if (location.X == checkLocation.X || location.Y == checkLocation.Y)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White Rook":
                        if (location.X == checkLocation.X || location.Y == checkLocation.Y)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "Black Knight":                        
                        if (location.X == checkLocation.X + 1 && location.Y == checkLocation.Y + 2 || location.X == checkLocation.X + 1 && location.Y == checkLocation.Y - 2
                            || location.X == checkLocation.X + 2 && location.Y == checkLocation.Y + 1 || location.X == checkLocation.X + 2 && location.Y == checkLocation.Y - 1
                            || location.X == checkLocation.X - 1 && location.Y == checkLocation.Y - 2 || location.X == checkLocation.X - 1 && location.Y == checkLocation.Y + 2
                            || location.X == checkLocation.X - 2 && location.Y == checkLocation.Y + 1 || location.X == checkLocation.X - 2 && location.Y == checkLocation.Y - 1)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White Knight":
                        if (location.X == checkLocation.X + 1 && location.Y == checkLocation.Y + 2 || location.X == checkLocation.X + 1 && location.Y == checkLocation.Y - 2
                            || location.X == checkLocation.X + 2 && location.Y == checkLocation.Y + 1 || location.X == checkLocation.X + 2 && location.Y == checkLocation.Y - 1
                            || location.X == checkLocation.X - 1 && location.Y == checkLocation.Y - 2 || location.X == checkLocation.X - 1 && location.Y == checkLocation.Y + 2
                            || location.X == checkLocation.X - 2 && location.Y == checkLocation.Y + 1 || location.X == checkLocation.X - 2 && location.Y == checkLocation.Y - 1)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "Black Bishop":
                        if (checkLocation.X - location.X == checkLocation.Y - location.Y 
                            || (checkLocation.X + location.X) + (checkLocation.Y + location.Y) == 2 * (location.X + location.Y))
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White Bishop":
                        if (checkLocation.X - location.X == checkLocation.Y - location.Y
                           || (checkLocation.X + location.X) + (checkLocation.Y + location.Y) == 2 * (location.X + location.Y))
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "Black Queen":
                        if (location.X == checkLocation.X || location.Y == checkLocation.Y || checkLocation.X - location.X == checkLocation.Y - location.Y
                            || (checkLocation.X + location.X) + (checkLocation.Y + location.Y) == 2 * (location.X + location.Y))
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White Queen":
                        if (location.X == checkLocation.X || location.Y == checkLocation.Y || checkLocation.X - location.X == checkLocation.Y - location.Y
                            || (checkLocation.X + location.X) + (checkLocation.Y + location.Y) == 2 * (location.X + location.Y))
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "Black King":
                        if (Math.Abs(location.X - checkLocation.X) == 1 && (Math.Abs(location.Y - checkLocation.Y) == 1 || location.Y - checkLocation.Y == 0)
                            || Math.Abs(location.Y - checkLocation.Y) == 1 && location.X == checkLocation.X)            
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White King":
                        if (Math.Abs(location.X - checkLocation.X) == 1 && (Math.Abs(location.Y - checkLocation.Y) == 1 || location.Y - checkLocation.Y == 0)
                            || Math.Abs(location.Y - checkLocation.Y) == 1 && location.X == checkLocation.X)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "Black Pawn":
                        if (location.Y == 2)
                        {
                            if (checkLocation.Y == location.Y + 2 && location.X == checkLocation.X)
                            {
                                button.BackColor = Color.Yellow;
                                button.Enabled = true;
                            }
                        }
                        if (checkLocation.Y == location.Y + 1 && location.X == checkLocation.X)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    case "White Pawn":
                        if (location.Y == 7)
                        {
                            if (checkLocation.Y == location.Y - 2 && location.X == checkLocation.X)
                            {
                                button.BackColor = Color.Yellow;
                                button.Enabled = true;
                            }
                        }
                        if (checkLocation.Y == location.Y - 1 && location.X == checkLocation.X)
                        {
                            button.BackColor = Color.Yellow;
                            button.Enabled = true;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void ResetBoard()
        {
            foreach (Button button in buttons)
            {
                Point location = (Point)button.Tag;
                if (button.Text != "")
                {
                    button.Enabled = true;
                }
                if (location.X % 2 == location.Y % 2)
                {
                    button.BackColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.SaddleBrown;
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
    }
}
