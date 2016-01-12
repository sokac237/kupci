namespace Kupci
{
    partial class frmZahtjeviDjeca
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
            this.components = new System.ComponentModel.Container();
            this.dgDjeca = new DevExpress.XtraGrid.GridControl();
            this.dgrDjeca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatumrod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zahtjevidjecaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mpmanDataSet1 = new Kupci.mpmanDataSet();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.zahtjevidjecaTableAdapter = new Kupci.mpmanDataSetTableAdapters.zahtjevidjecaTableAdapter();
            this.tableAdapterManager = new Kupci.mpmanDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgDjeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDjeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevidjecaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpmanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDjeca
            // 
            this.dgDjeca.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.dgDjeca.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.dgDjeca.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgDjeca.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgDjeca.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgDjeca.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgDjeca.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgDjeca.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgDjeca.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgDjeca.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dgDjeca.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.dgDjeca.Location = new System.Drawing.Point(12, 12);
            this.dgDjeca.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.dgDjeca.MainView = this.dgrDjeca;
            this.dgDjeca.Name = "dgDjeca";
            this.dgDjeca.Size = new System.Drawing.Size(429, 421);
            this.dgDjeca.TabIndex = 12;
            this.dgDjeca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgrDjeca});
            this.dgDjeca.DoubleClick += new System.EventHandler(this.dgKupci_DoubleClick);
            // 
            // dgrDjeca
            // 
            this.dgrDjeca.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgrDjeca.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgrDjeca.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.Empty.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgrDjeca.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgrDjeca.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgrDjeca.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgrDjeca.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgrDjeca.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgrDjeca.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgrDjeca.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgrDjeca.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrDjeca.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgrDjeca.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.GroupRow.Options.UseFont = true;
            this.dgrDjeca.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgrDjeca.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgrDjeca.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgrDjeca.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgrDjeca.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgrDjeca.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgrDjeca.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgrDjeca.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.OddRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.OddRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgrDjeca.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgrDjeca.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.Preview.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.Preview.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.Row.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.Row.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgrDjeca.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgrDjeca.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgrDjeca.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgrDjeca.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgrDjeca.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.VertLine.Options.UseBackColor = true;
            this.dgrDjeca.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dgrDjeca.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dgrDjeca.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dgrDjeca.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dgrDjeca.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dgrDjeca.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dgrDjeca.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dgrDjeca.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colime,
            this.colprezime,
            this.colOIB,
            this.coldatumrod});
            this.dgrDjeca.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgrDjeca.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.dgrDjeca.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            this.dgrDjeca.GridControl = this.dgDjeca;
            this.dgrDjeca.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.dgrDjeca.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.dgrDjeca.Name = "dgrDjeca";
            this.dgrDjeca.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrDjeca.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgrDjeca.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgrDjeca.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgrDjeca.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.dgrDjeca.OptionsBehavior.Editable = false;
            this.dgrDjeca.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.dgrDjeca.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.dgrDjeca.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgrDjeca.OptionsSelection.MultiSelect = true;
            this.dgrDjeca.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.dgrDjeca.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.dgrDjeca.OptionsView.ColumnAutoWidth = false;
            this.dgrDjeca.OptionsView.EnableAppearanceEvenRow = true;
            this.dgrDjeca.OptionsView.EnableAppearanceOddRow = true;
            this.dgrDjeca.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.dgrDjeca.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.dgrDjeca.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.dgrDjeca.OptionsView.ShowAutoFilterRow = true;
            this.dgrDjeca.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgrDjeca.OptionsView.ShowGroupPanel = false;
            this.dgrDjeca.OptionsView.ShowIndicator = false;
            this.dgrDjeca.PaintStyleName = "WindowsXP";
            this.dgrDjeca.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.dgrDjeca.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colime, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.dgrDjeca.SynchronizeClones = false;
            this.dgrDjeca.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
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
            this.colime.VisibleIndex = 0;
            this.colime.Width = 99;
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
            this.colprezime.Width = 127;
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
            this.colOIB.VisibleIndex = 2;
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
            this.coldatumrod.VisibleIndex = 3;
            this.coldatumrod.Width = 90;
            // 
            // zahtjevidjecaBindingSource
            // 
            this.zahtjevidjecaBindingSource.DataMember = "zahtjevidjeca";
            this.zahtjevidjecaBindingSource.DataSource = this.mpmanDataSet1;
            // 
            // mpmanDataSet1
            // 
            this.mpmanDataSet1.DataSetName = "mpmanDataSet";
            this.mpmanDataSet1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.mpmanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Location = new System.Drawing.Point(447, 12);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(100, 23);
            this.btnPrenesi.TabIndex = 13;
            this.btnPrenesi.Text = "Prenesi";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(447, 41);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 23);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(447, 70);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // zahtjevidjecaTableAdapter
            // 
            this.zahtjevidjecaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.djecaTableAdapter = null;
            this.tableAdapterManager.kupciTableAdapter = null;
            this.tableAdapterManager.statkarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kupci.mpmanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zahtjevidjecaTableAdapter = this.zahtjevidjecaTableAdapter;
            this.tableAdapterManager.zahtjeviTableAdapter = null;
            // 
            // frmZahtjeviDjeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 442);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrenesi);
            this.Controls.Add(this.dgDjeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZahtjeviDjeca";
            this.ShowInTaskbar = false;
            this.Text = "Zahtjevi sa portala";
            this.Load += new System.EventHandler(this.frmZahtjeviDjeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDjeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDjeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevidjecaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpmanDataSet1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgDjeca;
        private DevExpress.XtraGrid.Views.Grid.GridView dgrDjeca;
        private Kupci.mpmanDataSet mpmanDataSet1;
        private System.Windows.Forms.Button btnPrenesi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource zahtjevidjecaBindingSource;
        private mpmanDataSetTableAdapters.zahtjevidjecaTableAdapter zahtjevidjecaTableAdapter;
        private mpmanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colime;
        private DevExpress.XtraGrid.Columns.GridColumn colprezime;
        private DevExpress.XtraGrid.Columns.GridColumn colOIB;
        private DevExpress.XtraGrid.Columns.GridColumn coldatumrod;

    }
}