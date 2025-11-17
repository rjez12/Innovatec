using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec
{
    public partial class Form1 : Form
    {
        private ArbolJerarquia arbol;
        private GrafoRutas grafo;
        public Form1()
        {
            InitializeComponent();

            arbol = new ArbolJerarquia();
            grafo = new GrafoRutas();

            // Mensaje inicial de ayuda
            lblResultadoJerarquia.Text = "Agregue la raíz (Director) para empezar.\nDeje 'Nombre del Jefe' vacío.";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string jefe = tbJefe.Text;
            string nombre = tbNuevoEmpleado.Text;
            string cargo = tbNuevoCargo.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Por favor, ingrese nombre y cargo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exito;
            if (arbol.Raiz == null && string.IsNullOrWhiteSpace(jefe))
            {
                // Es el primer empleado (la raíz)
                exito = arbol.AgregarEmpleado(null, nombre, cargo);
                lblResultadoJerarquia.Text = $"{nombre} agregado como la raíz.";
            }
            else
            {
                exito = arbol.AgregarEmpleado(jefe, nombre, cargo);
                if (exito)
                {
                    lblResultadoJerarquia.Text = $"{nombre} agregado bajo {jefe}.";
                }
                else
                {
                    if (arbol.Raiz == null)
                        MessageBox.Show($"Debe agregar la raíz primero (deje 'Nombre del Jefe' vacío).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show($"No se encontró al jefe '{jefe}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ActualizarTreeView(); // Actualizar la vista visual

            // Limpiar y preparar para el siguiente
            tbNuevoEmpleado.Clear();
            tbNuevoCargo.Clear();
            tbJefe.Text = nombre; // Sugerir al recién agregado como próximo jefe
            tbNuevoEmpleado.Focus(); // Poner el cursor listo para el siguiente nombre
        }

        // Esta función "dibuja" nuestro árbol lógico en el control visual TreeView
        private void ActualizarTreeView()
        {
            tvMostrar.Nodes.Clear();
            if (arbol.Raiz != null)
            {
                TreeNode nodoRaizVisual = new TreeNode(arbol.Raiz.TextoNodo);
                LlenarNodosTreeView(arbol.Raiz, nodoRaizVisual);
                tvMostrar.Nodes.Add(nodoRaizVisual);
                tvMostrar.ExpandAll(); // Mostrar todo el árbol desplegado
            }
        }

        // Función recursiva que construye el TreeView (Esto es un RECORRIDO en sí mismo)
        private void LlenarNodosTreeView(NodoOrganizacion nodoLogico, TreeNode nodoVisual)
        {
            foreach (var hijoLogico in nodoLogico.Subordinados)
            {
                TreeNode hijoVisual = new TreeNode(hijoLogico.TextoNodo);
                nodoVisual.Nodes.Add(hijoVisual);

                // Llamada recursiva para los subordinados de este subordinado
                LlenarNodosTreeView(hijoLogico, hijoVisual);
            }
        }

    }
}

