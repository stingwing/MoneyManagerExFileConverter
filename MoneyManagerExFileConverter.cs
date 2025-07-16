using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManagerExFileConverter
{
    public partial class MoneyManagerExFileConverter : Form
    {
        List<string> _importFile = new List<string>();
        public static bool SplitCSVFinishedMidLine = false;
        private List<transactionRecord> _transactionRecords = null;
        private AppConfig _config = null;

        private class transactionRecord
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public decimal Credit { get; set; }
            public decimal Debit { get; set; }
            public decimal Balance { get; set; }
            public string Payee { get; set; } = string.Empty;
            public string searchString { get; set; } = string.Empty;
        }

        private class CategoryRecord
        {
            public string SearchString { get; set; }
            public string Payee { get; set; }
        }

        [DataContract]
        public class AppConfig
        {
            [DataMember]
            public string TransactionsPath { get; set; }

            [DataMember]
            public string CategoryRecordsPath { get; set; }

            [DataMember]
            public string DefaultImportPath { get; set; }

            [DataMember]
            public List<string> Accounts { get; set; } = new List<string>();

            [DataMember]
            public string SelectedAccount { get; set; }
        }

        public MoneyManagerExFileConverter()
        {
            InitializeComponent();
            _config = LoadConfig();
            if (_config != null)
            {
                LoadAccountsToComboBox(_config);
                uiPath.Text = _config.DefaultImportPath;
            }

            uiAccount.SelectedIndexChanged += uiAccount_SelectedIndexChanged;
        }

        private List<CategoryRecord> OpenCatagoryFile()
        {
            var catagores = new List<CategoryRecord>();
            var path = _config.CategoryRecordsPath;
            if (!File.Exists(path))
                return catagores;

            var catagoresList = File.ReadAllLines(path);

            foreach (var line in catagoresList)
            {
                var csv = SplitCSVLine(line, true);
                var categoryRecord = new CategoryRecord
                {
                    SearchString = csv[0],
                    Payee = csv[1]
                };

                catagores.Add(categoryRecord);
            }

            return catagores;
        }

        private List<string> OpenHistoricalData()
        {
            var path = Path.Combine(_config.TransactionsPath, uiAccount.Text, "Transactions.csv");
            var logFile = File.ReadAllLines(path);
            var _importFile = new List<string>(logFile);

            return _importFile;
        }

        private void uiOpenFile_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                uiPath.Text = fbd.FileName;
        }

        private void uiImport_Click(object sender, EventArgs e)
        {
            ImportFile();
        }

        private void ImportFile()
        {
            _transactionRecords = new List<transactionRecord>();
            uiData.ClearSelection();
            var path = uiPath.Text;
            var catagories = OpenCatagoryFile();
            var historicalData = OpenHistoricalData();
            if (!File.Exists(path))
                return;

            var logFile = File.ReadAllLines(path);
            var _importFile = new List<string>(logFile);

            var first = true;

            foreach (var line in _importFile)
            {
                if (first)
                {
                    first = false;
                    continue; // skip the header line
                }

                if (historicalData.Contains(line))
                    continue;

                var csv = SplitCSVLine(line, true);

                decimal credit = 0, debit = 0, balance = 0;

                var date = DateTime.Parse(csv[0]).Date;
                var description = csv[1];
                credit = decimal.TryParse(csv[2], out credit) ? credit : 0;
                debit = decimal.TryParse(csv[3], out debit) ? debit : 0;
                balance = decimal.TryParse(csv[4], out balance) ? balance : 0;
              

                var transactionRecord = new transactionRecord
                {
                    Date = date,
                    Description = description,
                    Credit = credit,
                    Debit = debit,
                    Balance = balance,
                    Payee = string.Empty,
                    searchString = string.Empty,
                };

                SearchPayees(transactionRecord, line, catagories);


                _transactionRecords.Add(transactionRecord);
            }

            uiData.DataSource = _transactionRecords;
        }

        private void SearchPayees(transactionRecord transactionRecord, string line, List<CategoryRecord> catagories)
        {
            var catagoryRecord = catagories.FirstOrDefault(x => transactionRecord.Description.Contains(x.SearchString));

            if(catagoryRecord == null)
                catagoryRecord = catagories.FirstOrDefault(x => transactionRecord.Description.IndexOf(x.SearchString, StringComparison.OrdinalIgnoreCase) >= 0);

            if (catagoryRecord == null)
                return;

            transactionRecord.Payee = catagoryRecord.Payee;
            transactionRecord.searchString = catagoryRecord.SearchString;
        }

        private void uiExport_Click(object sender, EventArgs e)
        {
            ExportTransactionsToCsv();
            if (MessageBox.Show("Would you like to update the Transaction History?", "Update Transaction History", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                UpdateHistoricalData(uiPath.Text);           
        }

        private void UpdateHistoricalData(string path)
        {
            var historicalPath = Path.Combine(_config.TransactionsPath, uiAccount.Text);
            var destinationFile = Path.Combine(historicalPath, "Transactions.csv");
            var sourceFile = _config.DefaultImportPath;

            if (!File.Exists(path))
            {
                MessageBox.Show($"Source file not found: {path}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var destDir = Path.GetDirectoryName(historicalPath);
                if (!Directory.Exists(destDir))
                    Directory.CreateDirectory(destDir);

                // If the destination file exists, delete it
                if (File.Exists(destinationFile))
                    File.Delete(destinationFile);

                // Move the file
                File.Move(path, destinationFile);
                MessageBox.Show("Transaction file moved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error moving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ExportTransactionsToCsv()
        {
            var delimiter = ",";
            var path = Path.Combine(_config.TransactionsPath,uiAccount.Text, "ExportFile.csv");
            using (var writer = new StreamWriter(path))
            {
                foreach (var record in _transactionRecords)
                {
                    var credit = string.Empty;
                    var debit = string.Empty;
                    if (record.Credit != 0)
                        credit = record.Credit.ToString();

                    if (record.Debit != 0)
                        debit = record.Debit.ToString();

                    var line = new StringBuilder();
                    line.Append(record.Date.ToString("dd/MM/yyyy")).Append(delimiter)
                        .Append(record.Description).Append(delimiter)
                        .Append(credit).Append(delimiter)
                        .Append(debit).Append(delimiter)
                        .Append(record.Balance.ToString("F2")).Append(delimiter)
                        .Append(record.Payee);

                    writer.WriteLine(line);
                }
            }
            UpdateCategoryRecords(_transactionRecords, false);
        }

        private void UpdateCategoryRecords(List<transactionRecord> transactionRecords, bool refresh)
        {
            var categoryFilePath = _config.CategoryRecordsPath;
            var existingEntries = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Read existing entries
            if (File.Exists(categoryFilePath))
            {
                foreach (var line in File.ReadAllLines(categoryFilePath))
                {
                    var csv = SplitCSVLine(line, true);
                    if (csv.Length >= 2)
                    {
                        // Use SearchString + Payee as unique key
                        existingEntries.Add($"{csv[0]}|{csv[1]}");
                    }
                }
            }

            // Find new unique entries from transactionRecords
            var newEntries = new List<string>();
            foreach (var record in transactionRecords) // rewrite this
            {
                var key = $"{record.searchString}|{record.Payee}";
                if (!string.IsNullOrWhiteSpace(record.searchString) &&
                    !string.IsNullOrWhiteSpace(record.Payee) &&
                    !existingEntries.Contains(key))
                {
                    // Remove any newlines from fields to keep CSV integrity
                    var searchString = record.searchString.Replace("\r", " ").Replace("\n", " ");
                    var payee = record.Payee.Replace("\r", " ").Replace("\n", " ");
                    // Prepare CSV line without quotes
                    var line = $"{searchString},{payee}";
                    newEntries.Add(line);
                    existingEntries.Add(key); // Prevent duplicates in this run
                }
            }

            // Append new entries to the file, each on a new line
            if (newEntries.Any())
                File.AppendAllLines(categoryFilePath, newEntries, Encoding.UTF8);
            
            if(refresh)
                ImportFile();
        }

        public static string[] SplitCSVLine(string line, bool trimStrings)
        {
            line = line.Replace(System.Environment.NewLine, " ");
            List<string> list = new List<string>();
            StringBuilder work = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '"' && line.LastIndexOf("\"") > i) // check there is another quote in the string.  May just be a quote with no closing quote
                {
                    int p2;
                    while (true)
                    {
                        p2 = line.IndexOf('"', i + 1);
                        work.Append(line.Substring(i + 1, p2 - i - 1));
                        i = p2;

                        // If this is a double quote, keep going!
                        if (((p2 + 1) < line.Length) && (line[p2 + 1] == '"'))
                        {
                            work.Append('"');
                            i++;

                            // otherwise, this is a single quote, we're done
                        }
                        else
                        {
                            break;
                        }
                    }
                    SplitCSVFinishedMidLine = false;
                }
                else
                {
                    if (c == '"')
                        SplitCSVFinishedMidLine = true;
                    if (c == ',')
                    {
                        string str = work.ToString();
                        if (trimStrings)
                            str = str.Trim();
                        list.Add(str);
                        work.Length = 0;
                    }
                    else
                    {
                        work.Append(c);
                    }
                }
            }

            string str2 = work.ToString().Trim();
            if (trimStrings)
                str2 = str2.Trim();
            list.Add(str2);

            return list.ToArray();
        }

        private void uiUpdateRecords_Click(object sender, EventArgs e)
        {
            UpdateCategoryRecords(_transactionRecords, true);
        }

        private string GetConfigFilePath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        }

        private AppConfig LoadConfig()
        {
            var path = GetConfigFilePath();
            if (!File.Exists(path))
                return null;

            using (var stream = new FileStream(path, FileMode.Open))
            {
                var serializer = new DataContractJsonSerializer(typeof(AppConfig));
                return (AppConfig)serializer.ReadObject(stream);
            }
        }

        private void LoadAccountsToComboBox(AppConfig config)
        {
            uiAccount.Items.Clear();
            if (config?.Accounts != null && config.Accounts.Count > 0)
            {
                foreach (var account in config.Accounts)
                    uiAccount.Items.Add(account);

                if (!string.IsNullOrEmpty(config.SelectedAccount) && config.Accounts.Contains(config.SelectedAccount))
                    uiAccount.SelectedItem = config.SelectedAccount;
                else
                    uiAccount.SelectedIndex = 0;
            }
        }

        private void uiAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_config == null) 
                return;

            var selectedAccount = uiAccount.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedAccount)) return;

            _config.SelectedAccount = selectedAccount;

            var subfolder = Path.Combine(_config.TransactionsPath, selectedAccount);
            Directory.CreateDirectory(subfolder);
        }
    }
}