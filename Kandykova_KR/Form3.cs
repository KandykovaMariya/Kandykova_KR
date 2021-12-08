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
    public partial class Form3 : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog=Kandykova_KR;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        DataContext context = new DataContext(conStr);
        public Form3()
        {
            InitializeComponent();

            Table<venue> venues = context.GetTable<venue>();
            dataGridView1.DataSource = venues.ToList();

            Table<tournament> tournaments = context.GetTable<tournament>();
            dataGridView2.DataSource = tournaments.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venue newVenue = new venue
            {
                name_place = textBox1.Text,
                country = textBox2.Text,
                city = textBox3.Text,
                date_open = Convert.ToDateTime(textBox4.Text),
            };

            context.GetTable<venue>().InsertOnSubmit(newVenue);
            context.SubmitChanges();
            Table<venue> venues = context.GetTable<venue>();
            dataGridView1.DataSource = venues.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tournament newTournament = new tournament
            {
                number_of_student = textBox5.Text,
                name_place = Convert.ToInt32(textBox6.Text),
                date_of_start = Convert.ToDateTime(textBox7.Text),
                date_of_finish = Convert.ToDateTime(textBox8.Text),
            };

            context.GetTable<tournament>().InsertOnSubmit(newTournament);
            context.SubmitChanges();
            Table<tournament> tournaments = context.GetTable<tournament>();
            dataGridView2.DataSource = tournaments.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            venue venues = context.GetTable<venue>().FirstOrDefault(
              x => x.id_venue == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            venues.name_place = textBox1.Text;
            venues.country = textBox2.Text;
            venues.city = textBox3.Text;
            venues.date_open = Convert.ToDateTime(textBox4.Text);
            context.SubmitChanges();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            venue venues = context.GetTable<venue>().FirstOrDefault(
                x => x.id_venue == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = venues.name_place.ToString();
            textBox2.Text = venues.country.ToString();
            textBox3.Text = venues.city.ToString();
            textBox4.Text = venues.date_open.ToLongDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tournament tournaments = context.GetTable<tournament>().FirstOrDefault(
          x => x.id_tournament == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            tournaments.number_of_student = textBox5.Text;
            tournaments.name_place = Convert.ToInt32(textBox6.Text);
            tournaments.date_of_start = Convert.ToDateTime(textBox7.Text);
            tournaments.date_of_finish = Convert.ToDateTime(textBox8.Text);
            context.SubmitChanges();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tournament tournaments = context.GetTable<tournament>().FirstOrDefault(
                x => x.id_tournament == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            textBox5.Text = tournaments.number_of_student;
            textBox6.Text = tournaments.name_place.ToString();
            textBox7.Text = tournaments.date_of_start.ToLongDateString();
            textBox8.Text = tournaments.date_of_finish.ToLongDateString();

        }
    }
}
