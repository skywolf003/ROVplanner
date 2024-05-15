﻿using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class SITL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SITL));
            this.myGMAP1 = new MissionPlanner.Controls.myGMAP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxrover = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_skipdownload = new System.Windows.Forms.CheckBox();
            this.NUM_heading = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.but_swarmrover = new MissionPlanner.Controls.MyButton();
            this.chk_wipe = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cmdline = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_simspeed = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_heading)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_simspeed)).BeginInit();
            this.SuspendLayout();
            // 
            // myGMAP1
            // 
            this.myGMAP1.Bearing = 0F;
            this.myGMAP1.CanDragMap = true;
            resources.ApplyResources(this.myGMAP1, "myGMAP1");
            this.myGMAP1.EmptyTileColor = System.Drawing.Color.Navy;
            this.myGMAP1.GrayScaleMode = false;
            this.myGMAP1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myGMAP1.HoldInvalidation = false;
            this.myGMAP1.LevelsKeepInMemmory = 5;
            this.myGMAP1.MarkersEnabled = true;
            this.myGMAP1.MaxZoom = 2;
            this.myGMAP1.MinZoom = 2;
            this.myGMAP1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.myGMAP1.Name = "myGMAP1";
            this.myGMAP1.NegativeMode = false;
            this.myGMAP1.PolygonsEnabled = true;
            this.myGMAP1.RetryLoadTile = 0;
            this.myGMAP1.RoutesEnabled = true;
            this.myGMAP1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.myGMAP1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.myGMAP1.ShowTileGridLines = false;
            this.myGMAP1.Zoom = 0D;
            this.myGMAP1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.myGMAP1_OnMarkerEnter);
            this.myGMAP1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.myGMAP1_OnMarkerLeave);
            this.myGMAP1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseDown);
            this.myGMAP1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseMove);
            this.myGMAP1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseUp);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBoxrover);
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBoxrover
            // 
            resources.ApplyResources(this.pictureBoxrover, "pictureBoxrover");
            this.pictureBoxrover.ImageNormal = ((System.Drawing.Image)(resources.GetObject("pictureBoxrover.ImageNormal")));
            this.pictureBoxrover.ImageOver = ((System.Drawing.Image)(resources.GetObject("pictureBoxrover.ImageOver")));
            this.pictureBoxrover.Name = "pictureBoxrover";
            this.pictureBoxrover.selected = false;
            this.pictureBoxrover.TabStop = false;
            this.pictureBoxrover.Tag = "rover";
            this.pictureBoxrover.Click += new System.EventHandler(this.pictureBoxrover_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.myGMAP1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chk_skipdownload);
            this.groupBox3.Controls.Add(this.NUM_heading);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chk_skipdownload
            // 
            resources.ApplyResources(this.chk_skipdownload, "chk_skipdownload");
            this.chk_skipdownload.Name = "chk_skipdownload";
            this.chk_skipdownload.UseVisualStyleBackColor = true;
            // 
            // NUM_heading
            // 
            resources.ApplyResources(this.NUM_heading, "NUM_heading");
            this.NUM_heading.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NUM_heading.Name = "NUM_heading";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.but_swarmrover);
            this.groupBox4.Controls.Add(this.chk_wipe);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_cmdline);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmb_model);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.num_simspeed);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // but_swarmrover
            // 
            resources.ApplyResources(this.but_swarmrover, "but_swarmrover");
            this.but_swarmrover.Name = "but_swarmrover";
            this.but_swarmrover.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.but_swarmrover.UseVisualStyleBackColor = true;
            this.but_swarmrover.Click += new System.EventHandler(this.but_swarmrover_Click);
            // 
            // chk_wipe
            // 
            resources.ApplyResources(this.chk_wipe, "chk_wipe");
            this.chk_wipe.Name = "chk_wipe";
            this.chk_wipe.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txt_cmdline
            // 
            resources.ApplyResources(this.txt_cmdline, "txt_cmdline");
            this.txt_cmdline.Name = "txt_cmdline";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cmb_model
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Items.AddRange(new object[] {
            resources.GetString("cmb_model.Items"),
            resources.GetString("cmb_model.Items1"),
            resources.GetString("cmb_model.Items2"),
            resources.GetString("cmb_model.Items3"),
            resources.GetString("cmb_model.Items4"),
            resources.GetString("cmb_model.Items5"),
            resources.GetString("cmb_model.Items6"),
            resources.GetString("cmb_model.Items7"),
            resources.GetString("cmb_model.Items8"),
            resources.GetString("cmb_model.Items9"),
            resources.GetString("cmb_model.Items10"),
            resources.GetString("cmb_model.Items11"),
            resources.GetString("cmb_model.Items12"),
            resources.GetString("cmb_model.Items13"),
            resources.GetString("cmb_model.Items14"),
            resources.GetString("cmb_model.Items15"),
            resources.GetString("cmb_model.Items16"),
            resources.GetString("cmb_model.Items17"),
            resources.GetString("cmb_model.Items18"),
            resources.GetString("cmb_model.Items19"),
            resources.GetString("cmb_model.Items20"),
            resources.GetString("cmb_model.Items21"),
            resources.GetString("cmb_model.Items22"),
            resources.GetString("cmb_model.Items23"),
            resources.GetString("cmb_model.Items24"),
            resources.GetString("cmb_model.Items25"),
            resources.GetString("cmb_model.Items26"),
            resources.GetString("cmb_model.Items27"),
            resources.GetString("cmb_model.Items28"),
            resources.GetString("cmb_model.Items29"),
            resources.GetString("cmb_model.Items30"),
            resources.GetString("cmb_model.Items31"),
            resources.GetString("cmb_model.Items32"),
            resources.GetString("cmb_model.Items33")});
            resources.ApplyResources(this.cmb_model, "cmb_model");
            this.cmb_model.Name = "cmb_model";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // num_simspeed
            // 
            resources.ApplyResources(this.num_simspeed, "num_simspeed");
            this.num_simspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_simspeed.Name = "num_simspeed";
            this.num_simspeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SITL
            // 
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SITL";
            resources.ApplyResources(this, "$this");
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_heading)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_simspeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myGMAP myGMAP1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private PictureBoxMouseOver pictureBoxrover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUM_heading;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_simspeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cmdline;
        private System.Windows.Forms.CheckBox chk_wipe;
        private System.Windows.Forms.CheckBox chk_skipdownload;
        private MyButton but_swarmrover;
    }
}