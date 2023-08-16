using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle_Management
{
    
    internal class Motorcycle
    {
        // Attribute 'ID' is used to store the number for each type of motorcycle.
        public string ID { get; set; }

        // The property 'OwnerName' contains the name of the owner of this motorcycle.
        public string OwnerName { get; set; }

        // The 'Brand' attribute is used to store the brand or manufacturer of the motorcycle.
        public string Brand  { get; set; }

        // The 'Image' property is used to store the image path and location of this motorcycle.
        public string Image { get ; set; }

        // The 'Date' attribute stores the production date of this motorcycle
        public string Date { get; set; }

        // the 'Describe' property is used to store a description or additional information about this motorcycle
        public string Describe { get; set; }
    }
}


