using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Delegues
{
    public delegate void extensionsMain(string[] args);
    public class VisualStudioCode
    {
        public List<VisualStudioCodeExtension> Extensions { get; set; }
        public extensionsMain ExecExtension = null;

        public VisualStudioCode(params VisualStudioCodeExtension[] extensions)
        {
            Extensions = new List<VisualStudioCodeExtension>();
            foreach (VisualStudioCodeExtension extension in extensions)
            {
                Extensions.Add(extension);
            }
            foreach  (VisualStudioCodeExtension extension in Extensions)
            {
                ExecExtension += extension.Main;
            }
            ExecExtension(null);
        }
    }
}
