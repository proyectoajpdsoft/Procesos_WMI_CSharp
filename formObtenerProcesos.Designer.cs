namespace ProyectoA_Procesos_WMI
{
    partial class formObtenerProcesosWMI
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
            btObtenerProcesos = new Button();
            txtProcesos = new TextBox();
            SuspendLayout();
            // 
            // btObtenerProcesos
            // 
            btObtenerProcesos.Location = new Point(42, 24);
            btObtenerProcesos.Name = "btObtenerProcesos";
            btObtenerProcesos.Size = new Size(130, 23);
            btObtenerProcesos.TabIndex = 0;
            btObtenerProcesos.Text = "Obtener procesos";
            btObtenerProcesos.UseVisualStyleBackColor = true;
            btObtenerProcesos.Click += btObtenerProcesos_Click;
            // 
            // txtProcesos
            // 
            txtProcesos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProcesos.Location = new Point(42, 53);
            txtProcesos.Multiline = true;
            txtProcesos.Name = "txtProcesos";
            txtProcesos.ScrollBars = ScrollBars.Both;
            txtProcesos.Size = new Size(508, 370);
            txtProcesos.TabIndex = 1;
            // 
            // formObtenerProcesosWMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(txtProcesos);
            Controls.Add(btObtenerProcesos);
            Name = "formObtenerProcesosWMI";
            Text = "ProyectoA  - Obtener Procesos WMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btObtenerProcesos;
        private TextBox txtProcesos;
    }
}