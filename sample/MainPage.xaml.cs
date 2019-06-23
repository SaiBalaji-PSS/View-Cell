using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LST.ItemsSource = new List<Class1>
            {
                new Class1{name="Steve Wozniak",detail="Co-Founder of Apple Computers",imgurl="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Steve_Wozniak%2C_November_2018.jpg/220px-Steve_Wozniak%2C_November_2018.jpg"},
                new Class1{name="Paul Allen",detail="Co-Founder of Microsoft",imgurl="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Paul_G._Allen_%28cropped%29.jpg/220px-Paul_G._Allen_%28cropped%29.jpg"},
                new Class1{name="Bill Gates",detail="Founder of Microsoft",imgurl="https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Bill_Gates_July_2014.jpg/220px-Bill_Gates_July_2014.jpg"},
                new Class1{name="Steve jobs",detail="Founder of Apple Computers",imgurl="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Steve_Jobs_Headshot_2010-CROP2.jpg/220px-Steve_Jobs_Headshot_2010-CROP2.jpg"},
                new Class1{name="Linus Torvalds",detail="Principal developer of Linux Kernel",imgurl="https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/LinuxCon_Europe_Linus_Torvalds_03_%28cropped%29.jpg/220px-LinuxCon_Europe_Linus_Torvalds_03_%28cropped%29.jpg"}
            };

        }
    }
}
