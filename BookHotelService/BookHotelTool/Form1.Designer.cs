﻿namespace BookHotelTool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbFloors = new System.Windows.Forms.ComboBox();
            this.btnAddRoomType = new System.Windows.Forms.Button();
            this.btnAddFloor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1231 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblShowRooms = new System.Windows.Forms.Label();
            this.pbBigRoom = new System.Windows.Forms.PictureBox();
            this.pbStandardRoom = new System.Windows.Forms.PictureBox();
            this.btnSaveToDisk = new System.Windows.Forms.Button();
            this.btnDeleteLastRoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandardRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(704, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(56, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(4, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LoadData";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbFloors
            // 
            this.cbFloors.FormattingEnabled = true;
            this.cbFloors.Location = new System.Drawing.Point(365, 13);
            this.cbFloors.Name = "cbFloors";
            this.cbFloors.Size = new System.Drawing.Size(252, 20);
            this.cbFloors.TabIndex = 3;
            this.cbFloors.SelectedIndexChanged += new System.EventHandler(this.cbFloors_SelectedIndexChanged);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.Location = new System.Drawing.Point(213, 12);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(101, 23);
            this.btnAddRoomType.TabIndex = 4;
            this.btnAddRoomType.Text = "AddRoomType";
            this.btnAddRoomType.UseVisualStyleBackColor = true;
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.Location = new System.Drawing.Point(122, 12);
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(75, 23);
            this.btnAddFloor.TabIndex = 5;
            this.btnAddFloor.Text = "AddFloor";
            this.btnAddFloor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Floors:";
            // 
            // lbl1231
            // 
            this.lbl1231.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1231.AutoSize = true;
            this.lbl1231.Location = new System.Drawing.Point(1018, 122);
            this.lbl1231.Name = "lbl1231";
            this.lbl1231.Size = new System.Drawing.Size(41, 12);
            this.lbl1231.TabIndex = 10;
            this.lbl1231.Text = "标准房";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1018, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "大床房";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblShowRooms
            // 
            this.lblShowRooms.AllowDrop = true;
            this.lblShowRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowRooms.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowRooms.Location = new System.Drawing.Point(7, 58);
            this.lblShowRooms.Name = "lblShowRooms";
            this.lblShowRooms.Size = new System.Drawing.Size(919, 486);
            this.lblShowRooms.TabIndex = 13;
            this.lblShowRooms.Click += new System.EventHandler(this.lblShowRooms_Click);
            this.lblShowRooms.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblShowRooms_DragDrop);
            this.lblShowRooms.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblShowRooms_DragEnter);
            this.lblShowRooms.Paint += new System.Windows.Forms.PaintEventHandler(this.lblShowRooms_Paint);
            this.lblShowRooms.Resize += new System.EventHandler(this.lblShowRooms_Resize);
            // 
            // pbBigRoom
            // 
            this.pbBigRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBigRoom.Image = global::BookHotelTool.Properties.Resources.home1;
            this.pbBigRoom.Location = new System.Drawing.Point(1008, 145);
            this.pbBigRoom.Name = "pbBigRoom";
            this.pbBigRoom.Size = new System.Drawing.Size(60, 60);
            this.pbBigRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBigRoom.TabIndex = 9;
            this.pbBigRoom.TabStop = false;
            this.pbBigRoom.Tag = "大床房";
            this.pbBigRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // pbStandardRoom
            // 
            this.pbStandardRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStandardRoom.Image = global::BookHotelTool.Properties.Resources.home;
            this.pbStandardRoom.Location = new System.Drawing.Point(1008, 58);
            this.pbStandardRoom.Name = "pbStandardRoom";
            this.pbStandardRoom.Size = new System.Drawing.Size(60, 60);
            this.pbStandardRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStandardRoom.TabIndex = 9;
            this.pbStandardRoom.TabStop = false;
            this.pbStandardRoom.Tag = "标准房";
            this.pbStandardRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // btnSaveToDisk
            // 
            this.btnSaveToDisk.Location = new System.Drawing.Point(623, 13);
            this.btnSaveToDisk.Name = "btnSaveToDisk";
            this.btnSaveToDisk.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToDisk.TabIndex = 14;
            this.btnSaveToDisk.Text = "SaveToDisk";
            this.btnSaveToDisk.UseVisualStyleBackColor = true;
            this.btnSaveToDisk.Click += new System.EventHandler(this.btnSaveToDisk_Click);
            // 
            // btnDeleteLastRoom
            // 
            this.btnDeleteLastRoom.Location = new System.Drawing.Point(766, 13);
            this.btnDeleteLastRoom.Name = "btnDeleteLastRoom";
            this.btnDeleteLastRoom.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteLastRoom.TabIndex = 15;
            this.btnDeleteLastRoom.Text = "DeleteLastRoom";
            this.btnDeleteLastRoom.UseVisualStyleBackColor = true;
            this.btnDeleteLastRoom.Click += new System.EventHandler(this.btnDeleteLastRoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BookHotelTool.Properties.Resources.home_no;
            this.pictureBox1.Location = new System.Drawing.Point(1011, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "不可预订";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::BookHotelTool.Properties.Resources.Restaurant;
            this.pictureBox2.Location = new System.Drawing.Point(1011, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "餐厅";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::BookHotelTool.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(1011, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "电梯";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::BookHotelTool.Properties.Resources.Meeting_Room;
            this.pictureBox4.Location = new System.Drawing.Point(941, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "会议室";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "不可预订";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1030, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "餐厅";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1030, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "电梯";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(956, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "会议室";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(960, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "走廊";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox5.Location = new System.Drawing.Point(941, 313);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "走廊";
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(960, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "厕所";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::BookHotelTool.Properties.Resources.toilet;
            this.pictureBox6.Location = new System.Drawing.Point(941, 229);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "厕所";
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::BookHotelTool.Properties.Resources.home3;
            this.pictureBox7.Location = new System.Drawing.Point(942, 58);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "豪华房";
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBigRoom_MouseDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(952, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "豪华房";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 553);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteLastRoom);
            this.Controls.Add(this.btnSaveToDisk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblShowRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl1231);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pbBigRoom);
            this.Controls.Add(this.pbStandardRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFloor);
            this.Controls.Add(this.btnAddRoomType);
            this.Controls.Add(this.cbFloors);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnInit);
            this.Name = "Form1";
            this.Text = "楼层布局编辑程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBigRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStandardRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbFloors;
        private System.Windows.Forms.Button btnAddRoomType;
        private System.Windows.Forms.Button btnAddFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbStandardRoom;
        private System.Windows.Forms.Label lbl1231;
        private System.Windows.Forms.PictureBox pbBigRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblShowRooms;
        private System.Windows.Forms.Button btnSaveToDisk;
        private System.Windows.Forms.Button btnDeleteLastRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label9;
    }
}

