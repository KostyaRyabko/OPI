using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPI
{
    public partial class main : Form
    {
        String FileName1;
        String FileName2;
        String FileName3;
        Form_inp_out f2 = new Form_inp_out();
        
        public main()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileName1 = "students";
            FileName2 = "teachers";
            int u = 0;
            try
            {
                var Reader = new StreamReader(FileName1, Encoding.Default);

                string line;

                while ((line = Reader.ReadLine()) != null)
                {
                    Students.Items.Add(line);
                }
                Reader.Close();

                var Reader2 = new StreamReader(FileName2, Encoding.Default);
                string line2;

                while ((line2 = Reader2.ReadLine()) != null)
                {
                    Employees.Items.Add(line2);
                }
                Reader2.Close();
            }
            catch
            {
                var Reader = new StreamReader(File.Create(FileName1), Encoding.Default);

                string line;

                while ((line = Reader.ReadLine()) != null)
                {
                    Students.Items.Add(line);
                }
                Reader.Close();

                var Reader2 = new StreamReader(File.Create(FileName2), Encoding.Default);
                string line2;

                while ((line2 = Reader2.ReadLine()) != null)
                {
                    Employees.Items.Add(line2);
                }
                Reader2.Close();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.surname.Clear();
            f2.name.Clear();
            f2.patronymic.Clear();
            f2.datatime.Visible = false;
            f2.form_dd.Visible = false;
            f2.groupp.Visible = false;
            f2.statuss.Visible = false;

            f2.surname.ReadOnly = false;            
            f2.name.ReadOnly = false;
            f2.patronymic.ReadOnly = false;
            f2.dateTimePicker1.Visible = true;
            f2.form_d.Visible = true;
            f2.group.Visible = true;
            f2.status.Visible = true;
            f2.add.Enabled = true;
            f2.edit.Enabled = false;
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileName3 = Students.Text;
                var Reader = new StreamReader(FileName3,Encoding.Default);
                string[] line = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    line[i] = Reader.ReadLine();
                    f2.surname.Text = line[0];
                    f2.name.Text = line[1];
                    f2.patronymic.Text = line[2];
                    f2.datatime.Text = line[3];
                    f2.form_dd.Text = line[4];
                    f2.groupp.Text = line[5];
                    f2.statuss.Text = line[6];
                }
                Reader.Close();

                f2.datatime.Visible = true;
                f2.form_dd.Visible = true;
                f2.groupp.Visible = true;
                f2.statuss.Visible = true;
                f2.surname.ReadOnly = true;
                f2.name.ReadOnly = true;
                f2.patronymic.ReadOnly = true;
                f2.dateTimePicker1.Visible = false;
                f2.form_d.Visible = false;
                f2.group.Visible = false;
                f2.status.Visible = false;
                f2.edit.Enabled = false;
                f2.add.Enabled = false;
                this.f2.ShowDialog();
            }
            catch
            { MessageBox.Show("Выберите из списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                f2.datatime.Visible = false;
                f2.form_dd.Visible = false;
                f2.groupp.Visible = false;
                f2.statuss.Visible = false;

                f2.surname.ReadOnly = false;
                f2.name.ReadOnly = false;
                f2.patronymic.ReadOnly = false;
                f2.dateTimePicker1.Visible = true;
                f2.form_d.Visible = true;
                f2.group.Visible = true;
                f2.status.Visible = true;
                f2.edit.Enabled = true;
                f2.add.Enabled = false;

                FileName3 = Students.Text;
                var Reader = new StreamReader(FileName3, Encoding.Default);
                string[] line = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    line[i] = Reader.ReadLine();
                    f2.surname.Text = line[0];
                    f2.name.Text = line[1];
                    f2.patronymic.Text = line[2];
                    //f2.dateTimePicker1.Text = line[3];
                    f2.form_d.Text = line[4];
                    f2.group.Text = line[5];
                    f2.status.Text = line[6];
                }
                Reader.Close();

                f2.ShowDialog();
            }
            catch
            { MessageBox.Show("Выберите из списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FileName3 = Employees.Text;
                var Reader = new StreamReader(FileName3,Encoding.Default);
                string[] line = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    line[i] = Reader.ReadLine();
                    f2.surname.Text = line[0];
                    f2.name.Text = line[1];
                    f2.patronymic.Text = line[2];
                    f2.datatime.Text = line[3];
                    f2.form_dd.Text = line[4];
                    f2.groupp.Text = line[5];
                    f2.statuss.Text = line[6];
                }
                Reader.Close();

                f2.datatime.Visible = true;
                f2.form_dd.Visible = true;
                f2.groupp.Visible = true;
                f2.statuss.Visible = true;
                f2.surname.ReadOnly = true;
                f2.name.ReadOnly = true;
                f2.patronymic.ReadOnly = true;
                f2.dateTimePicker1.Visible = false;
                f2.form_d.Visible = false;
                f2.group.Visible = false;
                f2.status.Visible = false;
                f2.edit.Enabled = false;
                f2.add.Enabled = false;
                this.f2.ShowDialog();
            }
            catch
            { MessageBox.Show("Выберите из списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                f2.datatime.Visible = false;
                f2.form_dd.Visible = false;
                f2.groupp.Visible = false;
                f2.statuss.Visible = false;

                f2.surname.ReadOnly = false;
                f2.name.ReadOnly = false;
                f2.patronymic.ReadOnly = false;
                f2.dateTimePicker1.Visible = true;
                f2.form_d.Visible = true;
                f2.group.Visible = true;
                f2.status.Visible = true;
                f2.edit.Enabled = true;
                f2.add.Enabled = false;

                FileName3 = Employees.Text;
                var Reader = new StreamReader(FileName3,Encoding.Default);
                string[] line = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    line[i] = Reader.ReadLine();
                    f2.surname.Text = line[0];
                    f2.name.Text = line[1];
                    f2.patronymic.Text = line[2];
                    //f2.dateTimePicker1.Text = line[3];
                    f2.form_d.Text = line[4];
                    f2.group.Text = line[5];
                    f2.status.Text = line[6];
                }
                Reader.Close();

                f2.ShowDialog();
            }
            catch
            { MessageBox.Show("Выберите из списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Students.Items.Clear();
            Employees.Items.Clear();

            var Reader = new StreamReader(FileName1, Encoding.Default);

            string line;

            while ((line = Reader.ReadLine()) != null)
            {
                Students.Items.Add(line);
            }
            Reader.Close();

            var Reader2 = new StreamReader(FileName2, Encoding.Default);
            string line2;

            while ((line2 = Reader2.ReadLine()) != null)
            {
                Employees.Items.Add(line2);
            }
            Reader2.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            File.Delete(Students.Text);
            if (Employees.Items.Contains(Students.Text))
            {
                Employees.Items.Remove(Students.Text);
                File.WriteAllText(FileName2, string.Empty);
                foreach (var item in Employees.Items)
                    File.AppendAllText(FileName2, item.ToString(), Encoding.Default);
            }
            Students.Items.Remove(Students.Text);
            File.WriteAllText(FileName1, string.Empty);
            foreach (var item in Students.Items)
                File.AppendAllText(FileName1, item.ToString(), Encoding.Default);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete(Employees.Text);
            if (Students.Items.Contains(Employees.Text))
            {
                Students.Items.Remove(Employees.Text);
                File.WriteAllText(FileName1, string.Empty);                
                foreach (var item in Students.Items)
                    File.AppendAllText(FileName1, item.ToString(), Encoding.Default);
            }
            Employees.Items.Remove(Employees.Text);
            File.WriteAllText(FileName2, string.Empty);         
            foreach (var item in Employees.Items)
                File.AppendAllText(FileName2,item.ToString(), Encoding.Default);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Students.Items.Clear();
            Employees.Items.Clear();
            Close();
        }
    }
}
