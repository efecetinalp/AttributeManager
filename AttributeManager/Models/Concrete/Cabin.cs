using AttributeManager.Models.Abstract;
using TCIConstants;

namespace AttributeManager.Models.Concrete
{
    public class Cabin : IDepartment
    {
        public string Designation { get; set; }
        public string AttributePath { get; set; }
        public string PresetPath { get; set; }
        public bool HasExtraAttribute { get; set; }

        ConstantsLibrary _constantsLibrary;

        public Cabin()
        {
            _constantsLibrary = new ConstantsLibrary();
            Designation = "CABIN";
            AttributePath = _constantsLibrary.CABIN_ATTRIBUTE_PATH;
            PresetPath = _constantsLibrary.CABIN_PRESET_PATH;
            HasExtraAttribute = false;
        }
    }
}
