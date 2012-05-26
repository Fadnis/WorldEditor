using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database
{
    public interface Core
    {
        string GetCreatureTemplate(uint entry);

        CreatureTemplate CreateCreatureTemplate(object[] data);
    }
}
