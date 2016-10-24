using KariyerPortali.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerPortali.Data
{
    public class KariyerPortaliSeedData : DropCreateDatabaseIfModelChanges<KariyerPortaliEntities>
    {
        protected override void Seed(KariyerPortaliEntities context)
        {
            GetCvs().ForEach(c => context.Cvs.Add(c));

            context.Commit();
        }

        private static List<Cv> GetCvs()
        {
            return new List<Cv>
            {
                new Cv {
                    CvName = "Murat Demirci"
                },
                new Cv {
                    CvName = "Şamil Yılmaz"
                }
            };
        }

    }
}
