using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FCFS
{

    
     
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////
        /////////// Implementation of FCFS ////////
        public class FCFS
        {
            private static int processNumbers;
            private int[] brustTime;
            private int[] waitingTime;
            private int[] turnArountTime;
            private int totalWaitingTime = 0;
            private double averageWaitingTime;
            private Dictionary<int, int> granttChart = new Dictionary<int, int>();
            Random random = new Random();

            // Getters
            public int[] getBrustTime()
            {
                return brustTime;
            }

            public int[] getWaitingTime()
            {
                return waitingTime;
            }

            public int[] getTurnAroundTime()
            {
                return turnArountTime;
            }

            public double getAvgWaitingTime()
            {
                return averageWaitingTime;
            }

            public Dictionary<int, int> getGranttChart()
            {
                return granttChart;
            }

            public FCFS(int n)
            {
                processNumbers = n;

                waitingTime = new int[processNumbers];
                brustTime = new int[processNumbers];
                turnArountTime = new int[processNumbers];

                // Filling the random brust time values
                for (int i = 0; i < processNumbers; i++)
                {
                    brustTime[i] = random.Next(1, 100);
                }

                // Implementing the Algorithm
                findWaitingTime();
                findTurnAroundTime();
                findAvgWaitingTime();
                setGranttChart();
            }

            /// <summary>
            /// Find the waiting time for each process
            /// </summary>
            private void findWaitingTime()
            {
                // waiting time for first process is 0
                waitingTime[0] = 0;

                // calculating waiting time
                for (int i = 1; i < processNumbers; i++)
                {
                    waitingTime[i] = brustTime[i - 1] + waitingTime[i - 1];
                }
            }

            /// <summary>
            /// Finding the turn around time for each process
            /// </summary>
            private void findTurnAroundTime()
            {
                for (int i = 0; i < processNumbers; i++)
                {
                    turnArountTime[i] = brustTime[i] + waitingTime[i];
                }
            }

            /// <summary>
            /// Find the Average Waiting Time of the Whole proccesses
            /// </summary>
            private void findAvgWaitingTime()
            {
                for (int i = 0; i < processNumbers; i++)
                {
                    totalWaitingTime += waitingTime[i];
                }

                averageWaitingTime = (double)totalWaitingTime / (double)processNumbers;
            }

            /// <summary>
            /// Set the Grantt Chart Values
            /// </summary>
            private void setGranttChart()
            {
                int currentValue = 0;

                for (int i = 0; i < processNumbers; i++)
                {
                    currentValue += brustTime[i];
                    granttChart.Add(i, currentValue);
                }
            }
        }

        //////////////////////////
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (processNumbersTextBox.Text != "" && Int32.Parse(processNumbersTextBox.Text) != 0)
            {
                reset();
                int numbers = Int32.Parse(processNumbersTextBox.Text);
                FCFS fCFS = new FCFS(numbers);
                int[] burstTime = fCFS.getBrustTime();
                int[] waitingTime = fCFS.getWaitingTime();
                int[] turnAroundTime = fCFS.getTurnAroundTime();
                for (int i = 0; i < numbers; i++)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(burstTime[i].ToString());
                    item.SubItems.Add(waitingTime[i].ToString());
                    item.SubItems.Add(turnAroundTime[i].ToString());
                    fcfsListView.Items.Add(item);
                }

                foreach (var proc in fCFS.getGranttChart())
                {
                    ganttChart.Series["Process scheduling"].Points.AddXY(proc.Key, proc.Value);
                }

                NumberFormatInfo setPrecision = new NumberFormatInfo();

                setPrecision.NumberDecimalDigits = 2;
                averageWaitingTimeLabel.Text = fCFS.getAvgWaitingTime().ToString("N", setPrecision);
            }

            else
            {
                MessageBox.Show("Enter Valid Value");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
            processNumbersTextBox.Clear();
        }

        private void reset()
        {
            fcfsListView.Items.Clear();
            averageWaitingTimeLabel.Text = "";
            ganttChart.Series["Process scheduling"].Points.Clear();
        }

        
    }
}
