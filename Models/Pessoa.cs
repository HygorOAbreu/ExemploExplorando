using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {   
        // propriedade privadas só podem ser modificadas dentro do scopo, ou seja pela propria classe em sí.
        private string _nome;
        // criando uma validação para o nome.
        private int _Idade;
        public string Nome 
        { 
            // obtem um valor
            get => _nome.ToUpper(); // retorna os nomes com todos os valores em maiuscúlo, => (BodyExpressions) utilizado como ponteiro (apontando para a ação que deve ser tomada)

           
            set
            { //atribue um valor.
                if(value == "")
                {
                    throw new ArgumentException("o Nome não pode ser vazio");// mensagem de erro caso a propriedade não seja validada.
                }

                _nome = value; // caso o valor passe pela validação, o valor é atribuido à _nome.
            } 
        } 
        public int Idade 
        { 
            get => _Idade;

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException ("a Idade não pode ser menor ou igual a 0");
                }

                _Idade = value;
            } 
        }  //Propriedade

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


    }
}