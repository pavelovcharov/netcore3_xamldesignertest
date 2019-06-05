using System;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using TestControl.Design;
using Microsoft.VisualStudio.DesignTools.Extensibility;

[assembly: ProvideMetadata(typeof(AttributeTableProvider))]

namespace TestControl.Design {

    public static class AttributeTableBuilderExtensions {
        private const string CompanyToolboxCategoryPath = "Test Category/";
        private const string CompanyToolboxTabName = "Test Tab";
        public static void RegisterControls(this AttributeTableBuilder builder, string categoryPath, params string[] controlTypes) {
            builder.ShowControls(controlTypes);
            builder.AddAttribute(new ToolboxCategoryAttribute(CompanyToolboxCategoryPath + categoryPath), controlTypes);
            builder.AddAttribute(new ToolboxTabNameAttribute(CompanyToolboxTabName + categoryPath), controlTypes);
        }
        public static void ShowControls(this AttributeTableBuilder builder, params string[] controlTypes) {
            builder.AddAttribute(ToolboxBrowsableAttribute.Yes, controlTypes);
        }
        public static void AddAttribute(this AttributeTableBuilder builder, Attribute attribute, params string[] controlTypes) {
            foreach(var type in controlTypes)
                builder.AddCustomAttributes(type, attribute);
        }
    }

    public class AttributeTableProvider : IProvideAttributeTable {
        public AttributeTable AttributeTable {
            get {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                

                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlAdornerProvider)));//should be first?
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlDefaultInitializer)));
                builder.AddCustomAttributes("TestControl.TestControl", new FeatureAttribute(typeof(TestControlContextMenuProvider)));


                builder.RegisterControls("test_cat", "TestControl.TestControl");

                return builder.CreateTable();
            }
        }
    }
}
