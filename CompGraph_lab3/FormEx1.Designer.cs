namespace CompGraph_lab3
{
    partial class FormEx1
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
            this.pictureBoxFloodingArea = new System.Windows.Forms.PictureBox();
            this.colorDialogEx1 = new System.Windows.Forms.ColorDialog();
            this.button_colorDialogEx1 = new System.Windows.Forms.Button();
            this.pictureBoxCorrectColor = new System.Windows.Forms.PictureBox();
            this.labelCorrectColor = new System.Windows.Forms.Label();
            this.radioButtonSelectedBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectedFlood = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.comboBoxSelectedFile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloodingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrectColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFloodingArea
            // 
            this.pictureBoxFloodingArea.Location = new System.Drawing.Point(34, 47);
            this.pictureBoxFloodingArea.Name = "pictureBoxFloodingArea";
            this.pictureBoxFloodingArea.Size = new System.Drawing.Size(459, 315);
            this.pictureBoxFloodingArea.TabIndex = 0;
            this.pictureBoxFloodingArea.TabStop = false;
            this.pictureBoxFloodingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxFloodingArea_MouseClick);
            // 
            // button_colorDialogEx1
            // 
            this.button_colorDialogEx1.Location = new System.Drawing.Point(734, 47);
            this.button_colorDialogEx1.Name = "button_colorDialogEx1";
            this.button_colorDialogEx1.Size = new System.Drawing.Size(104, 23);
            this.button_colorDialogEx1.TabIndex = 1;
            this.button_colorDialogEx1.Text = "Выбрать цвет";
            this.button_colorDialogEx1.UseVisualStyleBackColor = true;
            this.button_colorDialogEx1.Click += new System.EventHandler(this.Button_colorDialogEx1_Click);
            // 
            // pictureBoxCorrectColor
            // 
            this.pictureBoxCorrectColor.Location = new System.Drawing.Point(689, 47);
            this.pictureBoxCorrectColor.Name = "pictureBoxCorrectColor";
            this.pictureBoxCorrectColor.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxCorrectColor.TabIndex = 2;
            this.pictureBoxCorrectColor.TabStop = false;
            // 
            // labelCorrectColor
            // 
            this.labelCorrectColor.AutoSize = true;
            this.labelCorrectColor.Location = new System.Drawing.Point(582, 52);
            this.labelCorrectColor.Name = "labelCorrectColor";
            this.labelCorrectColor.Size = new System.Drawing.Size(101, 13);
            this.labelCorrectColor.TabIndex = 3;
            this.labelCorrectColor.Text = "Выбранный цвет - ";
            // 
            // radioButtonSelectedBrush
            // 
            this.radioButtonSelectedBrush.AutoSize = true;
            this.radioButtonSelectedBrush.Checked = true;
            this.radioButtonSelectedBrush.Location = new System.Drawing.Point(604, 99);
            this.radioButtonSelectedBrush.Name = "radioButtonSelectedBrush";
            this.radioButtonSelectedBrush.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSelectedBrush.TabIndex = 4;
            this.radioButtonSelectedBrush.TabStop = true;
            this.radioButtonSelectedBrush.Text = "Кисть";
            this.radioButtonSelectedBrush.UseVisualStyleBackColor = true;
            this.radioButtonSelectedBrush.EnabledChanged += new System.EventHandler(this.RadioButtonSelectedBrush_EnabledChanged);
            // 
            // radioButtonSelectedFlood
            // 
            this.radioButtonSelectedFlood.AutoSize = true;
            this.radioButtonSelectedFlood.Location = new System.Drawing.Point(604, 123);
            this.radioButtonSelectedFlood.Name = "radioButtonSelectedFlood";
            this.radioButtonSelectedFlood.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSelectedFlood.TabIndex = 5;
            this.radioButtonSelectedFlood.TabStop = true;
            this.radioButtonSelectedFlood.Text = "Заливка";
            this.radioButtonSelectedFlood.UseVisualStyleBackColor = true;
            this.radioButtonSelectedFlood.EnabledChanged += new System.EventHandler(this.RadioButtonSelected_EnabledChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(734, 217);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(104, 23);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // comboBoxSelectedFile
            // 
            this.comboBoxSelectedFile.FormattingEnabled = true;
            this.comboBoxSelectedFile.Items.AddRange(new object[] {
            "нет"});
            this.comboBoxSelectedFile.Location = new System.Drawing.Point(604, 217);
            this.comboBoxSelectedFile.Name = "comboBoxSelectedFile";
            this.comboBoxSelectedFile.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectedFile.TabIndex = 7;
            this.comboBoxSelectedFile.Text = "нет";
            this.comboBoxSelectedFile.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedFile_SelectedIndexChanged);
            // 
            // FormEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 507);
            this.Controls.Add(this.comboBoxSelectedFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.radioButtonSelectedFlood);
            this.Controls.Add(this.radioButtonSelectedBrush);
            this.Controls.Add(this.labelCorrectColor);
            this.Controls.Add(this.pictureBoxCorrectColor);
            this.Controls.Add(this.button_colorDialogEx1);
            this.Controls.Add(this.pictureBoxFloodingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEx1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompGraph_lab3.Ex1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEx1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloodingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrectColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFloodingArea;
        private System.Windows.Forms.ColorDialog colorDialogEx1;
        private System.Windows.Forms.Button button_colorDialogEx1;
        private System.Windows.Forms.PictureBox pictureBoxCorrectColor;
        private System.Windows.Forms.Label labelCorrectColor;
        private System.Windows.Forms.RadioButton radioButtonSelectedBrush;
        private System.Windows.Forms.RadioButton radioButtonSelectedFlood;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ComboBox comboBoxSelectedFile;
    }
}