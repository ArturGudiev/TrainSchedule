//-----------------------------User-section----------------------------------------------------
//  <User-defined part of application>
//
//      This is partial class that can be invoked from main entry point
//      This class is purposed for user-defined bussines logic of the application
//      The user should add proprietary code.
//      All modifications will be preserved during all automatic re-generations of the project
//  </User-defined part of application>
//----------------------------------------------------------------------------------------------


using System;
using Ubiq.Graphics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Application0
{
    partial class Application0
    {

        int _count = 0;
        Input input;
        string name = "";
        bool flag = true;
        Button goButton;
        TextBlock result;
        StackPanel sp;
        TextBlock source;
        TextBlock target;
        DropBox dropBox1;
        DropBox dropBox2;
        StackPanel mainPanel;
        ListBox listBox;
        //Timer event handler.
        //Additional bussiness logic for timer
        enum AppState
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

        Button getButton(string str)
        {
            return new Button
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
                Text = str
            };
        }

        DropBox getDropBox(List<string> list)
        {
            return new DropBox
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
                ItemList = list
            };
        }

        StackPanel getStackPanel(List<string> list)
        {
            List<Cell> listCell = list.Select(a => new Cell { Content = getTextBlock(a) }).ToList();
            var sp = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            listCell.ForEach(e => sp.Children.Add(e));
            return sp;
        }

        StackPanel getStackPanel(List<VisualElement> list, Orientation or)
        {
            StackPanel sp = new StackPanel
            {
                Orientation = or,
                Children = { },
            };
            //list.ForEach(el => sp.Children.Add(el));
            for(int i = 0; i < list.Count; i++){
                sp.Children.Add(list[i]);
            }
            return sp;
        }

        private AppState appState = AppState.State1;

        bool SwitchState()
        {
            Console.WriteLine("In console");
            appState = appState == AppState.State1 ? AppState.State2 : AppState.State1;
            
            return true;
        }

        //User section for bussines logic
        //Your code should be inserted here
        protected async Task UserSection()
        {

            source = getTextBlock("Source");
            target = getTextBlock("Target");

            input = new Input
            {
                VerticalAlignment = VerticalAlignment.Center,           // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,       // Horizontal alignment within the parent control
                Background = new SolidColorBrush(Colors.Gray),         // Color of button
                Foreground = new SolidColorBrush(Colors.Black),        // Color of text written on button   
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
                // on client device screen size
                WrapContent = true,
                Width = 200,
                Text = ""
            };

            goButton = getButton("Go");
            result = getTextBlock("University -> SPb");

            sp = getStackPanel(new List<string> { "a", "b", "c" });
            sp.Visibility = Visibility.Collapsed;

            //Setting content of the active screen
            
            
            //showState1();
            
            //The infinite loop which prevents this application from unloading from the server
            for (; ; )
            {
                switch (appState)
                {
                    case AppState.State1:
                            showState1();
                            break;
                    case AppState.State2:
                            showState2();
                            break;
                }
                // Wait for user action or dispatcher event
                await Wait();
            }
        }

        private void showState2()
        {
            goButton = getButton("Back");
            
            var source = dropBox1.ItemList[dropBox1.Index];
            var target = dropBox2.ItemList[dropBox2.Index];
            //var textBlock = getTextBlock(source + " -> " + target);
            var textBlock = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,                   // Vertical alignment within the parent control
                HorizontalAlignment = HorizontalAlignment.Center,               // Horizontal alignment within the parent control
                WrapContent = true,                                             // If we don't set WrapContent attribute, the text block will 
                Height = 50,
                Font = new Font(new FontFamily("Arial"), Screen.LargeBasicFontSize), // Font for drawing text. LargeFontSize is a predefined constant
                Text = source + " : " + target,
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
                }
            };
            Screen.Content = panel;
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
         
            var textState1 = getTextBlock("State1");
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
                }
            };
            Screen.Content = panel;
        }
    }

}





