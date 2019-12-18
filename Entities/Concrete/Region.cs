using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
namespace Entities.Concrete
{
   public  class Region:IEntity
    {
        //  RegionID, RegionDescription
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
