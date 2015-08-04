using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Evapotranspiration
{
    public class Precipitation : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Precipitation()
        {
        }

        protected override void OnClick()
        {
            //Connect Prec_Form to Precipitation.cs
            Prec_Form form = new Prec_Form();
            form.ShowDialog();
        }

        protected override void OnUpdate()
        {
        }
    }
}
