using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Bored.Core.Models;

namespace Bored.Core.Interfaces
{
    public interface IActivityService
    {
        Task<Activity> LoadRandomActivityAsync();
        Task<List<Activity>> LoadRandomActivitiesAsync(int count);
        [Obsolete("Just use the async version please - this performs very baldy!")]
        List<Activity> LoadRandomActivities(int count);
    }
}
