﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oven_Interface.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.00683333")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("-4.84517")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("823.974")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int ActiveProgramId {
            get {
                return ((int)(this["ActiveProgramId"]));
            }
            set {
                this["ActiveProgramId"] = value;
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
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int powerplantPin {
            get {
                return ((int)(this["powerplantPin"]));
            }
            set {
                this["powerplantPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int temperatureUpPin {
            get {
                return ((int)(this["temperatureUpPin"]));
            }
            set {
                this["temperatureUpPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int temperatureDownPin {
            get {
                return ((int)(this["temperatureDownPin"]));
            }
            set {
                this["temperatureDownPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int lightsPin {
            get {
                return ((int)(this["lightsPin"]));
            }
            set {
                this["lightsPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int waterSolenoidPin {
            get {
                return ((int)(this["waterSolenoidPin"]));
            }
            set {
                this["waterSolenoidPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int openVentilationPin {
            get {
                return ((int)(this["openVentilationPin"]));
            }
            set {
                this["openVentilationPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int closeVentilationPin {
            get {
                return ((int)(this["closeVentilationPin"]));
            }
            set {
                this["closeVentilationPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int waterCounterPin {
            get {
                return ((int)(this["waterCounterPin"]));
            }
            set {
                this["waterCounterPin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int canChangeTempsAgainAfter {
            get {
                return ((int)(this["canChangeTempsAgainAfter"]));
            }
            set {
                this["canChangeTempsAgainAfter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int turnOffTempOperationsAfter {
            get {
                return ((int)(this["turnOffTempOperationsAfter"]));
            }
            set {
                this["turnOffTempOperationsAfter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public long timeToFullyOpenVentilationValve {
            get {
                return ((long)(this["timeToFullyOpenVentilationValve"]));
            }
            set {
                this["timeToFullyOpenVentilationValve"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public long waterClicksPerLiter {
            get {
                return ((long)(this["waterClicksPerLiter"]));
            }
            set {
                this["waterClicksPerLiter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int howOftenToCheckSensors {
            get {
                return ((int)(this["howOftenToCheckSensors"]));
            }
            set {
                this["howOftenToCheckSensors"] = value;
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
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int relayBoardNumber {
            get {
                return ((int)(this["relayBoardNumber"]));
            }
            set {
                this["relayBoardNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int temperatureSensorBoardNumber {
            get {
                return ((int)(this["temperatureSensorBoardNumber"]));
            }
            set {
                this["temperatureSensorBoardNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int waterCounterBoardNumber {
            get {
                return ((int)(this["waterCounterBoardNumber"]));
            }
            set {
                this["waterCounterBoardNumber"] = value;
            }
        }
    }
}
