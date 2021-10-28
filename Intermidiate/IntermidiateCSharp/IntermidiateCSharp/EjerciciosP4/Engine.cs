using System;
using System.Collections.Generic;
using System.Text;

namespace IntermidiateCSharp.EjerciciosP4
{
    public class Engine
    {

        private readonly List<IActivityWorkflow> _activitiesWorkflow;

        public Engine()
        {
            _activitiesWorkflow = new List<IActivityWorkflow>();
        }

        public void StarWorkflow()
        {
            foreach (var activity in _activitiesWorkflow)
                activity.Execute(new Activity());
        }

        public void RegisterActivity(IActivityWorkflow activityWorkflow)
        {
            _activitiesWorkflow.Add(activityWorkflow);
        }
    }
}
