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
using System.Web;
using System.Windows.Forms;
using BookHotelTool.Service;
using DAL;
using Entities;
using WHPLib;

namespace BookHotelTool
{
    public partial class FormMain : Form
    {
        public const int pxpercure = 20;
        public const int controlwidth = 6;

        public long floorid = 0;
        public string lastAngle = "0";
        public bool isDragDrop = false;
        private bool isMoving = false;
        private RoomInfo selectedRoomInfo = null;
        private Point originPoint = new Point(0, 0);


        private bool isResizing = false;
        public ShowService ShowService = new ShowService();

        public FormMain()
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
            this.ShowService.floor = 0;
            ShowService.OnShow += () =>
            {
                ShowService.loadFloor();
                this.lblShowRooms.Invalidate();
            };

            ShowService.Show();
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

        //点击
        private void lblShowRooms_Click(object sender, EventArgs er)
        {

        }

        //设置选择房间
        public RoomInfo SetSelectedRoom(int X, int Y)
        {
            this.ShowService.rooms.ForEach(r => r.isSelected = false);
            foreach (RoomInfo room in this.ShowService.rooms)
            {
                Rectangle rectangle = new Rectangle((int)room.PositionX * pxpercure, (int)room.PositionY * pxpercure,
                    (int)room.Width * pxpercure, (int)room.Height * pxpercure);
                if (rectangle.Contains(X, Y))
                {
                    room.isSelected = true;
                    return room;
                }
            }
            return null;
        }

        private void lblShowRooms_DragEnter(object sender, DragEventArgs e)
        {
            //当Button被拖拽到WinForm上时候，鼠标效果出现
            if ((e.Data.GetDataPresent(typeof(PictureBox))))
            {
                e.Effect = DragDropEffects.Copy;
                isDragDrop = true;
                lblShowRooms.Invalidate();
            }
        }

        //拖放下
        private void lblShowRooms_DragDrop(object sender, DragEventArgs e)
        {
            isDragDrop = false;
            var pb = e.Data.GetData(typeof(PictureBox)) as PictureBox;

            var loc = lblShowRooms.PointToClient(new Point(e.X, e.Y));
            //get the cube position
            var x = loc.X / pxpercure;
            var y = loc.Y / pxpercure;
            long maxid = 0;
            if (DBManager.Data.RoomInfos.Count > 0)
            {
                maxid = DBManager.Data.RoomInfos.Max(info => info.RoomInfoId) + 1;
            }

            RoomInfo room = new RoomInfo()
            {
                RoomInfoId = maxid,
                RoomTypeId = 0,
                Angle = 0,//dlg.tbAngle.Text.Trim()
                Height = 6,//dlg.tbHeight.Text.Trim(
                Width = 4,//dlg.tbWidth.Text.Trim()
                HotelFloorId = floorid,
                PositionX = x,
                PositionY = y,
                Message = "",//dlg.tbMessage.Text.Trim(),
                IsCanBook = true,
                PicURl = "http://localhost:8080/Images/home.png",
                RoomNo = pb.Tag.ToString()//dlg.tbRoomNo.Text.Trim()
            };

            //var dlg = new AddNewRoom();
            //dlg.tbRoomNo.Text = pb.Tag.ToString();
            //dlg.tbAngle.Text = lastAngle;
            //dlg.ShowDialog();
            //if (dlg.DialogResult != DialogResult.OK)
            //{
            //    lblShowRooms.Invalidate();
            //    return;
            //}


            if (pb.Tag.ToString() == "标准房")
            {
                room.RoomTypeId = 0;
                room.PicURl = "http://localhost:8080/Images/home.png";
            }
            else if (pb.Tag.ToString() == "大床房")
            {
                room.RoomTypeId = 1;
                room.PicURl = "http://localhost:8080/Images/home1.png";
            }
            else if (pb.Tag.ToString() == "豪华房")
            {
                room.RoomTypeId = 4;
                room.PicURl = "http://localhost:8080/Images/home3.png";
            }
            else if (pb.Tag.ToString() == "会议室")
            {
                room.RoomTypeId = 5;
                room.PicURl = "http://localhost:8080/Images/Meeting Room.png";
            }
            else if (pb.Tag.ToString() == "不可预订")
            {
                room.IsCanBook = false;
                room.RoomTypeId = 1;
                room.PicURl = "http://localhost:8080/Images/home_no.png";
            }
            else if (pb.Tag.ToString() == "餐厅")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://localhost:8080/Images/Restaurant.png";
            }
            else if (pb.Tag.ToString() == "电梯")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://localhost:8080/Images/lift.png";
            }
            else if (pb.Tag.ToString() == "会议室")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://localhost:8080/Images/Meeting_Room.png";
            }
            else if (pb.Tag.ToString() == "厕所")
            {
                room.RoomTypeId = -1;
                room.PicURl = "http://localhost:8080/Images/toilet.png";
            }
            else if (pb.Tag.ToString() == "走廊")
            {
                room.RoomTypeId = 3;
                room.PicURl = "";
            }

            DBManager.Data.RoomInfos.Add(room);

            this.ShowService.loadFloor();
            SetSelectedRoom(loc.X, loc.Y);
            this.ShowService.Show();
            SaveToWebSite();
        }

        private void lblShowRooms_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = this.ClientRectangle;

            //get vertical line count.
            int vcount = rect.Width / pxpercure + 1;
            int hcount = rect.Height / pxpercure + 1;

            if (isDragDrop || isMoving || isResizing)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    pen.Brush = Brushes.DarkRed;
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
            }
            //string url = HttpUtility.UrlDecode("/hotel_model.png");
            //url = url.Replace('\\', '/');
            //string fname = "Images/" + url.Substring(url.LastIndexOf('/') + 1);

            //System.Drawing.Image img1 = Image.FromFile(fname);
            //e.Graphics.DrawImage(img1,
            //    new Rectangle(new Point(0, 0),
            //        new Size((int)lblShowRooms.Width, (int)lblShowRooms.Height)));

            //paint rooms:
            //List<RoomInfo> rooms = ; // DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == floorid).ToList();
            foreach (var room in this.ShowService.rooms)
            {
                var r = new Rectangle(new Point((int)room.PositionX * pxpercure, (int)room.PositionY * pxpercure),
                    new Size((int)room.Width * pxpercure, (int)room.Height * pxpercure));

                if (!string.IsNullOrWhiteSpace(room.PicURl))
                {
                    var img = GetImage(room);
                    e.Graphics.DrawImage(img, r);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, r);
                }

                using (Font font = new Font("Arial", 14))
                {
                    e.Graphics.DrawString(room.RoomNo.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 10);
                    e.Graphics.DrawString(room.Message.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 30);
                    e.Graphics.DrawString(room.Angle.ToString(), font, Brushes.Green, (int)room.PositionX * pxpercure + 10, (int)room.PositionY * pxpercure + 50);
                }
            }
            foreach (RoomInfo room in this.ShowService.rooms)
            {

                if (room.isSelected)
                {
                    //draw 4 line and a point
                    var r = new Rectangle(new Point((int)room.PositionX * pxpercure, (int)room.PositionY * pxpercure),
    new Size((int)room.Width * pxpercure, (int)room.Height * pxpercure));


                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        Rectangle lineRectangle = r;
                        if (lineRectangle.X > 0) lineRectangle.X--;
                        if (lineRectangle.Y > 0) lineRectangle.Y--;
                        lineRectangle.Width++;
                        lineRectangle.Height++;

                        e.Graphics.DrawRectangle(pen, lineRectangle);
                    }
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        Rectangle smRectangle = room.GetControlRectangle();
                        e.Graphics.FillRectangle(Brushes.White, smRectangle);
                        e.Graphics.DrawRectangle(pen, smRectangle);
                    }
                }
            }
        }

        private static Image GetImage(RoomInfo room)
        {
            string url = HttpUtility.UrlDecode(room.PicURl);
            url = url.Replace('\\', '/');
            string fname = "Images/" + url.Substring(url.LastIndexOf('/') + 1);


            System.Drawing.Image img = Image.FromFile(fname);
            return img;
        }

        private void lblShowRooms_Resize(object sender, EventArgs e)
        {
            lblShowRooms.Invalidate();
        }

        private void cbFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorid = (cbFloors.SelectedItem as HotelFloor).HotelFloorId;
            this.ShowService.floor = floorid;
            ShowService.Show();
        }

        private void btnSaveToDisk_Click(object sender, EventArgs e)
        {
            //var rs1 = DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == 0).ToList();
            //var rs2 = DBManager.Data.RoomInfos.Where(r => r.HotelFloorId == 1).ToList();
            //foreach (RoomInfo info in rs1)
            //{
            //    info.HotelFloorId = 1;
            //}
            //foreach (RoomInfo info in rs2)
            //{
            //    info.HotelFloorId = 0;
            //}
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
            ShowService.Show();
        }

        private void lblShowRooms_DragLeave(object sender, EventArgs e)
        {
            isDragDrop = false;
            ShowService.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToWebSite();
        }

        private static void SaveToWebSite()
        {
            for (int i = 1; i <= 3; i++)
            {
                var rooms = DBManager.Data.RoomInfos.Where(f => f.HotelFloorId == (i - 1));
                foreach (RoomInfo room in rooms)
                {
                    if (!string.IsNullOrWhiteSpace(room.PicURl))
                    {
                        int index = room.PicURl.Replace("\\", "/").LastIndexOf('/');
                        room.PicURl = "../roomImg" + room.PicURl.Substring(index);
                    }
                }
                string content = rooms.ToJson();
                content = "var rooms" + i + "DATA = " + content;
                File.WriteAllText(@"C:\360YunPan\Projects\Hackathon\panda\BookHotel\panda\data\" + "rooms" + (i) + ".js",
                    content);
            }
        }

        private void lblShowRooms_MouseMove(object sender, MouseEventArgs e)
        {

            var rooms = this.ShowService.rooms.Where(r => r.isSelected == true).ToList();
            RoomInfo room;
            //不满足条件回复原样
            if (rooms == null || rooms.Count == 0)
            {
                this.Cursor = Cursors.Default;
                return;
            }
            room = rooms[0];
            //满足条件设置为小手，
            if (room.GetControlRectangle().Contains(e.X, e.Y))
            {
                this.Cursor = Cursors.SizeAll;
            }
            else if (room.GetRectangle().Contains(e.X, e.Y))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
            int bx, by;
            if (isResizing && selectedRoomInfo != null)
            {
                bx = (e.X - originPoint.X) / pxpercure;
                by = (e.Y - originPoint.Y) / pxpercure;
                if (bx != 0)
                {
                    selectedRoomInfo.Width += bx;
                    if (selectedRoomInfo.Width < 1) selectedRoomInfo.Width = 1;
                    originPoint.X = e.X;// movingRoomInfo.GetRectangle().X;
                }
                if (by != 0)
                {

                    selectedRoomInfo.Height += by;
                    if (selectedRoomInfo.Height < 1) selectedRoomInfo.Height = 1;
                    originPoint.Y = e.Y;
                }
                this.ShowService.Show();
            }

            else if (isMoving && selectedRoomInfo != null)
            {
                bx = (e.X - originPoint.X) / pxpercure;
                by = (e.Y - originPoint.Y) / pxpercure;
                if (bx != 0)
                {
                    selectedRoomInfo.PositionX += bx;
                    originPoint.X = e.X;// movingRoomInfo.GetRectangle().X;
                }
                if (by != 0)
                {
                    selectedRoomInfo.PositionY += by;
                    originPoint.Y = e.Y;// movingRoomInfo.GetRectangle().Y;
                }
                this.ShowService.Show();
            }

        }

        private void lblShowRooms_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseEventArgs e = er as MouseEventArgs;
            //var loc = lblShowRooms.PointToClient(new Point(e.X, e.Y));

            ////get the block of clicked.
            //var bx = loc.X / pxpercure;
            //var by = loc.Y / pxpercure;
            var sr = GetSelectedRoom();
            if (sr != null && sr.GetControlRectangle().Contains(e.X, e.Y))
            {
                isResizing = true;
                originPoint = new Point(e.X, e.Y);
                selectedRoomInfo = sr;
                return;
            }


            selectedRoomInfo = SetSelectedRoom(e.X, e.Y);

            this.ShowService.Show();
            if (selectedRoomInfo != null)
            {
                isMoving = true;
                var r = selectedRoomInfo.GetRectangle();
                originPoint = new Point(e.X, e.Y);
            }

        }

        private void lblShowRooms_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            isResizing = false;
            originPoint = new Point(0, 0);
            selectedRoomInfo = null;
        }

        private RoomInfo GetSelectedRoom()
        {
            var rooms = this.ShowService.rooms.Where(r => r.isSelected == true).ToList();
            RoomInfo room;
            //不满足条件回复原样
            if (rooms == null || rooms.Count == 0)
            {
                return null;
            }
            room = rooms[0];
            return room;
        }

    }

    public static class extension
    {
        public static Rectangle GetRectangle(this RoomInfo room)
        {
            return new Rectangle((int)room.PositionX * FormMain.pxpercure, (int)room.PositionY * FormMain.pxpercure,
                    (int)room.Width * FormMain.pxpercure, (int)room.Height * FormMain.pxpercure);

        }
        public static Rectangle GetControlRectangle(this RoomInfo room)
        {
            return new Rectangle((int)(room.PositionX + room.Width) * FormMain.pxpercure - FormMain.controlwidth / 2, (int)(room.PositionY + room.Height) * FormMain.pxpercure - FormMain.controlwidth / 2,
                     FormMain.controlwidth, FormMain.controlwidth);

        }
    }
}
