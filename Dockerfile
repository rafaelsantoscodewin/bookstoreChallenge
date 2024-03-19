FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

RUN apt-get update && \
    apt-get install -y openssl && \
    rm -rf /var/lib/apt/lists/*

RUN dotnet dev-certs https -ep /https/bookstore.pfx -p Docker123
RUN dotnet dev-certs https --trust

COPY bookstoreChallenge/bookstoreChallenge.app.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish bookstoreChallenge/bookstoreChallenge.sln -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=build /app/out .
COPY --from=build /https/* /https/
ENTRYPOINT ["dotnet", "bookstoreChallenge.app.dll"]