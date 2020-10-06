using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_itProger
{
    public partial class Form1 : Form
    {
        private int speedvertical=6;
        private int speedhorisontal = 6;
        private int score = 0;
        List<PictureBox> enemList = new List<PictureBox>();        
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true; // включаем таймер
            Cursor.Hide();//скрываем курсор
            this.FormBorderStyle = FormBorderStyle.None;//убираем рамку формы
           this.TopMost = true;// показываем форму поверх всех окон
           this.Bounds = Screen.PrimaryScreen.Bounds; //размер окна будет полноэкранный
            label2.Text = "";
           
            gamepanel.Top = BackGround.Bottom -(BackGround.Bottom / 10); // устанавливаем отбиватель чуть выше низа формы
            
            int count = BackGround.Width / 30;
            for (int i = 0; i < count; i++)    // добавляев "врагов"
            {
                
                for (int h=0;h<5 ;h++ ) { 
                PictureBox pcb = new PictureBox();
                pcb.BackColor = Color.Red;
                pcb.Size = new Size(30,30);
                pcb.Left = BackGround.Left + 30*i;
                pcb.Top = BackGround.Top + 50*h;
                BackGround.Controls.Add(pcb);
                enemList.Add(pcb);
                }

            }






        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// по нажатию esc будет закрываться форма
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.R) // рестарт
            {
                
                gameball.Top = 300;
                gameball.Left = 300;
                speedhorisontal = 6;
                speedvertical = 6;
                score = 0;
                label2.Text = "";
                timer1.Enabled=true;
                label1.Text = $"Score: {score}";
                

                int count = BackGround.Width / 30;

                foreach (PictureBox enemy in enemList) // удаляет массив врагов
                {
                    BackGround.Controls.Remove(enemy);
                }
                for (int i = 0; i < count; i++)    // добавляев "врагов"
                {

                    for (int h = 0; h < 5; h++)
                    {
                        PictureBox pcb = new PictureBox();
                        pcb.BackColor = Color.Red;
                        pcb.Size = new Size(30, 30);
                        pcb.Left = BackGround.Left + 30 * i;
                        pcb.Top = BackGround.Top + 50 * h;
                        BackGround.Controls.Add(pcb);
                        enemList.Add(pcb);
                    }

                }
            }

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2); // позиция панели изменяется с курсором , который стоит на ее середине
            gameball.Left += speedhorisontal;
            gameball.Top += speedvertical;

            if (gameball.Left <= BackGround.Left)  // при касании мачем верха, левой и правой стороны экрана он отскакивает
                speedhorisontal *= -1;
            if (gameball.Right >= BackGround.Right) 
                speedhorisontal *= -1;
            if (gameball.Top <= BackGround.Top)
                speedvertical *= -1;
            if (gameball.Bottom >= BackGround.Bottom) // если касается дна то игра заканчивается
            {
                timer1.Enabled = false;
                
                label2.Text = "You loose! HaHa";
                label2.Left = (BackGround.Width / 2) - (label2.Width / 2);
                label2.Top = BackGround.Height / 2;
                
                foreach (PictureBox enemy in enemList) // удаляет массив врагов
                {
                    BackGround.Controls.Remove(enemy);
                }

            }
            if (gameball.Bottom >= gamepanel.Top   // при касании панельки  мяч отскакиевает
                && gameball.Bottom <= gamepanel.Bottom
                && gameball.Left >= gamepanel.Left
                && gameball.Right <= gamepanel.Right)
            {
                
                speedvertical *= -1;
                score++;
                Random rColor = new Random();
                BackGround.BackColor = Color.FromArgb(rColor.Next(150,255), rColor.Next(150, 255), rColor.Next(150, 255));// меняет цвет фона

            }
            foreach (PictureBox enemy in enemList) {  // если мяч касается любого из врагов , то отскакивает
                if (gameball.Bottom >=enemy.Top-3
    
                    && gameball.Top <= enemy.Bottom+3
                    && gameball.Left >= enemy.Left-3
                    && gameball.Right <= enemy.Right+3)
                {
                    enemy.Top = -50;
                    
                    speedvertical *= -1;
                    score++;
                    BackGround.Controls.Remove(enemy);

                }
            }
            label1.Text =$"Score: {score}";// пишет количество очков



        }
    }
}
