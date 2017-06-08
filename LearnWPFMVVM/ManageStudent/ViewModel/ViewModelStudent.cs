using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ManageStudent.Model;

namespace ManageStudent.ViewModel
{
    class ViewModelStudent:BaseViewModel
    {
        private IList<ModelStudent> m_StudentList;
        private DataSet m_StudentDS;

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
    }
}
