using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using OrleanSilo.Interfaces;

namespace OrleanSilo.Grains
{
    public class Manager : Grain, IManager
    {
        private IEmployee _me;
        private readonly List<IEmployee> _reports = new List<IEmployee>();

        public Task<List<IEmployee>> GetDirectReports()
        {
            return Task.FromResult(_reports);
        }

        public Task AddDirectReport(IEmployee employee)
        {
            _reports.Add(employee);
            employee.SetManager(this);
            employee.Greeting(_me, "Welcome to my team!");
            return TaskDone.Done;
        }

        public Task<IEmployee> AsEmployee()
        {
            return Task.FromResult(_me);
        }

        public override Task OnActivateAsync()
        {
            _me = GrainFactory.GetGrain<IEmployee>(this.GetPrimaryKey());
            return base.OnActivateAsync();
        }
    }
}