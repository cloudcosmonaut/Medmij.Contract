pack:
	dotnet restore
	dotnet build --configuration Release --no-restore
	dotnet pack

clean:
	rm -rf obj/
	rm -rf bin/

publish: clean pack
	dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json -k $NUGET_API_KEY --skip-duplicate -n 1
