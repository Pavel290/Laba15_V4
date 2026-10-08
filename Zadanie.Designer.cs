namespace Laba15_V4 {
    partial class Zadanie {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnSetX = new Button();
            btnCountElements = new Button();
            btnGetAnswer = new Button();
            txtSetX = new TextBox();
            txtCountElement = new TextBox();
            SuspendLayout();
            // 
            // btnSetX
            // 
            btnSetX.Location = new Point(42, 80);
            btnSetX.Name = "btnSetX";
            btnSetX.Size = new Size(260, 46);
            btnSetX.TabIndex = 0;
            btnSetX.Text = "Задать Х";
            btnSetX.UseVisualStyleBackColor = true;
            btnSetX.Click += btnSetX_Click;
            // 
            // btnCountElements
            // 
            btnCountElements.Location = new Point(42, 177);
            btnCountElements.Name = "btnCountElements";
            btnCountElements.Size = new Size(260, 82);
            btnCountElements.TabIndex = 1;
            btnCountElements.Text = "Кол-во элементов  после равно";
            btnCountElements.UseVisualStyleBackColor = true;
            btnCountElements.Click += btnCountElements_Click;
            // 
            // btnGetAnswer
            // 
            btnGetAnswer.Location = new Point(42, 305);
            btnGetAnswer.Name = "btnGetAnswer";
            btnGetAnswer.Size = new Size(665, 80);
            btnGetAnswer.TabIndex = 2;
            btnGetAnswer.Text = "Узнать ответ";
            btnGetAnswer.UseVisualStyleBackColor = true;
            btnGetAnswer.Click += btnGetAnswer_Click;
            // 
            // txtSetX
            // 
            txtSetX.Location = new Point(346, 87);
            txtSetX.Name = "txtSetX";
            txtSetX.Size = new Size(361, 39);
            txtSetX.TabIndex = 3;
            // 
            // txtCountElement
            // 
            txtCountElement.Location = new Point(346, 199);
            txtCountElement.Name = "txtCountElement";
            txtCountElement.Size = new Size(361, 39);
            txtCountElement.TabIndex = 4;
            // 
            // Zadanie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCountElement);
            Controls.Add(txtSetX);
            Controls.Add(btnGetAnswer);
            Controls.Add(btnCountElements);
            Controls.Add(btnSetX);
            Name = "Zadanie";
            Text = "Zadanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSetX;
        private Button btnCountElements;
        private Button btnGetAnswer;
        private TextBox txtSetX;
        private TextBox txtCountElement;
    }
}