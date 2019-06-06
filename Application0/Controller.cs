using System.Collections.Generic;
using System.Runtime.InteropServices;
using Ubiq.Graphics;

namespace Application0
{
    public abstract class Controller
    {
        protected Screen Screen;
            private Application0 app;
            public Controller(Application0 app)
            {
                this.app = app;
                this.Screen = app.Screen;
            }

        public abstract void action();
           
        
    }
    
    public class Controller1 : Controller
    {
        private static Controller1 instance ;
        public static Controller1 getInstance(Application0 app)
        {
            if (instance == null)
                instance = new Controller1(app);
            return instance;
        }
        
        Button goButton;
        private TextBlock source;
        private TextBlock target;
        private DropBox dropBox1;
        private DropBox dropBox2;
        private ListBox listBox;
        
        enum Controller1State
        {
            State1,
            State2,
        }
        TextBlock getTextBlock(string str, double fsize = 0)
        {

            return new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,                   // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,               // Horizontal alignment within the parent control
                WrapContent = true,                                             // If we don't set WrapContent attribute, the text block will 
                Font = new Font(new FontFamily("Arial"),fsize == 0 ? Screen.LargeFontSize : fsize ), // Font for drawing text. LargeFontSize is a predefined constant
                Text = str
            };
        }
        private Controller1(Application0 app) : base(app){}
        private Controller1State controllerState = Controller1State.State1;

        bool SwitchState()
        {
            controllerState = controllerState == Controller1State.State1 ? Controller1State.State2 : Controller1State.State1;
            return true;
        }
        public override void action()
        {
            switch (controllerState)
            {
                case Controller1State.State1:
                    showState1();
                    break;
                case Controller1State.State2:
                    showState2();
                    break;
            }
        }
        
        private void showState1()
        {
            #region stat1
            goButton = new Button
            {
                VerticalAlignment = VerticalAlignment.Center,           // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,       // Horizontal alignment within the parent control
                Background = new SolidColorBrush(Colors.Gray),         // Color of button
                Foreground = new SolidColorBrush(Colors.Black),        // Color of text written on button   
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
                // on client device screen size
                WrapContent = true,                                     // The button "wraps" its text with given padding
                Font = new Font(new FontFamily("Arial"),               // Font for drawing text
                                 0.5 * Screen.LargeFontSize),           // LargeFontSize is a predefined constant that depends on client device screen size         
                Text = "Показать расписание",
            };

            source = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,                   // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,               // Horizontal alignment within the parent control
                WrapContent = true,                                             // If we don't set WrapContent attribute, the text block will 
                Font = new Font(new FontFamily("Arial"), Screen.LargeFontSize), // Font for drawing text. LargeFontSize is a predefined constant
                Text = "Откуда",
            };

            target = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,                   // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,               // Horizontal alignment within the parent control
                WrapContent = true,                                             // If we don't set WrapContent attribute, the text block will 
                Font = new Font(new FontFamily("Arial"), Screen.LargeFontSize), // Font for drawing text. LargeFontSize is a predefined constant
                Text = "Куда",
            }; 
            dropBox1 = new DropBox
            {
                VerticalAlignment = VerticalAlignment.Center,           // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,       // Horizontal alignment within the parent control
                //Background = new SolidColorBrush(Colors.White),         // Color of button
                //Foreground = new SolidColorBrush(Colors.White),        // Color of text written on button   
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
                // on client device screen size
                WrapContent = true,                                     // The button "wraps" its text with given padding
                Font = new Font(new FontFamily("Arial"),               // Font for drawing text
                                 0.5 * Screen.LargeFontSize),           // LargeFontSize is a predefined constant that depends on client device screen size                      
                ItemList = new List<string>(new string[] { "Мартышкино", "Университет", "Старый Петергоф", "Новый Петергоф",
                "Стрельна", "Сергиево", "Сосновая Полняна", "Лигово", "Ульянка", "Дачное", "Ленинский Проспект", "Санкт-Петербург"}),
            };

            dropBox2 = new DropBox
            {
                VerticalAlignment = VerticalAlignment.Center,           // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,       // Horizontal alignment within the parent control
                //Background = new SolidColorBrush(Colors.White),         // Color of button
                //Foreground = new SolidColorBrush(Colors.White),        // Color of text written on button   
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
                // on client device screen size
                WrapContent = true,                                     // The button "wraps" its text with given padding
                Font = new Font(new FontFamily("Arial"),               // Font for drawing text
                                 0.5 * Screen.LargeFontSize),           // LargeFontSize is a predefined constant that depends on client device screen size  
                ItemList = new List<string>(new string[] { "Мартышкино", "Университет", "Старый Петергоф", "Новый Петергоф",
                "Стрельна", "Сергиево", "Сосновая Полняна", "Лигово", "Ульянка", "Дачное", "Ленинский Проспект", "Санкт-Петербург"}),
            };
            #endregion
            goButton.Pressed += (s, e) => SwitchState();
            DropBox dropBox = new DropBox { };
         
            var panel = new StackPanel
            {
                Children =  
                {
                    new Cell{ 
                     Content = 
                        new StackPanel{
                        Orientation = Orientation.Horizontal,
                        Children = {   
                           new Cell{Content = new StackPanel{ Children = {new Cell{Content = source}, new Cell{Content = dropBox1,}}, Orientation = Orientation.Vertical}},
                           new Cell{Content = new StackPanel{ Children = {new Cell{Content = target}, new Cell{Content = dropBox2}}, Orientation = Orientation.Vertical}},
                      }
                    }
                    }, 
                    new Cell {Content = goButton},
                },

                
            };
            Screen.Content = panel;
        }
        
         private void showState2()
        {
            goButton = new Button
            {
                Visibility = Visibility.Hidden,
                VerticalAlignment = VerticalAlignment.Center,           // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,       // Horizontal alignment within the parent control
                Background = new SolidColorBrush(Colors.Gray),         // Color of button
                Foreground = new SolidColorBrush(Colors.Black),        // Color of text written on button   
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
                // on client device screen size
                WrapContent = true,                                     // The button "wraps" its text with given padding
                Font = new Font(new FontFamily("Arial"),               // Font for drawing text
                    0.5 * Screen.LargeFontSize),           // LargeFontSize is a predefined constant that depends on client device screen size         
                Text = "Назад",
            };
            
            var source = dropBox1.ItemList[dropBox1.Index];
            var target = dropBox2.ItemList[dropBox2.Index];
            var textBlock = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,                   // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,               // Horizontal alignment within the parent control
                WrapContent = true,                                             // If we don't set WrapContent attribute, the text block will 
                Height = 50,
                Font = new Font(new FontFamily("Arial"), Screen.LargeBasicFontSize), // Font for drawing text. LargeFontSize is a predefined constant
                Text = source + " : " + target,
                Foreground = new SolidColorBrush(Colors.Black),
            };
            goButton.Pressed += (s, e) => SwitchState();
            var textState2 = getTextBlock(dropBox2.Index.ToString());
            listBox = new ListBox
            {
                Children = {
                new Cell{Content = getTextBlock("06:00           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("06:20           по рабочим", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("06:40           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("07:00           по рабочим", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("07:30           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("08:00           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("08:30           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("09:13           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("09:45           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("10:30           по рабочим", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("13:10           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("13:40           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("14:40           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("15:40           ежедневно", Screen.SmallFontSize), Height = 30},
                new Cell{Content = getTextBlock("16:00           по рабочим", Screen.SmallFontSize), Height = 30}},
            };
             
            //var target = getTextBlock("Target");
            var panel = new StackPanel
            {
                Children =  
                {
                    new Cell {Content = textBlock, Height = 70},                   
                    new Cell {Content = listBox},
                    new Cell {Content = goButton, Height = 70},
                },
                Background = new SolidColorBrush(Colors.Black),
            };
            Screen.Content = panel;
        }
    }
}