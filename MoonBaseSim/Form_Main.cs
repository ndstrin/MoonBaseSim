using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonBaseSim
{
    public partial class Form_Main : Form
    {
        // Gobal Values for Applications for Resources and Level
        MoonBase MoonBase = new MoonBase();
        bool MiningOre = false;
        bool ProcessOre = false;


        public Form_Main()
        {
            InitializeComponent();
            //Sets the Intial Values
            RefreshBaseValues();
            RefreshResouceValues();
        }

        // Updates/Sets the Base Values in Main Form 
        private void RefreshBaseValues()
        {
            LB_Base_Level_Value.Text = MoonBase.Level.ToString();
            LB_Base_Workers_Value.Text = MoonBase.Total_Workers.ToString();
            LB_Base_ActiveWorkers.Text = MoonBase.ActiveWorkers().ToString();
            UpdateExp();
        }
        // Updates/Sets the Resources in the Main Form
        private void RefreshResouceValues()
        {
            LB_Resource_Oxygen_Value.Text = MoonBase.Resources.Oxygen.ToString();
            LB_Resouce_Water_Value.Text = MoonBase.Resources.Water.ToString();
            LB_Resource_Food_Value.Text = MoonBase.Resources.Food.ToString();
            LB_Resource_Ore_Value.Text = MoonBase.Resources.Ore.ToString();
            UpdateExp();

        }
        //Updates the EXP Values and tracks the Levels updates.
        private void UpdateExp() 
        {
            LB_EXP_Value.Text = MoonBase.EXP.ToString();

        }

        // Background Worker for Mining do work while active
        private void backgroundWorker_MineOre_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (MiningOre)
                {
                    if (MoonBase.CurrentWorkers.Minners > 0)
                    {
                        MoonBase.Resources.Ore += (int)(1 * MoonBase.CurrentWorkers.Minners);
                        MoonBase.EXP += 1;
                    }
                    backgroundWorker_MineOre.ReportProgress(1);
                    Thread.Sleep(1000);
                }
            }
            catch { }
        }

        // Activate the Mining of Ore background process
        private void btn_Mine_Click(object sender, EventArgs e)
        {
            // Turns of the Mining Ore
            if (MiningOre)
            {
                btn_Mine.Text = "Mine Ore";
                MiningOre = false;

            }
            // Turns on Mining Ore
            else
            {
                btn_Mine.Text = "Minning Ore";
                MiningOre = true;
                backgroundWorker_MineOre.RunWorkerAsync();
            }
            // Reloads the Base Values for Works value
            RefreshBaseValues();

        }

        private void backgroundWorker_MineOre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Refreshes the Resources after Mining has Completed
            RefreshResouceValues();
        }

        private void backgroundWorker_MineOre_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Live Updates the Resource Values while Mining.
            RefreshResouceValues();
        }
        //Remove Resouces for Game play
        private void timer_GamePlay_Tick(object sender, EventArgs e)
        {
            try
            {
                MoonBase.Resources.Oxygen = MoonBase.Resources.Oxygen - 2;
                //MoonBase.Resources.Food = MoonBase.Resources.Food - 1;
                RefreshResouceValues();

            }
            catch { }
        }
        //Background Process for running Ore Process to convert Ore to Oxygen
        private void backgroundWorker_ProcessOre_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (ProcessOre && MoonBase.Resources.Ore > 0 && MoonBase.CurrentWorkers.ProcessingWorkers > 0)
                {
                    MoonBase.Resources.Oxygen += 1*MoonBase.CurrentWorkers.ProcessingWorkers;
                    MoonBase.Resources.Ore -= 4*MoonBase.CurrentWorkers.ProcessingWorkers;
                    MoonBase.EXP += 10;
                    backgroundWorker_ProcessOre.ReportProgress(1);
                    Thread.Sleep(3000);
                }
            }
            catch { }
        }

        private void backgroundWorker_ProcessOre_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Live Updates the Resource Values while Processing Ore.
            RefreshResouceValues();
        }
        //Starts the Processing Ore to Generate Oxygen
        private void BTN_ProcessOre_Click(object sender, EventArgs e)
        {
            //If Running 
            if (ProcessOre) 
            {
                ProcessOre = false;
                BTN_ProcessOre.Text = "Process Ore";
            }
            //Start if not Running
            else
            {
                ProcessOre = true;
                BTN_ProcessOre.Text = "Processing Ore";
                backgroundWorker_ProcessOre.RunWorkerAsync();
            }
        }
        //Updates the Total Number of Minners
        private void ActiveMiners_ValueChanged(object sender, EventArgs e)
        {
            if (ActiveMiners.Value == 0)
            {
                btn_Mine.Enabled = false;
            }
            else
            {
                btn_Mine.Enabled = true;
            }
            MoonBase.CurrentWorkers.Minners = (int)ActiveMiners.Value;
            RefreshBaseValues();
        }
        //Updates the Total Number of Processing Workers
        private void ProcessingWorkers_ValueChanged(object sender, EventArgs e)
        {
            if (ProcessingWorkers.Value == 0)
            { BTN_ProcessOre.Enabled = false; }
            else
            {
                BTN_ProcessOre.Enabled = true;
            }
            MoonBase.CurrentWorkers.ProcessingWorkers = (int)ProcessingWorkers.Value;
            RefreshBaseValues();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }


        private void ActiveMiners_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
