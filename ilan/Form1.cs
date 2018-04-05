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
        List<PictureBox> ilanParca = new List<PictureBox>();
        PictureBox Snake;
        PictureBox Meal;
        int topPos;
        int leftPos;
        public Form1()
        {
            InitializeComponent();
            createSnake();
            CreateMeal();
            
        }


        public void createSnake()
        {
           
                Snake = new PictureBox();
                Snake.Width = 10;
                Snake.Height = 10;
                Snake.BackColor = Color.Red;
                Snake.Location = new Point(100, 100);
                Snake.Left += 40;
                Snake.Top = 150;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
            

           

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
            int MealLeft = rnd.Next(0, this.Width / 40);
            int MealTop = rnd.Next(0, this.Height / 40);
            MealTop = MealTop * 40;
            MealLeft = MealLeft * 40;
            if (MealLeft % 40 == 0 && MealTop % 40 == 0)
            {
                Meal = new PictureBox();
                Meal.Width = 10;
                Meal.Height = 10;
                Meal.BackColor = Color.Green;
                Meal.Left = MealLeft;
                Meal.Top = MealTop;
                Controls.Add(Meal);
            }
            else
            {
                CreateMeal();
            }

        }

        public void YuxariGet()
        {
            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {
               

                Snake = new PictureBox();
                Snake.Width = 10;
                Snake.Height = 10;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                Meal.Hide();
                CreateMeal();

            }
            topPos -= 10;
            Snake.Top = topPos;
        }

        public void AsagiGet()
        {

            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {
                

                Snake = new PictureBox();
                Snake.Width = 10;
                Snake.Height = 10;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                Meal.Hide();
                CreateMeal();
            }
            topPos += 10;
            Snake.Top = topPos;
        }

        public void SolaGet()
        {

            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i + 1].Top;
                ilanParca[i].Left = ilanParca[i + 1].Left;
            }
            int a = 0;
            foreach (var item in ilanParca)
            {
                a++;
                if (ilanParca.Count == a)
                {
                    item.Left += 40;
                }
            }



            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {
              
                

                Snake = new PictureBox();
                Snake.Width = 10;
                Snake.Height = 10;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                Meal.Hide();
                CreateMeal();
            }
            leftPos -= 10;
            Snake.Left = leftPos;
        }


        public void SagaGet()
        {
            for (int i = 0; i < ilanParca.Count - 1; i++)
            {
                ilanParca[i].Top = ilanParca[i + 1].Top;
                ilanParca[i].Left = ilanParca[i + 1].Left;
            }
            int a = 0;
            foreach (var item in ilanParca)
            {
                a++;
                if (ilanParca.Count == a)
                {
                    item.Left += 40;
                }
            }

           

            if ((Snake.Top == Meal.Top) && (Snake.Left == Meal.Left))
            {
               


                Snake = new PictureBox();
                Snake.Width = 10;
                Snake.Height = 10;
                Snake.BackColor = Color.Green;
                Snake.Left = ilanParca[ilanParca.Count - 1].Left + 40;
                Snake.Top = ilanParca[ilanParca.Count - 1].Top;
                Controls.Add(Snake);
                ilanParca.Add(Snake);
                Meal.Hide();
                CreateMeal();

                //ilanParca.Add(Snake);
                //Snake.Left = ilanParca[ilanParca.Count - 1].Left;
                //Snake.Top = ilanParca[ilanParca.Count - 1].Top + 40;

            }
            leftPos += 10;
            Snake.Left = leftPos;
        }

        

        private void uP_Click_1(object sender, EventArgs e)
        {
           
            YuxariGet();
        }

        private void Down_Click_1(object sender, EventArgs e)
        {
            
            AsagiGet();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            
            SolaGet();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            SagaGet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
