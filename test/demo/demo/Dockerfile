#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 82

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
#COPY ["Web/ToolkitWeb.csproj", "Web/"]
#COPY ["Data/Cn.Intf/Cn.Intf.csproj", "Data/Cn.Intf/"]
#COPY ["Data/Cn.Common/Cn.Common.csproj", "Data/Cn.Common/"]
#RUN dotnet restore "Web/ToolkitWeb.csproj"
#COPY . .
#WORKDIR "/src/Web"
#RUN dotnet build "ToolkitWeb.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "ToolkitWeb.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "demo.dll"]