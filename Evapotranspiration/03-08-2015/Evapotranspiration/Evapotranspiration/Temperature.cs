using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Evapotranspiration
{
    public class Temperature : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Temperature()
        {
        }

        protected override void OnClick()
        {
            //Connect Temp_form to Temperature.cs
            Temp_Form form = new Temp_Form();
            form.ShowDialog();
        }

        protected override void OnUpdate()
        {
        }
    }
}
