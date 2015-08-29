﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace HearthCap.Properties {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    public class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("HearthCap.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HearthstoneTracker is developed by Remco Ros aka GameForFree on Twitch.tv/GameForFree.
        ///
        ///Thanks to:
        ///- Jackyjoe for the logo.
        ///- Renjestoo, xREITYD and phillyCHEEEEEZ for alpha testing.
        ///- megablue (developer of HearthTracking) for hanging around in my stream a lot.
        ///- Every follower on twitch for the feedback and support!
        ///
        ///If you have any questions, contact me on twitch or visit the website..
        /// </summary>
        public static string AboutText {
            get {
                return ResourceManager.GetString("AboutText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.paypal.com/cgi-bin/webscr?cmd=_donations&amp;business=7ZX2TR6T7STZ6&amp;lc=US&amp;item_name=HearthstoneTracker%20donation&amp;item_number=Windows%20application&amp;currency_code=USD&amp;bn=PP%2dDonationsBF%3abtn_donate_LG%2egif%3aNonHosted.
        /// </summary>
        public static string DonationLink {
            get {
                return ResourceManager.GetString("DonationLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HearthstoneTracker uses several open-source libraries. 
        ///
        ///-----
        ///
        ///The MIT License
        ///
        ///Copyright (c) 2010 Blue Spire Consulting, Inc.
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Softwar [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LibrariesLicenseText {
            get {
                return ResourceManager.GetString("LibrariesLicenseText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All logos, products, and company names mentioned and used in HearthstoneTracker are trademarks of their respective owners and subject to their own copyright laws, foreign or domestic.
        ///
        ///Hearthstone™ is a registered trademark of Blizzard Entertainment, Inc., in the U.S. and/or other countries.
        ///
        ///HearthstoneTracker is in no way owned or affiliated with Blizzard Entertainment..
        /// </summary>
        public static string LicenseText {
            get {
                return ResourceManager.GetString("LicenseText", resourceCulture);
            }
        }
    }
}
