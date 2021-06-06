﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopApp.Core
{
    class OservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
