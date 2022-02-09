param ($migration_name)

if ($migration_name -eq $null) {
    write-host "Please provide migration name"
    exit
}

# $directory_path = Split-Path $MyInvocation.MyCommand.Path -Parent
# Set-Location "$directory_path/../TextbookManagement.Persistence"

dotnet ef migrations add $migration_name `
    --project TextbookManagement.Persistence `
    --startup-project TextbookManagement.Mvc `
    --output-dir Migrations