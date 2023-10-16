
namespace VirtualSerialPort
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_ReceivePanel = new System.Windows.Forms.GroupBox();
            this.txt_Received = new System.Windows.Forms.TextBox();
            this.gb_SendPanel = new System.Windows.Forms.GroupBox();
            this.cb_DataShow = new System.Windows.Forms.ComboBox();
            this.cb_CheckSelect = new System.Windows.Forms.ComboBox();
            this.cb_DataSelect = new System.Windows.Forms.ComboBox();
            this.cb_StopSelect = new System.Windows.Forms.ComboBox();
            this.cb_baudSelect = new System.Windows.Forms.ComboBox();
            this.cb_SelectComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_OpenOrrEndCom = new System.Windows.Forms.Button();
            this.btn_CheckPort = new System.Windows.Forms.Button();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.gb_ReceivePanel.SuspendLayout();
            this.gb_SendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ReceivePanel
            // 
            this.gb_ReceivePanel.Controls.Add(this.txt_Received);
            this.gb_ReceivePanel.Location = new System.Drawing.Point(16, 4);
            this.gb_ReceivePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ReceivePanel.Name = "gb_ReceivePanel";
            this.gb_ReceivePanel.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ReceivePanel.Size = new System.Drawing.Size(977, 302);
            this.gb_ReceivePanel.TabIndex = 0;
            this.gb_ReceivePanel.TabStop = false;
            this.gb_ReceivePanel.Text = "数据接收";
            // 
            // txt_Received
            // 
            this.txt_Received.Location = new System.Drawing.Point(4, 21);
            this.txt_Received.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Received.Multiline = true;
            this.txt_Received.Name = "txt_Received";
            this.txt_Received.ReadOnly = true;
            this.txt_Received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Received.Size = new System.Drawing.Size(960, 273);
            this.txt_Received.TabIndex = 0;
            // 
            // gb_SendPanel
            // 
            this.gb_SendPanel.Controls.Add(this.cb_DataShow);
            this.gb_SendPanel.Controls.Add(this.cb_CheckSelect);
            this.gb_SendPanel.Controls.Add(this.cb_DataSelect);
            this.gb_SendPanel.Controls.Add(this.cb_StopSelect);
            this.gb_SendPanel.Controls.Add(this.cb_baudSelect);
            this.gb_SendPanel.Controls.Add(this.cb_SelectComPort);
            this.gb_SendPanel.Controls.Add(this.label5);
            this.gb_SendPanel.Controls.Add(this.label6);
            this.gb_SendPanel.Controls.Add(this.label3);
            this.gb_SendPanel.Controls.Add(this.label4);
            this.gb_SendPanel.Controls.Add(this.label2);
            this.gb_SendPanel.Controls.Add(this.label1);
            this.gb_SendPanel.Controls.Add(this.btn_Send);
            this.gb_SendPanel.Controls.Add(this.btn_OpenOrrEndCom);
            this.gb_SendPanel.Controls.Add(this.btn_CheckPort);
            this.gb_SendPanel.Controls.Add(this.txt_Send);
            this.gb_SendPanel.Location = new System.Drawing.Point(16, 314);
            this.gb_SendPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gb_SendPanel.Name = "gb_SendPanel";
            this.gb_SendPanel.Padding = new System.Windows.Forms.Padding(4);
            this.gb_SendPanel.Size = new System.Drawing.Size(977, 358);
            this.gb_SendPanel.TabIndex = 1;
            this.gb_SendPanel.TabStop = false;
            this.gb_SendPanel.Text = "数据发送";
            // 
            // cb_DataShow
            // 
            this.cb_DataShow.FormattingEnabled = true;
            this.cb_DataShow.Location = new System.Drawing.Point(112, 266);
            this.cb_DataShow.Margin = new System.Windows.Forms.Padding(4);
            this.cb_DataShow.Name = "cb_DataShow";
            this.cb_DataShow.Size = new System.Drawing.Size(223, 23);
            this.cb_DataShow.TabIndex = 15;
            // 
            // cb_CheckSelect
            // 
            this.cb_CheckSelect.FormattingEnabled = true;
            this.cb_CheckSelect.Location = new System.Drawing.Point(112, 219);
            this.cb_CheckSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cb_CheckSelect.Name = "cb_CheckSelect";
            this.cb_CheckSelect.Size = new System.Drawing.Size(223, 23);
            this.cb_CheckSelect.TabIndex = 14;
            // 
            // cb_DataSelect
            // 
            this.cb_DataSelect.FormattingEnabled = true;
            this.cb_DataSelect.Location = new System.Drawing.Point(112, 164);
            this.cb_DataSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cb_DataSelect.Name = "cb_DataSelect";
            this.cb_DataSelect.Size = new System.Drawing.Size(223, 23);
            this.cb_DataSelect.TabIndex = 13;
            // 
            // cb_StopSelect
            // 
            this.cb_StopSelect.FormattingEnabled = true;
            this.cb_StopSelect.Location = new System.Drawing.Point(112, 116);
            this.cb_StopSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cb_StopSelect.Name = "cb_StopSelect";
            this.cb_StopSelect.Size = new System.Drawing.Size(223, 23);
            this.cb_StopSelect.TabIndex = 12;
            // 
            // cb_baudSelect
            // 
            this.cb_baudSelect.FormattingEnabled = true;
            this.cb_baudSelect.Location = new System.Drawing.Point(112, 72);
            this.cb_baudSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cb_baudSelect.Name = "cb_baudSelect";
            this.cb_baudSelect.Size = new System.Drawing.Size(223, 23);
            this.cb_baudSelect.TabIndex = 11;
            // 
            // cb_SelectComPort
            // 
            this.cb_SelectComPort.FormattingEnabled = true;
            this.cb_SelectComPort.Location = new System.Drawing.Point(112, 25);
            this.cb_SelectComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cb_SelectComPort.Name = "cb_SelectComPort";
            this.cb_SelectComPort.Size = new System.Drawing.Size(223, 23);
            this.cb_SelectComPort.TabIndex = 10;
            this.cb_SelectComPort.SelectedIndexChanged += new System.EventHandler(this.cb_SelectComPort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(23, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = " 显示:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(23, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "校验位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "停止位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = " 串口:";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(843, 305);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(127, 38);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_OpenOrrEndCom
            // 
            this.btn_OpenOrrEndCom.Location = new System.Drawing.Point(209, 305);
            this.btn_OpenOrrEndCom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpenOrrEndCom.Name = "btn_OpenOrrEndCom";
            this.btn_OpenOrrEndCom.Size = new System.Drawing.Size(127, 38);
            this.btn_OpenOrrEndCom.TabIndex = 2;
            this.btn_OpenOrrEndCom.Text = "打开串口";
            this.btn_OpenOrrEndCom.UseVisualStyleBackColor = true;
            this.btn_OpenOrrEndCom.Click += new System.EventHandler(this.btn_OpenOrrEndCom_Click);
            // 
            // btn_CheckPort
            // 
            this.btn_CheckPort.Location = new System.Drawing.Point(47, 305);
            this.btn_CheckPort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckPort.Name = "btn_CheckPort";
            this.btn_CheckPort.Size = new System.Drawing.Size(127, 38);
            this.btn_CheckPort.TabIndex = 1;
            this.btn_CheckPort.Text = "检测串口";
            this.btn_CheckPort.UseVisualStyleBackColor = true;
            this.btn_CheckPort.Click += new System.EventHandler(this.btn_CheckPort_Click);
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(372, 15);
            this.txt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(596, 275);
            this.txt_Send.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.gb_SendPanel);
            this.Controls.Add(this.gb_ReceivePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "虚拟串口通信";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ReceivePanel.ResumeLayout(false);
            this.gb_ReceivePanel.PerformLayout();
            this.gb_SendPanel.ResumeLayout(false);
            this.gb_SendPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ReceivePanel;
        private System.Windows.Forms.TextBox txt_Received;
        private System.Windows.Forms.GroupBox gb_SendPanel;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_OpenOrrEndCom;
        private System.Windows.Forms.Button btn_CheckPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_DataShow;
        private System.Windows.Forms.ComboBox cb_CheckSelect;
        private System.Windows.Forms.ComboBox cb_DataSelect;
        private System.Windows.Forms.ComboBox cb_StopSelect;
        private System.Windows.Forms.ComboBox cb_baudSelect;
        private System.Windows.Forms.ComboBox cb_SelectComPort;
    }
}

