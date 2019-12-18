using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRegionService
    {
        IDataResult<Region> GetById(int regionId);
        IDataResult<List<Region>> GetList();

        IResult Add(Region region);
        IResult Delete(Region region);
        IResult Update(Region region);
    }
}
