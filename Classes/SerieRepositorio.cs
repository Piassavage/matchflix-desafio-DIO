using System.Collections.Generic;
using MatchFlix.Interfaces;

namespace MatchFlix.Classes
{
    public class SerieRepositorio : IRepositorio<Video>
    {
        
        private List<Video> listaSerie = new List<Video>();

        public void Atualiza(int id, Video entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Video entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Video> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Video RetornaPorId(int id)
        {
            return listaSerie[id];
        }

    }
}