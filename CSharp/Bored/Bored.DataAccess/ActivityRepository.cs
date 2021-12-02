using System;
using System.Threading.Tasks;

using ServiceStack;

using Bored.Core.Interfaces;
using Bored.Core.Configuration;
using Bored.DataAccess.Converters;
using Bored.ServiceModel;

namespace Bored.DataAccess
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly JsonServiceClient _client;
        private readonly BoredApiConfiguration _apiConfiguration;


        public ActivityRepository(BoredApiConfiguration apiConfiguration)
        {
            _apiConfiguration = apiConfiguration ??
                throw new ArgumentNullException(nameof(apiConfiguration));

            _client = new JsonServiceClient(_apiConfiguration.BaseUrl);
        }


        public async Task<Core.Models.Activity> GetRandomActivityAsync()
        {
            var response = await _client.GetAsync(new GetActivity())
                .ConfigureAwait(false);

            if (response == null)
                throw new ArgumentNullException(nameof(response), "Could not load activity.");

            return response.ToLogicModel();
        }
    }
}
