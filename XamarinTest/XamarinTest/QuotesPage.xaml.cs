using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quotes : ContentPage
    {
        public Quotes()
        {
            InitializeComponent();

            r = new Random();
            quotes = new string[]
            {
                "The secret of life is honesty and fair dealing. If you can fake that, you've got it made. - Groucho Marx",
                "I refuse to join any club that would have me as a member. - Groucho Marx",
                "Outside of a dog, a book is a man's best friend. Inside of a dog it's too dark to read. - Groucho Marx",
                "Those are my principles, and if you don't like them... well, I have others. - Groucho Marx",
                "Go, and never darken my towels again. - Groucho Marx"
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            randomquotelabel.Text = GenerateQuote();
        }

        private int num;
        private string[] quotes;
        private Random r;

        public string GenerateQuote()
        {
            num = r.Next(1, 5);
            return quotes[num];
        }

        /* private void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string quote = e.NewValue.ToString();

            if (e.OldValue <= 27)
            {
                e.NewValue.ToString("Quote1");
            }

            if (e.OldValue >= 28 | e.OldValue <= 39)
            {
                e.NewValue.ToString("Quote2");
            }

            if (e.OldValue >= 40)
            {
                e.NewValue.ToString("Quote3");
            }
        } */
    }
}