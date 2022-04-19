
namespace PROJECTPRACTICE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.textapply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textimage = new System.Windows.Forms.Button();
            this.image_load = new System.Windows.Forms.Button();
            this.Xbox = new System.Windows.Forms.TextBox();
            this.Ybox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ybox);
            this.panel1.Controls.Add(this.Xbox);
            this.panel1.Controls.Add(this.imageBox2);
            this.panel1.Controls.Add(this.imageBox1);
            this.panel1.Controls.Add(this.textapply);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textimage);
            this.panel1.Controls.Add(this.image_load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.imageBox2.Location = new System.Drawing.Point(556, 21);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(302, 258);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Visible = false;
            this.imageBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox2_MouseClick);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.imageBox1.Location = new System.Drawing.Point(38, 30);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(280, 249);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // textapply
            // 
            this.textapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapply.Location = new System.Drawing.Point(669, 411);
            this.textapply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textapply.Name = "textapply";
            this.textapply.Size = new System.Drawing.Size(174, 37);
            this.textapply.TabIndex = 5;
            this.textapply.Text = "Apply text";
            this.textapply.UseVisualStyleBackColor = true;
            this.textapply.Visible = false;
            this.textapply.Click += new System.EventHandler(this.textapply_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textimage
            // 
            this.textimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textimage.Location = new System.Drawing.Point(302, 371);
            this.textimage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textimage.Name = "textimage";
            this.textimage.Size = new System.Drawing.Size(224, 40);
            this.textimage.TabIndex = 3;
            this.textimage.Text = "Add text on image:";
            this.textimage.UseVisualStyleBackColor = true;
            this.textimage.Visible = false;
            this.textimage.Click += new System.EventHandler(this.textimage_Click);
            // 
            // image_load
            // 
            this.image_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_load.Location = new System.Drawing.Point(68, 305);
            this.image_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.image_load.Name = "image_load";
            this.image_load.Size = new System.Drawing.Size(154, 40);
            this.image_load.TabIndex = 2;
            this.image_load.Text = "Load Image";
            this.image_load.UseVisualStyleBackColor = true;
            this.image_load.Click += new System.EventHandler(this.image_load_Click);
            // 
            // Xbox
            // 
            this.Xbox.Location = new System.Drawing.Point(426, 91);
            this.Xbox.Name = "Xbox";
            this.Xbox.Size = new System.Drawing.Size(48, 26);
            this.Xbox.TabIndex = 6;
            this.Xbox.Text = "0";
            this.Xbox.Visible = false;
            // 
            // Ybox
            // 
            this.Ybox.AcceptsReturn = true;
            this.Ybox.AcceptsTab = true;
            this.Ybox.Location = new System.Drawing.Point(426, 143);
            this.Ybox.MaxLength = 120;
            this.Ybox.Name = "Ybox";
            this.Ybox.Size = new System.Drawing.Size(48, 26);
            this.Ybox.TabIndex = 7;
            this.Ybox.Text = "0";
            this.Ybox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set Cordinates";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "X:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y:";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button image_load;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button textimage;
        private System.Windows.Forms.Button textapply;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ybox;
        private System.Windows.Forms.TextBox Xbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

