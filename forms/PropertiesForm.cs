using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter.forms
{
    public partial class PropertiesForm : Form
    {
        private PropertyService propSerivice;

        public PropertiesForm()
        {
            InitializeComponent();
            this.propSerivice = PropertyService.getInstance();
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            this.tb_pen_width.Text = propSerivice.penWidth.ToString();
            this.tb_rect_width.Text = propSerivice.rectangleSize.Width.ToString();
            this.tb_rect_height.Text = propSerivice.rectangleSize.Height.ToString();
            this.tb_max_revert_steps.Text = propSerivice.maxHistorie.ToString();
        }

        private void bt_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if( this.saveProperties() )
            {
                this.Close();
            }
        }

        private Boolean saveProperties()
        {

            string penWidth = this.tb_pen_width.Text;
            string rectWidth = this.tb_rect_width.Text;
            string rectHeight = this.tb_rect_height.Text;
            string maxRevertSteps = this.tb_max_revert_steps.Text;

            if (string.IsNullOrEmpty(penWidth) || 
                string.IsNullOrEmpty(rectWidth) || 
                string.IsNullOrEmpty(rectHeight) || 
                string.IsNullOrEmpty(maxRevertSteps))
            {
                showSaveError("All fields are required");
                return false;
            }

            try
            {
                propSerivice.penWidth = Convert.ToSingle(penWidth);
                propSerivice.maxHistorie = Convert.ToInt32(maxRevertSteps);

                propSerivice.rectangleSize = new Size(Convert.ToInt32(rectHeight), Convert.ToInt32(rectWidth));
            } catch(Exception e)
            {
                showSaveError("One of the properties are in the wrong format");
                return false;
            }

            try
            {
                PropertiesLoader.saveProperties();
            } catch(Exception e)
            {
                MessageBox.Show("Unable to save properties", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void showSaveError(string message)
        {
            if (MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
