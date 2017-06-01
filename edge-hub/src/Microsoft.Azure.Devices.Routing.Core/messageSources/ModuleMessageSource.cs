﻿// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Routing.Core.MessageSources
{
    using System.Globalization;
    using Microsoft.Azure.Devices.Routing.Core.Util;

    public class ModuleMessageSource : BaseMessageSource
    {
        const string SourcePattern = "/messages/modules/{0}/outputs/{1}";

        ModuleMessageSource(string source)
            : base(source)
        {
        }

        public static ModuleMessageSource Create(string moduleId, string outputEndpoint)
        {
            Preconditions.CheckArgument(!string.IsNullOrWhiteSpace(moduleId), "ModuleId cannot be null or empty");
            Preconditions.CheckArgument(!string.IsNullOrWhiteSpace(outputEndpoint), "OutputEndpoint cannot be null or empty");

            return new ModuleMessageSource(string.Format(CultureInfo.InvariantCulture, SourcePattern, moduleId, outputEndpoint));
        }
    }
}