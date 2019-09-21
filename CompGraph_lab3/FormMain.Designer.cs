namespace CompGraph_lab3
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OpenFormEx1 = new System.Windows.Forms.Button();
            this.button_OpenFormEx2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OpenFormEx1
            // 
            this.button_OpenFormEx1.Location = new System.Drawing.Point(53, 77);
            this.button_OpenFormEx1.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenFormEx1.Name = "button_OpenFormEx1";
            this.button_OpenFormEx1.Size = new System.Drawing.Size(75, 23);
            this.button_OpenFormEx1.TabIndex = 0;
            this.button_OpenFormEx1.Text = "Задание 1";
            this.button_OpenFormEx1.UseVisualStyleBackColor = true;
            this.button_OpenFormEx1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_OpenFormEx2
            // 
            this.button_OpenFormEx2.Location = new System.Drawing.Point(53, 105);
            this.button_OpenFormEx2.Name = "button_OpenFormEx2";
            this.button_OpenFormEx2.Size = new System.Drawing.Size(75, 23);
            this.button_OpenFormEx2.TabIndex = 1;
            this.button_OpenFormEx2.Text = "Задание 2";
            this.button_OpenFormEx2.UseVisualStyleBackColor = true;
            this.button_OpenFormEx2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 212);
            this.Controls.Add(this.button_OpenFormEx2);
            this.Controls.Add(this.button_OpenFormEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompGraph_lab3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenFormEx1;
        private System.Windows.Forms.Button button_OpenFormEx2;
    }
}

