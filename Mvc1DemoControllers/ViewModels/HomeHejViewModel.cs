using System.Collections.Generic;

namespace Mvc1DemoControllers.ViewModels
{
    // DTO 
    public class HomeHejViewModel
    {
        public string Username { get; set; }
        public List<string> Books { get; set; } = new List<string>();
    }
}