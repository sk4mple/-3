namespace Модуль_3
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            menuStrip1 = new MenuStrip();
            help = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            opentoolStripButton1 = new ToolStripButton();
            formsPlot = new ScottPlot.WinForms.FormsPlot();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(614, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // help
            // 
            help.DropDownItems.AddRange(new ToolStripItem[] { about, помощьToolStripMenuItem });
            help.Name = "help";
            help.Size = new Size(81, 24);
            help.Text = "Справка";
            // 
            // about
            // 
            about.Name = "about";
            about.Size = new Size(224, 26);
            about.Text = "О программе";
            about.Click += about_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { opentoolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(614, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // opentoolStripButton1
            // 
            opentoolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            opentoolStripButton1.Image = (Image)resources.GetObject("opentoolStripButton1.Image");
            opentoolStripButton1.ImageTransparentColor = Color.Magenta;
            opentoolStripButton1.Name = "opentoolStripButton1";
            opentoolStripButton1.Size = new Size(29, 24);
            opentoolStripButton1.Text = "toolStripButton1";
            opentoolStripButton1.ToolTipText = "Открыть файл";
            opentoolStripButton1.Click += opentoolStripButton1_Click;
            // 
            // formsPlot
            // 
            formsPlot.DisplayScale = 1.25F;
            formsPlot.Dock = DockStyle.Fill;
            formsPlot.Location = new Point(0, 55);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(614, 293);
            formsPlot.TabIndex = 2;
            formsPlot.Load += formsPlot_Load;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(224, 26);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 348);
            Controls.Add(formsPlot);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Mainform";
            Text = "Мое второе приложение";
            Load += Mainform_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem help;
        private ToolStripMenuItem about;
        private ToolStrip toolStrip1;
        private ToolStripButton opentoolStripButton1;
        private ScottPlot.WinForms.FormsPlot formsPlot;
        private ToolStripMenuItem помощьToolStripMenuItem;
    }
}
