using System;

namespace Lista1Exercicio02
{
    public class Morador : Pessoa
    {
        public Habitacao hab;

        public Morador(string p_nome, int p_idade, Habitacao p_hab) : base(p_nome, p_idade)
        {
            this.hab = p_hab;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                "Sou um morador, meu nome é {0}, tenho {1} anos, minha habitação tem {2} m2, e a cor da porta é {3}.",
                this.nome,
                this.idade,
                this.hab.area,
                this.hab.porta.cor
            );
        }
    }
}

