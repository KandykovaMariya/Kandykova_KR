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
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog=Kandykova_KR;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        DataContext context = new DataContext(conStr);

        public Form1()
        {
            InitializeComponent();
            Table<result_sportsman> sresult = context.GetTable<result_sportsman>();
            dataGridView1.DataSource = sresult.ToList();

            Table<result_team> Tresult = context.GetTable<result_team>();
            dataGridView2.DataSource = Tresult.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_sportsman newResult = new result_sportsman
            {
                id_sportsman = Convert.ToInt32(textBox1.Text),
                place_student = Convert.ToString(textBox2.Text),
                sport = Convert.ToInt32(textBox3.Text),
            };

            context.GetTable<result_sportsman>().InsertOnSubmit(newResult);
            context.SubmitChanges();
            Table<result_sportsman> result_s = context.GetTable<result_sportsman>();
            dataGridView1.DataSource = result_s.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            result_team newResult1 = new result_team
            {
                id_team = Convert.ToInt32(textBox4.Text),
                id_tournament = Convert.ToInt32(textBox5.Text),
                result_teams = Convert.ToString(textBox6.Text),
                place_team = Convert.ToString(textBox7.Text),
                sport = Convert.ToInt32(textBox8.Text),
            };

            context.GetTable<result_team>().InsertOnSubmit(newResult1);
            context.SubmitChanges();
            Table<result_team> result_s1 = context.GetTable<result_team>();
            dataGridView2.DataSource = result_s1.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_sportsman result_Sportsman = context.GetTable<result_sportsman>().FirstOrDefault(
               x => x.id_result_sportsman == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            result_Sportsman.id_sportsman = Convert.ToInt32(textBox1.Text);
            result_Sportsman.place_student = Convert.ToString(textBox2.Text);
            result_Sportsman.sport = Convert.ToInt32(textBox3.Text);
            context.SubmitChanges();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            result_sportsman result_Sportsman = context.GetTable<result_sportsman>().FirstOrDefault(
                x => x.id_result_sportsman == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = result_Sportsman.id_sportsman.ToString();
            textBox2.Text = result_Sportsman.place_student.ToString();
            textBox3.Text = result_Sportsman.sport.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            result_team result_Team = context.GetTable<result_team>().FirstOrDefault(
               x => x.id_result_team == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            textBox4.Text = result_Team.id_team.ToString();
            textBox5.Text = result_Team.id_tournament.ToString();
            textBox6.Text = result_Team.result_teams.ToString();
            textBox7.Text = result_Team.place_team.ToString();
            textBox8.Text = result_Team.sport.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_team result_Team = context.GetTable<result_team>().FirstOrDefault(
               x => x.id_result_team == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            result_Team.id_team = Convert.ToInt32(textBox4.Text);
            result_Team.id_tournament = Convert.ToInt32(textBox5.Text);
            result_Team.result_teams = Convert.ToString(textBox6.Text);
            result_Team.place_team = Convert.ToString(textBox7.Text);
            result_Team.sport = Convert.ToInt32(textBox8.Text);
            context.SubmitChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
