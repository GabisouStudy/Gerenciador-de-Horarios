namespace GerenciadorDeHorarios
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
            this.dragBox1 = new DragBox.DragBox();
            this.dragLabel1 = new DragBox.DragLabel();
            this.SuspendLayout();
            // 
            // dragBox1
            // 
            this.dragBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dragBox1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dragBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dragBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dragBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dragBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dragBox1.ForeColor = System.Drawing.Color.White;
            this.dragBox1.Location = new System.Drawing.Point(298, 122);
            this.dragBox1.Name = "dragBox1";
            this.dragBox1.Size = new System.Drawing.Size(113, 42);
            this.dragBox1.TabIndex = 0;
            this.dragBox1.UseVisualStyleBackColor = false;
            // 
            // dragLabel1
            // 
            this.dragLabel1.AutoSize = true;
            this.dragLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dragLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel1.LastLocation = new System.Drawing.Point(0, 0);
            this.dragLabel1.LinkedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.dragLabel1.Location = new System.Drawing.Point(416, 247);
            this.dragLabel1.Name = "dragLabel1";
            this.dragLabel1.NormalColor = System.Drawing.Color.Empty;
            this.dragLabel1.Size = new System.Drawing.Size(104, 25);
            this.dragLabel1.TabIndex = 1;
            this.dragLabel1.Text = "Me Arraste";
            this.dragLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dragLabel1);
            this.Controls.Add(this.dragBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Horários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DragBox.DragBox dragBox1;
        private DragBox.DragLabel dragLabel1;
    }
}

