using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace BookHotelTool
{
    public partial class EditRoomInfo : Form
    {
        public RoomInfo Room { get; set; }
        public EditRoomInfo(RoomInfo room)
        {
            this.Room = room;
            InitializeComponent();

            tbRoomNo.Text = Room.RoomNo.ToString();
            tbMessage.Text = Room.Message;
            tbWidth.Text = Room.Width.ToString();
            tbHeight.Text = Room.Height.ToString();

            tbAngle.Text = Room.Angle.ToString();
        }

        private void EditRoomInfo_Load(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            double d = 0;
            Room.RoomNo = tbRoomNo.Text;
            Room.Message = tbMessage.Text;

            double.TryParse(tbWidth.Text, out d);
            Room.Width = d;
            double.TryParse(tbHeight.Text, out d);
            Room.Height = d;
            double.TryParse(tbAngle.Text, out d);
            Room.Angle = d;
        }
    }
}
