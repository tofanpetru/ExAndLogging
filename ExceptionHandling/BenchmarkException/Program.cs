using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using BenchmarkException;

var config = new ManualConfig()
        .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        .AddValidator(JitOptimizationsValidator.DontFailOnError)
        .AddLogger(ConsoleLogger.Default)
        .AddColumnProvider(DefaultColumnProviders.Instance);


var _ = BenchmarkRunner.Run<SearchBenchmark>(config);

Console.ReadLine();