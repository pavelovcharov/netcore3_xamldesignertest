using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Model;

namespace TestControl.Design {

    public class TestControlDefaultInitializer : DefaultInitializer {
        public override void InitializeDefaults(ModelItem item) {
            item.Properties["Width"].SetValue(800d);
            base.InitializeDefaults(item);
        }
    }
}
