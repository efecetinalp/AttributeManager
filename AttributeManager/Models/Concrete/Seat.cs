using AttributeManager.Models.Abstract;
using TCIConstants;

namespace AttributeManager.Models.Concrete
{
    public class Seat : IDepartment
    {
        public string Designation { get; set; }
        public string AttributePath { get; set; }
        public string PresetPath { get; set; }
        public bool HasExtraAttribute { get; set; }

        ConstantsLibrary _constantsLibrary;

        public Seat()
        {
            _constantsLibrary = new ConstantsLibrary();
            Designation = "SEAT";
            AttributePath = _constantsLibrary.SEAT_ATTRIBUTE_PATH;
            PresetPath = _constantsLibrary.SEAT_PRESET_PATH;
            HasExtraAttribute = false;
        }
    }
}
