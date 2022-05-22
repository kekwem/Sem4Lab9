using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> Data()
        {
            List<string> lista_adresow = new List<string>();
            foreach (var element in listBox.Items)
            {
                lista_adresow.Add(element.ToString());
            }
            return lista_adresow;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                listBox.Items.Add(textBox.Text);
            }
        }

        public static async Task<string> Download(string adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres);
                Console.WriteLine(adres + " pobrany!");
                return result;
            }
        }

        private async void pobierzButton_Click(object sender, EventArgs e)
        {
            /*
            var lista = Data();
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (string adres in lista)
            {
                tasks.Add(Download(adres));
            }
            var t = await Task.WhenAll(tasks);
            foreach (var result in t)
            {
                Console.WriteLine(result);
            }
            */

            var lista = Data();
            List<Task<string>> tasks = new List<Task<string>>();
            Parallel.For(0, listBox.Items.Count, i => tasks.Add(Download(lista[i])));
            
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
