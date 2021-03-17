﻿using System;
using System.Windows.Input;

namespace ViewModelsSamples
{
    public class Command : ICommand
    {
        private Action<object> command;
        public event EventHandler CanExecuteChanged;

        public Command(Action<object> command)
        {
            this.command = command;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => command(parameter);
    }
}
