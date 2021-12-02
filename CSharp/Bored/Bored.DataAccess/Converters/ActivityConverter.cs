using ServiceStack;

namespace Bored.DataAccess.Converters
{
    public static class ActivityConverter
    {
        public static Core.Models.Activity ToLogicModel(this ServiceModel.Models.Activity from)
        {
            if (from == null)
                return null;

            return new Core.Models.Activity()
                .PopulateWith(from);
        }

        public static ServiceModel.Models.Activity ToServiceModel(this Core.Models.Activity from)
        {
            if (from == null)
                return null;

            return new ServiceModel.Models.Activity()
                .PopulateWith(from);
        }
    }
}
