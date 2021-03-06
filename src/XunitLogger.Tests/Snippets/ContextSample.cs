﻿using Xunit;
using Xunit.Abstractions;

public class ContextSample  :
    XunitLoggingBase
{
    [Fact]
    public void Usage()
    {
        var currentGuid = Context.CurrentGuid;

        var nextGuid = Context.NextGuid();

        Context.WriteLine("Some message");

        var currentLogMessages = Context.LogMessages;

        var testOutputHelper = Context.TestOutput;

        var currentTest = Context.Test;
    }

    [Fact]
    public void StaticUsage()
    {
        var currentGuid = XunitLogging.Context.CurrentGuid;

        var nextGuid = XunitLogging.Context.NextGuid();

        XunitLogging.Context.WriteLine("Some message");

        var currentLogMessages = XunitLogging.Context.LogMessages;

        var testOutputHelper = XunitLogging.Context.TestOutput;

        var currentTest = XunitLogging.Context.Test;
    }

    public ContextSample(ITestOutputHelper output) :
        base(output)
    {
    }
}