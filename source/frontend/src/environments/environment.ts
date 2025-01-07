export const environment = {
  apiBasePath: `${location.protocol}//${location.hostname}:5050/api`,
  authority: `<ZITADEL issuer URL>`,
  clientId: '<ZITADEL application client ID>',
  scopes: 'openid profile email offline_access',
};
