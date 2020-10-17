.PHONY: all
## Runs unit the tests.
all:test

.PHONY: test
## Runs the unit tests.
test:
	dotnet test -c Release --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover

.PHONY: start
## Starts the app.
start:
	dotnet run

.PHONY: clean
## Removes generated files.
clean:
	dotnet clean
	dotnet clean -c Release 

## build
.PHONY: build
build:
	dotnet build -c Release 

.PHONY: publish
publish:
	dotnet publish -c Release

-include User.mk
-include ../User.mk
-include ~/User.mk
