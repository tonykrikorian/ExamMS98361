using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console
{
    public class SystemLog
    {
        [Key]
        public int ID { get; set; }

        public DateTime Fecha { get; set; }

        public string Value { get; set; }
    }
}
