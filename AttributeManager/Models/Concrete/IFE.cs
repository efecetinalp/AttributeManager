using AttributeManager.Models.Abstract;
using TCIConstants;

namespace AttributeManager.Models.Concrete
{
    public class IFE : IDepartment
    {
        public string Designation { get; set; }
        public string AttributePath { get; set; }
        public string PresetPath { get; set; }
        public bool HasExtraAttribute { get; set; }

        ConstantsLibrary _constantsLibrary;

        public IFE()
        {
            _constantsLibrary = new ConstantsLibrary();
            Designation = "IFE";
            AttributePath = _constantsLibrary.IFE_ATTRIBUTE_PATH;
            PresetPath = _constantsLibrary.IFE_PRESET_PATH;
            HasExtraAttribute = true;
        }
    }
}
