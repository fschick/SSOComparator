export const environment = {
  apiBasePath: `${location.protocol}//${location.hostname}:5050/api`,
  authority: '<authentik application issuer URL>',
  clientId: '<authentik provider client ID>',
  scopes: 'openid profile email offline_access',
};
