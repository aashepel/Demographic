using Demographic.Core;
using Demographic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public interface IEngine
    {
        event Action YearTick;
        void OnChildBirth(Person person);
        UInt64 CounterPepoles { get; }
        DeathProbablilityService DeathProbablilityService { get; }
        List<SnapshotYear> SnapshotYears { get; }
        uint CurrentYear { get; }
        void StartImitation(DoWorkEventArgs e);
        void InitEngine(EngineConfig config, BackgroundWorker backgroundWorker, DoWorkEventArgs e);
    }
}
