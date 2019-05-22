using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Interaction;
using Microsoft.VisualStudio.DesignTools.Extensibility.Model;
using Microsoft.VisualStudio.DesignTools.Extensibility.Policies;

namespace TestControl.Design {
    public class SmartTagFeatureConnector : FeatureConnector<TestControlAdornerProvider> {
        public SmartTagFeatureConnector(FeatureManager manager) : base(manager) {
        }
    }
    public class SmartTagAdornerSelectionPolicy : SelectionPolicy {
        protected override IEnumerable<ModelItem> GetPolicyItems(Selection selection) {
            return base.GetPolicyItems(selection);
        }
    }
    [UsesItemPolicy(typeof(SmartTagAdornerSelectionPolicy))]
    [FeatureConnector(typeof(SmartTagFeatureConnector))]
    public class TestControlAdornerProvider : AdornerProvider {
        public TestControlAdornerProvider() {
            Canvas canvas = new Canvas();
            canvas.HorizontalAlignment = HorizontalAlignment.Stretch;
            canvas.VerticalAlignment = VerticalAlignment.Stretch;
            canvas.Children.Add(new Button { Content = "button in adorner" });
            canvas.Background = Brushes.Yellow;
            Panel.Children.Add(canvas);
        }
        protected AdornerPanel Panel {
            get {
                if(panel == null)
                    panel = CreateAdornerPanel();
                return panel;
            }
        }
        AdornerPanel panel;
        protected virtual AdornerPanel CreateAdornerPanel() {
            AdornerPanel panel = new AdornerPanel();
            panel.IsContentFocusable = true;
            AdornerProperties.SetOrder(panel, AdornerOrder.Foreground);
            Adorners.Add(panel);
            return panel;
        }
        protected override void Activate(ModelItem item) {
            base.Activate(item);
        }

    }
}
