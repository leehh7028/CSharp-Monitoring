namespace SchoolBusMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_SensorStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_BeaconStart = new System.Windows.Forms.Button();
            this.Btn_SensorStop = new System.Windows.Forms.Button();
            this.Btn_BeaconStop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IntervaConfig = new System.Windows.Forms.TextBox();
            this.Btn_IntervalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(83, 278);
            this.textBox1.TabIndex = 1;
            // 
            // Btn_SensorStart
            // 
            this.Btn_SensorStart.Location = new System.Drawing.Point(19, 396);
            this.Btn_SensorStart.Name = "Btn_SensorStart";
            this.Btn_SensorStart.Size = new System.Drawing.Size(154, 37);
            this.Btn_SensorStart.TabIndex = 5;
            this.Btn_SensorStart.Text = "센서 데이터 측정";
            this.Btn_SensorStart.UseVisualStyleBackColor = true;
            this.Btn_SensorStart.Click += new System.EventHandler(this.Btn_SensorStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(341, 278);
            this.textBox2.TabIndex = 1;
            // 
            // Btn_BeaconStart
            // 
            this.Btn_BeaconStart.Location = new System.Drawing.Point(416, 396);
            this.Btn_BeaconStart.Name = "Btn_BeaconStart";
            this.Btn_BeaconStart.Size = new System.Drawing.Size(154, 37);
            this.Btn_BeaconStart.TabIndex = 5;
            this.Btn_BeaconStart.Text = "Beacon 측정";
            this.Btn_BeaconStart.UseVisualStyleBackColor = true;
            this.Btn_BeaconStart.Click += new System.EventHandler(this.Btn_BeaconStart_Click);
            // 
            // Btn_SensorStop
            // 
            this.Btn_SensorStop.Location = new System.Drawing.Point(188, 396);
            this.Btn_SensorStop.Name = "Btn_SensorStop";
            this.Btn_SensorStop.Size = new System.Drawing.Size(154, 37);
            this.Btn_SensorStop.TabIndex = 5;
            this.Btn_SensorStop.Text = "센서 데이터 측정 중단";
            this.Btn_SensorStop.UseVisualStyleBackColor = true;
            this.Btn_SensorStop.Click += new System.EventHandler(this.Btn_SensorStop_Click);
            // 
            // Btn_BeaconStop
            // 
            this.Btn_BeaconStop.Location = new System.Drawing.Point(586, 396);
            this.Btn_BeaconStop.Name = "Btn_BeaconStop";
            this.Btn_BeaconStop.Size = new System.Drawing.Size(154, 37);
            this.Btn_BeaconStop.TabIndex = 5;
            this.Btn_BeaconStop.Text = "Beacon 측정 중단";
            this.Btn_BeaconStop.UseVisualStyleBackColor = true;
            this.Btn_BeaconStop.Click += new System.EventHandler(this.Btn_BeaconStop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(314, 278);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interval";
            // 
            // txt_IntervaConfig
            // 
            this.txt_IntervaConfig.Location = new System.Drawing.Point(78, 17);
            this.txt_IntervaConfig.Name = "txt_IntervaConfig";
            this.txt_IntervaConfig.Size = new System.Drawing.Size(100, 21);
            this.txt_IntervaConfig.TabIndex = 8;
            // 
            // Btn_IntervalButton
            // 
            this.Btn_IntervalButton.Location = new System.Drawing.Point(184, 17);
            this.Btn_IntervalButton.Name = "Btn_IntervalButton";
            this.Btn_IntervalButton.Size = new System.Drawing.Size(75, 23);
            this.Btn_IntervalButton.TabIndex = 9;
            this.Btn_IntervalButton.Text = "설정";
            this.Btn_IntervalButton.UseVisualStyleBackColor = true;
            this.Btn_IntervalButton.Click += new System.EventHandler(this.Btn_IntervalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.Btn_IntervalButton);
            this.Controls.Add(this.txt_IntervaConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_BeaconStop);
            this.Controls.Add(this.Btn_BeaconStart);
            this.Controls.Add(this.Btn_SensorStop);
            this.Controls.Add(this.Btn_SensorStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_SensorStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_BeaconStart;
        private System.Windows.Forms.Button Btn_SensorStop;
        private System.Windows.Forms.Button Btn_BeaconStop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IntervaConfig;
        private System.Windows.Forms.Button Btn_IntervalButton;
    }
}

