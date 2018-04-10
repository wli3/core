// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Cli.Prototype.Utils;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Cli.Prototype.Tasks
{
    /// <summary>
    /// Embeds the App Name into the AppHost.exe
    /// </summary>
    public class EmbedAppNameInHost : Task
    {
        [Required]
        public string AppHostSourceFilePath { get; set; }

        [Required]
        public string AppHostDestinationFilePath { get; set; }

        [Required]
        public string AppBinaryFilePath { get; set; }

        public override bool Execute()
        {
            Utils.EmbedAppNameInHost.EmbedAndReturnModifiedAppHostPath(
                AppHostSourceFilePath,
                AppHostDestinationFilePath,
                AppBinaryFilePath);
            return true;
        }
    }
}