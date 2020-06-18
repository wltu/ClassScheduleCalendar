export STORAGE_LOCATION = $(CURDIR)/storage

compile: storage
	dotnet build ./ClassScheduleCalendar
	dotnet build ./ClassScheduleCalendarTests

compile-main: storage
	dotnet build ./ClassScheduleCalendar

compile-test:
	dotnet build ./ClassScheduleCalendarTests

run: storage
	dotnet run --project ./ClassScheduleCalendar

test: storage
	dotnet test ./ClassScheduleCalendarTests

storage :
	mkdir storage