﻿using ReservationSystem.business;
using ReservationSystem.entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class AddService : Form
    {
        
        private ServiceManager serviceManager;

        public AddService()
        {
            InitializeComponent();
            serviceManager = new ServiceManager(
                    new repos.ServiceRepository()
                );
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Service service = new Service(
                    tb_title.Text,
                    Double.Parse(tb_price.Text)
                );


            serviceManager.SaveService(service);
            this.Close();
        }
    }
}
