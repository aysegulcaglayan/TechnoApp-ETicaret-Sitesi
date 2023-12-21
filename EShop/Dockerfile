FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EShop/Eshop.csproj", "EShop/"]
RUN dotnet restore "EShop/EShop.csproj"
COPY . .
WORKDIR "/src/EShop"
RUN dotnet build "EShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EShop.dll"]


