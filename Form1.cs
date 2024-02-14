using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Dmigoto_Sword_GUI
{
    public partial class Form1 : Form
    {
        string current_game = "";
        string basePath = AppDomain.CurrentDomain.BaseDirectory.ToString();

        public Form1()
        {
            InitializeComponent();
        }


        public void setCurrentGame(string gameName)
        {
            this.current_game = gameName;
            this.Text = "CurrentGame: " + current_game;
        }

        private void genshinImpactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentGame("GI");
        }

        private void honkaiStarRailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentGame("HSR");
        }

        private void honkaiImpact3rdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentGame("HI3");
        }

        private void zenlessZoneZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentGame("ZZZ");
        }

        private void narakaBladepointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCurrentGame("Unknown");
        }

        public void runCommand(string arguments)
        {

            // 创建一个 Process 对象
            Process process = new Process();

            // 设置要执行的程序和参数
            process.StartInfo.FileName = basePath + "3Dmigoto-Sword.exe";
            process.StartInfo.Arguments = arguments;  // 可选，如果该程序接受命令行参数
            //MessageBox.Show("当前运行参数： " + arguments);

            // 配置进程启动信息
            process.StartInfo.UseShellExecute = false;  // 不使用操作系统的shell启动程序
            process.StartInfo.RedirectStandardOutput = true;  // 重定向标准输出
            process.StartInfo.RedirectStandardError = true;   // 重定向标准错误输出
            process.StartInfo.CreateNoWindow = true;  // 不创建新窗口

            // 指定输出流编码格式为UTF-8
            //process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            //process.StartInfo.StandardErrorEncoding = Encoding.UTF8;

            // 启动程序
            process.Start();

            string output = process.StandardOutput.ToString();
            string error = process.StandardError.ToString();

            process.WaitForExit();


            if (!string.IsNullOrEmpty(output) && output.Trim() != "System.IO.StreamReader")
            {
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Run Success.");
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_game))
            {
                MessageBox.Show("Please select your target mod file's game name.");
                return;
            }

            openFileDialog1.Filter = "3Dmigoto INI Files (*.ini)|*.ini";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                string reverse_setting = "settings\\ReverseSetting.json";
                string reverse_setting_path = basePath + reverse_setting;
                JObject jsonObject = new JObject();
                jsonObject["GameName"] = current_game;
                jsonObject["ReverseFilePath"] = filePath;
                File.WriteAllText(reverse_setting_path, jsonObject.ToString());
                runCommand("reverse");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_game))
            {
                MessageBox.Show("Please select your target mod file's game name.");
                return;
            }

            openFileDialog1.Filter = "3Dmigoto INI Files (*.ini)|*.ini";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                string reverse_setting = "settings\\ReverseSetting.json";
                string reverse_setting_path = basePath + reverse_setting;
                JObject jsonObject = new JObject();
                jsonObject["GameName"] = current_game;
                jsonObject["ReverseFilePath"] = filePath;
                File.WriteAllText(reverse_setting_path, jsonObject.ToString());
                runCommand("reverseMerged");
            }
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/StarBobis");
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/Mdw8dKsTa5");
        }
    }
}
