using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TestControl {
    [TestToolBox]
    public class TestControl : ContentControl {
        static TestControl() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TestControl), new FrameworkPropertyMetadata(typeof(TestControl)));
        }
    }

    public class TestControl2 : ContentControl {
        static TestControl2() {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(TestControl), new FrameworkPropertyMetadata(typeof(TestControl)));
        }
    }


    public class TestToolBoxAttribute : Attribute {

    }
}
