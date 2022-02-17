# How to get started

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [ASP.NET Core Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Postgres (you can install locally or use docker)
- Docker (Optional)

## Start to run the project

## Database

You can use a install of postgres on your computer, I invite you to follow [this](https://www.2ndquadrant.com/en/blog/pginstaller-install-postgresql/) guide.

Alternatively you can use docker to run your database, you need to run on the first time `docker run --name runforyourlife -e POSTGRES_PASSWORD=password -p 5432:5432 -d postgres` it will create a new container with default credentials.

After this if you want to start it again you will need to use `docker start runforyourlife` or if you want to stop it `docker start runforyourlife`

you will also need to copy the `appsettings.json.example` to `appsettings.json` and edit the connection string as your need.

If you use my command to generate your docker container you doesn't need to change the connection string

### Generate a new migrations

```bash
dotnet ef migrations add [name]
```

### Update schema with new migrations

```bash
dotnet ef database update
```

### Delete schema
```bash
dotnet ef database drop
```