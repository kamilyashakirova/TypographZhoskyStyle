namespace TypographZhoskyStyle
{
    partial class TypographZhoskyStyle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypographZhoskyStyle));
            label1 = new Label();
            label2 = new Label();
            text_txt = new TextBox();
            edit_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(307, 60);
            label1.Name = "label1";
            label1.Size = new Size(311, 48);
            label1.TabIndex = 0;
            label1.Text = "- Это \"Типограф\"?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(259, 108);
            label2.Name = "label2";
            label2.Size = new Size(426, 48);
            label2.TabIndex = 1;
            label2.Text = "— Нет, это «Типографъ»!";
            // 
            // text_txt
            // 
            text_txt.BorderStyle = BorderStyle.FixedSingle;
            text_txt.Font = new Font("Century Gothic", 10.8F);
            text_txt.Location = new Point(115, 194);
            text_txt.Multiline = true;
            text_txt.Name = "text_txt";
            text_txt.PlaceholderText = "Введите текст";
            text_txt.Size = new Size(721, 317);
            text_txt.TabIndex = 2;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.White;
            edit_btn.Font = new Font("Century Gothic", 10.8F);
            edit_btn.Location = new Point(375, 532);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(191, 54);
            edit_btn.TabIndex = 3;
            edit_btn.Text = "Оттипографить";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // TypographZhoskyStyle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(938, 607);
            Controls.Add(edit_btn);
            Controls.Add(text_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TypographZhoskyStyle";
            Text = "Типографъ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_txt;
        private Button edit_btn;
    }
}
