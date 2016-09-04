
namespace Roulette_32_Numbers_32_Extractor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.filesCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.extractNumbersButton = new System.Windows.Forms.Button();
			this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.filesTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.skipprocessedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filesfilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainToolStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.selectionToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.statusToolStripStatusLabel,
									this.fileCountToolStripStatusLabel,
									this.filesTextToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 335);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
			this.mainStatusStrip.TabIndex = 1;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripButton,
									this.openToolStripButton,
									this.toolStripSeparator,
									this.helpToolStripButton});
			this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(284, 25);
			this.mainToolStrip.TabIndex = 2;
			this.mainToolStrip.Text = "toolStrip1";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.filesCheckedListBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.extractNumbersButton, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 286);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// filesCheckedListBox
			// 
			this.filesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filesCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filesCheckedListBox.FormattingEnabled = true;
			this.filesCheckedListBox.IntegralHeight = false;
			this.filesCheckedListBox.Location = new System.Drawing.Point(3, 3);
			this.filesCheckedListBox.Name = "filesCheckedListBox";
			this.filesCheckedListBox.Size = new System.Drawing.Size(278, 240);
			this.filesCheckedListBox.TabIndex = 0;
			// 
			// extractNumbersButton
			// 
			this.extractNumbersButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.extractNumbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.extractNumbersButton.Location = new System.Drawing.Point(3, 249);
			this.extractNumbersButton.Name = "extractNumbersButton";
			this.extractNumbersButton.Size = new System.Drawing.Size(278, 34);
			this.extractNumbersButton.TabIndex = 1;
			this.extractNumbersButton.Text = "&Extract numbers";
			this.extractNumbersButton.UseVisualStyleBackColor = true;
			// 
			// statusToolStripStatusLabel
			// 
			this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
			this.statusToolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
			this.statusToolStripStatusLabel.Text = "Status:";
			// 
			// fileCountToolStripStatusLabel
			// 
			this.fileCountToolStripStatusLabel.Name = "fileCountToolStripStatusLabel";
			this.fileCountToolStripStatusLabel.Size = new System.Drawing.Size(41, 17);
			this.fileCountToolStripStatusLabel.Text = "waiting";
			// 
			// filesTextToolStripStatusLabel
			// 
			this.filesTextToolStripStatusLabel.Name = "filesTextToolStripStatusLabel";
			this.filesTextToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
			this.filesTextToolStripStatusLabel.Text = "to process";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.toolStripSeparator2,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// selectionToolStripMenuItem
			// 
			this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.selectallToolStripMenuItem,
									this.deselectAllToolStripMenuItem,
									this.toggleToolStripMenuItem});
			this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
			this.selectionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.selectionToolStripMenuItem.Text = "&Selection";
			// 
			// selectallToolStripMenuItem
			// 
			this.selectallToolStripMenuItem.Name = "selectallToolStripMenuItem";
			this.selectallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectallToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.selectallToolStripMenuItem.Text = "Select &all";
			// 
			// deselectAllToolStripMenuItem
			// 
			this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
			this.deselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.deselectAllToolStripMenuItem.Text = "&Deselect all";
			// 
			// toggleToolStripMenuItem
			// 
			this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
			this.toggleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.toggleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.toggleToolStripMenuItem.Text = "To&ggle";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.skipprocessedFilesToolStripMenuItem,
									this.alwaysOnTopToolStripMenuItem,
									this.filesfilterToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// skipprocessedFilesToolStripMenuItem
			// 
			this.skipprocessedFilesToolStripMenuItem.Checked = true;
			this.skipprocessedFilesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.skipprocessedFilesToolStripMenuItem.Name = "skipprocessedFilesToolStripMenuItem";
			this.skipprocessedFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.skipprocessedFilesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.skipprocessedFilesToolStripMenuItem.Text = "Skip p&rocessed files";
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "Always on t&op";
			// 
			// filesfilterToolStripMenuItem
			// 
			this.filesfilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.txtToolStripMenuItem,
									this.allFilesToolStripMenuItem});
			this.filesfilterToolStripMenuItem.Name = "filesfilterToolStripMenuItem";
			this.filesfilterToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.filesfilterToolStripMenuItem.Text = "Files filter";
			// 
			// txtToolStripMenuItem
			// 
			this.txtToolStripMenuItem.Checked = true;
			this.txtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
			this.txtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.txtToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.txtToolStripMenuItem.Text = "*.txt (&Text files)";
			// 
			// allFilesToolStripMenuItem
			// 
			this.allFilesToolStripMenuItem.Name = "allFilesToolStripMenuItem";
			this.allFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.allFilesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.allFilesToolStripMenuItem.Text = "*.* (&All files)";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "&New";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 357);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.mainToolStrip);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "Roulette Numbers Extractor";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripStatusLabel filesTextToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel fileCountToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filesfilterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem skipprocessedFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectallToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button extractNumbersButton;
		private System.Windows.Forms.CheckedListBox filesCheckedListBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
	}
}
