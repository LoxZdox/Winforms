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
            this.BackgroundImage = System.Drawing.Image.FromFile(@"src/background.jpg");
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button1.Name = "Adding Button";
            button2.Name = "Editing Button";
            button3.Name = "Deleting Button";
            button1.Text = "Add a new do to do.";
            button2.Text = "Edit do";
            button3.Text = "Delete do";
            button1.Location = new System.Drawing.Point(20,20);
            button2.Location = new System.Drawing.Point(20, 90);
            button3.Location = new System.Drawing.Point(20, 160);
            button1.Size = new System.Drawing.Size(200, 50);
            button2.Size = new System.Drawing.Size(200, 50);
            button3.Size = new System.Drawing.Size(200, 50);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
        }
        private Button button1;
        private Button button2;
        private Button button3;

        #endregion
    }
}

