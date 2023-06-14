using ProyectoCaiV01.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCaiV01
{
    public partial class MenuVentas : Form
    {
        public ModuloVuelos moduloVuelos;
        public ModuloAlojamientos moduloAlojamientos;
        public ModuloPresupuesto moduloPresupuesto;
        public MenuVentas()
        {
            InitializeComponent();
        }

        private void MenuVentas_Load(object sender, EventArgs e)
        {
            //Mostrar el menú de ventas

            menuListBox = new ListBox();
            menuListBox.Location = new Point(10, 150);
            menuListBox.Size = new Size(200, 100);
            menuListBox.SelectedIndexChanged += MenuListBox_SelectedIndexChanged;
            Controls.Add(menuListBox);

            // Agregar opciones al ListBox del menú
            menuListBox.Items.Add("[1] Consultar disponibilidad de vuelos");
            menuListBox.Items.Add("[2] Consultar inventario de hotelería");
            menuListBox.Items.Add("[3] Consultar solicitudes de paquetes de clientes");
            menuListBox.Items.Add("[4] Consultar reservas");
            menuListBox.Items.Add("[5] Ver mi presupuesto actual");
            menuListBox.Items.Add("[6] Salir");
        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcionSeleccionada = menuListBox.SelectedIndex + 1;

            switch (opcionSeleccionada)
            {
                case 1:
                    ModuloVuelos.ConsultarDisponibilidadVuelos(this);
                    break;
                case 2:
                    moduloAlojamientos.ConsultarInventarioHoteleria();
                    break;
                case 5:
                    moduloPresupuesto.VerPresupuestoActual();
                    break;
                case 6:
                    Application.Exit();
                    break;
                default:
                    // Opción inválida seleccionada
                    MessageBox.Show("Opción inválida");
                    menuListBox.SelectedIndex = -1;
                    break;
            }
        }

        public void AgregarEtiqueta(string texto, int x, int y)
        {
            Label etiqueta = new Label();
            etiqueta.Text = texto;
            etiqueta.Location = new Point(x, y);
            Controls.Add(etiqueta);
        }
        public TextBox AgregarTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(150, 20);
            Controls.Add(textBox);
            return textBox;
        }
        private ListBox menuListBox;

        public DateTimePicker AgregarDateTimePicker(int x, int y)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new Point(x, y);
            Controls.Add(dateTimePicker);
            return dateTimePicker;
        }

        public NumericUpDown AgregarNumericUpDown(int x, int y)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Location = new Point(x, y);
            numericUpDown.Size = new Size(50, 20);
            Controls.Add(numericUpDown);
            return numericUpDown;
        }

        public Button AgregarBoton(string texto, int x, int y)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Location = new Point(x, y);
            Controls.Add(boton);
            return boton;
        }

        public void LimpiarFormulario()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ListBox listBox)
                {
                    listBox.Items.Clear();
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Today;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
        }

        private void MenuVentas_Load_1(object sender, EventArgs e)
        {

            //Mostrar el menú de ventas

            menuListBox = new ListBox();
            menuListBox.Location = new Point(10, 150);
            menuListBox.Size = new Size(200, 100);
            menuListBox.SelectedIndexChanged += MenuListBox_SelectedIndexChanged;
            Controls.Add(menuListBox);

            // Agregar opciones al ListBox del menú
            menuListBox.Items.Add("[1] Consultar disponibilidad de vuelos");
            menuListBox.Items.Add("[2] Consultar inventario de hotelería");
            menuListBox.Items.Add("[3] Consultar solicitudes de paquetes de clientes");
            menuListBox.Items.Add("[4] Consultar reservas");
            menuListBox.Items.Add("[5] Ver mi presupuesto actual");
            menuListBox.Items.Add("[6] Salir");
        }
    }
}
