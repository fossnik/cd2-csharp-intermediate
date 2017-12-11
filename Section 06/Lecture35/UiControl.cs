using System;

namespace Lecture35
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Postition TopLeft { get; set; }

        public virtual void Draw()
        {
            
        }

        public void Focus()
        {
            Console.WriteLine("Received focus. ");
        }
    }
}