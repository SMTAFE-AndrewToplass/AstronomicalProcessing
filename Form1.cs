// Andrew Toplass, La-Jean Harvey, Sprint One
// Date: 21/03/2024
// Version: 1.0
// Astronomical Processing
// Stores number of neutrino interactions per hour, allows for editing, sorting
// and searching through the data.

namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessing : Form
    {
        public AstronomicalProcessing()
        {
            InitializeComponent();
            FillArray(data);
            ShowArray(data, ListBoxData);
        }

        // Array for storing the integer data.
        static readonly int max = 24;
        readonly int[] data = new int[max];

        // When selecting an item in the listbox, update the edit textbox.
        private void ListBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxEditItem.Text = ListBoxData.Text;
        }

        // Edit array item of currently selected listbox item with data from
        // the edit textbox when clicking the edit button.
        private void ButtonEditApply_Click(object sender, EventArgs e)
        {
            // Try and get a data value from edit textbox.
            if (int.TryParse(TextBoxEditItem.Text, out int value))
            {
                // Get the index of selected listbox item.
                int idx = ListBoxData.SelectedIndex;

                // Check if index value is within the bounds of the data array.
                if (idx >= 0 && idx < data.Length)
                {
                    // Assign the edited value to the array and update the listbox.
                    data[idx] = value;
                    ShowArray(data, ListBoxData, true);
                }
                else
                {
                    MessageBox.Show("Please select an item to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("You must enter an integer number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ButtonSearchData_Click(object sender, EventArgs e)
        {
            // TODO: Run binary search on list box data with search text box data.
        }

        private void ButtonSortData_Click(object sender, EventArgs e)
        {
            // TODO: Run bubble sort on list box data.
        }

        /// <summary>
        /// Fills array with random integers (between 10 and 90 by default).
        /// </summary>
        /// <param name="array">Array to fill with data.</param>
        /// <param name="min">Minimum value for random data.</param>
        /// <param name="max">Maximum value for random data.</param>
        static private void FillArray(int[] array, int min = 0, int max = 90)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                // Add new random number between min & max (0 & 90 by default).
                array[i] = rand.Next(min, max);
            }
        }

        /// <summary>
        /// Displays array data inside of a ListBox.
        /// </summary>
        /// <param name="array">Array data to display.</param>
        /// <param name="listBox">ListBox to store the array data.</param>
        /// <param name="restore">Restore previously selected item position.</param>
        static private void ShowArray(int[] array, ListBox listBox, bool restore = false)
        {
            // Store the selected index for restoring it after updating.
            int idx = listBox.SelectedIndex;
            // Clear the listbox to write the new data.
            listBox.Items.Clear();
            foreach (int item in array)
            {
                // Add each array item to the listbox.
                listBox.Items.Add(item);
            }
            // Restore selected item.
            if (restore) listBox.SelectedIndex = idx;
        }

        // TODO: Add any methods for array data (search, sort, display)...
    }
}
