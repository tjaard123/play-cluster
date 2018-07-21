# Notifications Service

## Build

```shell
dotnet restore
dotnet publish -c Release -o dist

docker build -t lala-bank/notifications .
```