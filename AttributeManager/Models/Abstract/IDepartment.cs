using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeManager.Models.Abstract
{
    public interface IDepartment
    {
        public string Designation { get; set; }
        public string AttributePath { get; set; }
        public string PresetPath { get; set; }
        public bool HasExtraAttribute { get; set; }
    }
}
