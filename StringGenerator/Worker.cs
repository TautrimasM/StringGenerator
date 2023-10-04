using MySqlConnector;

namespace StringGenerator;

internal class Worker
{
    private bool _threadsRun;
    private int _currentThreadId = 1;
    private ListView _stringList = new();

    const int _maxItemCount = 20;
    const int _minDelay = 500;
    const int _maxDelay = 2000;


    public void StopThreads()
    {
        _threadsRun = false;
        _currentThreadId = 1;
    }
    public void StartThreads(int numberOfThreads, ListView stringList)
    { 
        _threadsRun = true;
        _stringList = stringList;
        Thread[] threads = new Thread[numberOfThreads];

        for (int i = 0; i < numberOfThreads; i++)
        {
            threads[i] = new Thread(DoWork);
            threads[i].Start();
        }

    }
    private void DoWork()
    {
        int threadId = _currentThreadId;
        Interlocked.Increment(ref _currentThreadId);

        string connectionString = "Server=localhost;User=root;";
        MySqlConnection connection = new(connectionString);
        connection.Open();
        DbManager.CreateMySqlDatabaseIfNotExist(connection, "StringDb");
        connection.ChangeDatabase("StringDb");
        DbManager.CreateTableIfNotExist(connection);
        connection.ChangeDatabase("StringDb");

        while (_threadsRun)
        {
            string randomString = Helper.GenerateRandomLengthString();
            if (string.IsNullOrEmpty(randomString))
            {
                continue;
            }

            DateTime timestamp = DateTime.Now;
            int delay = Helper.GetRandomNumber(_minDelay, _maxDelay + 1);
            ListViewItem item = new(threadId.ToString());
            item.SubItems.Add(randomString);

            if (_stringList.Items.Count > _maxItemCount)
            {
                _stringList.Invoke(() => _stringList.Items.RemoveAt(0));
            }

            _stringList.Invoke((Action)(() => _stringList.Items.Add(item)));

            DbManager.InsertData(threadId, timestamp, randomString, connection);
            Thread.Sleep(delay);
        }
    }
}

