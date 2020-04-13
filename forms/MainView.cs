using ClickCounter.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class MainView : Form
    {
        private String pathToImage = null; 

        private Boolean isCounting = false;
        private Boolean isloadedImage = false;

        private Image image;

        private Image second;

        private List<SelectionButton> selectionButtons;

        public MainView()
        {
            this.selectionButtons = new List<SelectionButton>();
            InitializeComponent();
            this.TopLevel = true;

            this.rb_counter1.setColorPanel(this.panel1);
            this.rb_counter2.setColorPanel(this.panel2);
            this.rb_counter3.setColorPanel(this.panel3);

            this.rb_counter1.setCountingLabel(this.lb_counter1);
            this.rb_counter2.setCountingLabel(this.lb_counter2);
            this.rb_counter3.setCountingLabel(this.lb_counter3);

            this.selectionButtons.Add(this.rb_counter1);
            this.selectionButtons.Add(this.rb_counter2);
            this.selectionButtons.Add(this.rb_counter3);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            this.isCounting = true; 
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            this.isCounting = false; 
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            SelectionButton selected = this.getSelectedRadioButton();
            selected.resetCountingLabel();    
        }

        private void resetAllCountingLabels()
        {
            foreach (SelectionButton button in this.selectionButtons)
            {
                button.resetCountingLabel();
            }
        }

        private SelectionButton getSelectedRadioButton()
        {
            foreach (SelectionButton button in this.selectionButtons)
            {
                if (button.Checked)
                {
                    return button;
                }
            }
            
            return null; 
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            this.loadImage();
        }

        private void loadImage()
        {
            String path = this.getPathToImage();
            if (path == null)
            {
                MessageBox.Show("Invalid path to image file.", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.resetAllCountingLabels();
            this.pathToImage = path;
            this.image = new Bitmap(Image.FromFile(path));
            this.pb_picture.Image = this.image;

            this.toolStrip_loadedImage.Text = this.pathToImage;
            this.isloadedImage = true;
        }

        private String getPathToImage()
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String tmp = this.openFileDialog.FileName;
                if (tmp == null)
                    return null;
                return tmp; 
            }

            return null; 
        }

        private void pb_picture_MouseUp(object sender, EventArgs ev)
        {
            if (this.isloadedImage && this.isCounting)
            {
                MouseEventArgs me = (MouseEventArgs)ev;
                this.pb_picture.Image = ImageManipulator.drawPoint(this.pb_picture.Image, new Point(me.X, me.Y), this.getSelectedColor());
                this.incClickCounter();
            }
        }

        private Color getSelectedColor()
        {
            SelectionButton tmp = this.getSelectedRadioButton();
            return tmp.getCorrespondingColor(); 
        }

        private void incClickCounter()
        {
            if (this.isCounting && this.isloadedImage)
            {
                this.getSelectedRadioButton().incCountingLabel(); 
            }
        }

        private void decClickCounter()
        {
            if (this.isCounting && this.isloadedImage)
            {
                this.getSelectedRadioButton().decCountingLabel();
            }
        }

        private void b_revert_MouseClick(object sender, MouseEventArgs e)
        {
            Image previous = ImageManipulator.revertLastManipulation();
            if( previous == null )
            {
                MessageBox.Show("No manipulations in history.", "Max revert reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.pb_picture.Image = previous;
            this.decClickCounter();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadImage();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Info().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PropertiesForm().Show();
        }
    }
}
