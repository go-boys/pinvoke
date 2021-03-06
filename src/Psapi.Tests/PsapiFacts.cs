﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System;
using Xunit;
using static PInvoke.Kernel32;
using static PInvoke.Psapi;

public class PsapiFacts
{
    [Fact]
    public void EmptyWorkingSet_Run()
    {
        using (var pid = GetCurrentProcess())
        {
            Assert.True(EmptyWorkingSet(pid));
        }
    }
}
