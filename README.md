# D4SignClient
Cliente para o [D4Sign](https://docapi.d4sign.com.br/), atualizado para .NET 8

O projeto me possibilitou utilizar a API do sistema [D4Sign](https://d4sign.com.br/) utilizando tecnologia .Net e navegar nos cofres existentes para fazer o download de documentos assinados, existem outras possibilidades para o uso desse projeto que já foram implementadas por [Hellstricker](https://github.com/Hellstricker), mas, não testei todas, não precisei utilizar ainda.

### Exemplo usando C#
 ``` csharp
 //Create client
var d4client = new D4Sign.Client.D4SignClient(host,version, token, cryptKey);

//Download document
var result = await d4client.GetDocument(documentKey, DocumentDownloadType.PDF);
Console.WriteLine(d.Url);
 ```

### O que é D4Sign?
A [D4Sign](https://d4sign.com.br/) é uma plataforma de assinatura eletrônica e digital do Brasil que possui integração de dados com o governo federal como forma de autenticação [gov.br](https://www.gov.br/pt-br/servicos/assinatura-eletronica).