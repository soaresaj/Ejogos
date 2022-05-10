using Ejogos.Models;
using System.Collections.Generic;

namespace Ejogos.Interface
{
    public interface IEquipe
    {
        //contrato
        //São os métodos que são obrigatórios em uma classe

        void Criar(Equipe novaequipe );
        List<Equipe> LerEquipes();

    }
}
