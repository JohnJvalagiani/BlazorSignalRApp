using Core.Services.Abstraction;
using IG.Core.Services;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Core.Services.Implementation
{
    public class AuctionPlayService : IAuctionPlayService
    {
        private readonly IRepo<Lot> _lotRepo;

        public AuctionPlayService(IRepo<Lot> lotRepo)
        {
           
            _lotRepo = lotRepo;
        }

        public async Task<bool> CancelLastBid(object lotId,int AuctionerId)
        {

            var currentlot = await _lotRepo.GetById(lotId);

            var lastBid = currentlot.tradeHistory.Bids.LastOrDefault(b=>int.Parse(b.playerId)== AuctionerId);

            currentlot.tradeHistory.Bids.Remove(lastBid);

            var result = await _lotRepo.Update(currentlot);

            if (result==null)
                return false;

            return true;
            
        }

        public async Task<Lot> PlaceBid(object lotId, Bid bid)
        {

            var currentlot = await _lotRepo.GetById(lotId);


            var lastBid= currentlot.tradeHistory.Bids.LastOrDefault();

            if (lastBid.bid > bid.bid)
                return currentlot;


                currentlot.tradeHistory.Bids.Add(bid);


            var result = await _lotRepo.Update(currentlot);

            return result;
        }

      
    }
}
