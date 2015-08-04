using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ArcMapAddin2
{
    public class Neo : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Neo()
        {
        }

        protected override void OnClick()
        {
            Temperature_Form form = new Temperature_Form();
        }

        protected override void OnUpdate()
        {
        }
    }
}
