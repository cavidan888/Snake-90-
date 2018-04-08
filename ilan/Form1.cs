using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilan
{
    public partial class Form1 : Form
    {
        List<Button> ilanParca = new List<Button>();
        Button Snake;
        Button Meal;
        int topPos = 40;
        int leftPos = 0;
        public Timer Bawla = new Timer();
        public Timer Saga = new Timer();
        public Timer Sola = new Timer();
        public Timer Yuxari = new Timer();
        public Timer Awagi = new Timer();
        public Form1()
        {
            InitializeComponent();
            createSnake();
            CreateMeal();
            Saga.Interval = 200;
            Bawla.Interval = 600;
           
            Saga.Tick += new System.EventHandler(this.TimerUp_Right);
            Sola.Interval = 200;
            Sola.Tick += new System.EventHandler(this.TimerLeft_Tick);
            Yuxari.Interval = 200;
            Yuxari.Tick += new System.EventHandler(this.TimerUp_Tick);
            Awagi.Interval = 200;
            Awagi.Tick += new System.EventHandler(this.TimerUp_Down);



        }


        public void createSnake()
        {

            Snake = new Button();
            Snake.Width = 20;
            Snake.Height = 20;
            Snake.BackColor = Color.Green;
            //Snake.Location = new Point(100, 100);
            Snake.Left += 20;
            Snake.Top = 150;
            this.Snake.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyUp);
            Controls.Add(Snake);
            ilanParca.Add(Snake);
            panel1.Controls.Add(Snake);



        }



       
        public void CreateMeal()
        {
            //Meal = new PictureBox();
            //Meal.Width = 10;
            //Meal.Height = 10;
            //Meal.BackColor = Color.Red;
            //Meal.Location = new Point(300, 150);
            //Controls.Add(Meal);


            Random rnd = new Random();
            int MealLeft = rnd.Next(0, this.panel1.Width / 40);
            int MealTop = rnd.Next(0, this.panel1.Height / 40);
            MealTop = MealTop * 40;
            MealLeft = MealLeft * 40;
            if (MealLeft % 40 == 0 && MealTop % 40 == 0)
            {
                Meal = new Button();
                Meal.Width = 20;
                Meal.Height = 20;
                Meal.BackColor = Color.Red;
                Meal.Left = MealLeft;
                Meal.Top = MealTop;
                Controls.Add(Meal);
                panel1.Controls.Add(Meal);
                
            }
            //else
            //{
            //    CreateMeal();
            //}

        }

        private void TimerUp_Tick(object sender, EventArgs e)
        {




            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i + 1].Top;
                ilanParca[i].Left = ilanParca[i + 1].Left;
            }





            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {


                Snake = new Button();
                Snake.Width = 20;
                Snake.Height = 20;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                
                ilanParca.Add(Snake);
                panel1.Controls.Add(Snake);
                panel1.Controls.Remove(Meal);
                CreateMeal();

            }
            if (topPos < 0)
            {
                topPos = this.Height - Snake.Height - 40;
            }
            topPos -= Snake.Width;
            Snake.Top = topPos;
        }

        private void TimerUp_Down(object sender, EventArgs e)
        {

            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i + 1].Top;
                ilanParca[i].Left = ilanParca[i + 1].Left;
            }

            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {

                Snake = new Button();
                Snake.Width = 20;
                Snake.Height = 20;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                
                panel1.Controls.Add(Snake);
                Meal.Hide();
                CreateMeal();
            }
            if (topPos > this.Height - Snake.Height - 17)
            {
                topPos = 0;
            }
            topPos += Snake.Width;
            Snake.Top = topPos;
        }

        private void TimerLeft_Tick(object sender, EventArgs e)
        {



            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i + 1].Top;
                ilanParca[i].Left = ilanParca[i + 1].Left;
            }


            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {



                Snake = new Button();
                Snake.Width = 20;
                Snake.Height = 20;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                panel1.Controls.Add(Snake);
                Meal.Hide();
                CreateMeal();
            }

            if (leftPos < 0)
            {
                leftPos = this.Width - Snake.Width + 17;
            }

            leftPos -= Snake.Width;
            Snake.Left = leftPos;
        }


        private void TimerUp_Right(object sender, EventArgs e)
        {
            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i+1].Top;
                ilanParca[i].Left = ilanParca[i+1].Left;
            }
           


            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {



                Snake = new Button();
                Snake.Width = 20;
                Snake.Height = 20;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                
                ilanParca.Add(Snake);
                panel1.Controls.Add(Snake);
                Meal.Hide();
                CreateMeal();

                //ilanParca.Add(Snake);
                //Snake.Left = ilanParca[ilanParca.Count - 1].Left;
                //Snake.Top = ilanParca[ilanParca.Count - 1].Top + 40;


            }
            if (leftPos > this.Width - Snake.Width + 17)
            {
                leftPos = 0;
            }
            leftPos += Snake.Width;
            Snake.Left = leftPos;
        }

        private void Snake_KeyUp(object sender, KeyEventArgs e)
        {
          

            if (e.KeyCode == Keys.Right)
            {
                Sola.Stop();
                Yuxari.Stop();
                Awagi.Stop();
                Saga.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                Sola.Start();
                Yuxari.Stop();
                Awagi.Stop();
                Saga.Stop();
            }
            if (e.KeyCode == Keys.Up)
            {
                Sola.Stop();
                Yuxari.Start();
                Awagi.Stop();
                Saga.Stop();
            }
            if (e.KeyCode == Keys.Down)
            {
                Sola.Stop();
                Yuxari.Stop();
                Awagi.Start();
                Saga.Stop();
            }
        }


        //private void uP_Click_1(object sender, EventArgs e)
        //{

        //    YuxariGet();
        //}

        //private void Down_Click_1(object sender, EventArgs e)
        //{

        //    AsagiGet();
        //}

        //private void Left_Click(object sender, EventArgs e)
        //{

        //    SolaGet();
        //}

        //private void Right_Click(object sender, EventArgs e)
        //{
        //    SagaGet();
        //}

       
    }
}