# Lista de Filmes(API Dotnet 5)

<!---Esses são exemplos. Veja https://shields.io para outras pessoas ou para personalizar este conjunto de escudos. Você pode querer incluir dependências, status do projeto e informações de licença aqui--->

![GitHub repo size](https://img.shields.io/github/repo-size/iuricode/README-template?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/iuricode/README-template?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/iuricode/README-template?style=for-the-badge)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/iuricode/README-template?style=for-the-badge)
![Bitbucket open pull requests](https://img.shields.io/bitbucket/pr-raw/iuricode/README-template?style=for-the-badge)

> Este projeto é uma simples API utilizando dotnet 5 que tem por principal objetivo provar os conceitos de API, JWT Token e Lógica utilizando a linguagem C#.


### Problema proposto

Criar uma API que seja possível:

- [x] Retornar em JSON uma lista de filmes com 20 registros por página (Não é necessário criar um bd próprio pode deixar estático no código os
filmes)
- [x] Ser possível buscar um filme com as 3 primeiras letras
- [x] Criar um meio de autenticação da API (token, x-api por exemplo) que você
acredite ser o mais seguro
Plus:
- [x] Ser possível buscar um filme com palavras chaves(qualquer palavra que o filme contenha)

## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
* Você tem uma máquina com o `<visual studio / visual studio code>` rodando.
* Você possui a versão 5 do `<Dotnet Framework>` instalada.


## 🚀 Rodando

Para rodar o ApiTest, siga estas etapas:

1. Baixe a pasta do projeto(git clone)

2. Descompacte a pasta

3. Navegue na pasta descompactada e abra o arquivo "ApiTeste.sln"

## ☕ Usando

Para usar ApiTest, siga estas etapas:

```
Após abrir o projeto e executar, irá abrir o browser com o swagger da API, onde é possível testar as funcionalidades
```
<img src="https://i.imgur.com/XotirMi.jpeg" alt="tela inicial swagger"/><br><br>

```
Os métodos Get/anonymous e FilmesPorPagina são publicos o que significa que não há necessidade de autenticação para usa-los.
Para usar o método Get/anonymous por exemplo é necessário clicar nele e pressionar "Try it out" e em seguida "Execute".
```
<img src="https://i.imgur.com/wweRWY7.jpeg" alt="try it out"/><br>
<img src="https://i.imgur.com/m7pxMaQ.jpeg" alt="Execute"/><br><br>

```
Ao clicar em "Execute" pode-se verificar a resposta/retorno logo abaixo
```
<img src="https://i.imgur.com/jnFZgim.jpeg" alt="ResultadoGet"/><br><br>

```
Agora vamos testar um método que requer autenticação...!
Primeiro passo é executar o método authenticate
```
<img src="https://i.imgur.com/n9RxWhi.jpeg" alt="metodo login"/><br><br>


```
Logo ao abrir, deve-se editar o username e o password, ambos para guilherme, pois é o usuário que tem a Role de Admin
```
<img src="https://i.imgur.com/nTIqV4S.jpeg" alt="preenchimento login"/><br><br>



```
Após executar o retorno deve ter gerado um token, deve-se então copiar este token pois será usado posteriormente 
```
<img src="https://i.imgur.com/EBc65hP.jpeg" alt="copia do token"/><br><br>


```
Com o token copiado clicar no botão "Authorize" e preencher Bearer [Token que foi copiado] sem colchetes.
```
<img src="https://i.imgur.com/t9QEtVU.jpeg" alt="Botão Authorize"/><br>
<img src="https://i.imgur.com/ooUUmYw.jpeg" alt="Colar Bearer"/><br><br>
```
Pronto agora já é possível testar qualquer método que exija authenticação(BuscaFilmeContendo, BuscaFilmeUsandoTresPrimeirosCaracteres)
```


[⬆ Voltar ao topo](#nome-do-projeto)<br>
