### I see you, Jithub

Github, the eponymous source control collaboration system for Open Source Projects, has been caught trying to sneakily continue its contracts with ICE -- you know, the government agency that puts kids in cages -- by getting a contract award from ICE through Dell Federal Systems.

Now all of this may be on the up-and-up; Dell sells Github enterprise to ICE as a reseller, Github gets plausible deniability, and ICE gets to use the cool kids source control system.

But it's still morally bankrupt for Github to take this contract -- for an amount, I might add, that totals $79,312.50, or roughly the same amount Microsoft should have paid Keivan for using his AppGet architectural work in their WinGet package manager solution.

We see you, Github. Special thanks to [Dave Copeland](https://twitter.com/davetron5000/status/1282738504624222208?s=20) for making me aware of this. Twitter is sometimes a beautiful thing.

### Vulnerabilities reported this week

Microsoft reported and [released a fix](https://github.com/dotnet/announcements/issues/159) for CVE-2020-1147, a .NET Core Remote Code Execution Vulnerability. If you accept XML input, this advisory affects you.  If any of your API endpoints accept XML, this advisory affects you. .NET Core 2.1.19, .NET 3.1.5, and .NET 5 Preview 6 are all vulnerable. This is fixed in the latest version of .NET Core 3.1.6, and will hopefully be fixed when .NET 5 Preview 7 is released. 

If you are running Visual Studio 16.4, you need to update SDK to 3.1.106; if you're running Visual studio 2019 16.5 or later, update to SDK 3.1.302 and then curse version numbers loudly like I'm about to.

If you use Windows DNS Server, there's another [RCE vulnerability that is apparently "wormable"](https://msrc-blog.microsoft.com/2020/07/14/july-2020-security-update-cve-2020-1350-vulnerability-in-windows-domain-name-system-dns-server/), but [at least some infosec people seem to think it won't turn into a big problem](https://twitter.com/hackerfantastic/status/1283096226616016896?s=20).  This being 2020, I'm not holding my breath.

### Self Contained Applications

One of the more interesting parts of .NET Core has become the "Self Contained Application" -> effectively the runtime, the application and its dependencies in one package. This is great for datacenter style deployments or cross platform console applications, or even potentially in .NET 6 with MAUI: Desktop applications.  That same advantage of self-contained applications is also a disadvantage, as foretold in this note in the Announcement: 

> Additionally, if you've deployed self-contained applications targeting any of the impacted versions, these applications are also vulnerable and must be recompiled and  redeployed.

Long story short: Not only do you need an update story for your organization's release cadence, that cadence must also take into account vulnerabilities in the runtime.

### Nick Craver talks Attacks on Stack Overflow.

Stack Overflow, the largest (that gets developer press and isn't Microsoft owned) site built on ASP.NET MVC (and soon .NET Core), gets a lot of attacks against it as a "top 50" (according to Wikipedia) site on the internet.  Nick Craver, their architectural lead; goes deep into the sorts of attacks that happen. https://www.youtube.com/watch?v=K6NECAZhJG4 This is a good watch. Watch it.

### Performance Improvements in .NET 5

This is the sort of thing I get jazzed about.  The faster C# gets, the less we have to worry about using a language like Go or Rust for high performance situations.  I don't use Rust, but anyone that does will tell you within seconds of meeting you.  They're our Crossfitters.

Anyway, having an easy-to-use toolchain to write fast code is good for all of us; and really good for our economic prospects, if we're being honest.  The .NET team gets jazzed about performance too, and they've released another blog post [detailing speed improvements in the forthcoming (now in Preview) .NET 5](https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-5/).  .NET 5, remember, is just .NET Core in a trench coat.  Microsoft is going directly from .NET Core 3 to .NET 5; because awkwardly, they already have a .NET 4.  I have lots of jokes to make about Microsoft Marketing, but I'd like to be clear about this: Microsoft has 20 years of inertia around the .NET Framework, and there were problem dozens of internal corporate teams that were hoping that .NET Core would fail because their bread and butter was built on .NET.  Luckily it didn't fail, and luckily the group that said "Let's unify the two" won.  Over time .NET Core has had to make concessions to stay in the game, like CSProj over project.json; but those concessions have ultimately scored large wins for both .NET Framework and .NET Core.  This is a narrow line to walk, and for all the grief I give them, Microsoft's Marketing team is handling this with grace and aplomb. 

### BinaryFormatter will finally be tossed off a bridge

https://github.com/dotnet/designs/pull/141

### ImageSharp passed 6 million downloads; and an exposure angel got their wings.

The creator of ImageSharp https://twitter.com/James_M_South/status/1282396639714373632 laments getting six million downloads on an open source project that obstensibly does not pay the bills.  At this point in OSS, you either go APGL or you get to the point where you wish you had.




### On .NET MAUI

I had understood [.NET MAUI](https://github.com/dotnet/maui) to be a codename for .NET 6. It is not.  Part of .NET 6 will be 'MAUI'. It's capitalized because it's an acroynmn. I should have known, of course, as we're programmers, and we love Acroymns.  Anyway, MAUI stands for: Multi-platform App UI.  Or for the rest of us: Cross Platform UIs!

YES. FINALLY. Something that will be faster than electron and have less users to boot! Seriously though, I'm pretty stoked that this is happening, though I hope Microsoft will take this time to realize that cross-platform UIs are probably best done in HTML, CSS, and JavaScript, and not XAML. Actually, scratch that, Cross platform UIs are terrible in HTML, CSS, and JavaScript, but it's ubitquitous, and that's what matters.  It looks like there will be a few 'AppModels' supported:
MVVM, RxUI, MVU, Blazor.  If you don't do Xamarin currently, RxUI and MVU will be new to you (and to the rest of us).  RxUI is a "reactive" style of programming to support one-way updates from the model to the UI. and MVU is "Model View Update", which I hear is cool but apparently every framework needs to create a new rendering pattern, and [MVU is Elm's gift](https://thomasbandt.com/model-view-update) to the rest of us.  Programmers create their own blog engines, UI Frameworks write their own Rendering pattern.


### PFCLotW (Pretty Fricking Cool Library of the Week)

If you're using .NET (Whether Framework or Core), and you want to benchmark your code, you should be using [Benchmark.NET](https://github.com/dotnet/BenchmarkDotNet).  It's called Benchmark because that's what it does, and they slapped the .NET moniker on the end because that's what library authors for .NET Do.  Since this is .NET, their alternatives were NBenchmark, and BenchmarkSharp. I'm glad Benchmark.NET won.

Anyway, Benchmark.NET let's you set up runs against your code; specifically against doing the same operation multiple ways. It then accurately benchmarks how fast the code is, what sort of memory usage it has, and a few other neat sundries about it.  

If you're using System.Timer(), don't. Use Benchmark.NET instead. (This is not a sponsored ad, but I do have a thing for Console Applications that are amazing)

### Events.NET

The .NET Conf is November 10th-12th, online only.  It's the 10th year of this event.  You can [save the date here](https://www.dotnetconf.net/?WT.mc_id=twc9-c9-chwarren).   If you're not a fan of sitting through three days of online events, I'll be live-tweeting it; In preparation, you can go ahead and block me now.

