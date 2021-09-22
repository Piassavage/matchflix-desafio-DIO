using System.Collections.Generic;
using MatchFlix.Interfaces;


namespace MatchFlix.Classes
{
   public class FilmeRepositorio : IRepositorio<Video>
    {
        
        private List<Video> listaFilme = new List<Video>();

        public void Atualiza(int id, Video entidade)
        {
            listaFilme[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Video entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Video> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Video RetornaPorId(int id)
        {
            return listaFilme[id];
        }

    }
}