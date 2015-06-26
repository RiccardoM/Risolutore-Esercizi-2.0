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

    public partial class fatResultsForm : Form {

        public fatResultsForm( string dimParPot, string dimBlocPot, string numBlocPot, string bit, string dimFile, string dimFat, string rapp) {
            InitializeComponent();

            dimParPotLabel.Text = dimParPot;
            dimBlocPotLabel.Text = dimBlocPot;
            numBlocParPotLabel.Text = numBlocPot;
            bitLabel.Text = bit;
            fileDimLabel.Text = dimFile + " B";
            strutDimLabel.Text = dimFat + " B";
            rappLabel.Text = rapp + " %";


        }

    }

}
