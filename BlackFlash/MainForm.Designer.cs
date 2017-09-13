namespace BlackFlash
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFlashed = new System.Windows.Forms.Label();
            this.lblFlashState = new System.Windows.Forms.Label();
            this.txtToggleValue = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSetValue = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.lblCurrentValueText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlashed
            // 
            this.lblFlashed.AutoSize = true;
            this.lblFlashed.Location = new System.Drawing.Point(12, 184);
            this.lblFlashed.Name = "lblFlashed";
            this.lblFlashed.Size = new System.Drawing.Size(50, 13);
            this.lblFlashed.TabIndex = 0;
            this.lblFlashed.Text = "Flashed: ";
            // 
            // lblFlashState
            // 
            this.lblFlashState.AutoSize = true;
            this.lblFlashState.Location = new System.Drawing.Point(62, 184);
            this.lblFlashState.Name = "lblFlashState";
            this.lblFlashState.Size = new System.Drawing.Size(0, 13);
            this.lblFlashState.TabIndex = 1;
            // 
            // txtToggleValue
            // 
            this.txtToggleValue.Location = new System.Drawing.Point(96, 143);
            this.txtToggleValue.Name = "txtToggleValue";
            this.txtToggleValue.Size = new System.Drawing.Size(131, 20);
            this.txtToggleValue.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(278, 117);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblSetValue
            // 
            this.lblSetValue.AutoSize = true;
            this.lblSetValue.Location = new System.Drawing.Point(12, 147);
            this.lblSetValue.Name = "lblSetValue";
            this.lblSetValue.Size = new System.Drawing.Size(79, 13);
            this.lblSetValue.TabIndex = 4;
            this.lblSetValue.Text = "Set value here:";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(233, 143);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(64, 20);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(93, 166);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentValue.TabIndex = 6;
            // 
            // lblCurrentValueText
            // 
            this.lblCurrentValueText.AutoSize = true;
            this.lblCurrentValueText.Location = new System.Drawing.Point(12, 166);
            this.lblCurrentValueText.Name = "lblCurrentValueText";
            this.lblCurrentValueText.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentValueText.TabIndex = 7;
            this.lblCurrentValueText.Text = "Current value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 206);
            this.Controls.Add(this.lblCurrentValueText);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblSetValue);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtToggleValue);
            this.Controls.Add(this.lblFlashState);
            this.Controls.Add(this.lblFlashed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "BlackFlash";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlashed;
        private System.Windows.Forms.Label lblFlashState;
        private System.Windows.Forms.TextBox txtToggleValue;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSetValue;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label lblCurrentValueText;
    }
}

