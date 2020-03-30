FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

# create a directory for the runs to be stored in.
WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish --configuration Release --output out Webflix.API.csproj

# create another build
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# create a directory for the runs to be stored in.
WORKDIR /www
COPY --from=build /app/out .
CMD [ "dotnet", "Webflix.API.dll"]

# 1 - 7: make the build.
#  10 - 15: will take the build and runs it
#Running image: