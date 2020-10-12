using System.Drawing;

namespace EngraveCenterer.Models
{
    public class Cover
    {
        public Size CoverSize { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public bool UpsideDown { get; set; }
    }
}
