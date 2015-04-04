using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entities;

namespace BookHotelTool
{
    public partial class Form1 : Form
    {
        public const int pxpercure = 20;
        public long floorid = 0;
        public string lastAngle = "0";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblShowRooms.BackColor = Color.White;
            cbFloors.Items.Clear();
            foreach (HotelFloor floor in DBManager.Data.HotelFloors)
            {
                cbFloors.Items.Add(floor);
            }
            cbFloors.SelectedItem = DBManager.Data.HotelFloors[0];
            lblShowRooms.Invalidate();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            DBManager.Data.Init();
            lblShowRooms.Invalidate();
        }

        private void pbBigRoom_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.DoDragDrop(pb, DragDropEffects.Copy | DragDropEffects.Move);

        }

        private void lblShowRooms_Click(object sender, EventArgs e)
        {

        }

        private void lblShowRooms_DragEnter(object sender, DragEventArgs e)
        {
            //当Button被拖拽到WinForm上时候，鼠标效果出现
            if ((e.Data.GetDataPresent(typeof(PictureBox))))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        //拖放下
        private void lblShowRooms_DragDrop(object sender, DragEventArgs e)
        {
            var pb = e.Data.GetData(typeof(PictureBox)) as PictureBox;

            var loc = lblShowRooms.PointToClient(new Point(e.X, e.Y));
            //get the cube position
            var x = loc.X / pxpercure;
            var y = loc.Y / pxpercure;

            var dlg = new AddNewRoom();
            dlg.tbRoomNo.Text = pb.Tag.ToString();
            dlg.tbAngle.Text = lastAngle;
            dlg.ShowDialog();
            if (dlg.DialogResult != DialogResult.OK)
            {
                return;
            }
            long maxid = 0;
            if (DBManager.Data.RoomInfos.Count > 0)
            {
                maxid = DBManager.Data.RoomInfos.Max(info => info.RoomInfoId) + 1;
            }
            lastAngle = dlg.tbAngle.Text;
            RoomInfo room = new RoomInfo()
                {
                    RoomInfoId = maxid,
                    RoomTypeId = 0,
                    Angle = double.Parse(dlg.tbAngle.Text.Trim()),
                    Height = double.Parse(dlg.tbHeight.Text.Trim()),
                    Width = double.Parse(dlg.tbWidth.Text.Trim()),
                    HotelFloorId = floorid,
                    PositionX = x,
                    PositionY = y,
                    Message = dlg.tbMessage.Text.Trim(),
                    IsCanBook = true,
                    PicURl = "http://www.cdpath.com/Images/home.png",
                    RoomNo = dlg.tbRoomNo.Text.Trim()
                };

            if (pb.Tag.ToString() == "标准房")
            {
                room.RoomTypeId = 0;
                room.PicURl = "http://www.cdpath.com/Images/home.png";
            }
            else if (pb.Tag.ToString() == "大床房")
            {
                room.RoomTypeId = 1;
                room.PicURl = "http://www.cdpath.com/Images/home1.png";
            }
            else if (pb.Tag.ToString() == "豪华房")
            {
                room.RoomTypeId = 4;
                room.PicURl = "http://www.cdpath.com/Images/home3.png";
            }
            else if (pb.Tag.ToString() == "会议室")
            {
                room.RoomTypeId = 5;
                room.PicURl = "http://www.cdpath.com/Images/Meeting Room.png";
            }
            else if (pb.Tag.ToString() == "不可预订")
            {
                room.IsCanBook = false;
                room.RoomTypeId = 1;
                room.PicURl = "http://www.cdpath.com/Images/home_no.png";
            }
            else if (pb.Tag.ToString() == "餐厅")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://www.cdpath.com/Images/Restaurant.png";
            }
            else if (pb.Tag.ToString() == "电梯")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://www.cdpath.com/Images/lift.png";
            }
            else if (pb.Tag.ToString() == "会议室")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://www.cdpath.com/Images/Meeting%20Room.png";
            }
            else if (pb.Tag.ToString() == "厕所")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://www.cdpath.com/Images/toilet.png";
            }
            else if (pb.Tag.ToString() == "走廊")
            {
                room.RoomTypeId = 3;
                room.PicURl = "";
            }

            DBManager.Data.RoomInfos.Add(room);

            lblShowRooms.Invalidate();
        }

        private void lblShowRooms_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;

            rect.Inflate(-10, -10);

            //get vertical line count.
            int vcount = rect.Width / pxpercure + 1;
            int hcount = rect.Height / pxpercure + 1;


            using (Pen pen = new Pen(Color.Red, 1))
            {
                pen.Brush = Brushes.CornflowerBlue;
                pen.DashStyle = DashStyle.Dash;
                for (int i = 0; i < vcount; i++)
                {
                    e.Graphics.DrawLine(pen, i * pxpercure, 0, i * pxpercure, rect.Height);

                }
                for (int i = 0; i < hcount; i++)
                {
                    e.Graphics.DrawLine(pen, 0, i * pxpercure, rect.Width, i * pxpercure);
                }
            }

            //paint rooms:
            List<RoomInfo> rooms = DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == floorid).ToList();
            foreach (var room in rooms)
            {
                if (!string.IsNullOrWhiteSpace(room.PicURl))
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(room.PicURl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    e.Graphics.DrawImage(img,
                        new Rectangle(new Point((int)room.PositionX * pxpercure, (int)room.PositionY * pxpercure),
                            new Size((int)room.Width * pxpercure, (int)room.Height * pxpercure)));

                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, new Rectangle(new Point((int)room.PositionX * pxpercure, (int)room.PositionY * pxpercure),
                            new Size((int)room.Width * pxpercure, (int)room.Height * pxpercure)));
                }


                using (Font font = new Font("Arial", 14))
                {
                    e.Graphics.DrawString(room.RoomNo.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 10);
                    e.Graphics.DrawString(room.Message.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 30);
                    e.Graphics.DrawString(room.Angle.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 50);
                }

            }



            // using (Pen pen = new Pen(Color.Red, 5))
            //     e.Graphics.DrawEllipse(pen, rect);

        }

        private void lblShowRooms_Resize(object sender, EventArgs e)
        {
            lblShowRooms.Invalidate();
        }

        private void cbFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorid = (cbFloors.SelectedItem as HotelFloor).HotelFloorId;
            lblShowRooms.Invalidate();
        }

        private void btnSaveToDisk_Click(object sender, EventArgs e)
        {
            DBManager.SaveToDisc();
        }

        private void btnDeleteLastRoom_Click(object sender, EventArgs e)
        {
            var rooms = DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == floorid).ToList();
            if (rooms.Count > 0)
            {
                long maxid = rooms.Max(r => r.RoomInfoId);
                DBManager.Data.RoomInfos.RemoveAll(r => r.RoomInfoId == maxid);
            }
            lblShowRooms.Invalidate();
        }

    }
}
