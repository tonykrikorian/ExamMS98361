using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console
{
    class CustomEvents
    {
        public event EventHandler changes;

        private string name;

        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    changes += R_CustomChanges;
                    name = value;
                    this.changes(this, EventArgs.Empty);
                }
                else
                {
                    changes += R_CustomChanges;
                    changes(this, EventArgs.Empty);
                }
                
            }
        }

        public void ErrorEventHander(object sender, EventArgs e)
        {
            CustomEvents r = (CustomEvents)sender;

            System.Console.WriteLine($"Valor {r.Name} es invalido");
        }

        public void R_CustomChanges(object sender, EventArgs e)
        {
            CustomEvents custom = (CustomEvents)sender;
            System.Console.WriteLine($"El Valor Introducido es {(string.IsNullOrEmpty(custom.Name)? "Invalido":custom.Name)}");
            using (var context = new DataContext())
            {
                SystemLog log = new SystemLog()
                {
                    Fecha = DateTime.Now,
                     Value = ((string.IsNullOrEmpty(custom.Name))? "Error valor vacio" : custom.Name)
                };

                context.SystemLogs.Add(log);
                context.SaveChanges();
            }

        }
    }
}
