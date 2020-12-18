using Core.Services.Abstraction;
using IG.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace Core.Services.Implementation
{
    public class AuctionManagerService : IAuctionManagerService
    {
        private readonly UserManager<Trader> _userManager;
        private readonly IRepo<Lot> _lotRepo;
        private readonly IRepo<TradeHistory> _tradeHistoryRepo;



        public AuctionManagerService(UserManager<Trader> userManager ,IRepo<Lot> lotRepo)
        {
            _userManager = userManager;
            _lotRepo = lotRepo;
        }


        public async Task<TradeHistory> AddTradeHistory(object lotId,Bid bid)
        {

            var thelot=await _lotRepo.GetById(lotId);

            thelot.tradeHistory.Bids.Add(bid);

            var result=  await  _lotRepo.Update(thelot);


            return result.tradeHistory;
        }

        public async Task<Lot> LotRegistration(Lot lot)
        {

            var result=await _lotRepo.Add(lot);

            return result;

        }
    }
}
