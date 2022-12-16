using System;
using BPKB_Project.Data;
using BPKB_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace BPKB_Project.Services.BPKBService
{
	public class BPKBService : IBPKBService
	{
        private readonly DataContext context;

        public BPKBService(DataContext context)
		{
            this.context = context;
        }

        public async Task<BPKB> CreateBPKB(BPKB request)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.bpkbs.Add(request);
                await context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception)
            {
                return null;
            }

            return request;
        }

        public async Task<List<BPKB>> GetAllBPKB()
        {
            var bpkbs = await context.bpkbs.ToListAsync();
            return bpkbs;
        }

        public async Task<List<Location>> GetAllLocation()
        {
            var locations = await context.locations.ToListAsync();
            return locations;
        }
    }
}

