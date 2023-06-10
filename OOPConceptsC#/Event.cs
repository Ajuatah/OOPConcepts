using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class Event
    {
    }

    public class Button
    {
        // Event declaration
        public event EventHandler Click;

        // Method to raise the event
        public void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
