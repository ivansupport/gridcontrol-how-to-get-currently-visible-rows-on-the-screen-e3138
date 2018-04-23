﻿// Developer Express Code Central Example:
// How to get visible rows on the screen
// 
// You should get a DataPresenter. This dependency object supports the IScrollInfo
// interface. This interface provides the VerticalOffset and ViewportHeight
// properties. In fact, the VerticalOffset property is a VisibleIndex for the first
// row, but the ViewprotHeight is a number of visible rows. Use the
// GridControl.GetRowHandleByVisibleIndex method to get the first visible and last
// visible row handles. If the last row handle is not valid, it means that you try
// to parse empty space, and the last row handle on the screen is the last row
// within row handles.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3138

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}