﻿/// <summary>
/// Questo è il form per mostrare i risultati degli esercizi Ext2fs.
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi {
    public partial class ext2fsResultForm : Form {

        public ext2fsResultForm(string potDimPar, string potDimBloc, string potDimInode, string potNumBlocPar, string bit, string numBlocInd, string maxFileDim, string strutDim, string rapp) {

            InitializeComponent();

            dimParPotLabel.Text = potDimPar;
            dimBlocPotLabel.Text = potDimBloc;
            dimInodePotLabel.Text = potDimInode;
            numBlocParPotLabel.Text = potNumBlocPar;
            bitLabel.Text = bit;
            numBlocInodeLabel.Text = numBlocInd;
            maxFileDimLabel.Text = maxFileDim + " B";
            strutDimLabel.Text = strutDim + " B";
            rappLabel.Text = rapp + " %";

        }

    }
}
