namespace WBFSManager.Controls.DiscDataBlock
{
	partial class DiscDataBlock
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscDataBlock));
			this.ControlContainer = new Telerik.WinControls.UI.RadPanel();
			this.QRCode = new C1.Win.C1BarCode.C1QRCode();
			this.GameTitleLabel = new Telerik.WinControls.UI.RadLabel();
			this.GameIDLabel = new Telerik.WinControls.UI.RadLabel();
			this.FileSystemLabel = new Telerik.WinControls.UI.RadLabel();
			this.SizeLabel = new Telerik.WinControls.UI.RadLabel();
			((System.ComponentModel.ISupportInitialize)(this.ControlContainer)).BeginInit();
			this.ControlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GameTitleLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GameIDLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FileSystemLabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeLabel)).BeginInit();
			this.SuspendLayout();
			// 
			// ControlContainer
			// 
			this.ControlContainer.Controls.Add(this.SizeLabel);
			this.ControlContainer.Controls.Add(this.FileSystemLabel);
			this.ControlContainer.Controls.Add(this.GameIDLabel);
			this.ControlContainer.Controls.Add(this.GameTitleLabel);
			this.ControlContainer.Controls.Add(this.QRCode);
			resources.ApplyResources(this.ControlContainer, "ControlContainer");
			this.ControlContainer.Name = "ControlContainer";
			// 
			// 
			// 
			this.ControlContainer.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radPanel1.RootElement.Alignment")));
			this.ControlContainer.RootElement.AngleTransform = ((float)(resources.GetObject("radPanel1.RootElement.AngleTransform")));
			this.ControlContainer.RootElement.FlipText = ((bool)(resources.GetObject("radPanel1.RootElement.FlipText")));
			this.ControlContainer.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radPanel1.RootElement.Margin")));
			this.ControlContainer.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radPanel1.RootElement.Padding")));
			this.ControlContainer.RootElement.Shape = null;
			this.ControlContainer.RootElement.Text = resources.GetString("radPanel1.RootElement.Text");
			this.ControlContainer.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radPanel1.RootElement.TextOrientation")));
			this.ControlContainer.ThemeName = "Windows7";
			this.ControlContainer.UseWaitCursor = true;
			((Telerik.WinControls.UI.RadPanelElement)(this.ControlContainer.GetChildAt(0))).Text = resources.GetString("resource.Text");
			((Telerik.WinControls.UI.RadPanelElement)(this.ControlContainer.GetChildAt(0))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding")));
			((Telerik.WinControls.UI.RadPanelElement)(this.ControlContainer.GetChildAt(0))).Shape = null;
			// 
			// QRCode
			// 
			resources.ApplyResources(this.QRCode, "QRCode");
			this.QRCode.Name = "QRCode";
			this.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.QRCode.SymbolSize = 2;
			this.QRCode.UseWaitCursor = true;
			// 
			// GameTitleLabel
			// 
			resources.ApplyResources(this.GameTitleLabel, "GameTitleLabel");
			this.GameTitleLabel.Name = "GameTitleLabel";
			// 
			// 
			// 
			this.GameTitleLabel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radLabel1.RootElement.Alignment")));
			this.GameTitleLabel.RootElement.AngleTransform = ((float)(resources.GetObject("radLabel1.RootElement.AngleTransform")));
			this.GameTitleLabel.RootElement.FlipText = ((bool)(resources.GetObject("radLabel1.RootElement.FlipText")));
			this.GameTitleLabel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel1.RootElement.Margin")));
			this.GameTitleLabel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel1.RootElement.Padding")));
			this.GameTitleLabel.RootElement.Text = resources.GetString("radLabel1.RootElement.Text");
			this.GameTitleLabel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radLabel1.RootElement.TextOrientation")));
			this.GameTitleLabel.UseWaitCursor = true;
			// 
			// GameIDLabel
			// 
			resources.ApplyResources(this.GameIDLabel, "GameIDLabel");
			this.GameIDLabel.Name = "GameIDLabel";
			// 
			// 
			// 
			this.GameIDLabel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radLabel2.RootElement.Alignment")));
			this.GameIDLabel.RootElement.AngleTransform = ((float)(resources.GetObject("radLabel2.RootElement.AngleTransform")));
			this.GameIDLabel.RootElement.FlipText = ((bool)(resources.GetObject("radLabel2.RootElement.FlipText")));
			this.GameIDLabel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel2.RootElement.Margin")));
			this.GameIDLabel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel2.RootElement.Padding")));
			this.GameIDLabel.RootElement.Text = resources.GetString("radLabel2.RootElement.Text");
			this.GameIDLabel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radLabel2.RootElement.TextOrientation")));
			this.GameIDLabel.UseWaitCursor = true;
			// 
			// FileSystemLabel
			// 
			resources.ApplyResources(this.FileSystemLabel, "FileSystemLabel");
			this.FileSystemLabel.Name = "FileSystemLabel";
			// 
			// 
			// 
			this.FileSystemLabel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radLabel3.RootElement.Alignment")));
			this.FileSystemLabel.RootElement.AngleTransform = ((float)(resources.GetObject("radLabel3.RootElement.AngleTransform")));
			this.FileSystemLabel.RootElement.FlipText = ((bool)(resources.GetObject("radLabel3.RootElement.FlipText")));
			this.FileSystemLabel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel3.RootElement.Margin")));
			this.FileSystemLabel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel3.RootElement.Padding")));
			this.FileSystemLabel.RootElement.Text = resources.GetString("radLabel3.RootElement.Text");
			this.FileSystemLabel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radLabel3.RootElement.TextOrientation")));
			this.FileSystemLabel.UseWaitCursor = true;
			// 
			// SizeLabel
			// 
			resources.ApplyResources(this.SizeLabel, "SizeLabel");
			this.SizeLabel.Name = "SizeLabel";
			// 
			// 
			// 
			this.SizeLabel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("radLabel4.RootElement.Alignment")));
			this.SizeLabel.RootElement.AngleTransform = ((float)(resources.GetObject("radLabel4.RootElement.AngleTransform")));
			this.SizeLabel.RootElement.FlipText = ((bool)(resources.GetObject("radLabel4.RootElement.FlipText")));
			this.SizeLabel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel4.RootElement.Margin")));
			this.SizeLabel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("radLabel4.RootElement.Padding")));
			this.SizeLabel.RootElement.Text = resources.GetString("radLabel4.RootElement.Text");
			this.SizeLabel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("radLabel4.RootElement.TextOrientation")));
			this.SizeLabel.UseWaitCursor = true;
			// 
			// DiscDataBlock
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.ControlContainer);
			this.DoubleBuffered = true;
			this.Name = "DiscDataBlock";
			((System.ComponentModel.ISupportInitialize)(this.ControlContainer)).EndInit();
			this.ControlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GameTitleLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GameIDLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FileSystemLabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeLabel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadPanel ControlContainer;
		private Telerik.WinControls.UI.RadLabel SizeLabel;
		private Telerik.WinControls.UI.RadLabel FileSystemLabel;
		private Telerik.WinControls.UI.RadLabel GameIDLabel;
		private Telerik.WinControls.UI.RadLabel GameTitleLabel;
		public C1.Win.C1BarCode.C1QRCode QRCode;


	}
}
