using System;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using TestControl.Design;

[assembly: ProvideMetadata(typeof(AttributeTableProvider))]

namespace TestControl.Design {


    public class AttributeTableProvider : IProvideAttributeTable {
        public AttributeTable AttributeTable {
            get {
                AttributeTableBuilder builder = new AttributeTableBuilder();
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlAdornerProvider)));//should be first?
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlDefaultInitializer)));
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlContextMenuProvider)));
                return builder.CreateTable();
            }
        }
    }
}
