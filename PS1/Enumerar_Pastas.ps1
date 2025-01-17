do {
    $pasta = Read-Host "Informe a pasta"
    $pastas = Get-ChildItem -Path $pasta -Directory
    Write-Host $pastas
    $i = 0
    foreach ($p in $pastas) {
        $i++
        $f = $i.ToString("D2");
        $novoNome = Join-Path -Path $pasta -ChildPath "$f - $p.Name"
        Rename-Item -Path $p.FullName -NewName $novoNome
        Write-Host "$p => $novoNome"
    }

    $resposta = Read-Host "Efetuar nova renomeacao? (S/N)"
} while($resposta.ToUpper() -eq "S")

