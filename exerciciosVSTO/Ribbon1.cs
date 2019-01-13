﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//----< Word Addin >---- 
using System.IO;
using Microsoft.Office.Tools.Ribbon;
//----</ Word Addin >---- 

namespace exerciciosVSTO
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void btnSave_as_PDF_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.SalvarComoPDF();
        }

        private void btn_Add_Image_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.InserirImagem();
        }

        private void btn_CriarTabela_Click(object sender, RibbonControlEventArgs e)
        {
            CreateTable tabela = new CreateTable();
            tabela.Show();
        }
    }
}

