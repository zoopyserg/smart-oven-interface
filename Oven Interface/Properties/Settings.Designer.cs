﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oven_Interface.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0023289618877854")]
        public decimal temperatureCoefficientA {
            get {
                return ((decimal)(this["temperatureCoefficientA"]));
            }
            set {
                this["temperatureCoefficientA"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-0.8132904677022324")]
        public decimal temperatureCoefficientB {
            get {
                return ((decimal)(this["temperatureCoefficientB"]));
            }
            set {
                this["temperatureCoefficientB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-60.54023427552839")]
        public decimal temperatureCoefficientC {
            get {
                return ((decimal)(this["temperatureCoefficientC"]));
            }
            set {
                this["temperatureCoefficientC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int channelTemperatureSensor {
            get {
                return ((int)(this["channelTemperatureSensor"]));
            }
            set {
                this["channelTemperatureSensor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int pinTemperatureRelay {
            get {
                return ((int)(this["pinTemperatureRelay"]));
            }
            set {
                this["pinTemperatureRelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int ActiveProgramId {
            get {
                return ((int)(this["ActiveProgramId"]));
            }
            set {
                this["ActiveProgramId"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\OvenDatabase." +
            "mdf;Integrated Security=True")]
        public string OvenDatabaseConnectionString {
            get {
                return ((string)(this["OvenDatabaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string language {
            get {
                return ((string)(this["language"]));
            }
            set {
                this["language"] = value;
            }
        }
    }
}
