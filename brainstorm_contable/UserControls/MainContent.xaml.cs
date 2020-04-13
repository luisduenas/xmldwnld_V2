using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace brainstorm_contable.UserControls
{
    /// <summary>
    /// Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl
    {
        public MainContent()
        {
            InitializeComponent();
        }
        private bool obtenerFoliosYLinks()
        {
            bool result = false;
            try
            {
                //urls = new Dictionary<string, string>();
                //document = webbrowser.Document;
                //links = document.GetElementsByTagName("span");
                //folios = document.GetElementsByTagName("input");
                //links = links.GetElementsByName("BtnDescarga");
                //folios = folios.GetElementsByName("ListaFolios");
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

        private void validaDescarga()
        {
            try
            {
                if (webBrowser.Source.ToString().StartsWith("https://portalcfdi.facturaelectronica.sat.gob.mx"))
                {
                    if (obtenerFoliosYLinks())
                    {
                        //realizaDescarga();
                    }
                }
                else
                {
                    MessageBox.Show("Primero filtre los folios a descargar");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Events
        private void mnDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mnDownload_Click");
        }

        private void mnGoTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mnGoTo_Click");
            validaDescarga();


        }

        private void mnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mnSettings_Click");

        }

        private void mnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mnExport_Click");

        }
    }
}
