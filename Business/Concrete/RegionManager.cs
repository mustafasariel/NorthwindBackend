using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RegionManager : IRegionService
    {
        private readonly IRegionDal _regionDal;
        public RegionManager(IRegionDal regionDal)
        {
            _regionDal = regionDal;
        }

        public IResult Add(Region region)
        {
            _regionDal.Add(region);
            return new SuccesResult(Messages.RegionAdd);
        }

        public IResult Delete(Region region)
        {
            _regionDal.Delete(region);
            return new SuccesResult(Messages.RegionDeleted);
        }

        public IDataResult<Region> GetById(int regionId)
        {
            return new SuccessDataResult<Region>(_regionDal.Get(r => r.RegionID == regionId));
        }

        public IDataResult<List<Region>> GetList()
        {
            return new SuccessDataResult<List<Region>>(_regionDal.GetList().ToList());
        }

        public IResult Update(Region region)
        {
            _regionDal.Update(region);
            return new SuccesResult(Messages.RegionUpdated);
        }
    }
}
