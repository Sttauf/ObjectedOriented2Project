namespace FinalProj
{
    partial class BattleWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonDefend = new System.Windows.Forms.Button();
            this.labelOrca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FinalProj.Properties.Resources.Orca;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(394, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProj.Properties.Resources.Penguin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(141, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(653, 164);
            this.listBox1.TabIndex = 4;
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAttack.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.Location = new System.Drawing.Point(257, 360);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(80, 46);
            this.buttonAttack.TabIndex = 5;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonDefend
            // 
            this.buttonDefend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDefend.Enabled = false;
            this.buttonDefend.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefend.Location = new System.Drawing.Point(343, 360);
            this.buttonDefend.Name = "buttonDefend";
            this.buttonDefend.Size = new System.Drawing.Size(80, 46);
            this.buttonDefend.TabIndex = 6;
            this.buttonDefend.Text = "Defend";
            this.buttonDefend.UseVisualStyleBackColor = false;
            this.buttonDefend.Click += new System.EventHandler(this.buttonDefend_Click);
            // 
            // labelOrca
            // 
            this.labelOrca.AutoSize = true;
            this.labelOrca.Location = new System.Drawing.Point(313, 102);
            this.labelOrca.Name = "labelOrca";
            this.labelOrca.Size = new System.Drawing.Size(0, 20);
            this.labelOrca.TabIndex = 7;
            // 
            // BattleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 412);
            this.Controls.Add(this.labelOrca);
            this.Controls.Add(this.buttonDefend);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleWindow";
            this.Text = "BattleWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonDefend;
        private System.Windows.Forms.Label labelOrca;
    }
}