using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace VirtualSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_SelectComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        #region 初始化属性
        ///<summary>
        ///实例化串口资源类
        ///</summary>
        private readonly SerialPort serialPort = new SerialPort();
        ///<summary>
        ///波特率数值范围
        ///</summary>
        private readonly List<string> baudList = new List<string>()
        {
            "300", "1200", "2400", "4800", "9600", "19200"
           //"600","1200", "2400", "4800", "9600","14400", "19200", "28800","38400", "43000", "57600",
           //"76800","115200","128000","230400","256000","460800","921600","1382400","自定义"
        };
        ///<summary>
        ///停止位
        /// </summary>
        private readonly List<string> stopList = new List<string> { "1", "1.5", "2" };
        ///<summary>
        ///数据位
        /// </summary>
        private readonly List<string> dataList =new List<string> { "5", "6", "7", "8" };
        /// <summary>
        /// 校验位
        /// </summary>
        private readonly List<string> checkList = new List<string>() { "NONE", "ODD", "EVEN", "MARK", "SPACE" };
        /// <summary>
        /// 数据显示
        /// </summary>
        private readonly List<string> showList = new List<string>() { "16进制(HEX)", "字符显示(ASCII)" };
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //串口选择
            InitPorts();
            //波特率
            InitBaud();
            //停止位
            InitStop();
            //数据位
            InitData();
            //校验位
            InitCheck();
            //初始化数据显示
            InitDataShow();
            //实例化串口控件
            InitSerialPort();
        }

        #region 初始化
        ///<summary>
        ///初始化串口控件
        /// </summary>       
        public void InitSerialPort()
        {
            serialPort.DataReceived += Sp1_DataReceived;
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            serialPort.ReadTimeout = 1000;
            serialPort.Close();
        }
        private void Sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            //异步委托一个线程，不然接收数据时会出现数据线程错误
            this.Invoke((EventHandler)(delegate
            {
                var showText = this.cb_DataShow.Text;
                if (serialPort.IsOpen)
                {
                    try
                    {
                        byte[] receivedData = new byte[serialPort.BytesToRead];//创建接收数据数组
                        serialPort.Read(receivedData, 0, receivedData.Length);//读取数据
                        var content = string.Empty;
                        //显示形式
                        switch (showText)
                        {
                            case "16进制(HEX)":
                                for (int i = 0; i < receivedData.Length; i++)
                                {
                                    //ToString("X2") 为C#中的字符串格式控制符
                                    //X为     十六进制
                                    //2为 每次都是两位数
                                    content += (receivedData[i].ToString("X2") + " ");
                                }
                                break;
                            case "字符显示(ASCII)":
                                content = Encoding.GetEncoding("GB2312").GetString(receivedData);//防止乱码
                                break;
                        }
                        //接收文本框
                        this.txt_Received.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}：{content} \r\n");
                        //"yyyy-MM-dd hh:mm:ss:ffff"
                        serialPort.DiscardInBuffer();//丢弃缓存区数据
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("请打开串口", "Error");
                }
            }));
        }
        ///<summary>
        ///扫描可用串口，初始化串口选择
        /// </summary>
        public void InitPorts()
        {
            this.cb_SelectComPort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_SelectComPort.Items.Clear();
            var comPostList = SerialPort.GetPortNames().ToList();
            if(comPostList != null && comPostList.Any())
            {
                comPostList = comPostList.OrderBy(x => x).ToList();
                foreach(var item in comPostList)
                {
                    this.cb_SelectComPort.Items.Add(item);
                }
                this.cb_SelectComPort.Enabled = true;
            }
            else
            {
                MessageBox.Show("未找到串口！","Error");
            }
        }
        ///<summary>
        ///初始化校验位
        /// </summary>
        public void InitCheck()
        {
            this.cb_CheckSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(var item in checkList)
            {
                this.cb_CheckSelect.Items.Add(item);
            }
            this.cb_CheckSelect.SelectedItem = "NONE";
        }
        /// <summary>
        /// 初始化数据位
        /// </summary>
        public void InitData()
        {
            this.cb_DataSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in dataList)
            {
                this.cb_DataSelect.Items.Add(item);
            }
            this.cb_DataSelect.SelectedItem = "8";
        }
        /// <summary>
        /// 初始化停止位
        /// </summary>
        public void InitStop()
        {
            this.cb_StopSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in stopList)
            {
                this.cb_StopSelect.Items.Add(item);
            }
            this.cb_StopSelect.SelectedItem = "1";
        }
        /// <summary>
        /// 初始化波特率
        /// </summary>
        public void InitBaud()
        {
            this.cb_baudSelect.DropDownStyle = ComboBoxStyle.DropDownList;//不可手动输入
            foreach (var item in baudList)
            {
                this.cb_baudSelect.Items.Add(item);
            }
            this.cb_baudSelect.SelectedItem = "9600";
        }
        /// <summary>
        /// 初始化数据显示
        /// </summary>
        public void InitDataShow()
        {
            this.cb_DataShow.DropDownStyle = ComboBoxStyle.DropDownList;//不可手动输入
            foreach (var item in showList)
            {
                this.cb_DataShow.Items.Add(item);
            }
            this.cb_DataShow.SelectedItem = "字符显示(ASCII)";
        }
        #endregion

        #region 设置串口
        ///<summary>
        ///设置串口信息
        /// </summary>
        private void SetSerialPort()
        {
            string strBuadRate = this.cb_baudSelect.Text.Trim();
            string strDataRate = this.cb_DataSelect.Text.Trim();
            string strCheckRate = this.cb_CheckSelect.Text.Trim();
            string strPortRate = this.cb_SelectComPort.Text.Trim();
            string strStopRate = this.cb_StopSelect.Text.Trim();
            int IBaudBits = Convert.ToInt32(strBuadRate);
            int IDataBits = Convert.ToInt32(strDataRate);
            serialPort.PortName = strPortRate;//设置串口号
            serialPort.BaudRate = IBaudBits;//设置波特率
            serialPort.DataBits = IDataBits;//设置数据位
            serialPort.Encoding = Encoding.UTF8;
            //设置校验位
            switch (strCheckRate)
            {
                case "NONE":
                    serialPort.Parity = Parity.None;
                    break;
                case "ODD":
                    serialPort.Parity = Parity.Odd;
                    break;
                case "EVEN":
                    serialPort.Parity = Parity.Even;
                    break;
                case "MARK":
                    serialPort.Parity = Parity.Mark;
                    break;
                case "SPACE":
                    serialPort.Parity = Parity.Space;
                    break;
                default:
                    serialPort.Parity = Parity.None;
                    break;
            }
            //设置停止位
            switch (strStopRate)
            {
                case "1":
                    serialPort.StopBits = StopBits.One;
                    break;
                case "1.5":
                    serialPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort.StopBits = StopBits.Two;
                    break;
                default:
                    serialPort.StopBits = StopBits.One;
                    break;
            }
            serialPort.ReadTimeout = 5000;//读取超时时间5s
        }
        #endregion

        #region 波特率选择
        /// <summary>
        /// 波特率选择,自定义时允许输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_baudSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cb_baudSelect.SelectedItem?.ToString() == "自定义")
            {
                this.cb_baudSelect.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                this.cb_baudSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        #endregion

        #region 打开串口

        private void btn_OpenOrrEndCom_Click(object sender, EventArgs e)
        {
            //串口是否打开
            if (!serialPort.IsOpen)
            {
                try
                {
                    this.btn_OpenOrrEndCom.Text = "关闭串口";
                    //如果打开状态，则先关闭一下
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    //设置串口
                    SetSerialPort();
                    //打开串口后不允许更改
                    this.cb_baudSelect.Enabled = false;
                    this.cb_CheckSelect.Enabled = false;
                    this.cb_SelectComPort.Enabled = false;
                    this.cb_StopSelect.Enabled = false;
                    this.cb_DataSelect.Enabled = false;
                    //打开
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开串口失败：" + ex.Message);
                    throw;
                }
            }
            else
            {
                this.cb_baudSelect.Enabled = true;
                this.cb_CheckSelect.Enabled = true;
                this.cb_SelectComPort.Enabled = true;
                this.cb_StopSelect.Enabled = true;
                this.cb_DataSelect.Enabled = true;
                this.btn_OpenOrrEndCom.Text = "打开串口";
                serialPort.Close();//关闭
            }
        }
        #endregion

        /// <summary>
        /// 检测串口
        /// </summary>
        private void btn_CheckPort_Click(object sender, EventArgs e)
        {
            this.cb_SelectComPort.Items.Clear();//清除原有串口选择数据
            var comPostList = System.IO.Ports.SerialPort.GetPortNames().ToList();//读取串口
            if (comPostList != null && comPostList.Any())
            {
                comPostList = comPostList.OrderBy(x => x).ToList();
                foreach (var item in comPostList)
                {
                    this.cb_SelectComPort.Items.Add(item);
                }
                this.cb_SelectComPort.Text = comPostList.FirstOrDefault();//默认选择第一个串口
            }
            else
            {
                MessageBox.Show("本机未找到串口！！！", "Error");
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    byte[] sendData = null;
                    string send = this.txt_Send.Text.Trim();
                    var showText = this.cb_DataShow.Text;
                    //按照指定编码将string编程字节数组
                    byte[] b = Encoding.GetEncoding("GBK").GetBytes(send);
                    if (showText == "16进制(HEX)")
                    {
                        string result = string.Empty;
                        //逐字节变为16进制字符
                        for (int i = 0; i < b.Length; i++)
                        {
                            result += Convert.ToString(b[i], 16).ToUpper() + " ";
                        }
                        sendData = Encoding.GetEncoding("GBK").GetBytes(result);
                    }
                    else
                    {
                        sendData = b;
                    }
                    serialPort.Write(sendData, 0, sendData.Length);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("发送失败：" + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("请先打开串口", "Error");
            }

        }


    }
}
