using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Input;
using ManageStudent.Model;
using ManageStudent.Utils;

namespace ManageStudent.ViewModel
{
    class ViewModelStudent:BaseViewModel
    {
        private IList<ModelStudent> m_StudentList;
        private DataSet m_StudentDS;
        private String query;

        public IList<ModelStudent> STUDENTLS
        {
            get
            {
                return m_StudentList;
            }
            set
            {
                this.m_StudentList = value;
                base.PropertyChangedEvent("STUDENTLS");
            }
        }
        public DataSet STUDENTDS
        {
            get
            {
                return m_StudentDS;
            }
            set
            {
                m_StudentDS = value;
                base.PropertyChangedEvent("STUDENTDS");
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return new DelegateCommand(Search);
            }
        }
        public ICommand ViewCommand
        {
            get
            {
                return new DelegateCommand(View, Validation);
            }
        }
        internal void View()
        {

        }
        internal void Search()
        {

        }
        internal bool Validation(object parameter)
        {
            return true;
        }        
    }
}
