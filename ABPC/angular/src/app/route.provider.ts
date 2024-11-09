import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];
//products/add
function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },{
        path: '/products',
        name: 'Products',
        iconClass: 'fas fa-store',
        order: 3,
        layout: eLayoutType.application,
      },{
        path: '/categories',
        name: 'Categories',
        iconClass: 'fas fa-th-large',
        order: 2,
        layout: eLayoutType.application,
      }
    ]);
  };
}
