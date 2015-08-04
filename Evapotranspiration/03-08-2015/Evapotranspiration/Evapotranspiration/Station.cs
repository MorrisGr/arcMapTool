using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Evapotranspiration
{
    public class Station : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public Station()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
            
            //Connect Station_Form to Station.cs
            Station_Form form = new Station_Form();
            form.ShowDialog();
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
