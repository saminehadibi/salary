#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Adibi.Web.Host/Adibi.Web.Host.csproj", "src/Adibi.Web.Host/"]
COPY ["src/Adibi.Web.Core/Adibi.Web.Core.csproj", "src/Adibi.Web.Core/"]
COPY ["src/Adibi.EntityFrameworkCore/Adibi.EntityFrameworkCore.csproj", "src/Adibi.EntityFrameworkCore/"]
COPY ["src/Adibi.Core/Adibi.Core.csproj", "src/Adibi.Core/"]
COPY ["src/Adibi.Application/Adibi.Application.csproj", "src/Adibi.Application/"]
RUN dotnet restore "src/Adibi.Web.Host/Adibi.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Adibi.Web.Host"
RUN dotnet build "Adibi.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Adibi.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Adibi.Web.Host.dll"]