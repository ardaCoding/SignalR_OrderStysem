using SignalR.BusinnesLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinnesLayer.Concrte
{
    public class FeatureManager:IFeatureService
    {
        private readonly IFeatureDal featureDal;
        public FeatureManager(IFeatureDal _featureDal) { 
        featureDal= _featureDal;
        }

        public void Tadd(Feature entity)
        {
          featureDal.add(entity);
        }

        public void TDelete(Feature entity)
        {
            featureDal.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
           return featureDal.GetByID(id);   
        }

        public List<Feature> TGetListAll()
        {
            return featureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            featureDal.Update(entity);
        }
    }
}
