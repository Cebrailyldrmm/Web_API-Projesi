using MüsteriFinder.Business.Abstract;
using MüsteriFinder.DataAcess.Abstract;
using MüsteriFinder.DataAcess.Concrete;
using MüsteriFİnder_Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüsteriFinder.Business.Concrete
{
    public class MüsteriManager : IMüsteriService
    {
        private IMüsteri_Repository _müsterirepository;

        public MüsteriManager()
        {
            _müsterirepository=new MüsteriRepository();

        }



        public Müsteri CreateMüsteri(Müsteri müsteri)
        {
          return  _müsterirepository.CreateMüsteri(müsteri);
        }

        public void DeleteMüsteri(int id)
        {
           _müsterirepository.DeleteMüsteri(id);
        }

        public List<Müsteri> GetAllMüsteris()
        {
            return _müsterirepository.GetAllMüsteris();
        }

        public Müsteri GetMüsteriById(int id)
        {
            return _müsterirepository.GetMüsteriById(id);
        }

        public Müsteri UpdateMüsteri(Müsteri müsteri)
        {
            return _müsterirepository.UpdateMüsteri(müsteri);
        }
    }
}
