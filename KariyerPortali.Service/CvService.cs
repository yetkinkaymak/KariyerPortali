using KariyerPortali.Data.Infrastructure;
using KariyerPortali.Data.Repositories;
using KariyerPortali.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerPortali.Service
{
    public interface ICvService
    {
        IEnumerable<Cv> GetCvs();
        Cv GetCv(int id);
        void CreateCv(Cv cv);
        void SaveCv();
    }
    public class CvService : ICvService
    {
        private readonly ICvRepository cvRepository;
        private readonly IUnitOfWork unitOfWork;

        public CvService(ICvRepository cvRepository, IUnitOfWork unitOfWork)
        {
            this.cvRepository = cvRepository;
            this.unitOfWork = unitOfWork;
        }
        #region ICvService Members
        public IEnumerable<Cv> GetCvs()
        {
            var cvs = cvRepository.GetAll();
            return cvs;
        }

        public Cv GetCv(int id)
        {
            var cv = cvRepository.GetById(id);
            return cv;
        }

        public void CreateCv(Cv cv)
        {
            cvRepository.Add(cv);
        }

        public void SaveCv()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
    
}
