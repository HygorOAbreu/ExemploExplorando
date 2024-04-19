
using ExemploExplorando.Models;

//Instanciando uma classe Atraves de Construtor.
Pessoa p1 = new Pessoa(nome: "Hygor",sobrenome: "de Abreu");   
//Instanciando uma classe e dando valores para a propriedade atraves do set.  
// setando (set) um valor para a propriedade.
//p1.Nome = "Hygor";
//p1.Idade = 34;
//p1.sobrenome = "de Abreu";
Pessoa p2 = new Pessoa("Bruno", "Giriotas");     
//p2.Nome = "Bruno";
//p2.Idade = 38;
//p2.sobrenome = "Giriotas";


//utilizando a propriedade apresentar para apresentar ao usuario uma mensagem com as informações atribuidas.
// p1.Apresentar();
// p2.Apresentar();
// Instanciando a classe curso, criando uma aub categoria para os cursos de inglês.
Curso cursoDeIngles = new Curso();
// definindo o a nome do novo curso.
cursoDeIngles.nomeCurso = "Inglês";
// definindo uma lista de armazenamento de alunos para o curso de inglês(das as informações geradas ficam em metadados).
cursoDeIngles.Alunos = new List<Pessoa>();
//adicionando pessoas a lista de membros do curso.
cursoDeIngles.AdicionarAluno(p1);
// listando alunos contidos na lista de alunos.
//adicionando pessoas a lista de membros do curso.
cursoDeIngles.AdicionarAluno(p2);
//lista todos os alunos integrantes do curso de inglês.
cursoDeIngles.listarAlunos();








