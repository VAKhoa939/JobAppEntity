﻿using JobApplication.C_Sharp_Files.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobApplication
{
    public partial class FCreatePost : Form
    {
        private ImageList uploadedImages = new ImageList();
        private int currentPictureBoxIndex = 0;

        public FCreatePost()
        {
            InitializeComponent();
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            Image uploadedImage = ImageUtil.UploadImage(); // Upload a single image
            if (uploadedImage != null)
            {
                // Resize the image to fit the PictureBox dimensions
                uploadedImage = ResizeImageToFitPictureBox(uploadedImage);

                if (currentPictureBoxIndex < 3) // Ensure we do not exceed the number of PictureBox controls
                {
                    // Clear previously uploaded images for the current PictureBox
                    uploadedImages.Images.Clear();
                    uploadedImages.Images.Add(uploadedImage); // Add the image to the ImageList

                    // Display the uploaded image in the current PictureBox
                    PictureBox currentPictureBox = GetCurrentPictureBox();
                    currentPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the PictureBox size mode to Zoom
                    currentPictureBox.Image = uploadedImage; // Display the image in the current PictureBox

                    currentPictureBoxIndex++; // Move to the next PictureBox
                }
                else
                {
                    MessageBox.Show("You have reached the maximum number of images.");
                }
            }
            else
            {
                MessageBox.Show("Please upload an image.");
            }
        }

        private PictureBox GetCurrentPictureBox()
        {
            // Get the current PictureBox control based on the currentPictureBoxIndex
            switch (currentPictureBoxIndex)
            {
                case 0:
                    return pbxJobImages1;
                case 1:
                    return pbxJobImages2;
                case 2:
                    return pbxJobImages3;
                default:
                    throw new InvalidOperationException("Invalid PictureBox index.");
            }
        }

        private Image ResizeImageToFitPictureBox(Image image)
        {
            // Resize the image to fit the dimensions of the PictureBox
            float ratio = Math.Min((float)GetCurrentPictureBox().Width / image.Width, (float)GetCurrentPictureBox().Height / image.Height);
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            return new Bitmap(image, newWidth, newHeight);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbxJobImages1.Image = null;
            pbxJobImages2.Image = null;
            pbxJobImages3.Image = null;
            txtPostName.Text = "";
            txtSalary.Text = "";
            txtAddress.Text = "";
            cbxWork.SelectedIndex = -1;
            txtSkillReq.Text = "";
            txtWorkHours.Text = "";
            txtContact.Text = "";
            uploadedImages.Images.Clear();
            currentPictureBoxIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Redirect to FMyPosts form
            FMyPosts myPostsForm = new FMyPosts();
            myPostsForm.Show();
            // Optionally, hide the current form
            this.Hide();
        }
    }
}
