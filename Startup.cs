using System;
namespace ScriptureJournalApp
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ScriptureJournalDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ScriptureJournalDbContext")));

        services.AddControllersWithViews();
    }
}

