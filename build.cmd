@echo off
pushd Client
dotnet publish -c Release
popd

pushd Server
dotnet publish -c Release
popd

rmdir /s /q dist
mkdir dist

copy /y fxmanifest.lua dist
xcopy /y /e Server\bin\Release\netstandard2.0\publish\ dist\Server\
xcopy /y /e languagePacks\ dist\languagePacks\

rmdir /s /q Server\bin\
rmdir /s /q Server\obj\