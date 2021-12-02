using ServiceStack;

namespace Bored.Wpf.Converters
{
    public static class ActivityConverter
    {
        public static Core.Models.Activity ToLogicModel(this Wpf.Models.Activity from)
        {
            if (from == null)
                return null;

            return new Core.Models.Activity()
                .PopulateWith(from);
        }

        public static Wpf.Models.Activity ToWpfModel(this Core.Models.Activity from)
        {
            if (from == null)
                return null;

            return new Wpf.Models.Activity()
                .PopulateWith(from);
        }
    }
}
