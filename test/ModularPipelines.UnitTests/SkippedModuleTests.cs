﻿using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.UnitTests;

public class SkippedModuleTests : TestBase
{
    private class SkippedModule : Module<CommandResult>
    {
        protected override Task<bool> ShouldSkip(IPipelineContext context)
        {
            return Task.FromResult(true);
        }

        protected override async Task<CommandResult?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            await Task.Yield();
            throw new Exception();
        }
    }
    
    [Test]
    public async Task Skipped_Result_Is_As_Expected()
    {
        var module = await RunModule<SkippedModule>();

        var moduleResult = await module;

        Assert.Multiple(() =>
        {
            Assert.That(moduleResult.ModuleResultType, Is.EqualTo(ModuleResultType.Skipped));
            Assert.That(moduleResult.Exception, Is.Null);
            Assert.That(() => moduleResult.Value, Throws.Exception);
        });
    }
}