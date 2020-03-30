FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish --configuration Release --output out Webflix.MVC.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /www
COPY --from=build /app/out .
CMD [ "dotnet", "Webflix.MVC.dll" ]

# 1 - 7: make the build.
#  10 - 15: will take the build and runs it