﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ManageStudent.Views.student
{
    /// <summary>
    /// Interaction logic for searchForm.xaml
    /// </summary>
    public partial class searchForm : Window
    {
        public searchForm()
        {
            InitializeComponent();
        }
        public void Init()
        {
            List<string> caption = new List<string>();
            caption.Add(My.Resources.searchFormStudent.lblcaptionSearch);
            
        }
    }
}
