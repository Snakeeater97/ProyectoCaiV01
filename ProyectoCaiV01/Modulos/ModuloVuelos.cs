using ProyectoCaiV01.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCaiV01.Modulos
{
    public class ModuloVuelos
    {
        private static ListBox vuelosListBox;

        private MenuVentas formulario;

        public MenuVentas llamada { get; set; }

        private ListBox presupuestoListBox;
        private List<string> presupuestoVuelos = new List<string>();

        public static void ConsultarDisponibilidadVuelos(MenuVentas menuVentas)
        {
            menuVentas.LimpiarFormulario();

            menuVentas.AgregarEtiqueta("Origen:", 215, 5);
            TextBox origenTextBox = menuVentas.AgregarTextBox(210, 30);
            menuVentas.AgregarEtiqueta("Destino:", 215, 55);
            TextBox destinoTextBox = menuVentas.AgregarTextBox(210, 80);
            menuVentas.AgregarEtiqueta("Fecha ida:", 215, 110);
            DateTimePicker fechaIdaPicker = menuVentas.AgregarDateTimePicker(215, 140);
            menuVentas.AgregarEtiqueta("Fecha vuelta (opcional):", 215, 200);
            DateTimePicker fechaVueltaPicker = menuVentas.AgregarDateTimePicker(215, 230);
            menuVentas.AgregarEtiqueta("Adultos:", 500, 30);
            NumericUpDown adultosNumericUpDown = menuVentas.AgregarNumericUpDown(500, 55);
            menuVentas.AgregarEtiqueta("Menores:", 500, 85);
            NumericUpDown menoresNumericUpDown = menuVentas.AgregarNumericUpDown(500, 110);
            menuVentas.AgregarEtiqueta("Infantes:", 500, 140);
            NumericUpDown infantesNumericUpDown = menuVentas.AgregarNumericUpDown(500, 165);
            vuelosListBox = new ListBox();
            vuelosListBox.Location = new Point(215, 290);
            vuelosListBox.Size = new Size(1000, 150);
            menuVentas.Controls.Add(vuelosListBox);
        }
    }
}