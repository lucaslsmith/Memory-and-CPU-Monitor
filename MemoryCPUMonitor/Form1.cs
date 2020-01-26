using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCPUMonitor
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer _timer;
        bool startflag = false;


        public Form1()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 1;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
        }

        private void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //Monitor and get the values of the CPU and memory.
            int CPUValue = GetCPUValue();
            int memoryValue = GetMemoryValue();



            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action(() => progressBar1.Value = CPUValue));
            }
            else
            {
                progressBar1.Value = CPUValue;
            }



            if (CPUUsage.InvokeRequired)
            {
                CPUUsage.Invoke(new Action(() => CPUUsage.Text = CPUValue.ToString() + "%"));
            }
            else
            {
                CPUUsage.Text = CPUValue.ToString() + "%";
            }




            if (progressBar2.InvokeRequired)
            {
                progressBar2.Invoke(new Action(() => progressBar2.Value = memoryValue));
            }
            else
            {
                progressBar2.Value = memoryValue;
            }



            if (MemoryUsage.InvokeRequired)
            {
                MemoryUsage.Invoke(new Action(() => MemoryUsage.Text = memoryValue.ToString() + "%"));
            }
            else
            {
                MemoryUsage.Text = memoryValue.ToString() + "%";
            }
        }

        private int GetCPUValue()
        {
            var CPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                CPUCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnValue = (int)CPUCounter.NextValue();
            return returnValue;
        }

        private int GetMemoryValue()
        {
            var MemoryCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnValue = (int)MemoryCounter.NextValue();
            return returnValue;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (startflag == false)
            {
                startflag = true;
                _timer.Enabled = true;
                Start.Text = "Stop Monitoring";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                Start.Text = "Start Monitoring";
            }
        }
    }
}
