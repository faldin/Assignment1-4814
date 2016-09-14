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

        private void btnDisplayHotels_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory.xml";
            frm.ShowDialog();
        }




        private void btnCreateHotels_Click(object sender, EventArgs e)
        {
            HotelFactory factory = new HotelFactory();
            factory.CreateHotelFile();



        }



        private void btnCreateInventory_Click(object sender, EventArgs e)
        {



        }


    }
}


