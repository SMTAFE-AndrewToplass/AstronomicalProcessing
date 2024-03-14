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

        // TODO: Setup array for data.
        static readonly int max = 24;
        readonly int[] data = new int[max];

        private void ListBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Update value in edit text box.
        }

        private void ButtonEditApply_Click(object sender, EventArgs e)
        {
            // TODO: Get value from edit text box and apply to selected list box item.
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
        /// Fills array with random integers between 10 and 90.
        /// </summary>
        /// <param name="array">Array to fill with data.</param>
        static private void FillArray(int[] array)
        {
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 90);
            }
        }

        /// <summary>
        /// Displays array data inside of a ListBox.
        /// </summary>
        /// <param name="array">Array data to display.</param>
        /// <param name="listBox">ListBox to store the array data.</param>
        static private void ShowArray(int[] array, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int item in array)
            {
                listBox.Items.Add(item);
            }
        }

        // TODO: Add any methods for array data (search, sort, display)...
    }
}
