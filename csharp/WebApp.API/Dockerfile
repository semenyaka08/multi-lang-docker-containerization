FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /src

COPY ["WebApp.API.csproj", "./WebApp.API.csproj"] 
RUN dotnet restore "WebApp.API.csproj"

COPY . .

RUN dotnet build "WebApp.API.csproj" -c Release
RUN dotnet publish "WebApp.API.csproj" -c Release -o /app/publish_output

WORKDIR /app/publish_output

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "WebApp.API.dll"]