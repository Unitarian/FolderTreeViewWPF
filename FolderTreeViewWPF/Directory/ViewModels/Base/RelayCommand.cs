﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FolderTreeViewWPF
{
    public class RelayCommand : ICommand
    {
        private Action mAction; 
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }

        public RelayCommand(Action action)
        {
            mAction = action;
        }
    }
}
