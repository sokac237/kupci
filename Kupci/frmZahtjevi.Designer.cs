namespace Kupci
{
    partial class frmZahtjevi
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
            this.dgKupci = new DevExpress.XtraGrid.GridControl();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatumrod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmjesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobitel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvrijemezah = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colka_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnova = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpostojeca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSvi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKupci
            // 
            this.dgKupci.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.dgKupci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKupci.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.dgKupci.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgKupci.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgKupci.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgKupci.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgKupci.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgKupci.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgKupci.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgKupci.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dgKupci.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.dgKupci.Location = new System.Drawing.Point(12, 12);
            this.dgKupci.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.dgKupci.MainView = this.dgBon;
            this.dgKupci.Name = "dgKupci";
            this.dgKupci.Size = new System.Drawing.Size(830, 421);
            this.dgKupci.TabIndex = 12;
            this.dgKupci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgKupci.DoubleClick += new System.EventHandler(this.dgKupci_DoubleClick);
            // 
            // dgBon
            // 
            this.dgBon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgBon.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgBon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgBon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.Empty.Options.UseBackColor = true;
            this.dgBon.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgBon.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgBon.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgBon.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgBon.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgBon.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgBon.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgBon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgBon.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgBon.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgBon.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgBon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupRow.Options.UseFont = true;
            this.dgBon.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgBon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgBon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgBon.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgBon.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgBon.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.OddRow.Options.UseBackColor = true;
            this.dgBon.Appearance.OddRow.Options.UseForeColor = true;
            this.dgBon.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgBon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgBon.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.Preview.Options.UseBackColor = true;
            this.dgBon.Appearance.Preview.Options.UseForeColor = true;
            this.dgBon.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.Row.Options.UseBackColor = true;
            this.dgBon.Appearance.Row.Options.UseForeColor = true;
            this.dgBon.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgBon.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgBon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgBon.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgBon.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.VertLine.Options.UseBackColor = true;
            this.dgBon.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgBon.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgBon.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgBon.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgBon.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgBon.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgBon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgBon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colime,
            this.colprezime,
            this.colOIB,
            this.coldatumrod,
            this.colmjesto,
            this.coladresa,
            this.coltelefon,
            this.colmobitel,
            this.colsms,
            this.colemail,
            this.colvrijemezah,
            this.gridColumn5,
            this.gridColumn1,
            this.colka_sifra,
            this.colnova,
            this.colpostojeca,
            this.gridColumn4,
            this.colnapomena,
            this.gridColumn2,
            this.gridColumn3,
            this.colSpol});
            this.dgBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgBon.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.dgBon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            this.dgBon.GridControl = this.dgKupci;
            this.dgBon.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.dgBon.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.dgBon.Name = "dgBon";
            this.dgBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgBon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgBon.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.dgBon.OptionsBehavior.Editable = false;
            this.dgBon.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.dgBon.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.dgBon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgBon.OptionsSelection.MultiSelect = true;
            this.dgBon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.dgBon.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.dgBon.OptionsView.ColumnAutoWidth = false;
            this.dgBon.OptionsView.EnableAppearanceEvenRow = true;
            this.dgBon.OptionsView.EnableAppearanceOddRow = true;
            this.dgBon.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.dgBon.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.dgBon.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.dgBon.OptionsView.ShowAutoFilterRow = true;
            this.dgBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgBon.OptionsView.ShowGroupPanel = false;
            this.dgBon.OptionsView.ShowIndicator = false;
            this.dgBon.PaintStyleName = "WindowsXP";
            this.dgBon.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.dgBon.SynchronizeClones = false;
            this.dgBon.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colime
            // 
            this.colime.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colime.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colime.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colime.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colime.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colime.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colime.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colime.Caption = "Ime";
            this.colime.FieldName = "ime";
            this.colime.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colime.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colime.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colime.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colime.Name = "colime";
            this.colime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colime.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colime.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colime.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colime.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colime.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colime.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colime.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colime.Visible = true;
            this.colime.VisibleIndex = 2;
            this.colime.Width = 126;
            // 
            // colprezime
            // 
            this.colprezime.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colprezime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colprezime.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colprezime.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colprezime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colprezime.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colprezime.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colprezime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colprezime.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colprezime.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colprezime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colprezime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colprezime.Caption = "Prezime";
            this.colprezime.FieldName = "prezime";
            this.colprezime.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colprezime.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colprezime.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colprezime.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colprezime.Name = "colprezime";
            this.colprezime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colprezime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colprezime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colprezime.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colprezime.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colprezime.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colprezime.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colprezime.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colprezime.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colprezime.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colprezime.Visible = true;
            this.colprezime.VisibleIndex = 1;
            this.colprezime.Width = 140;
            // 
            // colOIB
            // 
            this.colOIB.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colOIB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colOIB.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colOIB.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colOIB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colOIB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colOIB.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colOIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colOIB.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colOIB.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colOIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colOIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colOIB.Caption = "OIB";
            this.colOIB.FieldName = "OIB";
            this.colOIB.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colOIB.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colOIB.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colOIB.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colOIB.Name = "colOIB";
            this.colOIB.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colOIB.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colOIB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colOIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colOIB.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colOIB.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colOIB.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colOIB.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colOIB.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colOIB.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colOIB.Visible = true;
            this.colOIB.VisibleIndex = 3;
            this.colOIB.Width = 78;
            // 
            // coldatumrod
            // 
            this.coldatumrod.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coldatumrod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coldatumrod.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coldatumrod.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coldatumrod.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coldatumrod.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coldatumrod.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coldatumrod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coldatumrod.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coldatumrod.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coldatumrod.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coldatumrod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coldatumrod.Caption = "Datum rođenja";
            this.coldatumrod.FieldName = "datumrod";
            this.coldatumrod.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.coldatumrod.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.coldatumrod.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.coldatumrod.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.coldatumrod.Name = "coldatumrod";
            this.coldatumrod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.coldatumrod.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.coldatumrod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.coldatumrod.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.coldatumrod.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.coldatumrod.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.coldatumrod.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.coldatumrod.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.coldatumrod.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.coldatumrod.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.coldatumrod.Visible = true;
            this.coldatumrod.VisibleIndex = 4;
            this.coldatumrod.Width = 94;
            // 
            // colmjesto
            // 
            this.colmjesto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colmjesto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colmjesto.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colmjesto.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colmjesto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colmjesto.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colmjesto.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colmjesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colmjesto.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colmjesto.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colmjesto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colmjesto.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colmjesto.Caption = "Mjesto";
            this.colmjesto.FieldName = "mjesto";
            this.colmjesto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colmjesto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colmjesto.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colmjesto.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colmjesto.Name = "colmjesto";
            this.colmjesto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colmjesto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colmjesto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colmjesto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colmjesto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colmjesto.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colmjesto.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colmjesto.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colmjesto.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colmjesto.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colmjesto.Visible = true;
            this.colmjesto.VisibleIndex = 6;
            this.colmjesto.Width = 127;
            // 
            // coladresa
            // 
            this.coladresa.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coladresa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coladresa.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coladresa.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coladresa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coladresa.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coladresa.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coladresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coladresa.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coladresa.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coladresa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coladresa.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coladresa.Caption = "Adresa";
            this.coladresa.FieldName = "adresa";
            this.coladresa.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.coladresa.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.coladresa.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.coladresa.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.coladresa.Name = "coladresa";
            this.coladresa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.coladresa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.coladresa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.coladresa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.coladresa.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.coladresa.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.coladresa.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.coladresa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.coladresa.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.coladresa.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.coladresa.Visible = true;
            this.coladresa.VisibleIndex = 7;
            this.coladresa.Width = 146;
            // 
            // coltelefon
            // 
            this.coltelefon.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coltelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coltelefon.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coltelefon.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coltelefon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coltelefon.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coltelefon.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.coltelefon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.coltelefon.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.coltelefon.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.coltelefon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.coltelefon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.coltelefon.Caption = "Telefon";
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.coltelefon.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.coltelefon.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.coltelefon.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.coltelefon.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.coltelefon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.coltelefon.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.coltelefon.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.coltelefon.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.coltelefon.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.coltelefon.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.coltelefon.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.coltelefon.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 8;
            this.coltelefon.Width = 72;
            // 
            // colmobitel
            // 
            this.colmobitel.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colmobitel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colmobitel.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colmobitel.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colmobitel.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colmobitel.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colmobitel.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colmobitel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colmobitel.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colmobitel.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colmobitel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colmobitel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colmobitel.Caption = "Mobitel";
            this.colmobitel.FieldName = "mobitel";
            this.colmobitel.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colmobitel.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colmobitel.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colmobitel.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colmobitel.Name = "colmobitel";
            this.colmobitel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colmobitel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colmobitel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colmobitel.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colmobitel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colmobitel.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colmobitel.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colmobitel.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colmobitel.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colmobitel.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colmobitel.Visible = true;
            this.colmobitel.VisibleIndex = 9;
            // 
            // colsms
            // 
            this.colsms.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colsms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colsms.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colsms.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colsms.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colsms.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colsms.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colsms.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colsms.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colsms.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colsms.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colsms.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colsms.Caption = "sms";
            this.colsms.FieldName = "sms";
            this.colsms.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colsms.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colsms.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colsms.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colsms.Name = "colsms";
            this.colsms.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colsms.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colsms.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colsms.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colsms.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colsms.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colsms.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colsms.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colsms.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colsms.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colsms.Visible = true;
            this.colsms.VisibleIndex = 10;
            // 
            // colemail
            // 
            this.colemail.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colemail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colemail.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colemail.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colemail.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colemail.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colemail.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colemail.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colemail.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colemail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colemail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colemail.Caption = "email";
            this.colemail.FieldName = "email";
            this.colemail.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colemail.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colemail.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colemail.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colemail.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colemail.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colemail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colemail.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colemail.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colemail.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colemail.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colemail.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colemail.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 11;
            // 
            // colvrijemezah
            // 
            this.colvrijemezah.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvrijemezah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvrijemezah.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvrijemezah.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvrijemezah.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvrijemezah.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvrijemezah.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colvrijemezah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colvrijemezah.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colvrijemezah.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colvrijemezah.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colvrijemezah.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colvrijemezah.Caption = "Vrijeme zahtjeva";
            this.colvrijemezah.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colvrijemezah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvrijemezah.FieldName = "vrijemezah";
            this.colvrijemezah.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colvrijemezah.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colvrijemezah.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colvrijemezah.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colvrijemezah.Name = "colvrijemezah";
            this.colvrijemezah.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colvrijemezah.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colvrijemezah.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colvrijemezah.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colvrijemezah.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colvrijemezah.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colvrijemezah.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colvrijemezah.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colvrijemezah.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colvrijemezah.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colvrijemezah.Visible = true;
            this.colvrijemezah.VisibleIndex = 19;
            this.colvrijemezah.Width = 148;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn5.Caption = "Vrijeme obrade";
            this.gridColumn5.DisplayFormat.FormatString = "dd.MM.yyyy hh:mm:ss";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "vrijemeobrade";
            this.gridColumn5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn5.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn5.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 20;
            this.gridColumn5.Width = 142;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn1.Caption = "Naziv poslovnice";
            this.gridColumn1.FieldName = "po_naziv";
            this.gridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 194;
            // 
            // colka_sifra
            // 
            this.colka_sifra.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colka_sifra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colka_sifra.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colka_sifra.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colka_sifra.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colka_sifra.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colka_sifra.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colka_sifra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colka_sifra.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colka_sifra.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colka_sifra.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colka_sifra.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colka_sifra.Caption = "Status";
            this.colka_sifra.FieldName = "ka_sifra";
            this.colka_sifra.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colka_sifra.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colka_sifra.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colka_sifra.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colka_sifra.Name = "colka_sifra";
            this.colka_sifra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colka_sifra.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colka_sifra.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colka_sifra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colka_sifra.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colka_sifra.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colka_sifra.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colka_sifra.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colka_sifra.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colka_sifra.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colka_sifra.Visible = true;
            this.colka_sifra.VisibleIndex = 5;
            this.colka_sifra.Width = 56;
            // 
            // colnova
            // 
            this.colnova.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colnova.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colnova.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colnova.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colnova.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colnova.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colnova.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colnova.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colnova.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colnova.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colnova.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colnova.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colnova.Caption = "Nova";
            this.colnova.FieldName = "nova";
            this.colnova.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colnova.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colnova.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colnova.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colnova.Name = "colnova";
            this.colnova.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colnova.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colnova.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colnova.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colnova.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colnova.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colnova.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colnova.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colnova.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colnova.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colnova.Visible = true;
            this.colnova.VisibleIndex = 14;
            this.colnova.Width = 58;
            // 
            // colpostojeca
            // 
            this.colpostojeca.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colpostojeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colpostojeca.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colpostojeca.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colpostojeca.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colpostojeca.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colpostojeca.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colpostojeca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colpostojeca.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colpostojeca.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colpostojeca.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colpostojeca.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colpostojeca.Caption = "Postojeća";
            this.colpostojeca.FieldName = "postojeca";
            this.colpostojeca.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colpostojeca.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colpostojeca.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colpostojeca.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colpostojeca.Name = "colpostojeca";
            this.colpostojeca.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colpostojeca.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colpostojeca.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colpostojeca.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colpostojeca.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colpostojeca.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colpostojeca.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colpostojeca.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colpostojeca.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colpostojeca.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colpostojeca.Visible = true;
            this.colpostojeca.VisibleIndex = 15;
            this.colpostojeca.Width = 68;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn4.Caption = "Broj kartice";
            this.gridColumn4.FieldName = "brkart";
            this.gridColumn4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn4.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn4.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 16;
            // 
            // colnapomena
            // 
            this.colnapomena.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colnapomena.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colnapomena.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colnapomena.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colnapomena.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colnapomena.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colnapomena.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colnapomena.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colnapomena.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colnapomena.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colnapomena.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colnapomena.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colnapomena.Caption = "Napomena";
            this.colnapomena.FieldName = "napomena";
            this.colnapomena.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colnapomena.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colnapomena.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colnapomena.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colnapomena.Name = "colnapomena";
            this.colnapomena.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colnapomena.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colnapomena.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colnapomena.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colnapomena.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colnapomena.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colnapomena.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colnapomena.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colnapomena.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colnapomena.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colnapomena.Visible = true;
            this.colnapomena.VisibleIndex = 13;
            this.colnapomena.Width = 208;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn2.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn2.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn2.Caption = "Dodatni";
            this.gridColumn2.FieldName = "dodatni";
            this.gridColumn2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn2.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn2.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn2.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn2.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 17;
            this.gridColumn2.Width = 62;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn3.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn3.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn3.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn3.Caption = "Kartica nosioca";
            this.gridColumn3.FieldName = "brkartdod";
            this.gridColumn3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn3.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn3.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn3.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn3.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn3.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 18;
            this.gridColumn3.Width = 97;
            // 
            // colSpol
            // 
            this.colSpol.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colSpol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colSpol.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colSpol.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colSpol.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colSpol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colSpol.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colSpol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colSpol.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colSpol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colSpol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colSpol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colSpol.Caption = "Spol";
            this.colSpol.FieldName = "spol";
            this.colSpol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colSpol.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colSpol.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colSpol.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colSpol.Name = "colSpol";
            this.colSpol.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colSpol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colSpol.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colSpol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colSpol.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colSpol.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colSpol.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colSpol.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colSpol.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colSpol.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colSpol.Visible = true;
            this.colSpol.VisibleIndex = 12;
            this.colSpol.Width = 45;
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrenesi.Location = new System.Drawing.Point(853, 12);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(100, 23);
            this.btnPrenesi.TabIndex = 13;
            this.btnPrenesi.Text = "Prenesi";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Location = new System.Drawing.Point(853, 41);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 23);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Ukloni";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(853, 99);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 23);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSvi
            // 
            this.btnSvi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSvi.Location = new System.Drawing.Point(853, 70);
            this.btnSvi.Name = "btnSvi";
            this.btnSvi.Size = new System.Drawing.Size(100, 23);
            this.btnSvi.TabIndex = 15;
            this.btnSvi.Text = "Prikaži sve";
            this.btnSvi.UseVisualStyleBackColor = true;
            this.btnSvi.Click += new System.EventHandler(this.btnSvi_Click);
            // 
            // frmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 443);
            this.Controls.Add(this.btnSvi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrenesi);
            this.Controls.Add(this.dgKupci);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmZahtjevi";
            this.ShowInTaskbar = false;
            this.Text = "Zahtjevi sa portala";
            this.Load += new System.EventHandler(this.frmZahtjevi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmZahtjevi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private mpmanDataSet mpmanDataSet;
        private mpmanDataSetTableAdapters.kupciTableAdapter kupciTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_kupci;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_brkart;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_sifrakar;
        private DevExpress.XtraGrid.Columns.GridColumn colstatkar_ST_SIFRA;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_prezime;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_ime;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_jmbg;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_oib;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_mjesto;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_posta;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_adresa;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_telefon1;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_telefon2;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_fax;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_siffir;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_danob1;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_danob2;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_dankar;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_vazido;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_status;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_rodjendan;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_limkar;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_limtra;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_saldo;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_kumtro;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_prag;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_datpop;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_preporuka;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_kucanstvo;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_imirovljenik;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_pokrodjen;
        private DevExpress.XtraGrid.Columns.GridColumn colkup_brosobne;
        private DevExpress.XtraGrid.GridControl dgKupci;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private System.Windows.Forms.Button btnPrenesi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOdustani;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colka_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colnova;
        private DevExpress.XtraGrid.Columns.GridColumn colpostojeca;
        private DevExpress.XtraGrid.Columns.GridColumn colime;
        private DevExpress.XtraGrid.Columns.GridColumn colprezime;
        private DevExpress.XtraGrid.Columns.GridColumn coldatumrod;
        private DevExpress.XtraGrid.Columns.GridColumn colmjesto;
        private DevExpress.XtraGrid.Columns.GridColumn coladresa;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colmobitel;
        private DevExpress.XtraGrid.Columns.GridColumn colnapomena;
        private DevExpress.XtraGrid.Columns.GridColumn colvrijemezah;
        private DevExpress.XtraGrid.Columns.GridColumn colOIB;
        private DevExpress.XtraGrid.Columns.GridColumn colsms;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colSpol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Button btnSvi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;

    }
}