using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Battery
    {

        public int BatteryId { get; set; }
        public int ChargerId { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<Charger> Chargers { get; set; }
    }
}
