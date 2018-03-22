using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    class SelectionButton : RadioButton
    {
        public Color correspondingColor;
        public Panel colorPanel;
        public Label countingLabel;

        public void setcorrespondingColor(Color c)
        {
            if (this.colorPanel == null)
                return; 

            this.correspondingColor = c;
            this.colorPanel.BackColor = c; 
        }

        public void incCountingLabel()
        {
            if (this.countingLabel == null)
                return; 

            String tmp = this.countingLabel.Text;
            int i = Convert.ToInt32(tmp);
            i++;
            this.countingLabel.Text = Convert.ToString(i); 
        }

        public void decCountingLabel()
        {
            if (this.countingLabel == null)
                return;

            String tmp = this.countingLabel.Text;
            int i = Convert.ToInt32(tmp);
            if (i <= 0)
                return;

            i--;
            this.countingLabel.Text = Convert.ToString(i);
        }

        public void setCountingLabel(Label l)
        {
            this.countingLabel = l;
            this.countingLabel.Text = "0"; 
        }

        public void setColorPanel(Panel p)
        {
            this.colorPanel = p;
            this.setcorrespondingColor(p.BackColor);
        }

        public Color getCorrespondingColor()
        {
            return this.correspondingColor;
        }

        public void resetCountingLabel()
        {
            this.countingLabel.Text = "0";
        }
    }
}
