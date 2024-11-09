import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddProductComponent } from './add-products/add-products.component';
import { ListProductsComponent } from './list-products/list-products.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: ListProductsComponent
  },
  {
    path: 'add',
    component: AddProductComponent
  }
];

// const routes: Routes = [
//   { path: 'products', component: ListProductsComponent },
//   { path: 'products/add', component: AddProductComponent }, // Add the route
//   // other routes
// ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
