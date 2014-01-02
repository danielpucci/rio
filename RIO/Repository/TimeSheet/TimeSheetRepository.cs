using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Repository.TimeSheet
{
    public class TimeSheetRepository : ITimeSheetRepository
    {        
        public Modelo.RioEntities DBContext = new RioEntities();

        IEnumerable<Modelo.Alocacao> ITimeSheetRepository.GetAlocacao(int id)
        {
            return ((IEnumerable<Modelo.Alocacao>)DBContext.Alocacao);
        }

        IEnumerable<Modelo.Livro> ITimeSheetRepository.GetLivro(int id)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.PostAlocacao(string value)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.PostLivro(string value)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.PutLivro(int id, string value)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.PutAlocacao(int id, string value)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.DeleteLivro(int id)
        {
            throw new NotImplementedException();
        }

        bool ITimeSheetRepository.DeleteAlocacao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
