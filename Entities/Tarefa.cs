using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Entities
{
    public class Tarefa
    {
        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public Status StatusTarefa { get; set; }  // Referência ao enum, não sabia como fazer por isso pedi ajuda a IA
    }

    public enum Status
    {
        Pendente,
        Executando,
        Finalizada
    }
}