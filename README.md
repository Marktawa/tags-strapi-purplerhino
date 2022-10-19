[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# How to Build a Blog App using Blazor WASM and Strapi

This repository serves as a code container for the tutorial I wrote on [Strapi's Blog](https://strapi.io/blog/).

## App Demo

![App Demo](/docs/app-demo-b-4x-f5.gif)

## Prerequisites

- Node v14.x.x or v16.x.x. Download Node from the [Download | Node.js page](https://nodejs.org/en/download/). I used *Node v16.14.2*
- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Getting Started

```bash
# clone the repo
$ git clone https://github.com/Marktawa/tags-strapi-purplerhino.git

# change directory
$ cd tags-strapi-purplerhino
```

### For Strapi

```bash
# navigate to backend directory that holds strapi code
/tags-strapi-purplerhino $ cd src/backend

# install dependencies
/tags-strapi-purplerhino/src/backend $ npm install

# served at http://localhost:1337
/tags-strapi-purplerhino/src/backend $ npm run develop
```

### For Blazor

```bash
# navigate to frontend directory
/tags-strapi-purplerhino $ cd src/frontend

# served at http://localhost:5024
/tags-strapi-purplerhino/src/frontend $ dotnet run
```

> For detailed instructions, [read the blog](https://strapi.io/blog/).

## Tech Stack

* [.NET](https://dotnet.microsoft.com/) - Frontend
* [Strapi](https://strapi.io/) - Backend and CMS

## Authors

- [Mark Tawanda Munyaka](https://github.com/Marktawa)

## Extra

- You are welcome to make [issues and feature requests](https://github.com/Marktawa/strapi-nuxt-preview/issues).
- In case you get stuck at somewhere, feel free to contact at [Mail](mailto:marktmunyaka@gmail.com).
