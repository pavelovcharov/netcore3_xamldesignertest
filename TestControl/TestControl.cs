using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TestControl {
    public class TestControl : ContentControl {
        static TestControl() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TestControl), new FrameworkPropertyMetadata(typeof(TestControl)));
        }
    }
}
