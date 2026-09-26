# Decisões Técnicas

## ADR-001 — Não utilizar Clean Architecture

Decisão:
Manter apenas uma Web API simples durante o laboratório.

Motivo:
O objetivo principal é visualizar o fluxo de autenticação sem introduzir abstrações arquiteturais.

Consequência:
Alguns componentes podem permanecer diretamente no projeto da API.

---

## ADR-002 — Cookie Authentication antes de Identity

Decisão:
Implementar autenticação por cookie manualmente antes de introduzir ASP.NET Core Identity.

Motivo:
Permitir compreender ClaimsIdentity, ClaimsPrincipal e SignInAsync antes que o Identity abstraia esse processo.