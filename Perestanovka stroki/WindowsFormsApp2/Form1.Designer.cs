namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label_string = new System.Windows.Forms.Label();
            this.Text_setence = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.Text_start = new System.Windows.Forms.TextBox();
            this.label_end = new System.Windows.Forms.Label();
            this.Text_end = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.Text_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_errors = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_string
            // 
            this.label_string.AutoSize = true;
            this.label_string.Location = new System.Drawing.Point(18, 30);
            this.label_string.Name = "label_string";
            this.label_string.Size = new System.Drawing.Size(89, 13);
            this.label_string.TabIndex = 0;
            this.label_string.Text = "Введите строку:";
            // 
            // Text_setence
            // 
            this.Text_setence.Location = new System.Drawing.Point(21, 58);
            this.Text_setence.Name = "Text_setence";
            this.Text_setence.Size = new System.Drawing.Size(478, 20);
            this.Text_setence.TabIndex = 1;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(18, 104);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(189, 13);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Переставить слова в конец строки:";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(18, 131);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(109, 13);
            this.label_start.TabIndex = 3;
            this.label_start.Text = "Начальная граница:";
            // 
            // Text_start
            // 
            this.Text_start.Location = new System.Drawing.Point(21, 147);
            this.Text_start.Name = "Text_start";
            this.Text_start.Size = new System.Drawing.Size(106, 20);
            this.Text_start.TabIndex = 4;
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(187, 131);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(102, 13);
            this.label_end.TabIndex = 5;
            this.label_end.Text = "Конечная граница:";
            // 
            // Text_end
            // 
            this.Text_end.Location = new System.Drawing.Point(190, 147);
            this.Text_end.Name = "Text_end";
            this.Text_end.Size = new System.Drawing.Size(106, 20);
            this.Text_end.TabIndex = 6;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(18, 182);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(62, 13);
            this.label_res.TabIndex = 7;
            this.label_res.Text = "Результат:";
            // 
            // Text_result
            // 
            this.Text_result.Location = new System.Drawing.Point(21, 198);
            this.Text_result.Name = "Text_result";
            this.Text_result.Size = new System.Drawing.Size(478, 20);
            this.Text_result.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ошибки:";
            // 
            // Text_errors
            // 
            this.Text_errors.Location = new System.Drawing.Point(21, 263);
            this.Text_errors.Multiline = true;
            this.Text_errors.Name = "Text_errors";
            this.Text_errors.Size = new System.Drawing.Size(478, 73);
            this.Text_errors.TabIndex = 10;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(21, 364);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Выполнить";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 402);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.Text_errors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_result);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.Text_end);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.Text_start);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.Text_setence);
            this.Controls.Add(this.label_string);
            this.Name = "Form1";
            this.Text = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_string;
        private System.Windows.Forms.TextBox Text_setence;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.TextBox Text_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.TextBox Text_end;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.TextBox Text_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox Text_errors;
    }
}

