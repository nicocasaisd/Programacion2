using System.Text;

namespace C06_EI03
{
    public partial class ContadorPalabras : Form
    {
        public ContadorPalabras()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = ObtenerPodio(contadorPalabras);

            MostrarPodio(podio);
        }

        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            // convertimos el dict en una lista de Key Value Pairs
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            // ordenamos
            podio.Sort(CompararCantidadRepeticiones);

            return podio;
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string,int> primerElemento,
            KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                for(int i=0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} Cantidad: {par.Value}");
                }
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    sb.AppendLine($"Palabra: {par.Key} Cantidad: {par.Value}");
                //}
            }

            MessageBox.Show(sb.ToString(), "Podio");
        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            // propiedad Text
            string texto = rtx_Palabras.Text;
            //Separo en palabras usando Split()
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {

                if (contadorPalabras.ContainsKey(palabra))
                {
                    // incremento el valor en esa key
                    contadorPalabras[palabra]++;
                }
                else
                {
                    // si no contiene la key la agrego e inicio en 1
                    contadorPalabras.Add(palabra, 1);
                }
            }
            return contadorPalabras;
        }
    }
}