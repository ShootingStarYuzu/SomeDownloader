﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DanbooruDownloader3.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string ProxyAddress {
            get {
                return ((string)(this["ProxyAddress"]));
            }
            set {
                this["ProxyAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public string ProxyPort {
            get {
                return ((string)(this["ProxyPort"]));
            }
            set {
                this["ProxyPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseProxy {
            get {
                return ((bool)(this["UseProxy"]));
            }
            set {
                this["UseProxy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LoadPreview {
            get {
                return ((bool)(this["LoadPreview"]));
            }
            set {
                this["LoadPreview"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveQuery {
            get {
                return ((bool)(this["SaveQuery"]));
            }
            set {
                this["SaveQuery"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AppendList {
            get {
                return ((bool)(this["AppendList"]));
            }
            set {
                this["AppendList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoLoadList {
            get {
                return ((bool)(this["AutoLoadList"]));
            }
            set {
                this["AutoLoadList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoLoadNextPage {
            get {
                return ((bool)(this["AutoLoadNextPage"]));
            }
            set {
                this["AutoLoadNextPage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoFocusCurrent {
            get {
                return ((bool)(this["AutoFocusCurrent"]));
            }
            set {
                this["AutoFocusCurrent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%provider%\\%rating% - %id% - %tags%")]
        public string filenameFormat {
            get {
                return ((string)(this["filenameFormat"]));
            }
            set {
                this["filenameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool overwrite {
            get {
                return ((bool)(this["overwrite"]));
            }
            set {
                this["overwrite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150")]
        public string filenameLengthLimit {
            get {
                return ((string)(this["filenameLengthLimit"]));
            }
            set {
                this["filenameLengthLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public string Timeout {
            get {
                return ((string)(this["Timeout"]));
            }
            set {
                this["Timeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MinimizeToTray {
            get {
                return ((bool)(this["MinimizeToTray"]));
            }
            set {
                this["MinimizeToTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SaveFolder {
            get {
                return ((string)(this["SaveFolder"]));
            }
            set {
                this["SaveFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string retry {
            get {
                return ((string)(this["retry"]));
            }
            set {
                this["retry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PadUserAgent {
            get {
                return ((bool)(this["PadUserAgent"]));
            }
            set {
                this["PadUserAgent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyUsername {
            get {
                return ((string)(this["ProxyUsername"]));
            }
            set {
                this["ProxyUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyPassword {
            get {
                return ((string)(this["ProxyPassword"]));
            }
            set {
                this["ProxyPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseProxyLogin {
            get {
                return ((bool)(this["UseProxyLogin"]));
            }
            set {
                this["UseProxyLogin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool batchAbortOnError {
            get {
                return ((bool)(this["batchAbortOnError"]));
            }
            set {
                this["batchAbortOnError"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseColoredTag {
            get {
                return ((bool)(this["UseColoredTag"]));
            }
            set {
                this["UseColoredTag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ControlText")]
        public global::System.Drawing.Color ColorGeneral {
            get {
                return ((global::System.Drawing.Color)(this["ColorGeneral"]));
            }
            set {
                this["ColorGeneral"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HotPink")]
        public global::System.Drawing.Color ColorArtist {
            get {
                return ((global::System.Drawing.Color)(this["ColorArtist"]));
            }
            set {
                this["ColorArtist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue")]
        public global::System.Drawing.Color ColorCopyright {
            get {
                return ((global::System.Drawing.Color)(this["ColorCopyright"]));
            }
            set {
                this["ColorCopyright"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Purple")]
        public global::System.Drawing.Color ColorCharacter {
            get {
                return ((global::System.Drawing.Color)(this["ColorCharacter"]));
            }
            set {
                this["ColorCharacter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OrangeRed")]
        public global::System.Drawing.Color ColorCircle {
            get {
                return ((global::System.Drawing.Color)(this["ColorCircle"]));
            }
            set {
                this["ColorCircle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color ColorFaults {
            get {
                return ((global::System.Drawing.Color)(this["ColorFaults"]));
            }
            set {
                this["ColorFaults"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TagAutoComplete {
            get {
                return ((bool)(this["TagAutoComplete"]));
            }
            set {
                this["TagAutoComplete"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmptyTagReplacement {
            get {
                return ((string)(this["EmptyTagReplacement"]));
            }
            set {
                this["EmptyTagReplacement"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TagBlacklist {
            get {
                return ((string)(this["TagBlacklist"]));
            }
            set {
                this["TagBlacklist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LightGray")]
        public global::System.Drawing.Color ColorBlacklistedTag {
            get {
                return ((global::System.Drawing.Color)(this["ColorBlacklistedTag"]));
            }
            set {
                this["ColorBlacklistedTag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RenameJpeg {
            get {
                return ((bool)(this["RenameJpeg"]));
            }
            set {
                this["RenameJpeg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableLogging {
            get {
                return ((bool)(this["EnableLogging"]));
            }
            set {
                this["EnableLogging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Full")]
        public string ImageSize {
            get {
                return ((string)(this["ImageSize"]));
            }
            set {
                this["ImageSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public string AutoCompleteLimit {
            get {
                return ((string)(this["AutoCompleteLimit"]));
            }
            set {
                this["AutoCompleteLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveFolderWhenExit {
            get {
                return ((bool)(this["SaveFolderWhenExit"]));
            }
            set {
                this["SaveFolderWhenExit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string TagGroupingLimit {
            get {
                return ((string)(this["TagGroupingLimit"]));
            }
            set {
                this["TagGroupingLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string TagCopyrigthGrouping {
            get {
                return ((string)(this["TagCopyrigthGrouping"]));
            }
            set {
                this["TagCopyrigthGrouping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string TagCharacterGrouping {
            get {
                return ((string)(this["TagCharacterGrouping"]));
            }
            set {
                this["TagCharacterGrouping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string TagCircleGrouping {
            get {
                return ((string)(this["TagCircleGrouping"]));
            }
            set {
                this["TagCircleGrouping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string TagFaultsGrouping {
            get {
                return ((string)(this["TagFaultsGrouping"]));
            }
            set {
                this["TagFaultsGrouping"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TagIgnored {
            get {
                return ((string)(this["TagIgnored"]));
            }
            set {
                this["TagIgnored"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IgnoreTagsUseRegex {
            get {
                return ((bool)(this["IgnoreTagsUseRegex"]));
            }
            set {
                this["IgnoreTagsUseRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BlacklistTagsUseRegex {
            get {
                return ((bool)(this["BlacklistTagsUseRegex"]));
            }
            set {
                this["BlacklistTagsUseRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public string delay {
            get {
                return ((string)(this["delay"]));
            }
            set {
                this["delay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool enableCookie {
            get {
                return ((bool)(this["enableCookie"]));
            }
            set {
                this["enableCookie"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateRequired {
            get {
                return ((bool)(this["UpdateRequired"]));
            }
            set {
                this["UpdateRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ControlDarkDark")]
        public global::System.Drawing.Color ColorUnknown {
            get {
                return ((global::System.Drawing.Color)(this["ColorUnknown"]));
            }
            set {
                this["ColorUnknown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseGlobalProviderTags {
            get {
                return ((bool)(this["UseGlobalProviderTags"]));
            }
            set {
                this["UseGlobalProviderTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-GB,en-US;q=0.8,en;q=0.6")]
        public string AcceptLanguage {
            get {
                return ((string)(this["AcceptLanguage"]));
            }
            set {
                this["AcceptLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableCompression {
            get {
                return ((bool)(this["EnableCompression"]));
            }
            set {
                this["EnableCompression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideBlacklistedImage {
            get {
                return ((bool)(this["HideBlacklistedImage"]));
            }
            set {
                this["HideBlacklistedImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProcessDeletedPost {
            get {
                return ((bool)(this["ProcessDeletedPost"]));
            }
            set {
                this["ProcessDeletedPost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string BatchJobDelay {
            get {
                return ((string)(this["BatchJobDelay"]));
            }
            set {
                this["BatchJobDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DelayIncludeSkipped {
            get {
                return ((bool)(this["DelayIncludeSkipped"]));
            }
            set {
                this["DelayIncludeSkipped"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WriteDownloadedFile {
            get {
                return ((bool)(this["WriteDownloadedFile"]));
            }
            set {
                this["WriteDownloadedFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isReplaceMode {
            get {
                return ((bool)(this["isReplaceMode"]));
            }
            set {
                this["isReplaceMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsIgnoreForGeneralTagOnly {
            get {
                return ((bool)(this["IsIgnoreForGeneralTagOnly"]));
            }
            set {
                this["IsIgnoreForGeneralTagOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsBlacklistOnlyForGeneralTags {
            get {
                return ((bool)(this["IsBlacklistOnlyForGeneralTags"]));
            }
            set {
                this["IsBlacklistOnlyForGeneralTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiple Artist")]
        public string tagOverArtistValue {
            get {
                return ((string)(this["tagOverArtistValue"]));
            }
            set {
                this["tagOverArtistValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiple Copyright")]
        public string tagOverCopyrightValue {
            get {
                return ((string)(this["tagOverCopyrightValue"]));
            }
            set {
                this["tagOverCopyrightValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiple Character")]
        public string tagOverCharaValue {
            get {
                return ((string)(this["tagOverCharaValue"]));
            }
            set {
                this["tagOverCharaValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiple Circle")]
        public string tagOverCircleValue {
            get {
                return ((string)(this["tagOverCircleValue"]));
            }
            set {
                this["tagOverCircleValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Multiple Fault")]
        public string tagOverFaultValue {
            get {
                return ((string)(this["tagOverFaultValue"]));
            }
            set {
                this["tagOverFaultValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsReplaceUnderscoreTag {
            get {
                return ((bool)(this["IsReplaceUnderscoreTag"]));
            }
            set {
                this["IsReplaceUnderscoreTag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WriteTagFile {
            get {
                return ((bool)(this["WriteTagFile"]));
            }
            set {
                this["WriteTagFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShutdownAfterCompleteBatchJob {
            get {
                return ((bool)(this["ShutdownAfterCompleteBatchJob"]));
            }
            set {
                this["ShutdownAfterCompleteBatchJob"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-dd HH:mm:ss")]
        public string DateTimeFormat {
            get {
                return ((string)(this["DateTimeFormat"]));
            }
            set {
                this["DateTimeFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string filterExtensions {
            get {
                return ((string)(this["filterExtensions"]));
            }
            set {
                this["filterExtensions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) " +
            "Chrome/67.0.3396.99 Safari/537.36")]
        public string UserAgent {
            get {
                return ((string)(this["UserAgent"]));
            }
            set {
                this["UserAgent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No Artist")]
        public string tagNoArtistValue {
            get {
                return ((string)(this["tagNoArtistValue"]));
            }
            set {
                this["tagNoArtistValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No Copyright")]
        public string tagNoCopyrightValue {
            get {
                return ((string)(this["tagNoCopyrightValue"]));
            }
            set {
                this["tagNoCopyrightValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No Character")]
        public string tagNoCharacterValue {
            get {
                return ((string)(this["tagNoCharacterValue"]));
            }
            set {
                this["tagNoCharacterValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No Circle")]
        public string tagNoCircleValue {
            get {
                return ((string)(this["tagNoCircleValue"]));
            }
            set {
                this["tagNoCircleValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No Fault")]
        public string tagNoFaultValue {
            get {
                return ((string)(this["tagNoFaultValue"]));
            }
            set {
                this["tagNoFaultValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool checkDBIfExists {
            get {
                return ((bool)(this["checkDBIfExists"]));
            }
            set {
                this["checkDBIfExists"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IgnoreSkipLimit {
            get {
                return ((bool)(this["IgnoreSkipLimit"]));
            }
            set {
                this["IgnoreSkipLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useLastModifiedDate {
            get {
                return ((bool)(this["useLastModifiedDate"]));
            }
            set {
                this["useLastModifiedDate"] = value;
            }
        }
    }
}
