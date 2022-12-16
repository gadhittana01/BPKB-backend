using System;
using BPKB_Project.Models;

namespace BPKB_Project.Services.BPKBService
{
	public interface IBPKBService
	{
        Task<List<Location>> GetAllLocation();

        Task<List<BPKB>> GetAllBPKB();

        Task<BPKB> CreateBPKB(BPKB request);
    }
}

