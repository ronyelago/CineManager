using System;

namespace CineManager.Classes
{
    public class Genero
    {
        private string id;
        private string nome;

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value.Length > 4 || value.Length < 4)
                {
                    throw new Exception("O Id de um Gênero deve ter 4 letras.");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value.Length > 25 || value == string.Empty)
                {
                    throw new Exception("Um Gênero pode conter no máximo 25 letras e não pode ser nulo.");
                }
                else
                {
                    this.nome = value;
                }
            }
        }
    }
}
