using dataBinding2ways.Dados;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection.Emit;

namespace dataBinding2ways
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Insercao_Click(object sender, RoutedEventArgs e)//OK
        {
            int quantidadeTarefas = dgTarefas.Items.Count;

            if (quantidadeTarefas < 7)
            {
                Tarefa nova = new Tarefa(entrada.Text.ToString(),false,false,false);
                dgTarefas.Items.Add(nova);
                tarefas.Add(nova);
                entrada.Text = string.Empty;
            }
            else
            {
                entrada.Text = string.Empty;
                System.Windows.MessageBox.Show("Número máximo de tarefas a cadastrar alcançado!");
            }
        }

        private void exclui_Click(object sender, RoutedEventArgs e)
        {
            dgTarefas.Items.Remove(dgTarefas.SelectedItem);
        }

        private void checkFeito(object sender, RoutedEventArgs e)
        {
        }

        private void checkFazendo(object sender, RoutedEventArgs e) {
            System.Windows.MessageBox.Show("Clicou em FAZENDO");
        }
        private void checkPendente(object sender, RoutedEventArgs e) {
            System.Windows.MessageBox.Show("Clicou em PENDENTE");
            
        }
    }
}
