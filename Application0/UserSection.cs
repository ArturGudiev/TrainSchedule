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
        private Controller controller1;
        private Controller currentController;
        
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
                Padding = new Thickness(Screen.NormalFontSize),        // Padding is using predefined constant NormalFontSize that depends
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
            for(int i = 0; i < list.Count; i++){
                sp.Children.Add(list[i]);
            }
            return sp;
        }   

        protected async Task UserSection()
        {
            controller1 = Controller1.getInstance(this);
            currentController = controller1;
            for (; ; )
            {
                currentController.action();
                await Wait();
            }
        }

       

    }

}





