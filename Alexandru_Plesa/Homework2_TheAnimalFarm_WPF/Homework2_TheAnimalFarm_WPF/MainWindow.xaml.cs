using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Homework2_TheAnimalFarm;

namespace Homework2_TheAnimalFarm_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AllAnimalsButton.ApplyTemplate();
        }

        AnimalFarm animalFarm = new AnimalFarm();
        ArrayList animalsInFarm = new ArrayList();
        TextBlock animalsDisplayed = new TextBlock();
        private static readonly Regex _regex = new Regex("[^0-9.-]+");

        private void PopulateFarmButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox textBox = InputAnimalNumber;
            animalsDisplayed = AnimalsTextBlock;
            TextBlock summaryTextBlock = SummaryTextBlock;
            int animalNumber = Convert.ToInt32(textBox.Text);


            animalsInFarm = animalFarm.GenerateAnimals(animalNumber);

            animalsDisplayed.Text = filterAnimals(animalsInFarm);
            summaryTextBlock.Text = numberOfEachAnimalType(animalsInFarm);
        }

        
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        public string filterAnimals(ArrayList animals)
        {
            string animalsString = "";

            foreach (Animal animal in animals)
            {
                if (DogsButton.IsChecked == true && animal.GetType() == typeof(Dog))
                {
                    animalsString += animal.ToString() + "\n ";
                }
                else if (CowsButton.IsChecked == true && animal.GetType() == typeof(Cow))
                {
                    animalsString += animal.ToString() + "\n ";
                }
                else if (PigsButton.IsChecked == true && animal.GetType() == typeof(Pig))
                {
                    animalsString += animal.ToString() + "\n ";
                }
                else if (CatsButton.IsChecked == true && animal.GetType() == typeof(Cat))
                {
                    animalsString += animal.ToString() + "\n ";
                }
                else if (AllAnimalsButton.IsChecked == true)
                {
                    animalsString += animal.ToString() + "\n ";
                }
            }
            return animalsString;
        }

        public string numberOfEachAnimalType(ArrayList animals)
        {
            string animalsString = "";
            int pigs = 0;
            int cows = 0;
            int dogs = 0;
            int cats = 0;

            foreach (Animal animal in animals)
            {
                if (animal.GetType() == typeof(Pig))
                {
                    pigs++;
                } else if (animal.GetType() == typeof(Cow))
                {
                    cows++;
                } else if (animal.GetType() == typeof(Dog))
                {
                    dogs++;
                } else
                {
                    cats++;
                }
            }

            animalsString = $"This farm has: \n{pigs} Pigs,\n{cows} Cows,\n{dogs} Dogs,\n{cats} Cats";

            return animalsString;
        }

        private void AllAnimalsButton_Checked(object sender, RoutedEventArgs e)
        {
            animalsDisplayed.Text = filterAnimals(animalsInFarm);
        }

        private void DogsButton_Checked(object sender, RoutedEventArgs e)
        {
            animalsDisplayed.Text = filterAnimals(animalsInFarm);
        }

        private void CatsButton_Checked(object sender, RoutedEventArgs e)
        {
            animalsDisplayed.Text = filterAnimals(animalsInFarm);
        }

        private void PigsButton_Checked(object sender, RoutedEventArgs e)
        {
            animalsDisplayed.Text = filterAnimals(animalsInFarm);
        }

        private void CowsButton_Checked(object sender, RoutedEventArgs e)
        {
            animalsDisplayed.Text = filterAnimals(animalsInFarm);
        }
    }
}
