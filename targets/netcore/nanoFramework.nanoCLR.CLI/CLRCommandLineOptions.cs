﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using CommandLine;

namespace nanoFramework.nanoCLR.CLI
{
    [Verb("nanoclr", HelpText = "Operations with nanoCLR.")]
    public class CLRCommandLineOptions
    {
        [Option("getversion", Required = false, HelpText = "Get nanoCLR version running on the virtual device")]
        public bool GetCLRVersion { get; set; }

        [Option("update", Required = false, Default = "", HelpText = "Checks for newer stable versions of the CLR and updates it, if there is one. A specific version can be specified. To check preview versions add the --preview option.")]
        public bool UpdateCLR { get; set; }

        [Option("preview", Required = false, HelpText = "Checks for preview versions of the nanoCLR.")]
        public bool CheckPreviewVersions { get; set; }

        [Option("version", Required = false, HelpText = "Specify the version of nanoCRL to install.")]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Allowed values:
        /// q[uiet]
        /// m[inimal]
        /// n[ormal]
        /// d[etailed]
        /// diag[nostic]
        /// </summary>
        [Option(
            'v',
            "verbosity",
            Required = false,
            Default = "d",
            HelpText = "Sets the verbosity level of the command. Allowed values are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic]. Not supported in every command; see specific command page to determine if this option is available.")]
        public string Verbosity { get; set; }
    }
}
