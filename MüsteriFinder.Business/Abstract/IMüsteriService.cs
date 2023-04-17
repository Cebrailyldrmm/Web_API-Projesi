using MüsteriFİnder_Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MüsteriFinder.Business.Abstract
{
    public interface IMüsteriService
    {
        List<Müsteri> GetAllMüsteris();

        Müsteri GetMüsteriById(int id);

        Müsteri CreateMüsteri(Müsteri müsteri);

        Müsteri UpdateMüsteri(Müsteri müsteri);

        void DeleteMüsteri(int id);
    }
}
