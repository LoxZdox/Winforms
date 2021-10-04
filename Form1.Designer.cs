using System.Windows.Forms;
namespace winforms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "I am not the form i am the window, you idiot!";
            button1 = new Button();
            button1.Name = "Happy Button!";
            button1.Text = "I am truly happy!";
            button1.Location = new System.Drawing.Point(20,100);
            button1.Size = new System.Drawing.Size(100, 50);
            this.Controls.Add(button1);
        }
        private Button button1;

        #endregion
    }
}

