using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string nomeCurso;
        private List<string> Pessoas = new List<string>();

        public void adicionarAluno()
        {
            Pessoas.Add();

        }
        public void removerAluno(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("o Nome não pode ser vazio");// mensagem de erro caso a propriedade não seja validada.
            }

            Pessoas.Remove(value.ToUpper());
        }
        public void listarAlunos()
        {
            Console.WriteLine("Os alunos são:");
            foreach(string pessoa in Pessoas)
            {
                Console.WriteLine ($"{pessoa}");
            }
        }
        public string obterAlunosMatriculado
        {
            get;
            set;
        }

    }
}