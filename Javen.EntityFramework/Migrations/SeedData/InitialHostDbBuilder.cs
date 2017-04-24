using Javen.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Javen.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly JavenDbContext _context;

        public InitialHostDbBuilder(JavenDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
