# Path to your C# file
$csFilePath = "Program.cs"

# Read the entire content of the file
$csFileContent = Get-Content -Raw -Path $csFilePath

# Verify if Program.cs file exists and has content
if (-not $csFileContent) {
    Write-Error "The Program.cs file could not be found or is empty."
    exit
}

# Output the content for verification
Write-Output $csFileContent

# Path to your appsettings.json file
$appSettingsPath = "appsettings.json"

# Read the appsettings.json file and verify if it exists
if (-not (Test-Path $appSettingsPath)) {
    Write-Error "The appsettings.json file could not be found."
    exit
}

$appSettings = Get-Content -Raw -Path $appSettingsPath | ConvertFrom-Json

# Extract the Id from appsettings.json
$scriptId = $appSettings.Script.Data.Id

# Construct the JSON payload
$payload = @{
    Id = $scriptId
    newScript = $csFileContent
} | ConvertTo-Json

# Convert the headers from JSON to a hashtable
$headers = @{}
$appSettings.Headers.PSObject.Properties | ForEach-Object {
    $headers[$_.Name] = $_.Value
}

# Send the POST request to the server
$response = Invoke-RestMethod -Uri "https://westeuv1-uiapi2387d-webpi-dev.azurewebsites.net/api/Script/update" -Method Post -Body $payload -ContentType "application/json" -Headers $headers

# Output the response for debugging purposes
$response
Write-Output $response
