FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder

WORKDIR /AppWeb

#Copy proyect file 
COPY ./ ./
WORKDIR /AppWeb/Api/
RUN dotnet restore 
RUN dotnet publish -c Release -o ./../build

#Build image 
FROM  mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /AppWeb
COPY --from=builder /AppWeb/build/ ./
ENTRYPOINT ["dotnet","api.dll"]

EXPOSE 7119


