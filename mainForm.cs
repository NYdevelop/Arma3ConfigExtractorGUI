using Arma3ConfigExtractorGUI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arma3ConfigExtractorGUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> pboMap = new Dictionary<string, string>();


        #region 実行
        private async void btnOutputAll_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "開始";

            var t = Task.Run(() =>
            {
                var workPath = InitWorkDir();
                string stringTablePath = textBoxOutput.Text + "\\StringTable.xml";
                if (checkGetStringTable.Checked)
                {
                    if (GetStringTable(workPath) == false) return "StringTable抽出失敗";
                }
                else
                {
                    stringTablePath = textBoxStringTable.Text;
                }

                int count = 0;
                var total = pboMap.Count;
                foreach (var item in pboMap.Values)
                {
                    ExtractProcess(workPath, item, stringTablePath);
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        toolStripStatusLabel.Text = "進捗: " + (++count) + "/" + total;
                    });
                }
                return "完了";
            });
            var ret = await t;
            toolStripStatusLabel.Text = ret;
        }

        private async void btnOutputOne_Click(object sender, EventArgs e)
        {
            if (listPBO.SelectedIndex == -1)
            {
                MessageBox.Show(
                        this,
                        "リストから選択してください",
                        "リストから選択してください",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            toolStripStatusLabel.Text = "開始";
            string fileName = (string)listPBO.SelectedItem;
            var t = Task.Run(()=>
            {
                var workPath = InitWorkDir();
                string stringTablePath = textBoxOutput.Text + "\\StringTable.xml";
                if (checkGetStringTable.Checked)
                {
                    if (GetStringTable(workPath) == false) return "StringTable抽出失敗";
                }
                else
                {
                    stringTablePath = textBoxStringTable.Text;
                }

                ExtractProcess(workPath, pboMap[fileName], stringTablePath);
                return "完了:" + fileName + ", 出力: " + Path.GetFileNameWithoutExtension(fileName) + ".csv";
            });
            var ret = await t;
            toolStripStatusLabel.Text = ret;
        }
        #endregion

        #region 実行関数
        private string InitWorkDir()
        {
            var workPath = Settings.Default.tmpWorkPath;
            if (workPath == "")
            {
                workPath = Path.GetTempPath() + "Arma3ConfigExtractor\\";
            }
            if (Directory.Exists(workPath))
            {
                Directory.Delete(workPath, true);
            }
            Directory.CreateDirectory(workPath);
            return workPath;
        }

        private void ExtractProcess(string workPath, string pboPath, string stringTablePath = "")
        {
            // 異常チェック
            if (Directory.Exists(textBoxOutput.Text) == false)
            {
                ShowMessageBox(
                    "出力先フォルダが見つかりません\n出力先フォルダ設定を確認してください",
                    "出力先フォルダが見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 解凍
            // pboconsole.exe -unpack ?.pbo
            string pboManagerExePath = textBoxPBOManagerDir.Text;
            if (RunProcess(
                pboManagerExePath,
                "-unpack " + pboPath + " " + workPath,
                workPath,
                "PBOConsole.exe設定を確認してください") == false)
            {
                return;
            }

            // config.binをcppに変換
            string cfgConvertPath = textBoxCfgConvertDir.Text;
            string binFile = workPath + "config.bin";
            if (File.Exists(binFile) == false)
            {
                string file = Path.GetFileName(binFile);
                ShowMessageBox(
                    file + "が見つかりません",
                    file + "が見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RunProcess(
                cfgConvertPath,
                binFile,
                workPath,
                "BINToCPP.bat設定を確認してください") == false)
            {
                return;
            }

            // cpp解析
            string Arma3ConfigExtractorPath = textBoxArma3ConfigExtractorDir.Text;
            string cppFile = workPath + "config.cpp";
            if (File.Exists(cppFile) == false)
            {
                string file = Path.GetFileName(cppFile);
                ShowMessageBox(
                    file + "が見つかりません",
                    file + "が見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(stringTablePath) == false)
            {
                string file = Path.GetFileName(stringTablePath);
                ShowMessageBox(
                    file + "が見つかりません\n設定を確認してください",
                    file + "が見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pboName = Path.GetFileNameWithoutExtension(pboPath);
            if (RunProcess(
                Arma3ConfigExtractorPath,
                cppFile + " " + stringTablePath + " " + pboName,
                textBoxOutput.Text,
                "Arma3ConfigExtractor.exe設定を確認してください") == false)
            {
                return;
            }
        }

        private bool GetStringTable(string workPath)
        {
            string[] files =
                Directory.GetFiles(
                    textBoxPboDir.Text,
                    "*.pbo",
                    SearchOption.TopDirectoryOnly);

            string matchFileName = "";
            var rx = new Regex(".*main.*", RegexOptions.Compiled);
            foreach (var f in files)
            {
                if (rx.IsMatch(f))
                {
                    matchFileName = f;
                    break;
                }
            }

            var l = files.ToList();
            if (matchFileName != "")
            {
                l.Remove(matchFileName);
                l.Insert(0, matchFileName);
            }

            foreach (var pboPath in l)
            {
                // 解凍
                string pboManagerExePath = textBoxPBOManagerDir.Text;
                if (RunProcess(
                    pboManagerExePath,
                    "-unpack " + pboPath + " " + workPath,
                    workPath,
                    "PBOConsole.exe設定を確認してください") == false)
                {
                    return false;
                }

                files =
                    Directory.GetFiles(
                        workPath,
                        "StringTable.xml",
                        SearchOption.AllDirectories);
                if (files.Length == 1)
                {
                    File.Delete(textBoxOutput.Text + "\\StringTable.xml");
                    File.Move(files[0], textBoxOutput.Text + "\\StringTable.xml");
                    return true;
                }
            }

            ShowMessageBox(
                "StringTable.xmlが見つかりませんでした",
                "StringTable.xmlが見つかりませんでした",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool RunProcess(string programPath, string arg, string workPath, string errorMsg)
        {
            if (File.Exists(programPath) == false)
            {
                string programFile = Path.GetFileName(programPath);
                ShowMessageBox(
                    programFile + "が見つかりません\n" + errorMsg,
                    programFile + "が見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = programPath;
            startInfo.Arguments = arg;
            startInfo.WorkingDirectory = workPath;

            startInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
            startInfo.UseShellExecute = false; // シェル機能を使用しない
            startInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト
            Process p = System.Diagnostics.Process.Start(startInfo); // アプリの実行開始
            string output = p.StandardOutput.ReadToEnd(); // 標準出力の読み取り
            output = output.Replace("\r\r\n", "\n"); // 改行コードの修正
            Debug.Write(output); // ［出力］ウィンドウに出力

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPboDir.Text = Settings.Default.PBODir;
            textBoxOutput.Text = Settings.Default.OutputPath;
            textBoxPBOManagerDir.Text = Settings.Default.PBOManagerDir;
            textBoxArma3ConfigExtractorDir.Text = Settings.Default.Arma3ConfigExtractorDir;
            textBoxCfgConvertDir.Text = Settings.Default.CfgConvertDir;

            if (Directory.Exists(textBoxPboDir.Text))
            {
                ListFiles(textBoxPboDir.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PBODir = textBoxPboDir.Text;
            Settings.Default.OutputPath = textBoxOutput.Text;
            Settings.Default.PBOManagerDir = textBoxPBOManagerDir.Text;
            Settings.Default.Arma3ConfigExtractorDir = textBoxArma3ConfigExtractorDir.Text;
            Settings.Default.CfgConvertDir = textBoxCfgConvertDir.Text;
            Settings.Default.Save();
        }

        private void ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                MessageBox.Show(
                    text,
                    caption,
                    buttons, icon);
            });
        }
        #endregion

        #region 各種設定
        private void btnSetPBODir_Click(object sender, EventArgs e)
        {
            string initDir = Directory.GetCurrentDirectory();
            if (Directory.Exists(textBoxPboDir.Text) == true)
            {
                initDir = textBoxPboDir.Text;
            }
            using (var dir = new OpenFileDialog()
            {
                Title = "PBOフォルダを指定してください。",
                InitialDirectory = initDir,
                FileName = "selectFolder",
                Filter = "Folder|.",
                CheckFileExists = false
            })
            {
                if (dir.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxPboDir.Text = Path.GetDirectoryName(dir.FileName);
                    ListFiles(textBoxPboDir.Text);
                }
            }
        }

        private void ListFiles(string path)
        {
            pboMap.Clear();
            listPBO.Items.Clear();

            string[] files =
                Directory.GetFiles(
                    path,
                    "*.pbo",
                    SearchOption.TopDirectoryOnly);
            if (files.Length == 0)
            {
                MessageBox.Show(
                    this,
                    "PBOが見つかりません",
                    "PBOが見つかりません",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var file in files)
            {
                var item = Path.GetFileName(file);
                listPBO.Items.Add(item);
                pboMap[item] = file;
            }
        }

        private void btnSetOutDir_Click(object sender, EventArgs e)
        {
            SettingDir(textBoxOutput, "出力CSVフォルダを指定してください。", "selectFolder", "Folder|.|All|*.*", false);
        }

        private void btnPBOManagerDir_Click(object sender, EventArgs e)
        {
            SettingDir(textBoxPBOManagerDir, "PBOConsole.exeを指定してください。", "PBOConsole.exe", "exe|*.exe");
        }

        private void btnArma3ConfigExtractorDir_Click(object sender, EventArgs e)
        {
            SettingDir(textBoxArma3ConfigExtractorDir, "Arma3ConfigExtractor.exeを指定してください。", "Arma3ConfigExtractor.exe", "exe|*.exe");
        }

        private void btnCfgConvertDir_Click(object sender, EventArgs e)
        {
            SettingDir(textBoxCfgConvertDir, "BINToCPP.batを指定してください。", "BINToCPP.bat", "bat|*.bat");
        }

        private void SettingDir(TextBox textbox, string description, string fileName, string extention, bool CheckFileExists = true)
        {
            string initDir = Directory.GetCurrentDirectory();
            if (Directory.Exists(textbox.Text) == true)
            {
                initDir = textbox.Text;
            }
            using (var dir = new OpenFileDialog()
            {
                Title = description,
                InitialDirectory = initDir,
                FileName = fileName,
                Filter = extention,
                CheckFileExists = CheckFileExists
            })
            {
                if (dir.ShowDialog(this) == DialogResult.OK)
                {
                    textbox.Text = dir.FileName;
                }
            }
        }

        private void buttonStringTable_Click(object sender, EventArgs e)
        {
            string initDir = Directory.GetCurrentDirectory();
            if (Directory.Exists(textBoxStringTable.Text) == true)
            {
                initDir = textBoxStringTable.Text;
            }
            using (var dir = new OpenFileDialog()
            {
                Title = "StringTable.xml",
                InitialDirectory = initDir,
                FileName = "StringTable.xml",
                Filter = "xml|*.xml",
                CheckFileExists = true
            })
            {
                if (dir.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxStringTable.Text = dir.FileName;
                }
            }
        }

        private void checkGetStringTable_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = !checkGetStringTable.Checked;
        }
        #endregion
    }
}
