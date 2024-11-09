import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ABPC',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44332/',
    redirectUri: baseUrl,
    clientId: 'ABPC_App',
    responseType: 'code',
    scope: 'offline_access ABPC',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44392',
      rootNamespace: 'ABPC',
    },
  },
} as Environment;
