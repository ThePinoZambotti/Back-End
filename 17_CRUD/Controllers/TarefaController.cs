using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;


namespace _17_CRUD.Controllers
{
    //Criando a classe TarefaController e herdando seus métodos de Controller
    public class TarefaController : Controller
    {
        //Criando um objeto _tarefas que armazenará uma lista de tarefas
        private static List<Tarefa> _tarefa = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefa);
        }

        //Criando o método para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //VErificando o total de tarefas da lista e somando mais 1 para o ID
            novaTarefa.Id = _tarefa.Count + 1;
            
            //Adicionando minha nova tarefa à minha lsita
            _tarefa.Add(novaTarefa);

            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            //Estou buscando na minha lista
            Tarefa tarefaBD = _tarefa.FirstOrDefault(t => t.Id == Id);

            //Verificando se encontrou a tarefa, se ela não é null
            if (tarefaBD == null)
                return NotFound();

            //Enviando para a View a tarefa encontrada que queremos alterar
            return View(tarefaBD);    
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefaEditando)
        {
            //Buscando tarefa da lista
            Tarefa tarefaBD = _tarefa.Find(t => t.Id == tarefaEditando.Id);

            //Verificando se encontrou ela
            if (tarefaBD == null)
                return NotFound();

            //Atualizando os dados da tarefa qua já está na lista    
            tarefaBD.Descricao = tarefaEditando.Descricao;
            tarefaBD.Concluida = tarefaEditando.Concluida;

            //Redirecionando para a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int Id)
        {
            Tarefa tarefaBD = _tarefa.FirstOrDefault(t => t.Id == Id);
            if (tarefaBD == null)
                return NotFound();
            return View(tarefaBD);    
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaBD = _tarefa.Find(t => t.Id == tarefaDeletando.Id);

            if (tarefaBD == null)
                return NotFound();
 
            _tarefa.Remove(tarefaBD);

            return RedirectToAction("Index");
        }
    }
}