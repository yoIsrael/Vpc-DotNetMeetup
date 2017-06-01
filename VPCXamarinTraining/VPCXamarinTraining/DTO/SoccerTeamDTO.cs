using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPCXamarinTraining.DTO
{
    public class SoccerTeamDTO
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string Detail { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
