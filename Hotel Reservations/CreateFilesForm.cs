//Eduardo M. Martin
//Samuel Van Dalen
//COP 4814 U03 - Component Based Software Dev - Fall 2016
//Assignment1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace Hotel_Reservations
{

   
    public partial class CreateFilesForm : Form
    {

    

        public CreateFilesForm()
        {
            InitializeComponent();
        }

    

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {

        }


        private void buildHotelsxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelFactory factory = new HotelFactory();
            factory.CreateHotelFile();
        }

        private void buildRoominventoryxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomFactory rooms = new RoomFactory();
            rooms.createRooms();
        }

        private void displayHotelsxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void displayRoominventoryxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roomInventory.xml";
            frm.ShowDialog();
        }

        private void btnLoadHotelsFile_Click(object sender, EventArgs e)
        {
            ShowHotels hotelShow = new ShowHotels();
            hotelShow.hotelShower();

            //lblStatus.Text("")
        }

        private void btnDisplayHotels_Click(object sender, EventArgs e)
        {

            BrowserForm frm = new BrowserForm();
            frm.URL = "hoorayforhtml.html";
            frm.ShowDialog();


            doThatHTML htmlMagic = new doThatHTML();
            htmlMagic.doTheHTML();

        }

        private void deSerializeThingsUseOnlyIfNeededToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomDeSerializer deSerializer = new RoomDeSerializer();
            deSerializer.deSerialzeNow();
        }


    }
}


