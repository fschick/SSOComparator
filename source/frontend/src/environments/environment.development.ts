export const environment = {
  apiBasePath: `${location.protocol}//${location.hostname}:5050/api`,
  authority: '<Auth0 issuer URL>',
  clientId: '<application client ID>',
  audience: '<api identifier for RBAC; application client ID for authentication only>',
  scopes: 'openid profile email offline_access',
};
