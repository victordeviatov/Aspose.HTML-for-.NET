﻿using Aspose.Html.Converters;
using Aspose.Html.Dom.Svg;
using Aspose.Html.Saving;

namespace Aspose.Html.Examples.CSharp.Conversion
{
    class SVGtoXPS
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory
            string dataDir = RunExamples.GetDataDir_Data();
            // Source SVG document  
            SVGDocument svgDocument = new SVGDocument(dataDir + "input.svg");
            // Initialize XpsSaveOptions 
            XpsSaveOptions options = new XpsSaveOptions()
            {
                BackgroundColor = System.Drawing.Color.Cyan
            };
            // Output file path 
            string outputFile = dataDir + "SVGtoXPS_Output.xps";
            // Convert SVG to XPS 
            Converter.ConvertSVG(svgDocument, options, outputFile);
            // ExEnd:1   
        }
    }
}
