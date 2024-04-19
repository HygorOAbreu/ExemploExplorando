using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string nomeCurso;
        public List<Pessoa> Alunos{get; set;}

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public void removerAluno(Pessoa aluno)
        {
           Alunos.Remove(aluno);
        }
        public void listarAlunos()
        {
            Console.WriteLine("Os alunos são:");
            foreach()
            {
                Console.WriteLine ($"{aluno}");
            }
        }
        public string obterAlunosMatriculado
        {
            get;
            set;
        }

    }
}