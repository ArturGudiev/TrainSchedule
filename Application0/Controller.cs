//Generated material. Generating code in C#.

using System;
using Ubiq.Graphics;
using System.Collections.Generic;

namespace Application0
{
    public abstract class Controller
    {
        protected Screen Screen;
        protected Application0 app;

        public Controller(Application0 app)
        {
            this.app = app;
            this.Screen = app.Screen;
        }

        public abstract void action();
    }


    public class MainController : Controller
    {
        TextBlock Title;
        ListBox ListBox;
        Button backButton;
        TextBlock FromLabel;
        TextBlock ToLabel;
        DropBox DropBox1;
        DropBox DropBox2;
        StackPanel LabelPanel;
        StackPanel DropBoxPanel;
        Button showButton;

        private int stateIndex = 1;
        private static MainController instance;

        private MainController(Application0 app) : base(app)
        {
        }

        public static MainController getInstance(Application0 app)
        {
            if (instance == null)
                instance = new MainController(app);
            return instance;
        }

        enum MainControllerState
        {
            State2,
            State1,
        }

        private MainControllerState controllerState = MainControllerState.State1;

        public override void action()
        {
            switch (controllerState)
            {
                case MainControllerState.State2:
                    showState2();


                    if (stateIndex == 1)
                    {
                        controllerState = MainControllerState.State1;
                        this.app.changed = true;
                    }

                    break;

                case MainControllerState.State1:
                    showState1();


                    if (stateIndex == 2)
                    {
                        controllerState = MainControllerState.State2;
                        this.app.changed = true;
                    }

                    break;
            }
        }

        private void showState2()
        {
            Title = new TextBlock
            {VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true,
                Font = new Font(new FontFamily("Arial"), 16), Foreground = new SolidColorBrush(Colors.White),
                Text = "Санкт-Петербург : Университет"
            };
            ListBox = new ListBox
            {
                Children =
                {
                    new Cell{Content = new TextBlock {Text = "06:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "06:20           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "06:40           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "07:00           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "07:30           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "08:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "08:30           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "09:13           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "09:45           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "10:30           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "13:10           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "13:40           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "14:40           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "15:40           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "16:00           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "16:30           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "17:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "17:20           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "17:40           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "18:00           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "18:15           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "18:30           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "18:45           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "19:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "19:15           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "19:30           по рабочим", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "20:10           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "20:30           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "21:15           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "22:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "23:00           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    new Cell{Content = new TextBlock {Text = "23:55           ежедневно", VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center, WrapContent = true, Font = new Font(new FontFamily("Arial"),  12), Foreground = new SolidColorBrush(Colors.White),},},
                    
                }
                
                ,
            };
            backButton = new Button
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = new SolidColorBrush(Colors.Gray),
                Foreground = new SolidColorBrush(Colors.Black),
                Padding = new Thickness(Screen.NormalFontSize),
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"), 0.5 * Screen.LargeFontSize),
                Text = "Назад"
            };
            backButton.Pressed += (sender, args) =>
            {
                stateIndex = 1;
                
            }; 
            var panel = new StackPanel
            {
                Children =
                {
                    new Cell {Content = Title, Height = 70},
                    new Cell {Content = ListBox},
                    new Cell {Content = backButton, Height = 70},
                },
                Background = new SolidColorBrush(Colors.Black),
            };
            Screen.Content = panel;
        }

        private void showState1()
        {
            FromLabel = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"), 16),
                Foreground = new SolidColorBrush(Colors.White),
                Text = "Откуда"
            };
            ToLabel = new TextBlock
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"), 16),
                Foreground = new SolidColorBrush(Colors.White),
                Text = "Куда"
            };
            DropBox1 = new DropBox
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Padding = new Thickness(Screen.NormalFontSize),
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"),
                    0.5 * Screen.LargeFontSize),
                ItemList = new List<string>(
                    "Мартышкино=Университет=Старый Петергоф=Новый Петергоф=Стрельна=Сергиево=Сосновая Полняна=Лигово=Ульянка=Дачное=Ленинский Проспект=Санкт-Петербург"
                        .Split('=')),
            };
            DropBox2 = new DropBox
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Padding = new Thickness(Screen.NormalFontSize),
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"),
                    0.5 * Screen.LargeFontSize),
                ItemList = new List<string>(
                    "Мартышкино=Университет=Старый Петергоф=Новый Петергоф=Стрельна=Сергиево=Сосновая Полняна=Лигово=Ульянка=Дачное=Ленинский Проспект=Санкт-Петербург"
                        .Split('=')),
            };
            LabelPanel = new StackPanel
            {
                Children =
                {
                    new Cell {Content = FromLabel},
                    new Cell {Content = ToLabel},
                },
                Orientation = Orientation.Horizontal
            };
            DropBoxPanel = new StackPanel
            {
                Children =
                {
                    new Cell {Content = DropBox1},
                    new Cell {Content = DropBox2},
                },
                Orientation = Orientation.Horizontal
            };
            showButton = new Button
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = new SolidColorBrush(Colors.Gray),
                Foreground = new SolidColorBrush(Colors.Black),
                Padding = new Thickness(Screen.NormalFontSize),
                WrapContent = true,
                Font = new Font(new FontFamily("Arial"), 0.5 * Screen.LargeFontSize),
                Text = "Показать расписание"
            };
            showButton.Pressed += (sender, args) => { stateIndex = 2; }; 
            var panel = new StackPanel
            {
                Children =
                {
                    new Cell {Content = LabelPanel},
                    new Cell {Content = DropBoxPanel},
                    new Cell {Content = showButton},
                },
                Background = new SolidColorBrush(Colors.Black),
            };
            Screen.Content = panel;
        }
    }
}