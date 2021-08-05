using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHistory.UserInterface.Helpers
{
    public static class ResourcesHelper
    {
        public const string closeButtonName = "close16.png";
        public static string ResourcesFilePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
    }
}
