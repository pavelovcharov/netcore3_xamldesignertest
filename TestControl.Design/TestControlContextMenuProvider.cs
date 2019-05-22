using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Interaction;
using Microsoft.VisualStudio.DesignTools.Extensibility.Model;

namespace TestControl.Design {

    public class TestControlContextMenuProvider : ContextMenuProvider {
        public TestControlContextMenuProvider() {
            UpdateItemStatus += TestControlContextMenuProvider_UpdateItemStatus;
        }

        private void TestControlContextMenuProvider_UpdateItemStatus(object sender, MenuActionEventArgs e) {
            Items.Add(new MenuAction("test action"));
        }
    }
}
