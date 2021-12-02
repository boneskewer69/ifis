using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Bored.Core.Models;
using Bored.Core.Interfaces;

namespace Bored.Core
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;


        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository ??
                throw new ArgumentNullException(nameof(activityRepository));
        }


        public async Task<Activity> LoadRandomActivityAsync()
            => await _activityRepository.GetRandomActivityAsync()
                .ConfigureAwait(false);

        public async Task<List<Activity>> LoadRandomActivitiesAsync(int count)
        {
            var tasks = new List<Task<Activity>>();
            
            // Load a number -count- activities async
            for (int i = 0; i < count; i++)
                tasks.Add(_activityRepository.GetRandomActivityAsync());

            // Wait for all activities to be loaded
            await Task.WhenAll(tasks)
                .ConfigureAwait(false);

            // Put results into list and return em
            var results = new List<Activity>();
            tasks.ForEach(t => results.Add(t.Result));
            return results;
        }

        public List<Activity> LoadRandomActivities(int count)
        {
            var results = new List<Activity>();
            for (int i = 0; i < count; i++)
                results.Add(_activityRepository.GetRandomActivityAsync().Result);
            return results;
        }
    }
}
