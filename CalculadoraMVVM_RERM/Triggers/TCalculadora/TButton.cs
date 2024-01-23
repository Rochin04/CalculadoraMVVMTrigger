using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculadoraMVVM_RERM.Triggers.TCalculadora
{
    public class TButton:TriggerAction<Button>
    {
        public bool activation { get; set; }
        //protected override async void Invoke(Button button)
        //{
        //    if (activation == true)
        //    {
        //        button.BackgroundColor = Color.White;
        //        await button.RelRotateTo(360, 5000, Easing.BounceOut);
        //    }
        //    if (activation == false)
        //    {
        //        button.BackgroundColor = new Button().BackgroundColor;
        //        button.Rotation = new Button().Rotation;
        //    }
        //}
        protected override async void Invoke(Button button)
        {
            if (activation == true)
            {
                button.BackgroundColor = Color.White;
                button.TextColor = Color.Black;
            }
            if (activation == false)
            {
                button.BackgroundColor = new Button().BackgroundColor;
                button.BackgroundColor = new Button().TextColor;
            }
        }
    }
}
