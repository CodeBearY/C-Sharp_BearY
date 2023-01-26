using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearning_Backend.Infrastructure.Domain.Model
{
    class Planet
    {
        //[Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float? Temperature { get; set; }

    }
}
