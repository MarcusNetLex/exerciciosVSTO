namespace exerciciosVSTO
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSave_as_PDF = this.Factory.CreateRibbonButton();
            this.Insert = this.Factory.CreateRibbonGroup();
            this.btn_Add_Image = this.Factory.CreateRibbonButton();
            this.btn_CriarTabela = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btn_InvertCase = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.btn_FindReplace = this.Factory.CreateRibbonButton();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.btn_AddField = this.Factory.CreateRibbonButton();
            this.btn_AddSpam = this.Factory.CreateRibbonButton();
            this.btn_AddQualification = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.Insert.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.Insert);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSave_as_PDF);
            this.group1.Label = "File";
            this.group1.Name = "group1";
            // 
            // btnSave_as_PDF
            // 
            this.btnSave_as_PDF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSave_as_PDF.Label = "Save As PDF";
            this.btnSave_as_PDF.Name = "btnSave_as_PDF";
            this.btnSave_as_PDF.OfficeImageId = "FileSaveAsPdfOrXps";
            this.btnSave_as_PDF.ShowImage = true;
            this.btnSave_as_PDF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSave_as_PDF_Click);
            // 
            // Insert
            // 
            this.Insert.Items.Add(this.btn_Add_Image);
            this.Insert.Items.Add(this.btn_CriarTabela);
            this.Insert.Label = "Inserir";
            this.Insert.Name = "Insert";
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.Label = "Add Image";
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.OfficeImageId = "PictureInsertFromFile";
            this.btn_Add_Image.ShowImage = true;
            this.btn_Add_Image.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Add_Image_Click);
            // 
            // btn_CriarTabela
            // 
            this.btn_CriarTabela.Label = "Add Table";
            this.btn_CriarTabela.Name = "btn_CriarTabela";
            this.btn_CriarTabela.OfficeImageId = "TableInsertDialogWord";
            this.btn_CriarTabela.ShowImage = true;
            this.btn_CriarTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_CriarTabela_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btn_InvertCase);
            this.group3.Label = "Format";
            this.group3.Name = "group3";
            // 
            // btn_InvertCase
            // 
            this.btn_InvertCase.Label = "Invert Case";
            this.btn_InvertCase.Name = "btn_InvertCase";
            this.btn_InvertCase.OfficeImageId = "ChangeCase";
            this.btn_InvertCase.ShowImage = true;
            this.btn_InvertCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_InvertCase_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.btn_FindReplace);
            this.group4.Label = "Find and Replace";
            this.group4.Name = "group4";
            // 
            // btn_FindReplace
            // 
            this.btn_FindReplace.Label = "Find and Replace";
            this.btn_FindReplace.Name = "btn_FindReplace";
            this.btn_FindReplace.OfficeImageId = "FindDialog";
            this.btn_FindReplace.ShowImage = true;
            this.btn_FindReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_FindReplace_Click);
            // 
            // group5
            // 
            this.group5.Items.Add(this.btn_AddField);
            this.group5.Items.Add(this.btn_AddSpam);
            this.group5.Items.Add(this.btn_AddQualification);
            this.group5.Label = "Field and Span";
            this.group5.Name = "group5";
            // 
            // btn_AddField
            // 
            this.btn_AddField.Label = "Add Field";
            this.btn_AddField.Name = "btn_AddField";
            this.btn_AddField.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AddField_Click);
            // 
            // btn_AddSpam
            // 
            this.btn_AddSpam.Label = "Add Span";
            this.btn_AddSpam.Name = "btn_AddSpam";
            this.btn_AddSpam.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AddSpam_Click);
            // 
            // btn_AddQualification
            // 
            this.btn_AddQualification.Label = "Add Qualification";
            this.btn_AddQualification.Name = "btn_AddQualification";
            this.btn_AddQualification.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AddQualification_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.Insert.ResumeLayout(false);
            this.Insert.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSave_as_PDF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Add_Image;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Insert;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_CriarTabela;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_InvertCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_FindReplace;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AddField;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AddSpam;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AddQualification;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1 {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
