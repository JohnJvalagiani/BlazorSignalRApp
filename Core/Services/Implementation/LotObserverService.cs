using Core.HelperClasses;
using IG.Core.Services;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Implementation
{
  public  class LotObserverService
    {
        private readonly IRepo<Lot> _lotRepo;



        public LotObserverService(IRepo<Lot> lotRepo)
        {
            this._lotRepo = lotRepo;
        }



        public async Task<bool> RemoveLotFromAuction (Lot lot)
        {

           var thelot= await _lotRepo.GetById(lot);


            await _lotRepo.Remove(thelot.Id);

            return true;



        }

       


        
    }
}
