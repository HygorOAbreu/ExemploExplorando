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

        public void AdicionarAluno(Pessoa aluno) // adiciona um aluno a lista de alunos.
        {
            Alunos.Add(aluno);
        }
        public bool removerAluno(Pessoa aluno) // remove um aluno da lista de alunos.
        {
           return Alunos.Remove(aluno);
        }
        public void listarAlunos() /// lista todos os alunos matriculados.
        {
            Console.WriteLine($"Os alunos do curso de {nomeCurso} são:");
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine ($"{aluno.nomeCompleto}");
            }
        }
        public int obterAlunosMatriculado() // retorna a quantidade de alunos matriculados.
        {
           int quantidade = Alunos.Count;
           return quantidade;
        }

    }
}