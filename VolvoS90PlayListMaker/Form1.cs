using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author:liheng四十斤莴笋
 * Date:2020-07-04
 * 用于给存放音乐文件的U盘生成适用于Volvo S90 车机支持的播放列表
*/

namespace VolvoS90PlayListMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeHintMessage();
            InitializeDiskList();

        }

        /// <summary>
        /// 初始化提示信息
        /// </summary>
        private void InitializeHintMessage()
        {
            this.TextBox_HintMessage.Text = "1，在U盘根目录按文件夹分类，歌曲存放在不同的文件夹内（可以有子文件夹）。";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "2，将U盘插到电脑上。";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "3，在电脑上运行此软件。（若无法识别U盘，请点击重新识别）";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "4，点击“生成”，并确认U盘根目录已根据文件夹生成相应的播放列表文件（m3u8）";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "5，关闭软件，拔出U盘。";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "6，U盘插到车载播放器上。";
            this.TextBox_HintMessage.Text += System.Environment.NewLine + "7，在车机上选择U盘，并点击“库”，选择“播放列表即可”。";
        }

        /// <summary>
        /// 初始化盘符下拉列表
        /// </summary>
        private int InitializeDiskList()
        {
            DriveInfo[] allDrivers = DriveInfo.GetDrives();
            List<DriveInfo> removableDrivers = new List<DriveInfo>();
            //检索计算机上的所有逻辑驱动器名称
            foreach (DriveInfo item in allDrivers)
            {
                if (item.DriveType == DriveType.Removable)
                {
                    removableDrivers.Add(item);
                }
            }

            this.comboBox1.Items.AddRange(removableDrivers.ToArray());
            if (removableDrivers.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
            return removableDrivers.Count;
        }



        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Run_Click(object sender, EventArgs e)
        {
            //button1_Click(sender, e);
            //return;


            //清空提示消息与结果列表
            this.TextBox_Result.Text = this.label6.Text = "";
            if (this.comboBox1.SelectedItem == null)
            {
                this.label6.Text = "请选择盘符。";
                return;
            }
            DriveInfo disk = (DriveInfo)this.comboBox1.SelectedItem;
            DirectoryInfo TheFolder = new DirectoryInfo(disk.Name);
            if (!TheFolder.Exists)
            {
                this.label6.Text = "请选择盘符。";
                return;
            }
            //清除已有的播放列表（m3u8文件）
            FileInfo[] playList = TheFolder.GetFiles();
            foreach (FileInfo fi in playList)
            {
                if (fi.Extension.ToLower().Equals(".m3u"))
                {
                    File.Delete(fi.FullName);
                }
            }
            //获取文件夹列表
            DirectoryInfo[] directortyList = TheFolder.GetDirectories();
            //遍历每个文件夹
            foreach (DirectoryInfo dr in directortyList)
            {
                if (dr.Name == "System Volume Information")
                    continue;
                List<string> playListData = new List<string>();
                //创建播放列表文件
                new FileInfo(dr.FullName + ".m3u").Create().Close();
                //遍历文件夹（递归查找）
                GetFilesRecursion(dr.FullName, dr.Name, ref playListData);

                foreach (string musicName in playListData)
                {
                    this.TextBox_Result.AppendText(musicName + System.Environment.NewLine);
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(dr.FullName + ".m3u", true, Encoding.GetEncoding("GB2312")))
                    //using (System.IO.StreamWriter file = new System.IO.StreamWriter(dr.FullName + ".m3u8", true))
                    {
                        file.WriteLine(musicName);// 直接追加文件末尾，换行
                    }
                }
            }
            this.label6.Text = "处理完成！";
        }

        /// <summary>
        /// 重新扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Rescan_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            int DiskCount = InitializeDiskList();
            //MessageBox.Show("找到" + DiskCount.ToString() + "个可移动磁盘");
            if (DiskCount > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void GetFilesRecursion(string fullpathname, string pathname, ref List<string> list)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(fullpathname);
            FileInfo[] fileList = TheFolder.GetFiles();
            foreach (FileInfo filename in fileList)
            {
                list.Add(pathname + "\\" + filename.Name);
            }

            DirectoryInfo[] folderList = TheFolder.GetDirectories();
            foreach (DirectoryInfo folder in folderList)
            {
                GetFilesRecursion(fullpathname + "\\" + folder.Name, pathname + "\\" + folder.Name, ref list);
            }
        }




















        /// <summary>
        /// 新建线程并执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart thStart = new ThreadStart(Pro);//threadStart委托 
            Thread thread = new Thread(thStart);
            thread.Priority = ThreadPriority.Highest;
            thread.IsBackground = true; //关闭窗体继续执行
            thread.Start();
        }

        public void Pro()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    if (TextBox_Result.InvokeRequired)//不同线程访问了
                        TextBox_Result.Invoke(new Action<RichTextBox, string>(SetTxtValue), TextBox_Result, j.ToString());//跨线程了
                    else//同线程直接赋值
                        TextBox_Result.Text = j.ToString();
                }
            }
        }

        private void SetTxtValue(RichTextBox txt, string value)
        {
            txt.Text = value;
        }
    }
}
