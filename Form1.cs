// Andrew Toplass, La-Jean Harvey, Sprint One
// Date: 21/03/2024
// Version: 1.0
// Astronomical Processing
// Stores number of neutrino interactions per hour, allows for editing, sorting
// and searching through the data.

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        // Store data sorted status, used for searching.
        private bool isSorted = false;

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
                isSorted = false;

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
                MessageBox.Show("You must enter an integer number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Performs the data edit when pressing enter
        private void TextBoxEditItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonEditApply.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        // Search for data in the array from the search textbox when clicking
        // the search button.
        private void ButtonSearchData_Click(object sender, EventArgs e)
        {
            // If data is not sorted before search, ask user to sort the data.
            if (!isSorted)
            {
                // Ask user if they want to sort the data, storing the answer.
                var answer = MessageBox.Show("Data needs to be sorted before searching. Would you like to sort the data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                {
                    // If they answered Yes, click the sort button then search.
                    ButtonSortData.PerformClick();
                }
                else
                {
                    // If they answered No, cancel the operation.
                    return;
                }
            }

            // Try and get a data value from search textbox.
            if (int.TryParse(TextBoxSearchData.Text, out int value))
            {
                // Run the binary search on the data array with the input from
                // the search textbox.
                int idx = BinarySearch(data, value);
                if (idx >= 0)
                {
                    // Select item that was found in the array.
                    ListBoxData.SelectedIndex = idx;
                    // Show message saying where the item was found.
                    MessageBox.Show($"Item found at index: {idx}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Warn user that the item they searched for was not found.
                    MessageBox.Show($"Item not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You must enter an integer number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        
        // Performs the Search when pressing enter
        private void TextBoxSearchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearchData.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        // Sorts the data using bubble sort then displaying sorted array
        private void ButtonSortData_Click(object sender, EventArgs e)
        {
            BubbleSort(data);
            isSorted = true;
            ShowArray(data, ListBoxData);
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

        /// <summary>
        /// Sorts the data from smallest to largest integer.
        /// </summary>
        /// <param name="array">Array you want to sort</param
        private void BubbleSort(int[] array)
        {
            // Temp hold the value of the next item so it can be swapped.
            int temp = 0;
            // 2 loops to make sure every value gets sorted.
            for (int outer = 0; outer < array.Length; outer++)
            {
                // Moves the largest item to the top 
                for (int inner = 0; inner < array.Length - 1; inner++)
                {
                    // If the current item is larger than the next item it moves up
                    if (array[inner] > array[inner + 1])
                    {
                        temp = array[inner + 1];
                        array[inner + 1] = array[inner];
                        array[inner] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Search for data inside integer array using the binary search algorithm.
        /// </summary>
        /// <param name="array">Array containing data to search through.</param>
        /// <param name="target">Data to find the index of.</param>
        /// <returns>Index of target inside array, returns -1 is nothing was found.</returns>
        private static int BinarySearch(int[] array, int target)
        {
            int mid,
                low = 0,
                high = array.Length;
            while (low <= high)
            {
                // Midpoint between low and high search limits.
                mid = (low + high) / 2;
                if (array[mid] == target)
                {
                    // Target was found, return index.
                    return mid;
                }
                else if (array[mid] > target)
                {
                    // Target is smaller than middle value, stop searching for
                    // larger values.
                    high = mid - 1;
                }
                else
                {
                    // Target is larger than middle value, stop searching for
                    // smaller values.
                    low = mid + 1;
                }
            }
            // If search doesn't find any matching items, return -1.
            return -1;
        }
    }
}
