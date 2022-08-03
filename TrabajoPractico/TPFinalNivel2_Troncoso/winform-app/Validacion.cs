using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    class Validacion
    {
        public bool validarFiltro(ComboBox cboCampo, ComboBox cboCriterio, TextBox text)
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para filtrar");
                return true;
            }
            else if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para filtrar.");
                return true;
            }
            else if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(text.Text))
                {
                    MessageBox.Show("Debes cargar el filtro numero");
                    return true;
                }
                if (!(soloNumeros(text.Text)))
                {
                    MessageBox.Show("Solo se permiten numeros en este campo");
                    return true;
                }
            }
            return false;
        }
        public bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        public bool validartxt(TextBox codigo,TextBox nombre, TextBox descripcion, TextBox precio, TextBox imagenUrl)
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                MessageBox.Show("Debe ingresar el codigo del producto");
                return true;
            }
            else if (string.IsNullOrEmpty(nombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del producto");
                return true;
            }
            else if (string.IsNullOrEmpty(precio.Text))
            {
                MessageBox.Show("Debe ingresar un precio para el producto");
                return true;
            }
            else if (string.IsNullOrEmpty(descripcion.Text))
            {
                DialogResult advertencia = MessageBox.Show("¿Esta seguro de que no quiere agregar una descripcion?", "Articulo sin descripcion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (advertencia == DialogResult.Yes)
                    return false;
                else
                    return true;
            }
            else if (string.IsNullOrEmpty(imagenUrl.Text))
            {
                DialogResult advertencia = MessageBox.Show("¿Esta seguro que no quiere agregar una imagen?", "Articulo sin imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (advertencia == DialogResult.Yes)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
