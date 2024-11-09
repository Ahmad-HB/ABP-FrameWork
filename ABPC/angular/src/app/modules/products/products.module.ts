// src/app/modules/products/products.module.ts
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ProductsRoutingModule } from './products-routing.module';
import { ListProductsComponent } from './list-products/list-products.component';
import { AddProductComponent } from './add-products/add-products.component';
import { ListService } from '@abp/ng.core';
import { LocalizationModule } from '@abp/ng.core';

@NgModule({
  declarations: [
    ListProductsComponent,
    AddProductComponent,
  ],
  imports: [
    CommonModule,
    NgxDatatableModule,
    ReactiveFormsModule,
    ProductsRoutingModule,
    LocalizationModule,
    
  ],
  providers: [
    ListService,
    // other services
  ]
})
export class ProductsModule { }