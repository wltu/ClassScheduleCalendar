compile:
	dotnet build ./ClassScheduleCalendar
	dotnet build ./ClassScheduleCalendarTests

compile-main:
	dotnet build ./ClassScheduleCalendar

compile-test:
	dotnet build ./ClassScheduleCalendarTests

run:
	dotnet run --project ./ClassScheduleCalendar

test:
	dotnet test ./ClassScheduleCalendarTests
