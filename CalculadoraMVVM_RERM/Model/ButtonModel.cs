using CalculadoraMVVM_RERM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMVVM_RERM.Model
{
    public class ButtonModel:ViewModelBase
    {
        public string _backgroundColor;
        public bool _selected;
        public string _textColor;
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
        public bool Selected
        { 
            get { return _selected; } 
            set {  SetProperty(ref _selected, value); }
        }
        public string TextColor
        {
            get { return _textColor; }
            set { SetValue(ref _textColor, value); }
        }
    }
}
