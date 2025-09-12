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
    //valeria rubi castañeda hernandez
    public partial class FrmAgenda : Form
    {
        // ruta del archivo JSON en la carpeta del ejecutable
        private string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "agenda.json");

        public FrmAgenda()
        {
            InitializeComponent();

            
            dGVAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            
            CargarDatosDesdeArchivo();

            // eventos para detectar cambios inmediatos en el DataGridView
            dGVAgenda.CellValueChanged += dGVAgenda_CellValueChanged;
            dGVAgenda.UserAddedRow += dGVAgenda_UserChanged;
            dGVAgenda.UserDeletedRow += dGVAgenda_UserChanged;
            dGVAgenda.CurrentCellDirtyStateChanged += dGVAgenda_CurrentCellDirtyStateChanged;
        }

        private void dGVAgenda_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dGVAgenda.IsCurrentCellDirty)
            {
               
                dGVAgenda.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dGVAgenda_UserChanged(object sender, DataGridViewRowEventArgs e)
        {
            GuardarDatosEnArchivo();
        }

        private void dGVAgenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GuardarDatosEnArchivo();
        }

        private void CargarDatosDesdeArchivo()
        {
            if (!File.Exists(rutaArchivo))
            {
                
                var datosIniciales = new BaseDatosJson
                {
                    Personas = new List<Persona>(),
                    TotalRegistros = 0,
                    UltimaActualizacion = DateTime.Now
                };

                GuardarJson(datosIniciales);
            }

            try
            {
                string json = File.ReadAllText(rutaArchivo);
                var baseDatos = JsonConvert.DeserializeObject<BaseDatosJson>(json);

                if (baseDatos == null)
                    baseDatos = new BaseDatosJson();

                ActualizarDataGrid(baseDatos);
                ActualizarStatusStrip(baseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar archivo: " + ex.Message);
            }
        }

        private void ActualizarDataGrid(BaseDatosJson baseDatos)
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

        private void ActualizarStatusStrip(BaseDatosJson baseDatos)
        {
            toolStripStatusLabelRegistros.Text = $"Registros: {baseDatos.TotalRegistros}";
            toolStripStatusLabelFecha.Text = $"Última actualización: {baseDatos.UltimaActualizacion:dd/MM/yyyy HH:mm:ss}";
        }

        private BaseDatosJson CargarDatosDesdeGrid()
        {
            var baseDatos = new BaseDatosJson();
            foreach (DataGridViewRow fila in dGVAgenda.Rows)
            {
                if (fila.IsNewRow) continue;

                var persona = new Persona
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

            baseDatos.TotalRegistros = baseDatos.Personas.Count;
            baseDatos.UltimaActualizacion = DateTime.Now;
            return baseDatos;
        }

        private void GuardarDatosEnArchivo()
        {
            var baseDatos = CargarDatosDesdeGrid();
            GuardarJson(baseDatos);
            ActualizarStatusStrip(baseDatos);
        }

        private void GuardarJson(BaseDatosJson datos)
        {
            var configuracion = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(datos, configuracion);
            File.WriteAllText(rutaArchivo, json);
        }

       
    }
}
