// <copyright file="IApplicationConfiguration.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;

namespace Rozafa.Application.Common.Interfaces
{
    public interface IApplicationConfiguration
    {
        public RICE RICE { get; }

        public Auth Auth { get; }
    }
}