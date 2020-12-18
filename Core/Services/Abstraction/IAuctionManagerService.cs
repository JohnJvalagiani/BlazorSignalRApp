using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Core.Services.Abstraction
{

   public interface IAuctionManagerService
    {

        Task<Lot> LotRegistration(Lot lot);
        Task<TradeHistory> AddTradeHistory(object LotId,Bid bid);
       
        
    }
}
