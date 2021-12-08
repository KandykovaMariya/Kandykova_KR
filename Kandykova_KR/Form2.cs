using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_KR
{
    public partial class Form2 : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog=Kandykova_KR;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        DataContext context = new DataContext(conStr);
        public Form2()
        {
            InitializeComponent();

            Table<student> students = context.GetTable<student>();
            dataGridView1.DataSource = students.ToList();

            Table<sportsman> sportsM = context.GetTable<sportsman>();
            dataGridView2.DataSource = sportsM.ToList();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            student student1 = context.GetTable<student>().FirstOrDefault(x => x.id_student
            == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = student1.first_name;
            textBox2.Text = student1.last_name;
            textBox3.Text = student1.patronymic;
            textBox4.Text = student1.date_of_birth.ToLongDateString();
            textBox5.Text = student1.specialnost.ToString();
            textBox6.Text = student1.phone.ToString();
            textBox7.Text = student1.email.ToString();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sportsman sportsman1 = context.GetTable<sportsman>().FirstOrDefault(x => x.id_sportsman
            == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            textBox8.Text = sportsman1.id_student.ToString();
            textBox9.Text = sportsman1.id_team.ToString();
            textBox10.Text = sportsman1.gender.ToString();
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student newStudent = new student
            {
                first_name = textBox1.Text,
                last_name = textBox2.Text,
                patronymic = textBox3.Text,
                date_of_birth = Convert.ToDateTime(textBox4.Text),
                specialnost = Convert.ToInt32(textBox5.Text),
                phone = textBox6.Text,
                email = textBox7.Text,
            };

            context.GetTable<student>().InsertOnSubmit(newStudent);
            context.SubmitChanges();
            Table<student> students = context.GetTable<student>();
            dataGridView1.DataSource = students.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student student1 = context.GetTable<student>().FirstOrDefault(
   x => x.id_student == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            student1.first_name = textBox1.Text;
            student1.last_name = textBox2.Text;
            student1.patronymic = textBox3.Text;
            student1.date_of_birth = Convert.ToDateTime(textBox4.Text);
            student1.specialnost = Convert.ToInt32(textBox5.Text);
            student1.phone = Convert.ToString(textBox6.Text);
            student1.email = Convert.ToString(textBox7.Text);
            context.SubmitChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sportsman newSportsman = new sportsman
            {
                id_student = Convert.ToInt32(textBox8.Text),
                id_team = Convert.ToInt32(textBox9.Text),
                gender = Convert.ToInt32(textBox10.Text),

            };

            context.GetTable<sportsman>().InsertOnSubmit(newSportsman);
            context.SubmitChanges();
            Table<sportsman> students = context.GetTable<sportsman>();
            dataGridView2.DataSource = students.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sportsman sportsman1 = context.GetTable<sportsman>().FirstOrDefault(
  x => x.id_sportsman == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));

            sportsman1.id_student = Convert.ToInt32(textBox8.Text);
            sportsman1.id_team = Convert.ToInt32(textBox9.Text);
            sportsman1.gender = Convert.ToInt32(textBox10.Text);
            context.SubmitChanges();
        }
    }
}
