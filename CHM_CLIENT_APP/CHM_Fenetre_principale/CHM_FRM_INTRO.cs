using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.Properties;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_INTRO : Form
    {
        public CHM_FRM_INTRO()
        {
            InitializeComponent();
        }

        //Create a Bitmpap Object.
        //Bitmap animatedImage = new Bitmap(Resources.anim_loading);
        bool currentlyAnimating = false;

        //This method begins the animation. 
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {

                //Begin the animation only once.
                ImageAnimator.Animate(pictureBox1.Image, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            //Force a call to the Paint event handler. 
            pictureBox1.Invalidate();
            //this.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Begin the animation.
            AnimateImage();

            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();

            //Draw the next frame in the animation.
            //e.Graphics.DrawImage(pictureBox1.Image, new Point(0, 0));
        }
    }
}