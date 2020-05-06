﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Connected_Architecture2
{
    public partial class Form1 : Form
    {
        string e_id;
        string name;
        string desg;
        string qual;
        DateTime doj;
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            SqlConnection con = new SqlConnection("Server = LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
            SqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "Select * from Employee;";

                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                reader.Close();
            }

            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                con.Close();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            e_id = int.Parse(textBox1.Text);
            name = textBox2.Text;
            desg = comboBox1.SelectedItem.ToString();
            qual = comboBox2.SelectedItem.ToString();
            doj = DateTime.Parse(dateTimePicker1.Text);

            if ((e_id == null) || (name == "") || (desg == "") || (qual == "") || (doj == null))
            {
                string msg = "No text box can be empty ";
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
                SqlCommand cmd = con.CreateCommand();

                try
                {
                    con.Open();
                    string query = "Insert into Employee values('"
                                + e_id + "','"
                                + name + "','"
                                + desg + "','"
                                + qual + "','"
                                + doj + "');";

                    cmd.CommandText = query;

                    cmd.ExecuteScalar();

                    MessageBox.Show("New Employee is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                catch (Exception ex)
                {
                    string msg = ex.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                finally
                {
                    cmd.Dispose();
                    con.Close();
                }


            }
        }

        private void button5_Click(object sender, EventArgs e) //Refresh
        {
            refresh();
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e) // Update
        {
            int id = int.Parse(comboBox3.Text);
            //e_id = int.Parse(textBox1.Text);
            name = textBox2.Text;
            desg = comboBox1.SelectedItem.ToString();
            qual = comboBox2.SelectedItem.ToString();
            doj = DateTime.Parse(dateTimePicker1.Text);
            if ((name == "") || (desg == "") || (qual == "") || (doj == null))
            {
                string msg = "No text box can be empty ";
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
                SqlCommand cmd = con.CreateCommand();

                try
                {
                    con.Open();
                    string query = "Update Employee Set EmpName='"
                                + name + "',Designation='"
                                + desg + "',Qualification='"
                                + qual + "',JoiningDate='"
                                + doj + "' where EmployeeID=" + id;
                    cmd.CommandText = query;

                    cmd.ExecuteScalar();

                    MessageBox.Show("Employee is updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    string msg = ex.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                finally
                {
                    cmd.Dispose();
                    con.Close();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure!!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
                SqlCommand cmd = con.CreateCommand();
                //char[] id = new char[5];
                var id = int.Parse(comboBox3.Text);
                //char[] id = emp_id_sel.ToArray();


                try
                {
                    con.Open();
                    string query = "Delete from Employee where EmployeeID =" + id;

                    cmd.CommandText = query;
                    cmd.ExecuteScalar();
                }

                catch (Exception ex)
                {
                    string msg = ex.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }

            else
            {

            }

        }

        private void button4_Click(object sender, EventArgs e) // Search
        {
            SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
            SqlCommand cmd = con.CreateCommand();
            //char[] id = new char[5];
            var id = int.Parse(textBox3.Text);
            //char[] id = emp_id_sel.ToArray();


            try
            {
                con.Open();
                string query = "Select * from Employee where EmployeeID =" + id;

                cmd.CommandText = query;
                //cmd.ExecuteScalar();

                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Rows.Count - 1 == 0)
                {
                    string msg = "Employee not Found";
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    string msg = "Employee Found";
                    string caption = "No Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("select * from Employee", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            e_id = Employee_ID.Text;
            name = Emp_Name.Text;
            desg = Designation_1.Text;
            qual = Qualification.Text;
            doj = DateTime.Parse(dateTimePicker1.Text);

            if ((e_id == "") || (name == "") || (desg == "") || (qual == "") || (doj == null))
            {
                string msg = "Enter all fields ";
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Server =LAPTOP-V94QJFN6\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
                SqlCommand cmd = con.CreateCommand();
                try
                {
                    con.Open();
                    string query = "Insert into Employee values('"
                                + e_id + "','"
                                + name + "','"
                                + desg + "','"
                                + qual + "','"
                                + doj + "');";

                    cmd.CommandText = query;

                    cmd.ExecuteScalar();

                    MessageBox.Show("New Employee is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    string msg = ex.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
                DisplayData();
            }
        }
    }
}
