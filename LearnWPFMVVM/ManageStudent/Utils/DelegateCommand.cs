using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManageStudent.Utils
{
    public class DelegateCommand : ICommand
    {
        private  Action commandTask;
        private readonly Predicate<object> canDoWork;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action excute)
        {
            this.commandTask = excute;
        }
        public DelegateCommand(Action excute,Predicate<object> canExcute)
        {
            this.commandTask = excute;
            this.canDoWork = canExcute;
        }
        public bool CanExecute(object parameter)
        {
            if (this.canDoWork == null)
            {
                return true;
            }
            else
            {
                return this.canDoWork(parameter);
            }
        }

        public void Execute(object parameter)
        {
            commandTask();
        }
    }
}
