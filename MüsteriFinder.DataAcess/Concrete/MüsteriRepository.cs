using MüsteriFinder.DataAcess.Abstract;
using MüsteriFİnder_Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüsteriFinder.DataAcess.Concrete
{
    public class MüsteriRepository : IMüsteri_Repository
    {
        public Müsteri CreateMüsteri(Müsteri müsteri)
        {
            using (var müsteriDbContext = new MüsteriDbContext())
            {
                müsteriDbContext.Müsteris.Add(müsteri);
                müsteriDbContext.SaveChanges();
                return müsteri;

            }
        }

        public void DeleteMüsteri(int id)
        {
            using (var müsteriDbContext = new MüsteriDbContext())
            {
                var deleteMüsteri = GetMüsteriById(id);
                müsteriDbContext.Müsteris.Remove(deleteMüsteri);
                müsteriDbContext.SaveChanges();
            }
        }

        public List<Müsteri> GetAllMüsteris()
        {
            using (var müsteriDbContext=new MüsteriDbContext())
            {
                return müsteriDbContext.Müsteris.ToList();
                
            }
        }

        public Müsteri GetMüsteriById(int id)
        {
            using (var müsteriDbContext = new MüsteriDbContext())
            {
                return müsteriDbContext.Müsteris.Find(id);
            }
        }

        public Müsteri UpdateMüsteri(Müsteri müsteri)
        {
            using (var müsteriDbContext = new MüsteriDbContext())
            {
                müsteriDbContext.Müsteris.Update(müsteri);
                return müsteri;
            }
        }
    }
}
