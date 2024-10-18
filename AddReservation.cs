using ReservationSystem.business;
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
    public partial class AddReservation : Form
    {
        private ReservationManager reservationManager;
        private ServiceManager serviceManager;
        public AddReservation()
        {
            InitializeComponent();
            reservationManager = new ReservationManager(
                    new repos.ReservationRepository()
                );
            serviceManager = new ServiceManager(
                    new repos.ServiceRepository()
                );

            cb_service.Items.AddRange(serviceManager.GetAll().ToArray());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if ( cb_service.SelectedItem == null)
            {
                MessageBox.Show("Please select a service.");
            }
            else
            {
                Service selectedService = cb_service.SelectedItem as Service;
                Reservation reservation = new Reservation(
                    tb_name.Text,
                    tb_surname.Text,
                    selectedService.id
                );

                this.reservationManager.Save(reservation);
            this.Close();
            }

        }
    }
}
