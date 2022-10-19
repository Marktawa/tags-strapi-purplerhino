# Linux

```bash
# Get Ubuntu release version
$ lsb_release -a
No LSB modules are available.
Distributor ID: Ubuntu
Description:    Ubuntu 20.04.5 LTS
Release:        20.04
Codename:       focal
```

## ffmpeg
```bash
# Remove audio
$ ffmpeg -i app-demo.mp4 -c:v copy -an app-demo-an.mp4 && rm app-demo.mp4 && mv app-demo-an.mp4 app-demo.mp4

# Lossless speed up video and remove audio
$ ffmpeg -i app-demo-mobile.mp4 -map 0:v -c:v copy -an -bsf:v h264_mp4toannexb raw-mobile.h264
$ ffmpeg -fflags +genpts -r 240 -i raw-mobile.h264 -c:v copy app-demo-mobile-4x.mp4

$ ffmpeg -i app-demo.mp4 -map 0:v -c:v copy -bsf:v h264_mp4toannexb raw.h264
$ ffmpeg -fflags +genpts -r 240 -i raw.h264 -c:v copy app-demo-4x.mp4

# Convert video to gif
$ ffmpeg -i app-demo-4x.mp4 -vf "fps=10,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse" -loop 0 app-demo-twitter-f10.gif

# Convert video to gif, resolution: 720p
$ ffmpeg -i app-demo-4x.mp4 -vf "fps=10,scale=1280:720:flags=lanczos,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse" -loop 0 app-demo-twitter-f10-720p.gif

# Banner bear example
$ ffmpeg -ss 23.0 -t 1.8 -i input.mp4 -filter_complex "[0:v] split [a][b];[a] palettegen [p];[b][p] paletteuse" output_trimmed_enhanced.gif
```

# References

- [**Github Issue**](https://github.com/strapi/community-content/issues/985)
- [**Github Repo**](https://github.com/Marktawa/tags-strapi-purplerhino)
- [**Dropbox Paper**](https://www.dropbox.com/scl/fi/v3bi4umqvz1rz6uo2e6hi/How-to-Build-a-Blog-App-using-Blazor-WASM-and-Strapi.paper?dl=0&rlkey=22befzxkh60xma24u0r7c5ye4)
- [Container - Tailwind CSS](https://tailwindcss.com/docs/container)
- [Strapi Plugin Transformer - Github](https://github.com/ComfortablyCoding/strapi-plugin-transformer)
- [Tooling for ASP.NET Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/tooling?view=aspnetcore-6.0&pivots=linux)
- [**The UK & Great Britain – What’s the Difference?**](https://www.historic-uk.com/HistoryUK/HistoryofBritain/The-UK-Great-Britain-Whats-the-Difference/)
- [**Why do the British drive on the left?**](https://www.historic-uk.com/CultureUK/Why-do-the-British-drive-on-the-left/)
- [**The British Peerage**](https://www.historic-uk.com/CultureUK/The-British-Peerage/)
- [**The Queen’s Champion**](https://www.historic-uk.com/CultureUK/The-Queens-Champion/)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [Install the .NET SDK or the .NET Runtime on Ubuntu](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)
- [Host and deploy ASP.NET Core Blazor WebAssembly](https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/webassembly)
- [Build an Azure Static Web Apps website with Blazor](https://learn.microsoft.com/en-us/azure/static-web-apps/deploy-blazor)
- [An introduction to Blazor WebAssembly](https://www.rocksolidknowledge.com/articles/an-introduction-to-blazor-webassembly)
- [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
- [ASP.NET Core Blazor hosting models](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-6.0)
- [comments in razor syntax](https://www.c-sharpcorner.com/UploadFile/3d39b4/getting-started-with-razor-view-engine-in-mvc-3/#:~:text=Comments,*%2F%22%20or%20%22%2F%2F%22.)
- [Undoing a git pull --rebase](https://stackoverflow.com/questions/2213235/undoing-a-git-pull-rebase)
- [Undo a git pull --rebase?](https://stackoverflow.com/questions/10907173/undo-a-git-pull-rebase/10907222#10907222)
- [git pull](https://www.atlassian.com/git/tutorials/syncing/git-pull#:~:text=The%20git%20pull%20command%20is,Git%2Dbased%20collaboration%20work%20flows.)
- [Download .NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- [Install .NET on Linux by using an install script or by extracting binaries](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual)
- [dotnet-install scripts reference](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)
- [Call a web API from ASP.NET Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/call-web-api?view=aspnetcore-5.0&pivots=webassembly)
- [HttpClientJsonExtensions.GetFromJsonAsync Method](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.json.httpclientjsonextensions.getfromjsonasync?view=net-6.0)
- [Blazor webassembly external api not working unless JSON is inside array](https://stackoverflow.com/questions/71229455/blazor-webassembly-external-api-not-working-unless-json-is-inside-array)
- [List<T> Constructors](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.-ctor?redirectedfrom=MSDN&view=net-6.0#System_Collections_Generic_List_1__ctor_System_Collections_Generic_IEnumerable__0__)
- [Type or namespace List<> not found [closed]](https://stackoverflow.com/questions/48694783/type-or-namespace-list-not-found)
- [How to deploy Blazor WebAssembly to Netlify](https://swimburger.net/blog/dotnet/how-to-deploy-blazor-webassembly-to-netlify)
- [Adding locally hosted code to GitHub](https://docs.github.com/en/get-started/importing-your-projects-to-github/importing-source-code-to-github/adding-locally-hosted-code-to-github)
- [**Netlify live app to Hashnode article**](https://fastidious-kheer-645326.netlify.app/)
- [How to Remove Audio from Video using FFmpeg. Bonus: Add, Extract, Replace](https://ottverse.com/add-remove-extract-audio-from-video-using-ffmpeg/)
- [Speeding up/slowing down video ffmpeg](https://trac.ffmpeg.org/wiki/How%20to%20speed%20up%20/%20slow%20down%20a%20video)
- [**Original Article**](https://strapi.io/blog/how-to-build-a-blog-using-blazor-wasm-and-strapi)
- [.gitignore](https://www.atlassian.com/git/tutorials/saving-changes/gitignore)
- [Responsive Design](https://tailwindcss.com/docs/responsive-design)
- [**Original Repo**](https://github.com/sumitkharche/strapi-blog-api)
- [Deploying a Strapi API on Heroku in 5 min](https://strapi.io/blog/deploying-a-strapi-api-on-heroku)
- [Resolve nullable warnings](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)
- [Why You Should Use git pull –ff-only](https://blog.sffc.xyz/post/185195398930/why-you-should-use-git-pull-ff-only)
- [How to Deploy a Blazor App on Netlify](https://markmunyaka.hashnode.dev/how-to-deploy-a-blazor-app-on-netlify)
- [How to Deploy a Blazor App on Netlify - Github Repo](https://github.com/Marktawa/silverfox)
- [Providers](https://docs.strapi.io/developer-docs/latest/development/providers.html)
- [Google Chrome with minimal layout without address bar, and without tabs](https://superuser.com/questions/1292362/google-chrome-with-minimal-layout-without-address-bar-and-without-tabs?answertab=scoredesc#tab-top)
- [**Github Issue**](https://github.com/strapi/community-content/issues/985)
- [**Github Repo**](https://github.com/Marktawa/tags-strapi-purplerhino)
- [**Github Issue**](https://github.com/strapi/community-content/issues/985)
- [**Github Repo**](https://github.com/Marktawa/tags-strapi-purplerhino)


# TO DO
- Deploy site to Netlify
- Deploy Strapi ( PAAS | IAAS )
- Add CI/CD pipeline to automate deployment
- Fix styling
- Change logo
