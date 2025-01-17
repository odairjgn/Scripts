do {
    $pasta = Read-Host "Informe a pasta"
    $arquivos = Get-ChildItem -Path $pasta -File -Recurse
    $substituir = Read-Host "Informe o fragmento a substituir"

    foreach ($arquivo in $arquivos) {
        $novoNome = $arquivo.FullName.Replace($substituir, "")
        Rename-Item -Path $arquivo.FullName -NewName $novoNome
        Write-Host "$arquivo.FullName => $novoNome"
    }

    $resposta = Read-Host "Efetuar nova substituição? (S/N)"
} while($resposta.ToUpper() -eq "S")

