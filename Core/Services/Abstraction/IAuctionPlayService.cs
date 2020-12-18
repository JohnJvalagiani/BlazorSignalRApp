using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstraction
{
    public interface IAuctionPlayService
    {

        Task<Lot> PlaceBid(object lotId,Bid bid);
        Task<bool> CancelLastBid(object id,int auctioneerId);
    }
}
