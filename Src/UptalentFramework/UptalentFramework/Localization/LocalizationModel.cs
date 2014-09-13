using PetaPoco;

namespace UptalentFramework.Localization
{
    public partial class LocalizationModel
    {
        public string Key { get; set; }

        public string Culture { get; set; }

        public string Value { get; set; }
    }
}