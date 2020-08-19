#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0
#tool nuget:?package=Cake.CoreCLR&version=0.33.0
#tool dotnet:?package=coverlet.console&version=1.7.2
#addin nuget:?package=Cake.Coverlet&version=2.4.2


// 运行参数
var target = Argument("target", "Base");
// 发布版本
var publishVersion = Argument("publishVersion", "0.0.1");

// 构建配置
var buildConfiguration = "Release";
// 根路径
var rootPath = Directory("./src");
// sln路径
var slnPath = File(rootPath.Path.Combine("DotNet.DevKit.sln").ToString());
// 项目文件集合
var csprojFiles  = GetFiles(rootPath.Path.Combine("**/*.csproj").ToString());
// 需要打包的项目文件集合
var nugetCsprojFiles = csprojFiles.Where(s=>!s.ToString().EndsWith(".Test.csproj"));
// 测试项目文件集合
var testCsprojFiles  = GetFiles(rootPath.Path.Combine("**/*.Test.csproj").ToString());
// 输出路径
var outputDir = Directory("./output");
// 输出nuget包路径
var outputNugetDir = Directory(outputDir.Path.Combine("./nuget").ToString());
// 输出测试报告目录
var outputTestReportDir = Directory(outputDir.Path.Combine("./testReport").ToString());
// 输出代码覆盖率报告目录
var outputConverageReportDir = Directory(outputDir.Path.Combine("./converage").ToString());

// 标准构建
Task("Base")
  .Description("标准构建")
  .IsDependentOn("Clean")
  .IsDependentOn("Restore")
  .IsDependentOn("Build")
  .IsDependentOn("Test")
  .Does(() =>
  {
    Information("标准构建");
  });

Task("Nuget")
  .Description("构建Nuget包")
  .IsDependentOn("Base")
  .Does(()=>
  {
      foreach(var csproj in nugetCsprojFiles){
        Information($"构建Nuget包:{csproj.ToString()}");
        DotNetCorePack(csproj.ToString(), new DotNetCorePackSettings{
          Configuration = buildConfiguration,
          OutputDirectory = outputNugetDir,
          IncludeSymbols = true,
          ArgumentCustomization = args => args
            .Append($"/p:Version={publishVersion}")
            .Append($"/p:AssemblyVersion={publishVersion}")
        });
      }
      
  });

Task("Coverage")
  .Description("测试覆盖率")
  .IsDependentOn("Clean")
  .IsDependentOn("Restore")
  .Does(() =>
  {
    Information("测试覆盖率");
    EnsureDirectoryExists(outputConverageReportDir.Path);
    foreach(var testCsprojFile in testCsprojFiles){
      DotNetCoreBuild(testCsprojFile.ToString(), new DotNetCoreBuildSettings {Configuration = "Debug"});
      Coverlet(testCsprojFile, new CoverletSettings{
        CollectCoverage = true,
        CoverletOutputFormat = CoverletOutputFormat.opencover | CoverletOutputFormat.cobertura | CoverletOutputFormat.json | CoverletOutputFormat.lcov,
        CoverletOutputDirectory = outputConverageReportDir.Path,
        CoverletOutputName = "Coverage"
      });
    }
  });

Task("Clean")
  .Description("清理")
  .Does(()=>
  {
    Information($"清理:${slnPath}");
    DotNetCoreClean(slnPath);
    CleanDirectories(outputDir.ToString());
  });

Task("Restore")
  .Description("还原Nuget包")
  .Does(()=>
  {
    Information($"还原Nuget包:${slnPath}");
    DotNetCoreRestore(slnPath);
  });

Task("Build")
  .Description("构建")
  .Does(()=>
  {
    var a = Directory("./src").Path.ToString();
    foreach (var csproj in csprojFiles)
    {
      Information($"构建 {csproj.GetFilename()}");
      DotNetCoreBuild(csproj.ToString(), new DotNetCoreBuildSettings{
        Configuration = buildConfiguration,
        ArgumentCustomization = args => args
            .Append($"/p:Version={publishVersion}")
            .Append($"/p:AssemblyVersion={publishVersion}")
      });
    }
  });

Task("Test")
  .Description("单元测试")
  .Does(()=>
  {
    foreach(var testCsprojFile in testCsprojFiles){
      Information($"执行单元测试:{testCsprojFile.GetFilename()}");
      var testReportFilaPath = new FilePath(outputTestReportDir.Path.Combine($"TestReport_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xml").ToString());
      DotNetCoreTest(testCsprojFile.ToString(), new DotNetCoreTestSettings{
        Configuration = buildConfiguration,
        NoBuild = false,
        VSTestReportPath = testReportFilaPath,
      });
    }
  });


RunTarget(target);