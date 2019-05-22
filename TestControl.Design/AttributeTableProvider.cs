using System;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Model;
using TestControl.Design;
using System.ComponentModel;

[assembly: ProvideMetadata(typeof(AttributeTableProvider))]

namespace TestControl.Design {


    public class AttributeTableProvider : IProvideAttributeTable {
        public AttributeTable AttributeTable {
            get {
                AttributeTableBuilder builder = new AttributeTableBuilder();
                //builder.AddCustomAttributes("MyLibrary.MyControl", new DescriptionAttribute(Strings.MyControlDescription);
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlDefaultInitializer)));
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlContextMenuProvider)));
                return builder.CreateTable();
            }
        }
    }
}
