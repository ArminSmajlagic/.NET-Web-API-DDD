﻿using Domain.Models.Common;
using Domain.Repositories;

namespace Infrastructure.Repositories.Banking
{
    public class BillingRepository : IBillingRepository
    {
        //TODO implement stadnard methodes with mongoclient
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseEntity GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
