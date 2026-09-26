# Roadmap

<table>
    <tr>
        <td>Tag</td>
        <td>Etapa</td>
        <td>Meta principal</td>
        <td>O que deve existir no projeto</td>
    </tr>
    <tr>
        <td>`v0.0-initial`</td>
        <td>Estrutura inicial</td>
        <td>Ter uma API mínima funcionando antes de qualquer autenticação</td>
        <td>Solution, Web API, endpoint público, README inicial</td>
    </tr>
    <tr>
        <td>`v0.1-fundamentals`</td>
        <td>Fundamentos</td>
        <td>Entender autenticação, autorização, `401`, `403`, `[Authorize]` e `HttpContext.User`</td>
        <td>Endpoint público e protegido, configuração mínima de authorization, documentação dos conceitos</td>
    </tr>
    <tr>
        <td>`v0.2-cookie-auth`</td>
        <td>Cookie Authentication</td>
        <td>Entender como uma sessão por cookie é criada e reconstruída</td>
        <td>`AddAuthentication`, `AddCookie`, `ClaimsIdentity`, `ClaimsPrincipal`, `SignInAsync`, `SignOutAsync`, endpoint `/me`</td>
    </tr>
    <tr>
        <td>`v0.3-identity`</td>
        <td>ASP.NET Core Identity</td>
        <td>Entender como usuários são gerenciados e persistidos no SQL Server</td>
        <td>EF Core, SQL Server, Identity, migrations, tabelas `AspNet*`, registro de usuário e análise de `PasswordHash`</td>
    </tr>
    <tr>
        <td>`v0.4-identity-cookie`</td>
        <td>Identity + Cookies</td>
        <td>Entender como Identity e Cookie Authentication trabalham juntos</td>
        <td>Registro, login, logout e usuário atual usando Identity; sessão por cookie; integração inicial com Angular quando fizer sentido</td>
    </tr>
    <tr>
        <td>`v0.5-jwt`</td>
        <td>JWT Bearer</td>
        <td>Entender autenticação stateless com Access Token</td>
        <td>Login retornando JWT, `JwtBearer`, header `Authorization: Bearer`, claims, issuer, audience, expiration</td>
    </tr>
    <tr>
        <td>`v0.6-refresh-token`</td>
        <td>Ciclo de tokens</td>
        <td>Entender renovação e revogação de sessões baseadas em token</td>
        <td>Access Token curto, Refresh Token, endpoint `/refresh`, expiração, rotação/revogação simples</td>
    </tr>
    <tr>
        <td>`v0.7-authorization`</td>
        <td>Autorização</td>
        <td>Separar definitivamente autenticação de autorização</td>
        <td>Roles, Claims, Policies, endpoints com diferentes regras de acesso, exemplos claros de `401` e `403`</td>
    </tr>
    <tr>
        <td>`v0.8-oauth`</td>
        <td>OAuth 2.0</td>
        <td>Entender autorização delegada e os principais atores do protocolo</td>
        <td>Exemplo ou integração usando Authorization Code + PKCE, scopes, client, authorization server e resource server</td>
    </tr>
    <tr>
        <td>`v0.9-oidc`</td>
        <td>OpenID Connect</td>
        <td>Entender autenticação federada e diferença entre Access Token e ID Token</td>
        <td>Login com provedor externo OIDC, ID Token, Access Token, claims do usuário e fluxo de callback</td>
    </tr>
    <tr>
        <td>`v1.0-auth-lab`</td>
        <td>Comparação final</td>
        <td>Conseguir escolher uma estratégia de autenticação conscientemente</td>
        <td>Documentação comparando Cookie, JWT, Identity, OAuth e OIDC, riscos, cenários de uso e arquitetura final</td>
    </tr>
</table>


## v0.0-initial
Objetivo:
- Criar a solução
- Criar a API
- Ter um endpoint público funcionando

Critério de conclusão:
- Projeto compila
- API executa
- GET /api/public retorna 200

## v0.1-fundamentals
Objetivo:
- Entender autenticação e autorização
- Entender 401 e 403
- Conhecer HttpContext.User
- Criar endpoint protegido

Critério de conclusão:
- Consigo explicar authentication vs authorization
- Consigo explicar 401 vs 403
- GET /api/private exige autenticação

## v0.2-cookie-auth
Objetivo:
- Implementar Cookie Authentication manual
- Entender ClaimsPrincipal
- Entender SignInAsync e SignOutAsync