// Andrew Toplass, La-Jean Harvey, Sprint Two
// Date: 21/03/2024
// Version: 1.0
// Astronomical Processing
// Stores number of neutrino interactions per hour, allows for editing, sorting
// and searching through the data, and also calculates the average, mode, range
// and mid-extreme of the data.

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
                    // Apply edited value to the array and update the listbox.
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

        // Applies edit from textbox into the data when pressing enter.
        private void TextBoxEditItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // If the key enter key was pressed, click the edit button.
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
                    // Select & highlight item that was found in the array.
                    ListBoxData.SelectedIndex = idx;
                    // Show message saying where the item was found.
                    MessageBox.Show($"Item {value} found at index: {idx}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Performs the Search when pressing enter.
        private void TextBoxSearchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // If shift key is held down, then perform sequential search.
                if (e.Modifiers == Keys.Shift)
                {
                    // If the key enter key was pressed, click the search button.
                    ButtonSequentialSearch.PerformClick();
                    e.SuppressKeyPress = true;
                }
                // Otherwise, perform binary search, which requires sorting.
                else
                {
                    // If the key enter key was pressed, click the search button.
                    ButtonSearchData.PerformClick();
                    e.SuppressKeyPress = true;
                }
                
            }
        }

        // Performs the sequential search when clicking the sequential search button.
        private void ButtonSequentialSearch_Click(object sender, EventArgs e)
        {
            // Try and get a data value from search textbox.
            if (int.TryParse(TextBoxSearchData.Text, out int value))
            {
                // Run the binary search on the data array with the input from
                // the search textbox.
                int idx = SequentialSearch(data, value);
                if (idx >= 0)
                {
                    // Select & highlight item that was found in the array.
                    ListBoxData.SelectedIndex = idx;
                    // Show message saying where the item was found.
                    MessageBox.Show($"Item {value} found at index: {idx}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Sorts the data using bubble sort then displaying sorted array.
        private void ButtonSortData_Click(object sender, EventArgs e)
        {
            BubbleSort(data);
            isSorted = true;
            ShowArray(data, ListBoxData);
        }

        // Finds the range and then displays it.
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            TextBoxRange.Text = Range(data).ToString();
        }
        
        // Finds the Mid-Range and then displays it.
        private void ButtonMidRange_Click(object sender, EventArgs e)
        {
            TextBoxMidRange.Text = $"{MidRange(data):f2}";
        }

        // Get the mode of the data when clicking on the mode button.
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int mode = Mode(data);
            if (mode < 0)
            {
                // If mode equals -1, then output: No Mode.
                TextBoxMode.Text = "No Mode";
            }
            else
            {
                // Otherwise, output the mode of the array.
                TextBoxMode.Text = mode.ToString();
            }
        }

        // Get the average of the data when clicking the average button.
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            TextBoxAverage.Text = $"{Average(data):f2}";
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
        /// Sorts the data from smallest to largest integer using the Bubble sort algorithm.
        /// </summary>
        /// <param name="array">Array to be sorted.</param
        private static void BubbleSort(int[] array)
        {
            // Use two loops to make sure every value gets sorted.
            for (int outer = 0; outer < array.Length; outer++)
            {
                // Move larger values to the end of the array.
                for (int inner = 0; inner < array.Length - 1; inner++)
                {
                    // If the current item is larger than the next, then swap.
                    if (array[inner] > array[inner + 1])
                    {
                        // Temp hold the value of the next item so it can be swapped.
                        (array[inner], array[inner + 1]) = (array[inner + 1], array[inner]);
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
                high = array.Length - 1;
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

        /// <summary>
        /// Does the Range Calculation.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>The data array you want to find the Range of.</returns>
        private static int Range(int[] input)
        {
            int largest = Largest(input);
            int smallest = Smallest(input);
            return largest - smallest;
        }

        /// <summary>
        /// Does the Mid-Range Calculation.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>The data array you want to find the Mid-Range of.</returns>
        private static double MidRange(int[] input)
        {
            int largest = Largest(input);
            int smallest = Smallest(input);
            return (largest + smallest) / 2.0;
        }

        /// <summary>
        /// Finds the Largest number in an Array.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>The data you want to find the largest number for.</returns>
        static private int Largest(int[] input)
        {
            int largest = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > largest)
                {
                    largest = input[i];
                }
            }
            return largest;
        }

        /// <summary>
        /// Finds the Smallest number in an Array.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>The data you want to find the smallest number for.</returns>
        static private int Smallest(int[] input)
        {
            int smallest = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < smallest)
                {
                    smallest = input[i];
                }
            }
            return smallest;
        } 

        /// <summary>
        /// Performs a sequential search.
        /// </summary>
        /// <param name="input">An array of integers to search through.</param>
        /// <param name="target">The integer to search for.</param>
        /// <returns>The index of the target integer, or -1 if is wasn't found.</returns>
        private static int SequentialSearch(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                // If the current element is equal to the target, return the index.
                if (input[i] == target)
                {
                    return i;
                }
            }
            // If the target wasn't found, then return -1.
            return -1;
        }

        /// <summary>
        /// Calculate the average from an array of integer inputs.
        /// </summary>
        /// <param name="input">An array of integers.</param>
        /// <returns>The average of all the integers in the input array, as a double.</returns>
        private static double Average(int[] input)
        {
            // Get the sum of the data using a for loop.
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                // Add each array value to the sum integer.
                sum += input[i];
            }
            // Divide the sum by the number of items, converting to a double.
            return sum / (double)input.Length;
        }

        /// <summary>
        /// Calculates the mode from an array of integer inputs.
        /// </summary>
        /// <param name="input">An array of integers</param>
        /// <returns>The most frequently occuring number inside the array, or -1 if no mode is found.</returns>
        private static int Mode(int[] input)
        {
            // Use dictionary to keep track of occurrences.
            Dictionary<int, int> count = [];

            // Keep track of current mode.
            int mode = -1;
            // Number of occurrences of current mode.
            int max = 1;

            // Loop through every array element to search for occurrences.
            for (int i = 0; i < input.Length; i++)
            {
                // Add dictionary key for array element, defaulting to 1.
                if (!count.TryAdd(input[i], 1))
                {
                    // If key already exists, then increment it by 1.
                    count[input[i]]++;

                    // Check if current number is larger than previous mode.
                    if (count[input[i]] > max)
                    {
                        // Set mode to current number.
                        max = count[input[i]];
                        mode = input[i];
                    }
                }
            }
            return mode;
        }
    }
}
