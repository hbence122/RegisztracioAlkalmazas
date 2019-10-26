namespace RegisztracioAlkalmazas
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
            this.lblnev = new System.Windows.Forms.Label();
            this.lblszul = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtSzul = new System.Windows.Forms.TextBox();
            this.lblHobbi = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.lblNewHobbi = new System.Windows.Forms.Label();
            this.txtNewHobbi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radF = new System.Windows.Forms.RadioButton();
            this.radN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblnev
            // 
            this.lblnev.AutoSize = true;
            this.lblnev.Location = new System.Drawing.Point(13, 13);
            this.lblnev.Name = "lblnev";
            this.lblnev.Size = new System.Drawing.Size(30, 13);
            this.lblnev.TabIndex = 0;
            this.lblnev.Text = "Név:";
            // 
            // lblszul
            // 
            this.lblszul.AutoSize = true;
            this.lblszul.Location = new System.Drawing.Point(13, 39);
            this.lblszul.Name = "lblszul";
            this.lblszul.Size = new System.Drawing.Size(65, 13);
            this.lblszul.TabIndex = 1;
            this.lblszul.Text = "Szül. dátum:";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Location = new System.Drawing.Point(13, 69);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(32, 13);
            this.lblNem.TabIndex = 2;
            this.lblNem.Text = "Nem:";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(115, 13);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 3;
            // 
            // txtSzul
            // 
            this.txtSzul.Location = new System.Drawing.Point(115, 40);
            this.txtSzul.Name = "txtSzul";
            this.txtSzul.Size = new System.Drawing.Size(100, 20);
            this.txtSzul.TabIndex = 4;
            // 
            // lblHobbi
            // 
            this.lblHobbi.AutoSize = true;
            this.lblHobbi.Location = new System.Drawing.Point(291, 13);
            this.lblHobbi.Name = "lblHobbi";
            this.lblHobbi.Size = new System.Drawing.Size(38, 13);
            this.lblHobbi.TabIndex = 7;
            this.lblHobbi.Text = "Hobbi:";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(294, 29);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(120, 95);
            this.list.TabIndex = 8;
            // 
            // lblNewHobbi
            // 
            this.lblNewHobbi.AutoSize = true;
            this.lblNewHobbi.Location = new System.Drawing.Point(214, 182);
            this.lblNewHobbi.Name = "lblNewHobbi";
            this.lblNewHobbi.Size = new System.Drawing.Size(49, 13);
            this.lblNewHobbi.TabIndex = 9;
            this.lblNewHobbi.Text = "Új hobbi:";
            // 
            // txtNewHobbi
            // 
            this.txtNewHobbi.Location = new System.Drawing.Point(294, 174);
            this.txtNewHobbi.Name = "txtNewHobbi";
            this.txtNewHobbi.Size = new System.Drawing.Size(100, 20);
            this.txtNewHobbi.TabIndex = 10;
            this.txtNewHobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewHobbi_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(250, 283);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Betöltés";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(115, 69);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(31, 17);
            this.radF.TabIndex = 14;
            this.radF.TabStop = true;
            this.radF.Text = "F";
            this.radF.UseVisualStyleBackColor = true;
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(153, 69);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(33, 17);
            this.radN.TabIndex = 15;
            this.radN.TabStop = true;
            this.radN.Text = "N";
            this.radN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 319);
            this.Controls.Add(this.radN);
            this.Controls.Add(this.radF);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewHobbi);
            this.Controls.Add(this.lblNewHobbi);
            this.Controls.Add(this.list);
            this.Controls.Add(this.lblHobbi);
            this.Controls.Add(this.txtSzul);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblszul);
            this.Controls.Add(this.lblnev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnev;
        private System.Windows.Forms.Label lblszul;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtSzul;
        private System.Windows.Forms.Label lblHobbi;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label lblNewHobbi;
        private System.Windows.Forms.TextBox txtNewHobbi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.RadioButton radN;
    }
}

