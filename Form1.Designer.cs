namespace Laba15_V4 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnChooseColor = new Button();
            btnChooseFonts = new Button();
            btnChooseFile = new Button();
            btnChooseFolder = new Button();
            panelChooseColor = new Panel();
            txtChooseFont = new TextBox();
            txtChoseFile = new TextBox();
            txtChooseFolder = new TextBox();
            SuspendLayout();
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(137, 87);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(240, 70);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Выбор цвета";
            btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // btnChooseFonts
            // 
            btnChooseFonts.Location = new Point(137, 190);
            btnChooseFonts.Name = "btnChooseFonts";
            btnChooseFonts.Size = new Size(240, 70);
            btnChooseFonts.TabIndex = 1;
            btnChooseFonts.Text = "Выбор шрифта";
            btnChooseFonts.UseVisualStyleBackColor = true;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(137, 329);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(240, 70);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Выбор файла";
            btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(137, 458);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(240, 70);
            btnChooseFolder.TabIndex = 3;
            btnChooseFolder.Text = "Выбор каталога";
            btnChooseFolder.UseVisualStyleBackColor = true;
            // 
            // panelChooseColor
            // 
            panelChooseColor.Location = new Point(430, 87);
            panelChooseColor.Name = "panelChooseColor";
            panelChooseColor.Size = new Size(600, 70);
            panelChooseColor.TabIndex = 4;
            // 
            // txtChooseFont
            // 
            txtChooseFont.Location = new Point(430, 190);
            txtChooseFont.Name = "txtChooseFont";
            txtChooseFont.Size = new Size(600, 39);
            txtChooseFont.TabIndex = 5;
            // 
            // txtChoseFile
            // 
            txtChoseFile.Location = new Point(430, 329);
            txtChoseFile.Name = "txtChoseFile";
            txtChoseFile.Size = new Size(600, 39);
            txtChoseFile.TabIndex = 6;
            // 
            // txtChooseFolder
            // 
            txtChooseFolder.Location = new Point(430, 458);
            txtChooseFolder.Name = "txtChooseFolder";
            txtChooseFolder.Size = new Size(600, 39);
            txtChooseFolder.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 662);
            Controls.Add(txtChooseFolder);
            Controls.Add(txtChoseFile);
            Controls.Add(txtChooseFont);
            Controls.Add(panelChooseColor);
            Controls.Add(btnChooseFolder);
            Controls.Add(btnChooseFile);
            Controls.Add(btnChooseFonts);
            Controls.Add(btnChooseColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseColor;
        private Button btnChooseFonts;
        private Button btnChooseFile;
        private Button btnChooseFolder;
        private Panel panelChooseColor;
        private TextBox txtChooseFont;
        private TextBox txtChoseFile;
        private TextBox txtChooseFolder;
    }
}
