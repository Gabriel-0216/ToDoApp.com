using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NascimentoSoftware.ToDoAppV2.com.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int PrevisaoHoras { get; set; }
        public int HorasUtilizadas { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataRegistro { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataFinalizacao { get; set; }

    }
}
