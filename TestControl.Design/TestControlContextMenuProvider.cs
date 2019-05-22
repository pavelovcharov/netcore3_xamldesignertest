using System.Windows;
using Microsoft.VisualStudio.DesignTools.Extensibility.Interaction;

namespace TestControl.Design {

    public class TestControlContextMenuProvider : ContextMenuProvider {
        public TestControlContextMenuProvider() {
            UpdateItemStatus += TestControlContextMenuProvider_UpdateItemStatus;
        }

        private void TestControlContextMenuProvider_UpdateItemStatus(object sender, MenuActionEventArgs e) {
            var action1 = new MenuAction("msgbox");
            action1.Execute += Action1_Execute;
            Items.Add(action1);
            Items.Add(new MenuAction("test action2"));
        }

        private void Action1_Execute(object sender, MenuActionEventArgs e) {
            MessageBox.Show("TestControlContextMenuProvider_UpdateItemStatus!");
        }
    }
}
