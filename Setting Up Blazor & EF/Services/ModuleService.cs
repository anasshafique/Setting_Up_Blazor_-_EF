using Microsoft.EntityFrameworkCore;
using Setting_Up_Blazor___EF.Data;
using Setting_Up_Blazor___EF.Data.Models;


namespace Setting_Up_Blazor___EF.Services
{
    public class ModuleService
    {
        IDbContextFactory<ApplicationDbContext> contextFactory;

        public ModuleService(IDbContextFactory<ApplicationDbContext> contextFactory) //dependency injection of the context factory into the service
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Module module)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                //Add module to the dataset
                context.Modules.Add(module);

                //Update the Database with changes
                context.SaveChanges();
            }
        }
    }
}