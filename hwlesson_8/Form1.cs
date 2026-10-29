namespace hwlesson_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendText(string message)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new Action(() => AppendText(message)));
            }
            else
            {
                txtOutput.AppendText(message + Environment.NewLine);
            }
        }

        // task 1
        private async void btnTask1_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            AppendText("<<< Task 1: Launching a Task in Three Ways >>>");

            await Task.Run(() =>
            {
                Task t1 = new Task(() =>
                {
                    AppendText($"[1] new Task().Start(): {DateTime.Now:HH:mm:ss.fff}");
                });
                t1.Start();
                t1.Wait();

                Task t2 = Task.Factory.StartNew(() =>
                {
                    AppendText($"[2] Task.Factory.StartNew: {DateTime.Now:HH:mm:ss.fff}");
                });
                t2.Wait();

                Task t3 = Task.Run(() =>
                {
                    AppendText($"[3] Task.Run: {DateTime.Now:HH:mm:ss.fff}");
                });
                t3.Wait();
            });
        }

        // task 2
        private async void btnTask2_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            AppendText("<<< Task 2: Prime Numbers from 0 to 1000 >>>");

            await Task.Run(() =>
            {
                AppendText("The main thread awaits the completion of the task via Wait()..");

                Task primeTask = Task.Run(() =>
                {
                    List<int> primes = new List<int>();
                    for (int i = 2; i <= 1000; i++)
                    {
                        if (IsPrime(i)) primes.Add(i);
                    }
                    AppendText($"Found prime numbers: {primes.Count}");
                    AppendText($"List: {string.Join(", ", primes)}");
                });

                primeTask.Wait();
                AppendText("The main thread has awaited the completion of the task.");
            });
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // task 3
        private async void btnTask3_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            AppendText("<<< Task 3: Array of Tasks >>>");

            int[] array = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(1, 100);

            AppendText($"Array: {string.Join(", ", array)}");

            await Task.Run(() =>
            {
                Task<int> minTask = Task.Run(() => array.Min());
                Task<int> maxTask = Task.Run(() => array.Max());
                Task<double> avgTask = Task.Run(() => array.Average());
                Task<int> sumTask = Task.Run(() => array.Sum());

                Task.WaitAll(minTask, maxTask, avgTask, sumTask);

                AppendText($"Minimum: {minTask.Result}");
                AppendText($"Maximum: {maxTask.Result}");
                AppendText($"Average: {avgTask.Result:F2}");
                AppendText($"Sum: {sumTask.Result}");
            });
        }

        // task 4
        private async void btnTask4_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            AppendText("<<< Task 4: Chain of Tasks (ContinueWith) >>>");

            int[] initialArray = { 25, 10, 50, 10, 25, 90, 5, 50 };
            int searchValue = 50;

            AppendText($"Initial array: {string.Join(", ", initialArray)}");
            AppendText($"Search value: {searchValue}");

            await Task.Run(() =>
            {
                Task<int[]> removeDuplicatesTask = Task.Run(() =>
                {
                    int[] unique = initialArray.Distinct().ToArray();
                    AppendText($"[Step 1] No duplicates: {string.Join(", ", unique)}");
                    return unique;
                });

                Task<int[]> sortTask = removeDuplicatesTask.ContinueWith(prev =>
                {
                    int[] sorted = prev.Result;
                    Array.Sort(sorted);
                    AppendText($"[Step 2] Sorted: {string.Join(", ", sorted)}");
                    return sorted;
                });

                Task searchTask = sortTask.ContinueWith(prev =>
                {
                    int[] sorted = prev.Result;
                    int index = Array.BinarySearch(sorted, searchValue);
                    if (index >= 0)
                        AppendText($"[Step 3] Value found at index: {index}");
                    else
                        AppendText($"[Step 3] Value not found.");
                });

                searchTask.Wait();
            });
        }
    }
}