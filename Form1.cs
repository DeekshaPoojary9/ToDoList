using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secret_to_do_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool tsk1 = false;
        bool tsk2 = false;
        bool tsk3 = false;
        bool tsk4 = false;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextNewTask.Text))
            {
                MessageBox.Show("Please enter a task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!panel1.Visible)
            {
                textBox1.Text = TextNewTask.Text;
                panel1.Visible = true;
                panel1.BackColor = SystemColors.Control;
            }
            else if (!panel2.Visible)
            {
                textBox2.Text = TextNewTask.Text;
                panel2.Visible = true;
                panel2.BackColor = SystemColors.Control;
            }
            else if (!panel3.Visible)
            {
                textBox3.Text = TextNewTask.Text;
                panel3.Visible = true;
                panel3.BackColor = SystemColors.Control;
            }
            else if (!panel4.Visible)
            {
                textBox4.Text = TextNewTask.Text;
                panel4.Visible = true;
                panel4.BackColor = SystemColors.Control; 
            }
            else
            {
                MessageBox.Show("Please delete a task before adding a new one.");
            }

            TextNewTask.Clear();
        }


        private void delete1_Click(object sender, EventArgs e)
        {
            tsk1 = false;
            panel1.Visible = false;
            ShiftTasks();
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            tsk2 = false;
            panel2.Visible = false;
            ShiftTasks();
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            tsk3 = false;
            panel3.Visible = false;
            ShiftTasks();
        }

        private void delete4_Click(object sender, EventArgs e)
        {
            tsk4 = false;
            panel4.Visible = false;
            ShiftTasks();
        }

        private void done1_Click(object sender, EventArgs e)
        {
            tsk1 = true;
            panel1.BackColor = Color.LightGreen;
        }

        private void done2_Click(object sender, EventArgs e)
        {
            tsk2 = true;
            panel2.BackColor = Color.LightGreen;
        }

        private void done3_Click(object sender, EventArgs e)
        {
            tsk3 = true;
            panel3.BackColor = Color.LightGreen;
        }

        private void done4_Click(object sender, EventArgs e)
        {
            tsk4 = true;
            panel4.BackColor = Color.LightGreen;
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            ok1.Visible = true;
            textBox1.ReadOnly = false;
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            ok2.Visible = true;
            textBox2.ReadOnly = false;
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            ok3.Visible = true;
            textBox3.ReadOnly = false;
        }

        private void edit4_Click(object sender, EventArgs e)
        {
            ok4.Visible = true;
            textBox4.ReadOnly = false;
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            ok1.Visible = false;
            textBox1.ReadOnly = true;
        }

        private void ok2_Click(object sender, EventArgs e)
        {
            ok2.Visible = false;
            textBox2.ReadOnly = true;
        }

        private void ok3_Click(object sender, EventArgs e)
        {
            ok3.Visible = false;
            textBox3.ReadOnly = true;
        }

        private void ok4_Click(object sender, EventArgs e)
        {
            ok4.Visible = false;
            textBox4.ReadOnly = true;
        }

        private void ShiftTasks()
        {
            if (!panel1.Visible && panel2.Visible)
            {
                textBox1.Text = textBox2.Text;
                panel1.BackColor = panel2.BackColor; 
                panel1.Visible = true;

                textBox2.Text = textBox3.Text;
                panel2.BackColor = panel3.BackColor; 
                panel2.Visible = panel3.Visible;

                textBox3.Text = textBox4.Text;
                panel3.BackColor = panel4.BackColor; 
                panel3.Visible = panel4.Visible;

                textBox4.Text = "";
                panel4.BackColor = SystemColors.Control; 
                panel4.Visible = false;
            }
            else if (!panel2.Visible && panel3.Visible)
            {
                textBox2.Text = textBox3.Text;
                panel2.BackColor = panel3.BackColor; 
                panel2.Visible = true;

                textBox3.Text = textBox4.Text;
                panel3.BackColor = panel4.BackColor;
                panel3.Visible = panel4.Visible;

                textBox4.Text = "";
                panel4.BackColor = SystemColors.Control; 
                panel4.Visible = false;
            }
            else if (!panel3.Visible && panel4.Visible)
            {
                textBox3.Text = textBox4.Text;
                panel3.BackColor = panel4.BackColor; 
                panel3.Visible = true;

                textBox4.Text = "";
                panel4.BackColor = SystemColors.Control; 
                panel4.Visible = false;
            }
        }

    }
}
