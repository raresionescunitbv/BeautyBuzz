FROM mcr.microsoft.com/dotnet/sdk:5:0 AS build
WORKDIR /src
COPY BeautyBuzz.csproj .
RUN dotnet restore "BeautyBuzz.csproj"
COPY . . 
RUN dotnet publish "BeautyBuzz.csproj" -c Release -o /publish

FROM mcr.microsoft.com/dotnet/sdk:5:0 AS final
WORKDIR /app
COPY --from=build /publish .

ENTRYPOINT [ "dotnet", "BeautyBuzz.dll" ]