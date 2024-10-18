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
    public partial class Dashboard : Form
    {

        private readonly ReservationManager reservationManager;
        private List<Reservation> list;

        public Dashboard()
        {
            InitializeComponent();

            reservationManager = new ReservationManager(
                    new repos.ReservationRepository()
                );

            
        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();
        }

        private void btn_add_reservation_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //addColumns();
            list = reservationManager.GetAll();
            //dgv_reservations.DataSource = list;

            var lista = list.Select(i => new { i.Name, i.Surname, i.service.title, i.service.price }).ToArray();
            dgv_reservations.DataSource = lista;

        }

        private void addColumns()
        {
            dgv_reservations.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Service.Price",
                HeaderText = "Price"
            });

        }
    }
}
