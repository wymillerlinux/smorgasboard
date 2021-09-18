FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MailSmgAPI/MailSmgAPI.csproj", "MailSmgAPI/"]
RUN dotnet restore "MailSmgAPI/MailSmgAPI.csproj"
COPY . .
WORKDIR "/src/MailSmgAPI"
RUN dotnet build "MailSmgAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MailSmgAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MailSmgAPI.dll"]
