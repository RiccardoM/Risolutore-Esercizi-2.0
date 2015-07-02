/// <summary>
/// Questo è il form per mostrare i risultati degli esercizi NTFS. 
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
    public partial class ntfsResultsForm : Form {


        public ntfsResultsForm( string dimParPot, string dimBlocPot, string numBlocPot, string bit, string dimFile, string dimNtfs, string dimRecord,
                                string resBytePrin, string resByteSec, string copPrin, string copSec, string numRec, string rapp) {

            InitializeComponent();

            dimParPotLabel.Text = dimParPot;
            dimBlocPotLabel.Text = dimBlocPot;
            numBlocParPotLabel.Text = numBlocPot;
            bitLabel.Text = bit;
            fileDimLabel.Text = dimFile + " B";

            dimRecLabel.Text = dimRecord + " B";
            resBytePrinLabel.Text = resBytePrin + " B";
            resByteSecLabel.Text = resByteSec + " B";
            numCopPrinLabel.Text = copPrin;
            numCopSecLabel.Text = copSec;
            numRecLabel.Text = numRec;


            strutDimLabel.Text = dimNtfs + " B";
            rappLabel.Text = rapp + " %";

        }

    }
}
