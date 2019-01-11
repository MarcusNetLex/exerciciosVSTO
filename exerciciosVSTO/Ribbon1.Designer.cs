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
            this.btn_Add_Image = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSave_as_PDF);
            this.group1.Items.Add(this.btn_Add_Image);
            this.group1.Label = "Arquivos";
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
            // btn_Add_Image
            // 
            this.btn_Add_Image.Label = "Add Image";
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.OfficeImageId = "PictureInsertFromFile";
            this.btn_Add_Image.ShowImage = true;
            this.btn_Add_Image.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Add_Image_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSave_as_PDF;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Add_Image;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1 {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
