﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuprememartPOS
{
    public partial class employees : UserControl
    {
        public employees()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection("Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;");


        private void dataGridViewEmplyoee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the clicked cell is not the header row
            {
                // Get the values from the clicked row and fill the textboxes
                DataGridViewRow row = dataGridViewEmplyoee.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Position"].Value.ToString();
                textBox3.Text = row.Cells["ContactNumber"].Value.ToString();
                textBox4.Text = row.Cells["NICNumber"].Value.ToString();

                // Store the EmployeeID for future use (for deletion and update)
                textBox4.Tag = row.Cells["EmployeeID"].Value;

                // Disable textboxes initially to prevent editing
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }

        }

        private void addemp_Click(object sender, EventArgs e)
        {
            {
                string employeeName = textBox1.Text;
                string position = textBox2.Text;
                string contactNumber = textBox3.Text;
                string nicNumber = textBox4.Text;

                // Validate input
                if (string.IsNullOrEmpty(employeeName) ||
                    string.IsNullOrEmpty(position) ||
                    string.IsNullOrEmpty(contactNumber) ||
                    string.IsNullOrEmpty(nicNumber))
                {
                    MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    con.Open();

                    if (textBox4.Tag == null) // No employee selected, so it's a new employee (insert)
                    {
                        // Insert new employee
                        string query = "INSERT INTO Employee (Name, Position, ContactNumber, NICNumber) VALUES (@Name, @Position, @ContactNumber, @NICNumber)";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Position", position);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NICNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Employee added successfully.");
                    }
                    else // An employee is selected, so it's an update
                    {
                        int employeeId = Convert.ToInt32(textBox4.Tag); // Get the EmployeeID from the Tag
                        string query = "UPDATE Employee SET Name = @Name, Position = @Position, ContactNumber = @ContactNumber, NICNumber = @NICNumber WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", employeeId);
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Position", position);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NICNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Employee updated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close(); // Ensure the connection is always closed
                }

                FILLDGV(); // Refresh DataGridView
            }
        }

        private void updateemp_Click(object sender, EventArgs e)
        {
            // Enable textboxes for editing
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void deleteemp_Click(object sender, EventArgs e)
        {
            int employeeID;

            // Validate EmployeeID
            if (textBox4.Tag == null || !int.TryParse(textBox4.Tag.ToString(), out employeeID))
            {
                MessageBox.Show("No employee selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Employee deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }

            FILLDGV(); // Refresh the DataGridView
        }


        private void empfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplname_TextChanged(object sender, EventArgs e)
        {

        }

        private void empcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void employees_Load_1(object sender, EventArgs e)
        {
            FILLDGV();
        }

        private void FILLDGV()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Employee";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEmplyoee.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }
            foreach (DataGridViewColumn column in dataGridViewEmplyoee.Columns)
            {
                column.ReadOnly = true; // Prevent editing in the DataGridView directly
            }

            // Fit the columns to the content width
            dataGridViewEmplyoee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmplyoee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Change column headers
            dataGridViewEmplyoee.Columns["EmployeeID"].HeaderText = "ID";
            dataGridViewEmplyoee.Columns["Name"].HeaderText = "Name";
            dataGridViewEmplyoee.Columns["Position"].HeaderText = "Position";
            dataGridViewEmplyoee.Columns["ContactNumber"].HeaderText = "Contact Number";
            dataGridViewEmplyoee.Columns["NICNumber"].HeaderText = "NIC";

            // Additional styling (optional)
            dataGridViewEmplyoee.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); // Set font
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); // Header style
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; // Header background color
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color

            // Set row selection mode to full row
            dataGridViewEmplyoee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set alternating row styles
            dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Enable textboxes to allow typing again
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            // Reset ProductID tag
            textBox4.Tag = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
