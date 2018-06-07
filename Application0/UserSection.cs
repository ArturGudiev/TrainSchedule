using System;
using System.Collections.Generic;
using System.Linq;
using Ubiq.Graphics;
using System.Threading.Tasks;

namespace Application0
{
    partial class Application0
    {
        public Controller currentController;
        public bool changed = false;

        protected async Task UserSection()
        {
            currentController = MainController.getInstance(this);
            for (; ; )
            {
                currentController.action();
                while (changed)
                {
                    changed = false;
                    currentController.action();
                }
                await Wait();
            }
        }

    }

}
