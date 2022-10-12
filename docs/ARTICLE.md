# Outline
- Prerequisites
- Introduction
    - What is Blazor
    - What is Strapi
- **Backend Setup**
- Step 1: Scaffold a Strapi App
- Step 2: Build the Posts collection
- Step 3: Make Strapi API public
- **Frontend Setup**
- Step 4: Set up Blazor project
    - A. Using dot CLI commands
    - B. Using Visual Studio Editor
- Step 5: Integrate Strapi API with Blazor App
- Step 6: Display all blog posts on the home page
- Step 7: Display a single blog post
- Step 8: Deploy the blog app
- Conclusion

In this tutorial you will learn how to create a simple but blazing fast blog app using [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor), [Tailwind CSS](https://tailwindcss.com/), and [Strapi](https://strapi.io/). You will use Strapi, the leading open-source headless CMS, to store your posts and Blazor to build your frontend.


- Here’s a short video demo


https://www.youtube.com/watch?v=-0HHEt6j2f0&


[https://youtu.be/-0HHEt6j2f0](https://youtu.be/-0HHEt6j2f0)


- [Live Demo](https://strapi-blazor-blog.netlify.app/)
- [Source Code](https://github.com/Marktawa/tags-strapi-purplerhino)
# Prerequisites

Before you can jump into this content, you need to have a basic understanding of the following:

1. Strapi - [get started here](https://strapi.io/documentation/developer-docs/latest/getting-started/introduction.html).
2. Node.js
3. Shell (Bash)
4. C#
5. Blazor

The following software should be installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download). Latest version
- Blazor project templates
- **Node** *v14.x.x* or *v16.x.x*. Download Node from the [Download | Node.js page](https://nodejs.org/en/download/). I used Node *v16.14.2*.
- **npm** or **yarn**. npm ships with your Node installation. If you prefer yarn, install it as an npm package. Check [Installation | Yarn](https://classic.yarnpkg.com/en/docs/install). I used yarn *v1.22.15*.
    

For a full rundown of all the requirements needed to run a Strapi app, check out the [Hardware and Software requirements](https://docs.strapi.io/developer-docs/latest/setup-deployment-guides/deployment.html#hardware-and-software-requirements).

# Introduction

## **What is Blazor?**

Blazor is a web framework from Microsoft which allows you to create a web application using C# and HTML. If you are a developer using C# and want to build a blazing fast web application, you should check out Blazor.

According to [Blazor's](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) [docs](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor):

> *Blazor is a free and open-source web framework that enables developers to create web apps using C# and HTML.* 

Blazor lets you build interactive web UIs using C# instead of JavaScript. Blazor apps are composed of reusable web UI components implemented using C#, HTML, and CSS.

Both client and server code are written in C#, allowing you to share code and libraries. Blazor can run your client-side C# code directly in the browser, using WebAssembly. Because it's real .NET running on WebAssembly, you can re-use code and libraries from server-side parts of your application.
 
In this article, you will use Blazor Web Assembly to build the client-side of the blog app.

## **What is Strapi - A Headless CMS?**

Strapi is a leading open-source headless CMS based on Node.js to develop and manage content using Restful APIs and GraphQL.

With Strapi, we can scaffold our API faster and consume the content via APIs using any HTTP RESTful client or GraphQL enabled frontend.

# **Backend Setup**
# Step 1: Scaffold a Strapi project

Open up your terminal and create an empty project directory to store your project. This folder would serve as the root folder. The frontend and backend code will be stored in subdirectories. I will name my project directory `purplerhino`.


    $ mkdir purplerhino

Change the directory to the project directory `purplerhino`.


    $ cd purplerhino

Enable source control for your project by initializing a git repository.


    /purplerhino $ git init

Create a Strapi app


    /purplerhino $ npx create-strapi-app backend --quickstart

The command above will scaffold a new Strapi project in a directory named `backend`. The `quickstart` flag sets up your Strapi app with an SQLite database.

After successful installation, the Strapi app starts automatically. Open the **Strapi Admin Registration** interface from your web browser at [localhost:1337/admin](http://localhost:1337/admin). Create the admin user for your Strapi application and click **Let's Start**.


![Strapi Admin Registration](https://www.dropbox.com/temp_thumb_from_token/s/kivn0uqjh7v6kz1?size_mode=5&preserve_transparency=true)

# Step 2: Build the Posts collection

Next, we will create a new **content type** that will store the details of each post.

We will create the name **content type** `posts` and it will contain the following fields: `title`, `content`, `author`, and `image`.


- Click **Content Type Builder** on the left side of the page. 
- Select **+** **Create New Collection Type** still at the left side of the page and fill in **Post** as the display name.
- Click on **Continue** to create a new **Post** collection.
     

We need to fill the **Post** collection with lots of post data. You can achieve this in two ways: using the Admin UI and using Strapi generated API.

We will use the Admin UI to create a post. 


- Click on **Continue**, and it will present you with another modal to select fields for your **Collection Type**.
![Build Post Collection](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634984006866_image.png)

- Select `Text` and fill in `title` in the Text field. 
- Click on `Add another field`, select `Rich Text`, and name it `content`.
- Click on `Add another field` and select Media field and name it `image`.
- Select `Text` field and name it `author`.
- After adding all the required fields, click on **Save** to save the collection
- Click on **Content Manager** on the left of your dashboard. Under **COLLECTION TYPES,** select **Post**.
- Next, click on **+ Create new entry** and add a few posts to your **Posts** collection. Click on **Save and Publish** for each post you add
![Posts collection in Strapi Dashboard](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634984384582_image.png)

# Step 3: Make Strapi API public

After creating the **Posts** collection successfully, it's time to allow public access to the collection because access will be denied if we try to access it with our public HTTP client.


- Click on **Settings** on the sidebar.
- In the **USERS & PERMISSIONS PLUGIN** section, click on **Roles**.
- On the **Roles** page, click on **Public.**


![Select Public User Permission Roles](https://paper-attachments.dropboxusercontent.com/s_1397259AE4EA905EA394D788E024F54EE4192AD1703CEE73F161107BB332DADF_1661802923852_select-public-user-permissions.png)



- Scroll down to the **Permissions** section:
- Select **Post** and check the **Select all** checkbox. This makes all the endpoints accessible to the public and performs any [Create, Read, Update, Delete (CRUD)](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete) actions on them.
![Open access for Posts](https://www.dropbox.com/s/vfspezp4nis5xnm/placeholder.png?raw=1)

- Click on **Save** 
# **Frontend Setup**
# Step 4: Setting up Blazor project

We can create a Blazor project using two ways:

- Using dot CLI commands
- Using Visual Studio Editor
## A. Using dot CLI commands

Open up your terminal and run the following commands:


    /purplerhino $ dotnet new blazorwasm -o frontend
    /purplerhino $ cd frontend
    /purplerhino/frontend $ dotnet run

Now open the [localhost:5000/](http://localhost:5000/) to see the Blazor `frontend` app.

![Blazor frontend app](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634985041305_image.png)

## B. Using Visual Studio Editor

Open a visual studio editor, click on `Create new project`, and search for `Blazor`.

![Visual Studio: Create new project](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634985287835_image.png)


Select `Blazor WebAssembly app` and click on the `Next` button. After that, provide a project name and click on the `Next` button.

![Visual Studio: Configure your new project](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634985433381_image.png)


After that, click on the `Create` button. That's it, and you have successfully created a Blazor project.
Now to run the app, click on the `IIS Express` button.

![Visual Studio: Project Overview](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634985635573_image.png)


You can see the app running as below:

![Blazor frontend app](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634985739780_image.png)

# Step 5: Integrate Strapi API with Blazor App

Now we have set up our Blazor project, the next step is to create the blog frontend.

So now, to access the posts, we have to use URLs such as `http://localhost:1337/posts`. In our Blazor project to store the Strapi API URL, create a new file **app settings.json** in the `wwwroot` folder and add the below code:


        {
          "AppSettings": {
            "STRAPI_API_URL": "http://localhost:1337/" // replace your local strapi url
          }
        }

Create a folder called `Models` and create a class called `AppSettings.cs` inside it and add the below code:


        namespace StrapiBlazorBlog.Models
        {
            public class AppSettings
            {
                public string STRAPI_API_URL { get; set; }
            }
        }

Now open the `Program.cs` file to add below code to which is required to read the data from the `appsettings.json` file anywhere in the application.


        using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
        using Microsoft.Extensions.Configuration;
        using Microsoft.Extensions.DependencyInjection;
        using StrapiBlazorBlog.Models;
        using System;
        using System.Net.Http;
        using System.Threading.Tasks;
        
        namespace StrapiBlazorBlog
        {
            public class Program
            {
                public static async Task Main(string[] args)
                {
                    var builder = WebAssemblyHostBuilder.CreateDefault(args);
                    builder.RootComponents.Add<App>("#app");
        
                    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        
                    await builder.Build().RunAsync();
                }
        
                public static void ConfigureServices(IServiceCollection services)
                {
                    // Example of loading a configuration as configuration isn't available yet at this stage.
                    services.AddSingleton(provider =>
                    {
                        var config = provider.GetService<IConfiguration>();
                        return config.GetSection("App").Get<AppSettings>();
                    });
                }
            }
        }

So we have set up the integration with Strapi API with the Blazor app. Now the next step is to create a component for our blog application.

# Step 6: Display all blog posts on the home page

We are using [Tailwind CSS](https://tailwindcss.com/) to style our awesome blog. So open the `index.html` file and add below CDN:


        <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet">

Create a class called `Post.cs` with the same property in our Strapi posts collection.


        namespace StrapiBlazorBlog.Models
        {
            public class Post
            {
                public int Id { get; set; }
                public string Title { get; set; }
                public string Content { get; set; }
                public string Author { get; set; }
                public Image Image { get; set; }
            }
        
            public class Image
            {
                public string Url { get; set; }
            }
        }

Now open `Pages/inde.razor` file and add below code to show all the posts fetch from Strapi into our client app:


        @page "/"
        @inject HttpClient Http
        @using Microsoft.Extensions.Configuration;
        @using Models
        @inject IConfiguration Configuration
        
        @if (allPosts == null)
        {
            <p><em>Loading...</em></p>
        }
        else
        {
        <section class="text-gray-600 body-font">
            <div class="container px-5 py-4 mx-auto">
                <div class="text-center mb-20">
                    <h1 class="sm:text-3xl text-2xl font-medium title-font text-gray-900 mb-4">Strapi Blazor Blog App</h1>
                    <p class="text-base leading-relaxed xl:w-2/4 lg:w-3/4 mx-auto text-gray-500s">The perfect blog application starter build using leading open source headless CSM called Strapi and Blazor.</p>
                    <div class="flex mt-6 justify-center">
                        <div class="w-16 h-1 rounded-full bg-indigo-500 inline-flex"></div>
                    </div>
                </div>
                <div class="flex flex-wrap -m-4">
                    @foreach (var post in allPosts)
                    {
                        <div class="xl:w-1/4 md:w-1/2 p-4">
                            <div class="bg-gray-100 p-6 rounded-lg">
                                <img class="h-40 rounded w-full object-cover object-center mb-6" src="@post.Image.Url" alt="content">
                                <h2 class="text-lg text-gray-900 font-medium title-font mb-4">@post.Title</h2>
                                <NavLink href="@($"post/{post.Id.ToString()}")">
                                    <a class="text-indigo-500 inline-flex items-center">
                                        Read More
                                        <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-2" viewBox="0 0 24 24">
                                            <path d="M5 12h14M12 5l7 7-7 7"></path>
                                        </svg>
                                    </a>
                                </NavLink>
                            </div>
                        </div>
                    }
                </div>
            </div>
        </section>
        }
        
        
        @code {
            private Post[] allPosts = null;
            public string strapi_api_url;
        
            protected override async Task OnInitializedAsync()
            {
                strapi_api_url = Configuration["AppSettings:STRAPI_API_URL"];
                var url = "{STRAPI_API_URL}/posts";
                allPosts = await Http.GetFromJsonAsync<Post[]>(url.Replace("{STRAPI_API_URL}", strapi_api_url));
                if (allPosts != null && allPosts.Length >0)
                {
                    foreach(var post in allPosts)
                    {
                        post.Image.Url = strapi_api_url + post.Image.Url;
                    }
                }
            }
        
        }

Update the `Shared/NavMenu.razor` file to remove extra menu from sidebar.


        <header class="text-gray-600 body-font">
            <div class="container mx-auto flex flex-wrap p-5 flex-col md:flex-row items-center">
                <a class="flex order-first lg:order-none lg:w-1/5 title-font font-medium items-center text-gray-900 lg:items-center lg:justify-center mb-4 md:mb-0">
                    <img src="/blazor_strapi_logo.png" alt="logo" style="height:60px" />
                    <span class="ml-3 text-3xl">StrapiBlazorBlog</span>
                </a>
            </div>
        </header>

Update `MainLayout.razor` file as below:


        @inherits LayoutComponentBase
        
        <div>
        <NavMenu />
        
        <div>
            @Body
        </div>
        </div>

Now run the application and see the output as below:


![Blog App Home page](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634993795450_image.png)


Wow 👌👌 We have now displayed all our posts on the home page successfully.

# Step 7: Display a single blog post

So next part is when we click on the `Read more` button from each post, we have to display details of the particular post. So we will create a new page called `PostDetails.razor` under the Pages folder and below code:


        @page "/post/{Id}"
        @inject HttpClient Http
        @inject NavigationManager NavigationManager
        @using System.Text.Json.Serialization
        @using Microsoft.Extensions.Configuration;
        @using Models
        @inject IConfiguration Configuration
        
        @if (postDetails == null)
        {
            <p><em>Loading...</em></p>
        }
        else
        {
            <section class="text-gray-700 body-font">
                <div class="container mx-auto flex px-5 pb-24 items-center justify-center flex-col">
                    <h1 class="title-font sm:text-4xl text-3xl mb-4 font-medium text-gray-900">@postDetails.Title</h1>
                    <img class=" mb-10 object-cover object-center rounded" alt="hero" src="@postDetails.Image.Url" style="height:400px;width:900px">
                    <div class=" w-full">
                        <div class="mb-8 leading-relaxed">@((MarkupString)postDetails.Content)</div>
                    </div>
                    <div class="p-2 w-full">
                        <button class="flex mx-auto text-white bg-indigo-500 border-0 py-2 px-8 focus:outline-none hover:bg-indigo-600 rounded text-lg" @onclick="NavigateToIndexComponent">Back</button>
                    </div>
                </div>
            </section>
        }
        
        @code {
            [Parameter] public string Id { get; set; }
        
            private Post postDetails = null;
        
            public string strapi_api_url;
        
            protected override async Task OnInitializedAsync()
            {
        
                strapi_api_url = Configuration["AppSettings:STRAPI_API_URL"];
                var url = "{STRAPI_API_URL}/posts/{Id}";
                url = url.Replace("{STRAPI_API_URL}", strapi_api_url);
                url = url.Replace("{Id}", Id);
                postDetails = await Http.GetFromJsonAsync<Post>(url);
        
                if (postDetails != null)
                {
                    postDetails.Image.Url = strapi_api_url + postDetails.Image.Url;
                }
            }
        
            private void NavigateToIndexComponent()
            {
                NavigationManager.NavigateTo("");
            }
        
        }

Now rerun the app and click on the `Read More` button from any post, and you will see details of that post.


![Single post page](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1634996931784_image.png)

# Step 8: Deploy the blog app

Now we have our Strapi backend API and our Blazor frontend app. So we will deploy strapi to Heroku and the Blazor app to Netlify. To deploy Starpi API on Heroku, check out this [article](https://strapi.io/blog/deploying-a-strapi-api-on-heroku).

We can now deploy our Blazor application on any hosting platform. We are deploying our app on [Netlify](https://www.netlify.com/) using Github Actions.


1. First, create a repo in GitHub and commit your code to that repository.
2. Login to Netlify and create a new site.
3. We need a Personal Access Token and Site Id to deploy our app to Netlify. So Go to Profile and generate a Personal Access Token.


![Netlify Personal Access Tokens](https://res.cloudinary.com/practicaldev/image/fetch/s--gjBuRBkE--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://cdn.cosmicjs.com/e37c4ff0-fa64-11ea-ac76-ed0a0ac0571c-access-token.PNG)


Go to a new site created in Netlify and navigate to site details and copy the `API ID`.


![Netlify API ID](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1635010296013_image.png)


Go to repository settings → Click on Secrets → add the above two secrets.


![Netlfiy Auth Token and Site ID](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1635010634194_image.png)


The next step is to create a Github action. So click on Actions and then select New Workflow and select the .NET Core template. After that, add the below code to the `yml` file.


        name: .NET
        
        on:
          push:
            branches: [ master ]
          pull_request:
            branches: [ master ]
        
        jobs:
          build:
        
            runs-on: ubuntu-latest
        
            steps:
            - uses: actions/checkout@v2
            - name: Setup .NET
              uses: actions/setup-dotnet@v1
              with:
                dotnet-version: 5.0.x
            - name: Restore dependencies
              run: dotnet restore
            - name: Build
              run: dotnet build --configuration Release --no-restore
            - name: Publish Blazor webassembly using dotnet 
              #create Blazor WebAssembly dist output folder in the project directory
              run: dotnet publish -c Release --no-build -o publishoutput
            - name: Publish generated Blazor webassembly to Netlify
              uses: netlify/actions/cli@master #uses Netlify Cli actions
              env: # These are the environment variables added in GitHub Secrets for this repo
                  NETLIFY_AUTH_TOKEN: ${{ secrets.NETLIFY_AUTH_TOKEN }}
                  NETLIFY_SITE_ID: ${{ secrets.NETLIFY_SITE_ID }}
              with:
                  args: deploy --dir=publishoutput/wwwroot --prod #push this folder to Netlify
                  secrets: '["NETLIFY_AUTH_TOKEN", "NETLIFY_SITE_ID"]'

After deployment you can see the site as live.


![Site running on Netlify](https://paper-attachments.dropboxusercontent.com/s_7B915BA17A20925DDCD3A880AE89946807D8A9C38702128574A00FF9B3FB24F0_1635011389468_image.png)

# Conclusion

This article demonstrated how to build a simple blog application using Blazor for frontend and Strapi as the Backend. Strapi has lots of integration with other frameworks, so please check out [Strapi blog](https://strapi.io/blog) for more information.

Let me know you have any suggestions and what you will be building with the knowledge.

