
/*****************************************************
This is a multi threaded program that checks if a word is in a file 
and if yes, prints each line where it occurs along with the line number


BY DEVANSHU D. SHETH
dds160030
CS6326.001

We have added some extra features:

1. option to search for whole words, or not
2. option to ignore case, or not
3. show progress bar
4. show the recent searches as suggestion
5. background worker is busy/not busy

******************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace Asg4_dds160030
{

    public partial class TextSearch : Form
    {
        // li is a listviewitem
        ListViewItem li = new ListViewItem();

        //path of the file to search
        public string strFilePath;

        //Record of line
        private MyObject record;

        //List of MyObjects
        List<MyObject> myobjects = new List<MyObject>();

        //current culture = american - modifiable for various countries
        CultureInfo culture = new CultureInfo("en-Us");

        //this is the collection of searches made
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();

        //used to count total number of lines
        int linecount = 0;

        //record of the strings read from the file
        List<string> records = new List<string>();


        public TextSearch()
        {

            InitializeComponent();
            // the textbox is programmatically defined to suggest recent searches in custom manner
            ctlKeyword.AutoCompleteCustomSource = source;
            ctlKeyword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ctlKeyword.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }



        //When browse button is clicked
        private void btnBrowse_Click(object sender, EventArgs e)
        {

            //use built-in ShowDialog of to get the File Explorer
            DialogResult result = FileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //the filepath obtained by the File Explorer
                string file = FileDialog.FileName;

                //displays file found
                ctlFilePath.Text = file;
                StatusBar.Refresh();
                lblstatusbar.Text = "File Found";
            }
        }

        //dowork method of background worker 
        //this is where the entire file is compared to see if the word is found in any line or not
        //this is executed by background thread
        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //File path must not be null at this stage
            if (strFilePath != null)
            {
                //File must exist at this stage, do nothing otherwise.
                //Wait for Form Load event
                if (File.Exists(strFilePath))
                {

                
                    int linenumber = 0;
                  
                   // int milliseconds = 100;


                    for (int i = 0; i < records.Count; i++)
                    {
                        if (!backWorker.CancellationPending)
                        {
                            //ignore case, not whole words 
                            if (ctlIgnoreCase.Checked == true && ctlWholeWords.Checked == false)
                            {
                                if ((culture.CompareInfo.IndexOf(records[i], ctlKeyword.Text, CompareOptions.IgnoreCase) >= 0))
                                {
                                    record = new MyObject();
                                    record.line = records[i];
                                    // line number is 1+index
                                    linenumber = i + 1;
                                    record.linenumber = linenumber.ToString();
                                    myobjects.Add(record);

                                }

                                backWorker.ReportProgress(i + 1);
                            }
                            //ignore case, whole words only
                            else if (ctlIgnoreCase.Checked == true && ctlWholeWords.Checked == true)
                            {
                                if (Regex.Match(records[i], @"\b" + ctlKeyword.Text + @"\b", RegexOptions.Singleline | RegexOptions.IgnoreCase).Success)
                                {
                                    record = new MyObject();
                                    record.line = records[i];
                                    // line number is 1+index
                                    linenumber = i + 1;
                                    record.linenumber = linenumber.ToString();
                                    myobjects.Add(record);
                                }
                                //pass data from background thread to the ui thread
                                e.Result = myobjects;
                                //report progress as it comes
                                backWorker.ReportProgress(i + 1);
                            }
                            //case matters, not whole words
                            else if (ctlIgnoreCase.Checked == false && ctlWholeWords.Checked == false)
                            {
                                if ((culture.CompareInfo.IndexOf(records[i], ctlKeyword.Text) >= 0))
                                {
                                    record = new MyObject();
                                    record.line = records[i];
                                    // line number is 1+index
                                    linenumber = i + 1;
                                    record.linenumber = linenumber.ToString();
                                    myobjects.Add(record);

                                }
                                //pass data from background thread to the ui thread
                                e.Result = myobjects;
                                //report progress as it comes
                                backWorker.ReportProgress(i + 1);
                            }
                            //case matters, whole words only
                            else if (ctlIgnoreCase.Checked == false && ctlWholeWords.Checked == true)
                            {
                                if (Regex.Match(records[i], @"\b" + ctlKeyword.Text + @"\b", RegexOptions.Singleline).Success)
                                {
                                    record = new MyObject();
                                    record.line = records[i];
                                    // line number is 1+index
                                    linenumber = i + 1;
                                    record.linenumber = linenumber.ToString();
                                    myobjects.Add(record);
                                }
                                //pass data from background thread to the ui thread
                                e.Result = myobjects;
                                //report progress as it comes
                                backWorker.ReportProgress(i + 1);
                            }

                        }
                        //cancel pending
                        else
                        {
                            e.Cancel = true;
                            break;
                        }


                    }

                }
            }
        }


        private void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //add item to listview dynamically and remove added item from myobjects
            for (int i = 0; i < myobjects.Count(); i++)
            {
                ListViewItem item = new ListViewItem(myobjects[i].linenumber.ToString());
                item.SubItems.Add(myobjects[i].line.ToString());
                listNames.Items.Add(item);
                myobjects.Remove(myobjects[i]);
            }


            //if progress is 100% show 100%, not one line less
            if (e.ProgressPercentage == linecount)
            {
                lblstatusbar.Text = string.Format("Free - Line Number: {0} out of  {1} lines completed", e.ProgressPercentage, linecount);

            }
            else
            {
                //if cancellation pending show free
                if (backWorker.CancellationPending)
                    lblstatusbar.Text = string.Format("Free - Line Number: {0} out of  {1} lines completed ", e.ProgressPercentage, linecount);
                //if ongoing, show busy
                else
                    lblstatusbar.Text = string.Format("Busy - Line Number: {0} out of  {1} lines completed ", e.ProgressPercentage, linecount);

            }
            //increase the maximum to the total number of lines so we can show both the lines completed as absolute value as well as percentage progress
            progressBar.Maximum = linecount;
            progressBar.Value = e.ProgressPercentage;
        }


        //triggered every time search/cancel is clicked

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           


            if (btnSearch.Text == "Search")
            {
                listNames.Items.Clear();
                string line;
                if (!backWorker.IsBusy)
                {
                    // Read the file and display it line by line.  
                    System.IO.StreamReader file = new System.IO.StreamReader(strFilePath);
                    while ((line = file.ReadLine()) != null)
                    {
                        records.Add(line);
                        //for debugging purposes
                        //           Thread.Sleep(milliseconds);
                    }
                    //   string[] records = File.ReadAllLines(strFilePath);
                    linecount = records.Count;
                    source.Add(ctlKeyword.Text);
                    backWorker.RunWorkerAsync();//Call the background worker
                    btnSearch.Text = "Cancel";
                }
                else
                {
                    StatusBar.Refresh();
                    lblstatusbar.Text = "Busy";
                }

            }
            else if (btnSearch.Text == "Cancel")
            {
                backWorker.CancelAsync();
                btnSearch.Text = "Search";
            }

        }
        //if file path is changed then triggered
        //also works as pseudo reload of the form
        private void ctlFilePath_TextChanged(object sender, EventArgs e)
        {
            //reload all the values, clear the unnecessary stuff
            backWorker.CancelAsync();
            listNames.Items.Clear();
            myobjects.Clear();
            progressBar.Value = 0;
            ctlIgnoreCase.Checked = true;
            ctlWholeWords.Checked = true;



            //if textbox is empty wait for user
            if (ctlFilePath.TextLength == 0)
            {
                btnSearch.Enabled = false;
                StatusBar.Refresh();
                lblstatusbar.Text = "Free - Waiting for entry";
            }
            else
            {
                if (ctlFilePath.TextLength > 0)
                {

                    strFilePath = ctlFilePath.Text;
                }

                //display file does not exist if filepath is invalid
                if ((File.Exists(strFilePath)) == false)
                {
                    //if file is not found
                    StatusBar.Refresh();
                    lblstatusbar.Text = "Free - File Not Found";
                }
                else
                {// if file found display found
                    StatusBar.Refresh();
                    lblstatusbar.Text = "Free - File Found";
                }
            }
        }
        // when background worker completes, clear unecessary objects and data and refresh for new searches
        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSearch.Text = "Search";

            records.Clear();
            myobjects.Clear();

        }


        // acts as form load event
        //if the keyword text field is changed it is triggered
        //progress bar is 0
        //myobjects is cleared
        //background worker is cancelled
        private void ctlKeyword_TextChanged(object sender, EventArgs e)
        {

            backWorker.CancelAsync();
            listNames.Items.Clear();
            myobjects.Clear();
            progressBar.Value = 0;
            StatusBar.Refresh();
            ctlIgnoreCase.Checked = true;
            ctlWholeWords.Checked = true;

            lblstatusbar.Text = "Free - Waiting for entry";

            if (ctlKeyword.TextLength == 0)
            {
                btnSearch.Enabled = false;
                StatusBar.Refresh();
                lblstatusbar.Text = "Free - Waiting for entry";
            }

            if (ctlKeyword.TextLength > 0)
            {
                btnSearch.Enabled = true;
            }
        }


    }
}
