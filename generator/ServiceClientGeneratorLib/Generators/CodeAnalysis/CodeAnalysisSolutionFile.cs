﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.CodeAnalysis
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CodeAnalysisSolutionFile : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 14
VisualStudioVersion = 14.0.23107.0
MinimumVisualStudioVersion = 10.0.40219.1
Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""ServiceAnalysis"", ""ServiceAnalysis"", ""{1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}""
EndProject
");
            
            #line 14 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    foreach(var project in (List<CodeAnalysisSolutionCreator.Project>)this.Session["CodeAnalysisProjects"])
    {

            
            #line default
            #line hidden
            this.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectPath));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("\"\r\nEndProject\r\n");
            
            #line 20 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"Project(""{D954291E-2A0B-460D-934E-DC6B0785DB48}"") = ""SharedAnalysisCode"", ""code-analysis\SharedAnalysisCode\SharedAnalysisCode.shproj"", ""{16E2A13F-F4F6-4774-A2D8-AD8127E7EE4F}""
EndProject
Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""AWSCodeAnalysisTestExtension.Vsix"", ""code-analysis\AWSCodeAnalysisTestExtension\AWSCodeAnalysisTestExtension.Vsix.csproj"", ""{11EAD86F-28B2-4DD6-AA76-72BB3B4AE80C}""
EndProject
Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""MockAnalyzer"", ""code-analysis\MockAnalyzer\MockAnalyzer.csproj"", ""{9BC3B08B-9F09-444E-AD15-67045FA3AF19}""
EndProject
Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""AnalyzerUnitTests"", ""code-analysis\AnalyzerUnitTests\AnalyzerUnitTests.csproj"", ""{9F38117D-9F41-44BA-9CB2-0EB42C66D2A0}""
EndProject

Global
	GlobalSection(SharedMSBuildProjectFiles) = preSolution
		code-analysis\SharedAnalysisCode\SharedAnalysisCode.projitems*{16e2a13f-f4f6-4774-a2d8-ad8127e7ee4f}*SharedItemsImports = 13
");
            
            #line 35 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    foreach(var project in (List<CodeAnalysisSolutionCreator.Project>)this.Session["CodeAnalysisProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\tcode-analysis\\SharedAnalysisCode\\SharedAnalysisCode.projitems*");
            
            #line 39 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid.ToLower()));
            
            #line default
            #line hidden
            this.Write("*SharedItemsImports = 4\r\n");
            
            #line 40 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"		code-analysis\SharedAnalysisCode\SharedAnalysisCode.projitems*{9bc3b08b-9f09-444e-ad15-67045fa3af19}*SharedItemsImports = 4

	EndGlobalSection
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
");
            
            #line 51 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    foreach(var project in (List<CodeAnalysisSolutionCreator.Project>)this.Session["CodeAnalysisProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 55 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.ActiveCfg = Debug|Any CPU\r\n\t\t");
            
            #line 56 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Debug|Any CPU.Build.0 = Debug|Any CPU\r\n\t\t");
            
            #line 57 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.ActiveCfg = Release|Any CPU\r\n\t\t");
            
            #line 58 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(".Release|Any CPU.Build.0 = Release|Any CPU\r\n");
            
            #line 59 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"		{11EAD86F-28B2-4DD6-AA76-72BB3B4AE80C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{11EAD86F-28B2-4DD6-AA76-72BB3B4AE80C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{11EAD86F-28B2-4DD6-AA76-72BB3B4AE80C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{11EAD86F-28B2-4DD6-AA76-72BB3B4AE80C}.Release|Any CPU.Build.0 = Release|Any CPU
		{9BC3B08B-9F09-444E-AD15-67045FA3AF19}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9BC3B08B-9F09-444E-AD15-67045FA3AF19}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9BC3B08B-9F09-444E-AD15-67045FA3AF19}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9BC3B08B-9F09-444E-AD15-67045FA3AF19}.Release|Any CPU.Build.0 = Release|Any CPU
		{9F38117D-9F41-44BA-9CB2-0EB42C66D2A0}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9F38117D-9F41-44BA-9CB2-0EB42C66D2A0}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9F38117D-9F41-44BA-9CB2-0EB42C66D2A0}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9F38117D-9F41-44BA-9CB2-0EB42C66D2A0}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
");
            
            #line 79 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    foreach(var project in (List<CodeAnalysisSolutionCreator.Project>)this.Session["CodeAnalysisProjects"])
    {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 83 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write(" = {1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}\r\n");
            
            #line 84 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisSolutionFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\nEndGlobal\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
