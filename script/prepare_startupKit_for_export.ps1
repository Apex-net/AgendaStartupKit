$path = "..\src\*"
$includeExtensions = @("*.asax","*.config","*.cshtml","*.csproj","*.cs")
$searchPattern = "WebMVC4" 
$excludeDirs = @("*\obj\*","*Scripts\i18n*","*\bin\*","*\packages\*")
$replaceString = '$safeprojectname$' 

$files = Get-ChildItem -Path $path -Include $includeExtensions -Recurse 


$i = 0
ForEach ($file in $files) { 
    
    $exit = $false

    foreach ($excDir in $excludeDirs) {
        if( $file.FullName -like $excDir ) 
        {
            $exit = $true
            continue
        }
    }

    if($exit) { continue } 

    if((Get-Content $file.fullName)  -match $searchPattern) 
    {
        Write-Host  $file.FullName `n  "found at lines: " $(Select-String -Path $file.fullName -Pattern $searchPattern | Select-Object LineNumber) `n

        <# commentare/scommentare per fare la ricerca/sostituzione #>
        (Get-Content $file.fullName) -replace $searchPattern, $replaceString | `
            Set-Content $file.fullName -Force -Encoding UTF8   
           
        $i++
    }
}

Write-Host $i "files modificati"
