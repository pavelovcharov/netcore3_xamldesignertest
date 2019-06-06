using Microsoft.VisualStudio.DesignTools.Extensibility;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManifestCreator.NetFramework {
    class Program {
        static void Main(string[] args) {

            var assembly = Assembly.LoadFrom("TestControl.designtools.dll");

            var attribute = assembly.GetCustomAttribute<ProvideMetadataAttribute>();

            var type = attribute.MetadataProviderType;
            
            
            var metadataProvider = (IProvideAttributeTable)Activator.CreateInstance(type);

            var attributeTable = metadataProvider.AttributeTable;

            foreach(var typeIdentifier in attributeTable.AttributedTypeIdentifiers) {
                var attrs = attributeTable.GetCustomAttributes(typeIdentifier);
                var browsable = attrs.Cast<Attribute>().OfType<ToolboxBrowsableAttribute>().FirstOrDefault()?.Browsable;
                var category = attrs.Cast<Attribute>().OfType<ToolboxCategoryAttribute>().FirstOrDefault()?.CategoryPath;
                var tabName = attrs.Cast<Attribute>().OfType<ToolboxTabNameAttribute>().FirstOrDefault()?.TabName;

                Console.WriteLine($"browasable: {browsable}, category: {category}, tabName: {tabName}");
            }
        }
    }
}
