using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoopsLeoK
{
    public partial class frmNestedLoopsLeoK : Form
    {
        public frmNestedLoopsLeoK()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            int capLetterCounter;
            int smallLetterCounter;
            string capLetter;
            string smallLetter;

            //clear the listbox items
            lstLetters.Items.Clear();

            //loop through A-Z
            for (capLetterCounter = 65; capLetterCounter <= 90; capLetterCounter++)
            {
                for (smallLetterCounter = 97; smallLetterCounter <= 122; smallLetterCounter++)
                {
                    //convert the counter number to their corrisponding letters 
                    capLetter = Char.ConvertFromUtf32(capLetterCounter);
                    smallLetter = Char.ConvertFromUtf32(smallLetterCounter);

                    //display the letters in the listbox
                    lstLetters.Items.Add(capLetter + " -> " + smallLetter);
                }
            }
        }
    }
}
