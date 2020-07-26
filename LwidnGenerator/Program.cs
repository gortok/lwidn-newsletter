using System;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Markdown;
using Statiq.Web;



namespace LwidnGenerator
{
		class Program
		{
				public static async Task<int> Main(string[] args) =>
				await Bootstrapper
						.Factory
						.CreateDefault(args)
						.BuildPipeline("Render Markdown", builder => builder
							.WithInputReadFiles("*.md")
							.WithProcessModules(new RenderMarkdown())
							.WithOutputWriteFiles(".html"))
						.RunAsync();
		}
}
