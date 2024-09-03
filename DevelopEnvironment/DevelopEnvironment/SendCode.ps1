# Path to your C# file
$csFilePath = "Program.cs"

# Read the entire content of the file
$csFileContent = Get-Content -Raw -Path $csFilePath

# Define the marker after which the code will be extracted
$marker = [regex]::Escape("/**** CODE PLACE ****/")

# Extract the code after the marker
$codeAfterMarker = $csFileContent -split $marker, 2 | Select-Object -Last 1

# Check if $codeAfterMarker is null or empty
if (-not $codeAfterMarker) {
    Write-Error "The marker was not found in the file."
    exit
}

# Trim any leading/trailing whitespace
$codeAfterMarker = $codeAfterMarker.Trim()

# Output the extracted code for verification
Write-Output $codeAfterMarker

# Path to your appsettings.json file
$appSettingsPath = "appsettings.json"

# Read the appsettings.json file
$appSettings = Get-Content -Raw -Path $appSettingsPath | ConvertFrom-Json

# Extract the Id from appsettings.json
$scriptId = $appSettings.Script.Data.Id

# Construct the JSON payload
$payload = @{
    Id = $scriptId
    newScript = $codeAfterMarker
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
