using System.Windows.Forms;

namespace ComponentsManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailText = email.Text;
            string passText = password.Text;

            // Define static email and password
            string staticEmail = "";
            string staticPassword = "";

            // Check if the entered email and password match the static ones
            if (emailText == staticEmail && passText == staticPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Switch panels
                loginPanel.Visible = false; // Hide Login Panel
                dashboardPanel.Visible = true;  // Show the second panel
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddComponent_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string name = componentName.Text;
            string whoRent = taker.Text;
            int quantity;
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Current date and time

            // Validate inputs
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Component Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ComponentsQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(whoRent))
            {
                MessageBox.Show("Who Rent cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the component data to a CSV file
            string filePath = "components.csv"; // File path where the data will be stored
            bool fileExists = File.Exists(filePath);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    // Write the header row if the file does not exist
                    if (!fileExists)
                    {
                        writer.WriteLine("ComponentName,Quantity,WhoRent,DateTime");
                    }

                    // Write the component data
                    writer.WriteLine($"{name},{quantity},{whoRent},{currentDateTime}");
                }

                // Notify the user
                MessageBox.Show("Component added and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear textboxes for the next input
                componentName.Text = string.Empty;
                ComponentsQuantity.Text = string.Empty;
                taker.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayall_Click(object sender, EventArgs e)
        {
            string filePath = "components.csv"; // Path to the CSV file

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file does not exist. Add some components first!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(filePath);

                // Check if the file contains data
                if (lines.Length == 0)
                {
                    MessageBox.Show("The file is empty.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get the headers from the first line
                string[] headers = lines[0].Split(',');

                // Clear the DataGridView and set its columns
                dataGridView.Columns.Clear();
                foreach (string header in headers)
                {
                    dataGridView.Columns.Add(header, header);
                }

                // Add rows to the DataGridView
                for (int i = 1; i < lines.Length; i++) // Skip the header row
                {
                    string[] row = lines[i].Split(',');
                    dataGridView.Rows.Add(row);
                }

                MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editComponentButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Populate the text fields with selected row data
                componentName.Text = selectedRow.Cells["ComponentName"].Value.ToString();
                ComponentsQuantity.Text = selectedRow.Cells["ComponentsQuantity"].Value.ToString();
                taker.Text = selectedRow.Cells["WhoRent"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Edit Component", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Update the selected row with the new values
                selectedRow.Cells["ComponentName"].Value = componentName.Text;
                selectedRow.Cells["ComponentsQuantity"].Value = ComponentsQuantity.Text;
                selectedRow.Cells["WhoRent"].Value = taker.Text;

                // Save changes to the CSV file
                SaveDataToCsv();

                MessageBox.Show("Component updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to save changes.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Confirm deletion with the user
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete the selected component?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                    // Remove the row from the DataGridView
                    dataGridView.Rows.Remove(selectedRow);

                    // Save the updated data back to the CSV file
                    SaveDataToCsv();

                    MessageBox.Show("Component deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Component", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SaveDataToCsv()
        {
            string filePath = "components.csv"; // Path to your CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers
                writer.WriteLine("ComponentName,ComponentsQuantity,WhoRent,Date");

                // Write rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row placeholder
                    {
                        string componentName = row.Cells["ComponentName"].Value?.ToString() ?? "";
                        string componentsQuantity = row.Cells["ComponentsQuantity"].Value?.ToString() ?? "";
                        string whoRent = row.Cells["WhoRent"].Value?.ToString() ?? "";
                        string date = row.Cells["Date"].Value?.ToString() ?? "";
                        writer.WriteLine($"{componentName},{componentsQuantity},{whoRent},{date}");
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = searchTextBox.Text.Trim().ToLower();

            // Check if the search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Search Components", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Loop through the rows of the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // Skip the new row placeholder
                {
                    // Get the value from the "ComponentName" column (or adjust as needed)
                    string componentName = row.Cells["ComponentName"].Value?.ToString().ToLower() ?? "";

                    // Check if the search term matches the component name
                    if (componentName.Contains(searchTerm))
                    {
                        // If a match is found, select the row
                        row.Selected = true;

                        // Scroll to the row
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;

                        return; // Exit after finding the first match
                    }
                }
            }

            // If no match is found, show a message
            MessageBox.Show("No components found with the given search term.", "Search Components", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            // Clear the search TextBox
            searchTextBox.Clear();

            // Deselect any selected rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = false;
            }

            // Optionally scroll to the top
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Prompt the user to select the location and name for the exported file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = "exported_components.csv" // Default file name
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string exportFilePath = saveFileDialog.FileName;

                try
                {
                    // Create a new StreamWriter to write to the selected file
                    using (StreamWriter writer = new StreamWriter(exportFilePath))
                    {
                        // Write the headers
                        writer.WriteLine("ComponentName,ComponentsQuantity,WhoRent,Date");

                        // Write the rows
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow) // Skip the new row placeholder
                            {
                                string componentName = row.Cells["ComponentName"].Value?.ToString() ?? "";
                                string componentsQuantity = row.Cells["ComponentsQuantity"].Value?.ToString() ?? "";
                                string whoRent = row.Cells["WhoRent"].Value?.ToString() ?? "";
                                string date = row.Cells["Date"].Value?.ToString() ?? "";

                                // Write each row as a comma-separated line in the CSV file
                                writer.WriteLine($"{componentName},{componentsQuantity},{whoRent},{date}");
                            }
                        }
                    }

                    MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting the data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
