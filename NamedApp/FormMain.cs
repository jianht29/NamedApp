using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace NamedApp
{
    public partial class FormMain : UIForm
    {
        public List<string> NamedList = new List<string>();

        [ConfigFile("NamedApp.ini")]
        public class NamedAppCfg : IniConfig<NamedAppCfg>
        {
            [ConfigSection("ColorFul")]
            public bool ColorRandom { get; set; }

            [ConfigSection("ColorFul")]
            public int ColorR { get; set; }

            [ConfigSection("ColorFul")]
            public int ColorG { get; set; }

            [ConfigSection("ColorFul")]
            public int ColorB { get; set; }

            [ConfigSection("Speech")]
            public bool VoiceControl { get; set; }

            [ConfigSection("Speech")]
            public bool VoiceBroadcast { get; set; }

            [ConfigSection("Speech")]
            public string StartCommand { get; set; }

            [ConfigSection("Speech")]
            public string StopCommand { get; set; }

            public override void SetDefault()
            {
                base.SetDefault();
                ColorRandom = false;
                ColorR = 0;
                ColorG = 136;
                ColorB = 139;
                VoiceControl = false;
                VoiceBroadcast = false;
                StartCommand = "开始|开始抽签|继续|走";
                StopCommand = "停止|停止抽签|结束|停";
            }
        }

        //创建语音输入对象
        SpeechRecognitionEngine rein;

        //初始化语音引擎  在窗体创建时要调用
        private void InitSpeech()
        {
            try
            {
                //创建语音读取对象
                rein = new SpeechRecognitionEngine();

                //将语法给到语音识别器
                ConfigGrammar();

                //绑定声音源
                rein.SetInputToDefaultAudioDevice();

                //加载触发事件
                rein.SpeechRecognized += Recog;

                //执行语音识别操作
                //rein.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                //Do NoThing
            }

            SetVoiceControl();
        }

        public void ConfigGrammar()
        {
            try
            {
                //创建词汇对象
                Choices choices = new Choices();
                //choices.Add(new string[] { "开始", "开始抽签", "继续", "走", "停止", "停止抽签", "结束", "停" });

                choices.Add(NamedAppCfg.Current.StartCommand.Split('|').ToArray());
                choices.Add(NamedAppCfg.Current.StopCommand.Split('|').ToArray());

                //创建语法库
                GrammarBuilder grammarBuilder = new GrammarBuilder(choices);

                //导入语法库
                Grammar grm = new Grammar(grammarBuilder);

                //将语法给到语音识别器
                rein.UnloadAllGrammars();
                rein.LoadGrammar(grm);
            }
            catch
            {
                //Do NoThing
            }
        }

        //语音播报函数
        public void Speak_Message(string value)
        {
            SpeechSynthesizer speechSyn = new SpeechSynthesizer();  //用于语音合成
            speechSyn.SetOutputToDefaultAudioDevice();
            speechSyn.SpeakAsync(value);
        }

        //语音识别后输出事件（输出转为字符串）
        private void Recog(object sender, SpeechRecognizedEventArgs e)
        {
            //switch (e.Result.Text)
            //{
            //    case "开始":
            //    case "开始抽签":
            //    case "继续":
            //    case "走":
            //        StartCtrl(); 
            //        break;
            //    case "停止":
            //    case "停止抽签":
            //    case "结束":
            //    case "停":
            //        StopCtrl();
            //        break;
            //    default:
            //        break;
            //}

            if (NamedAppCfg.Current.StartCommand.Contains(e.Result.Text) && this.uiSymbolButtonNamed.Text == "开始抽签")
            {
                StartCtrl();
            }
            if (NamedAppCfg.Current.StopCommand.Contains(e.Result.Text) && this.uiSymbolButtonNamed.Text == "停止抽签")
            {
                StopCtrl();
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        public void StartCtrl()
        {
            this.uiSymbolLabelName.Text = "";

            this.uiSymbolButtonNamed.Style = UIStyle.Red;
            this.uiSymbolButtonNamed.Symbol = 61517;
            this.uiSymbolButtonNamed.Text = "停止抽签";
            this.uiSymbolLabelName.Symbol = 61442;
            this.uiSymbolLabelName.Font = new Font("微软雅黑", 130, FontStyle.Bold);
            this.TimerNamed.Start();
        }
        public void StopCtrl()
        {
            this.uiSymbolLabelName.Text = "";

            this.uiSymbolButtonNamed.Style = UIStyle.Colorful;
            this.uiSymbolButtonNamed.Symbol = 61515;
            this.uiSymbolButtonNamed.Text = "开始抽签";
            this.uiSymbolLabelName.Symbol = 61447;
            this.TimerNamed.Stop();

            Random rd = new Random();
            int index = rd.Next(NamedList.Count);

            if (NamedList[index].Length >= 6)
            {
                this.uiSymbolLabelName.Font = new Font("微软雅黑", 80, FontStyle.Bold);
            }
            else if (NamedList[index].Length == 5)
            {
                this.uiSymbolLabelName.Font = new Font("微软雅黑", 100, FontStyle.Bold);
            }
            else if (NamedList[index].Length == 4)
            {
                this.uiSymbolLabelName.Font = new Font("微软雅黑", 120, FontStyle.Bold);
            }
            else
            {
                this.uiSymbolLabelName.Font = new Font("微软雅黑", 150, FontStyle.Bold);
            }

            if (NamedList[index].Length == 2)
            {
                this.uiSymbolLabelName.Text = NamedList[index].Substring(0, 1) + "　" + NamedList[index].Substring(1, 1);
            }
            else if (NamedList[index].Length >= 6)
            {
                this.uiSymbolLabelName.Text = NamedList[index].Substring(0, 6);
            }
            else
            {
                this.uiSymbolLabelName.Text = NamedList[index];
            }

            if (NamedAppCfg.Current.VoiceBroadcast)
            {
                try
                {
                    Speak_Message(this.uiSymbolLabelName.Text.Trim().Replace("　", ""));
                }
                catch
                {
                    //Do NoThing
                }
            }
        }

        private void uiSymbolButtonNamed_Click(object sender, EventArgs e)
        {
            if (this.uiSymbolButtonNamed.Text == "开始抽签")
            {
                StartCtrl();
            }
            else
            {
                StopCtrl();
            }
        }

        /// <summary>读取文件，返回一个含有文件数据的行列表</summary>
        /// <param name="TxtFilePath">文件路径</param>
        /// <returns>文件数据的行列表</returns>
        private List<string> ReadTxtFromFile(string TxtFilePath)
        {
            // 1 首先创建一个泛型为string 的List列表
            List<string> AllRowStrList = new List<string>();
            {
                // 2 加载文件
                System.IO.StreamReader sr = new System.IO.StreamReader(TxtFilePath, Encoding.UTF8);
                String line; // 3 调用StreamReader的ReadLine()函数
                while ((line = sr.ReadLine()) != null)
                {   // 4 将每行添加到文件List中
                    AllRowStrList.Add(line.Replace(" ", "").Replace("　", ""));
                }
                // 5 关闭流
                sr.Close();
            }
            // 6 完成操作
            return AllRowStrList;
        }

        public void SetStyle()
        {
            if (NamedAppCfg.Current.ColorRandom)
            {
                Color colorFul = RandomColor.GetColor(ColorScheme.Random, Luminosity.Dark);
                UIStyles.InitColorful(colorFul, Color.White);
                NamedAppCfg.Current.ColorR = colorFul.R;
                NamedAppCfg.Current.ColorG = colorFul.G;
                NamedAppCfg.Current.ColorB = colorFul.B;
                NamedAppCfg.Current.Save();
            }
            else
            {
                try
                {
                    UIStyles.InitColorful(Color.FromArgb(NamedAppCfg.Current.ColorR, NamedAppCfg.Current.ColorG, NamedAppCfg.Current.ColorB), Color.White);
                }
                catch
                {
                    UIStyles.InitColorful(Color.FromArgb(0, 136, 139), Color.White);
                }
            }

            this.uiStyleManager.Style = UIStyle.Colorful;
            if (this.uiSymbolButtonNamed.Text == "开始抽签")
            {
                this.uiSymbolButtonNamed.Style = UIStyle.Colorful;
            }
        }

        public void LoadNamedList(bool editNamedList = false)
        {
            string namedListTxtFile = Application.StartupPath + "\\NamedList.txt";

            if (!File.Exists(namedListTxtFile))
            {
                string[] lines = { "姓名一", "姓名二", "姓名三" };
                File.WriteAllLines(namedListTxtFile, lines);
                this.ShowInfoDialog2("抽签点名程序", "请在NamedList.txt中输入每行一个的姓名列表！");
                if (!editNamedList)
                {
                    System.Diagnostics.Process.Start("notepad.exe", namedListTxtFile).WaitForExit();
                }
            }

            if (editNamedList)
            {
                System.Diagnostics.Process.Start("notepad.exe", namedListTxtFile).WaitForExit();
            }

            NamedList = ReadTxtFromFile(namedListTxtFile);
        }

        public void SetVoiceControl()
        {
            try
            {
                if (NamedAppCfg.Current.VoiceControl)
                {
                    //执行语音识别操作
                    rein.RecognizeAsync(RecognizeMode.Multiple);
                }
                else
                {
                    //停止语音识别操作
                    rein.RecognizeAsyncStop();
                }
            }
            catch
            {
                //Do NoThing
            }
        }

        public void SetMenuStatus()
        {

            this.ToolStripMenuItemColorDefault.Checked = !NamedAppCfg.Current.ColorRandom;
            this.ToolStripMenuItemColorFul.Checked = NamedAppCfg.Current.ColorRandom;
            this.ToolStripMenuItemVoiceBroadcast.Checked = NamedAppCfg.Current.VoiceBroadcast;
            this.ToolStripMenuItemVoiceControl.Checked = NamedAppCfg.Current.VoiceControl;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) * 1 / 3;
            // 加载配置文件
            NamedAppCfg.Current.Load();
            // 设置菜单状态
            SetMenuStatus();
            // 设置主题风格
            SetStyle();
            // 设置初始状态
            ReSetNamed();
            // 加载抽签名单
            LoadNamedList();
            // 初始化语音识别
            InitSpeech();
        }

        private void TimerNamed_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int index = rd.Next(NamedList.Count);
            this.uiSymbolLabelName.Text = NamedList[index].Substring(0, NamedList[index].Length >= 3 ? 3 : NamedList[index].Length).Replace("(", "").Replace("（", "").Replace("）", "").Replace(")", "");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void ReSetNamed()
        {
            this.uiSymbolLabelName.Font = new Font("微软雅黑", 120, FontStyle.Bold);
            this.uiSymbolLabelName.Text = "准备抽签";
            this.uiSymbolLabelName.Symbol = 61484;
            this.uiSymbolButtonNamed.Style = UIStyle.Colorful;
            this.uiSymbolButtonNamed.Symbol = 61515;
            this.uiSymbolButtonNamed.Text = "开始抽签";
            this.TimerNamed.Stop();
        }

        private void ToolStripMenuItemReSet_Click(object sender, EventArgs e)
        {
            ReSetNamed();
            LoadNamedList();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemColorDefault_Click(object sender, EventArgs e)
        {
            NamedAppCfg.Current.ColorRandom = false;
            NamedAppCfg.Current.ColorR = 0;
            NamedAppCfg.Current.ColorG = 136;
            NamedAppCfg.Current.ColorB = 139;
            NamedAppCfg.Current.Save();
            SetStyle();
            this.ToolStripMenuItemColorDefault.Checked = true;
            this.ToolStripMenuItemColorFul.Checked = false;
        }

        private void ToolStripMenuItemColorFul_Click(object sender, EventArgs e)
        {
            NamedAppCfg.Current.ColorRandom = true;
            NamedAppCfg.Current.Save();
            SetStyle();
            this.ToolStripMenuItemColorDefault.Checked = false;
            this.ToolStripMenuItemColorFul.Checked = true;
        }

        private void ToolStripMenuItemVoiceBroadcast_Click(object sender, EventArgs e)
        {
            NamedAppCfg.Current.VoiceBroadcast = !NamedAppCfg.Current.VoiceBroadcast;
            NamedAppCfg.Current.Save();
            this.ToolStripMenuItemVoiceBroadcast.Checked = NamedAppCfg.Current.VoiceBroadcast;
        }

        private void ToolStripMenuItemVoiceControl_Click(object sender, EventArgs e)
        {
            NamedAppCfg.Current.VoiceControl = !NamedAppCfg.Current.VoiceControl;
            NamedAppCfg.Current.Save();
            SetVoiceControl();
            this.ToolStripMenuItemVoiceControl.Checked = NamedAppCfg.Current.VoiceControl;
        }

        private void ToolStripMenuItemVoiceCommand_Click(object sender, EventArgs e)
        {
            FormVoiceCommand formVoiceCommand = new FormVoiceCommand();
            formVoiceCommand.uiTextBoxStart.Text = NamedAppCfg.Current.StartCommand;
            formVoiceCommand.uiTextBoxStop.Text = NamedAppCfg.Current.StopCommand;
            if (formVoiceCommand.ShowDialog() == DialogResult.OK)
            {
                NamedAppCfg.Current.StartCommand = formVoiceCommand.uiTextBoxStart.Text.Trim().Replace(" ", "").Replace("　", "").Replace("｜", "|");
                NamedAppCfg.Current.StopCommand = formVoiceCommand.uiTextBoxStop.Text.Trim().Replace(" ", "").Replace("　", "").Replace("｜", "|");
                NamedAppCfg.Current.Save();
                ConfigGrammar();
                SetVoiceControl();
            }
        }

        private void ToolStripMenuItemNamedList_Click(object sender, EventArgs e)
        {
            ReSetNamed();
            LoadNamedList(true);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TimerNamed.Stop();
            this.rein.RecognizeAsyncCancel();
            this.rein.RecognizeAsyncStop();
            this.rein.Dispose();
        }
    }
}
