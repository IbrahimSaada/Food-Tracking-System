using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Drawing.Text;
using System.Collections;
using System.Linq.Expressions;

namespace Food_Tracking_System
{
    
    public partial class application : Form
    {
       
        public application()
        {
            InitializeComponent();
        }

        private void application_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-GHAKMBS\\SQLEXPRESS;Initial Catalog=\"Food Tracking\";Integrated Security=True;";
                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    conn1.Open();


                    string fname = txt_fname.Text;
                    string lname = txt_lname.Text;
                    double weight = double.Parse(txt_weight.Text);
                    double height = double.Parse(txt_height.Text);
                    int age = int.Parse(txt_age.Text);
                    object selectedOption = combo_activity.SelectedItem;
                    string activity = "";
                    if (selectedOption != null)
                    {
                        activity = selectedOption.ToString();
                    }
                    string gender = "";
                    if (radioFemale.Checked)
                    {
                        gender = "female";
                    }
                    else if (radioMale.Checked)
                    {
                        gender = "male";
                    }

                    string insertQuery = "INSERT INTO Customer (Height, Weight, Age, Gender, Activity, FirstName, LastName) VALUES (@Height, @Weight, @Age, @Gender, @Activity, @FirstName, @LastName)";

                    using (SqlCommand command = new SqlCommand(insertQuery, conn1))
                    {

                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Height", height);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Activity", activity);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@FirstName", fname);
                        command.Parameters.AddWithValue("@LastName", lname);


                        command.ExecuteNonQuery();
                        float totalcalories = 0;


                        if (gender == "male")
                        {
                            totalcalories = (float)((88.4 + 13.4 * (float)weight) + (4.8f * (float)height) - (5.68f * age)*getActivity());

                        }
                        else if(gender =="female")
                        {
                            totalcalories = (float)((447.6 + 9.25 * (float)weight) + (3.10f * (float)height) - (4.33f * age)*getActivity());
                        }
                        using (SqlConnection conn2 = new SqlConnection(connectionString))
                        {
                            conn2.Open();
                            string insertCaloriesQuery = "INSERT INTO Calculated_Calories (Calories_formula, gender, Customer_ID ) VALUES (@Calories, @gender, @Customer_ID)";

                            using (SqlCommand command1 = new SqlCommand(insertCaloriesQuery, conn2))
                            {
                                command1.Parameters.AddWithValue("@Calories", totalcalories);
                                command1.Parameters.AddWithValue("@gender", gender);
                                command1.Parameters.AddWithValue("@Customer_ID", GenerateNewCustomerID());

                                command1.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Customer information and calculated calories saved successfully!");
                        textCaloriesTotal.Text = GenerateCaloriesFormula().ToString("F2");
                    }
            
                    tabs.SelectedTab = Calories_Macros;
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void combo_activity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double getActivity() 
        {
            double activity = 0;
            if (combo_activity.SelectedItem == "Sedentary")
            {
                activity = 1.2;
                return activity;
            }
            else if (combo_activity.SelectedItem == "Lightly active")
            {
                activity = 1.375;
                return activity;
            }
            else if (combo_activity.SelectedItem == "Moderately active")
            {
                activity = 1.55;
                return activity;
            }
            else if (combo_activity.SelectedItem == "Active")
            {
                activity = 1.725;
                return activity;
            }
            else if (combo_activity.SelectedItem == "Very active")
            { 
                activity = 1.9;
                return activity;
             }



            return 0;
        }
        private int GenerateNewCustomerID()
        {
            int newCustomerID = 0;
            string connectionString = "Data Source=DESKTOP-GHAKMBS\\SQLEXPRESS;Initial Catalog=\"Food Tracking\";Integrated Security=True;";

            try
            {
                using (SqlConnection conn3 = new SqlConnection(connectionString))
                {
                    conn3.Open();

                    string query = "SELECT MAX(Customer_ID) FROM Customer";

                    using (SqlCommand command = new SqlCommand(query, conn3))
                    {
                        
                        var result = command.ExecuteScalar();

                        
                        if (result != DBNull.Value && result != null)
                        {
                            
                            newCustomerID = Convert.ToInt32(result);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred while generating Customer_ID: " + ex.Message);
            }

            return newCustomerID;
        }
        private double GenerateCaloriesFormula()
        {
            double caloriesFormula = 0;
            string connectionString = "Data Source=DESKTOP-GHAKMBS\\SQLEXPRESS;Initial Catalog=\"Food Tracking\";Integrated Security=True;";
            try
            {
                using (SqlConnection conn4 = new SqlConnection(connectionString))
                {
                    conn4.Open();

                    string selectCaloriesQuery = "SELECT Calories_formula FROM Calculated_Calories WHERE Calories_ID = (SELECT MAX(Calories_ID) FROM Calculated_Calories)";
                    using (SqlCommand command = new SqlCommand(selectCaloriesQuery, conn4))
                    {
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            caloriesFormula = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating Calories_formula: " + ex.Message);
            }

            return caloriesFormula;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click_2(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-GHAKMBS\\SQLEXPRESS;Initial Catalog=\"Food Tracking\";Integrated Security=True;";
                using (SqlConnection conn5 = new SqlConnection(connectionString))
                {
                    conn5.Open();
                    string selectgain = "SELECT Wgain FROM Calories_Macros";
                    string selectlose = "SELECT Wloss FROM Calories_Macros";
                    if (radioButton1.Checked)
                    {
                        gbLose.Hide();
                        using (SqlCommand command = new SqlCommand(selectgain, conn5))
                        {
                            var result = command.ExecuteScalar();
                            double g = Convert.ToDouble(textCaloriesTotal.Text) + Convert.ToDouble(result);
                            textBox1.Text = g.ToString();
                            tabs.SelectedTab = plan;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        gbGain.Hide();
                        using (SqlCommand command = new SqlCommand(selectlose, conn5))
                        {
                            var result = command.ExecuteScalar();
                            double g = Convert.ToDouble(textCaloriesTotal.Text) - Convert.ToDouble(result);
                            textBox1.Text = g.ToString();
                            tabs.SelectedTab = plan;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database:\n" + ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
    

        
    

