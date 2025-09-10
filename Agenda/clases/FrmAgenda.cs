using Agenda.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;


namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        private string rutaArchivo = "agenda.json"; //  nombre del archivo JSON
        private bool cambiosPendientes = false;     //  bandera que nos dice si hubo cambios y necesitamos guardar
        private BaseDatosJson baseDatos = new BaseDatosJson();  // aquí almacenamos la lista de personas cargada o para guardar
        public FrmAgenda()
        {
            InitializeComponent();
            CargarDatosDesdeArchivo();
            // Suscribir eventos
            dGVAgenda.CellValueChanged += dGVAgenda_CellValueChanged;
            timer1.Tick += timer1_Tick;
            timer1.Start(); // Empieza el temporizador
        }
        private void CargarDatosDesdeArchivo()
        {
            if (File.Exists(rutaArchivo))  // Verifica que el archivo exista
            {
                try
                {
                    string json = File.ReadAllText(rutaArchivo); // Lee el contenido
                    baseDatos = JsonConvert.DeserializeObject<BaseDatosJson>(json); // Convierte JSON a objeto

                    if (baseDatos == null) // Por si está vacío o da error
                        baseDatos = new BaseDatosJson();

                    ActualizarDataGrid();     // Mostrar en la tabla
                    ActualizarStatusStrip();  // Actualizar la barra de estado
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar archivo: " + ex.Message);
                }
            }
        }
        private void ActualizarDataGrid()
        {
            dGVAgenda.Rows.Clear();
            foreach (var persona in baseDatos.Personas)
            {
                dGVAgenda.Rows.Add(new object[]
                {
            persona.Nombre,
            persona.ApellidoPaterno,
            persona.ApellidoMaterno,
            persona.Direccion,
            persona.Telefono,
            persona.Correo
                });
            }
        }

        private void ActualizarStatusStrip()
        {
            toolStripStatusLabelRegistros.Text = $"Registros: {baseDatos.TotalRegistros}";
            toolStripStatusLabelFecha.Text = $"Última actualización: {baseDatos.UltimaActualizacion.ToString("dd/MM/yyyy HH:mm:ss")}";
        }
        private void GuardarDatosEnArchivo()
        {
            // Limpia la lista antes de agregar los nuevos datos
            baseDatos.Personas.Clear();

            foreach (DataGridViewRow fila in dGVAgenda.Rows)
            {
                // Ignorar la fila nueva (vacía) para no guardar datos incompletos
                if (fila.IsNewRow) continue;

                // Crea un objeto Persona con los datos de la fila
                var persona = new Persona()
                {
                    Nombre = fila.Cells[0].Value?.ToString() ?? "",
                    ApellidoPaterno = fila.Cells[1].Value?.ToString() ?? "",
                    ApellidoMaterno = fila.Cells[2].Value?.ToString() ?? "",
                    Direccion = fila.Cells[3].Value?.ToString() ?? "",
                    Telefono = fila.Cells[4].Value?.ToString() ?? "",
                    Correo = fila.Cells[5].Value?.ToString() ?? ""
                };

                baseDatos.Personas.Add(persona);
            }

            // actualiza el total y fecha
            baseDatos.TotalRegistros = baseDatos.Personas.Count;
            baseDatos.UltimaActualizacion = DateTime.Now;

            var json = JsonConvert.SerializeObject(baseDatos, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);

            // Resetea la bandera de cambios pendientes
            cambiosPendientes = false;

            // Actualiza el StatusStrip con la nueva info
            ActualizarStatusStrip();
        }

    
    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //  método para evitar que el diseñador falle.
        } 
   
private void dGVAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambiosPendientes = true; // Marca que hubo un cambio pendiente
        }

        // evento del temporizador (Timer)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cambiosPendientes)
            {
                GuardarDatosEnArchivo(); // guarda solo si hubo cambios
            }
        }

    } 
}
