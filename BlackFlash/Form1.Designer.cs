namespace BlackFlash
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFlashed = new System.Windows.Forms.Label();
            this.lblFlashState = new System.Windows.Forms.Label();
            this.txtToggleValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlashed
            // 
            this.lblFlashed.AutoSize = true;
            this.lblFlashed.Location = new System.Drawing.Point(9, 178);
            this.lblFlashed.Name = "lblFlashed";
            this.lblFlashed.Size = new System.Drawing.Size(50, 13);
            this.lblFlashed.TabIndex = 0;
            this.lblFlashed.Text = "Flashed: ";
            // 
            // lblFlashState
            // 
            this.lblFlashState.AutoSize = true;
            this.lblFlashState.Location = new System.Drawing.Point(65, 178);
            this.lblFlashState.Name = "lblFlashState";
            this.lblFlashState.Size = new System.Drawing.Size(0, 13);
            this.lblFlashState.TabIndex = 1;
            // 
            // txtToggleValue
            // 
            this.txtToggleValue.Location = new System.Drawing.Point(96, 143);
            this.txtToggleValue.Name = "txtToggleValue";
            this.txtToggleValue.Size = new System.Drawing.Size(77, 20);
            this.txtToggleValue.TabIndex = 2;
            this.txtToggleValue.Text = "1";
            this.txtToggleValue.TextChanged += new System.EventHandler(this.toggleValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set Value here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToggleValue);
            this.Controls.Add(this.lblFlashState);
            this.Controls.Add(this.lblFlashed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BlackFlash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlashed;
        private System.Windows.Forms.Label lblFlashState;
        private System.Windows.Forms.TextBox txtToggleValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

