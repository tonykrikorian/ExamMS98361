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
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                    this.changes(this, EventArgs.Empty);
                }
                else
                {
                    this.changes(this, EventArgs.Empty);
                }
                
            }
        }
    }
}
