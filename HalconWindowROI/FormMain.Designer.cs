
namespace HalconWindowROI
{
    partial class FormMain
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
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnDrawRect1 = new System.Windows.Forms.Button();
            this.btnDrawRect2 = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 42);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(569, 381);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(569, 381);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(614, 57);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "加载图片";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnDrawRect1
            // 
            this.btnDrawRect1.Location = new System.Drawing.Point(614, 113);
            this.btnDrawRect1.Name = "btnDrawRect1";
            this.btnDrawRect1.Size = new System.Drawing.Size(75, 23);
            this.btnDrawRect1.TabIndex = 2;
            this.btnDrawRect1.Text = "绘制矩形1";
            this.btnDrawRect1.UseVisualStyleBackColor = true;
            this.btnDrawRect1.Click += new System.EventHandler(this.btnDrawRect1_Click);
            // 
            // btnDrawRect2
            // 
            this.btnDrawRect2.Location = new System.Drawing.Point(614, 158);
            this.btnDrawRect2.Name = "btnDrawRect2";
            this.btnDrawRect2.Size = new System.Drawing.Size(75, 23);
            this.btnDrawRect2.TabIndex = 3;
            this.btnDrawRect2.Text = "绘制矩形2";
            this.btnDrawRect2.UseVisualStyleBackColor = true;
            this.btnDrawRect2.Click += new System.EventHandler(this.btnDrawRect2_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(614, 211);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(75, 23);
            this.btnDrawCircle.TabIndex = 4;
            this.btnDrawCircle.Text = "绘制圆形";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.btnDrawRect2);
            this.Controls.Add(this.btnDrawRect1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnDrawRect1;
        private System.Windows.Forms.Button btnDrawRect2;
        private System.Windows.Forms.Button btnDrawCircle;
    }
}

