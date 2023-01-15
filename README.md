# Keycloak, authentik, ... or a SaaS service after all?

Demo repository to my (German) talk.

## Overview

Which authentication is the right one for my project? Features, configuration and integration: WebAuth, TOTP or both? RBAC, UMA, REST-API, ...? Learn all about the strengths of many SSO solutions when used with ASP.NET. Finally, there is a sample implementation for selected providers that you can use to get started right away.

## Repository structure

The repository contains several branches for individual implementations

```
root / 'Initial commit'
01-authentication-none
02-authentication-generic
03-authorization-generic
  -- main / slides
  -- 04-authorization-keycloak
  -- 04-authorization-authentik
  -- 04-authorization-zitadel
  -- 04-authorization-auth0
  -- 04-authorization-curity
  -- 04-authorization-entraid
```

## Authentication / Authorization

All samples implements a basic authentication and as far as possible an authorization using `Role Based Access Control`.

## Repository updates

I will use ‘[Rewriting History](https://git-scm.com/book/en/v2/Git-Tools-Rewriting-History)’ for updates. So just get the repository every time you want the latest version. A `git pull` will normally lead to conflicts.