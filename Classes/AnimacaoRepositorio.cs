using System.Collections.Generic;
using MatchFlix.Interfaces;

namespace MatchFlix.Classes
{
    public class AnimacaoRepositorio : IRepositorio<Video>
    {
        
        private List<Video> listaAnimacao = new List<Video>();

        public void Atualiza(int id, Video entidade)
        {
            listaAnimacao[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaAnimacao[id].Excluir();
        }

        public void Insere(Video entidade)
        {
            listaAnimacao.Add(entidade);
        }

        public List<Video> Lista()
        {
            return listaAnimacao;
        }

        public int ProximoId()
        {
            return listaAnimacao.Count;
        }

        public Video RetornaPorId(int id)
        {
            return listaAnimacao[id];
        }

    }
}