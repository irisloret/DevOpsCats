FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /app

# Copy project
COPY app/*.csproj ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
COPY app/. ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "catsProject.dll"]

