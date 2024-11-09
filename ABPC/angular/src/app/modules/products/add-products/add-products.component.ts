// src/app/modules/products/add-products/add-products.component.ts
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoriesService, CategoryDto } from '@proxy/categories';
import { CreateUpdateProductDto, ProductsService } from '@proxy/products';

@Component({
  selector: 'app-add-products',
  templateUrl: './add-products.component.html',
  styleUrls: ['./add-products.component.scss']
})
export class AddProductComponent implements OnInit {
  productForm: FormGroup;
  categories: CategoryDto[] = [];

  constructor(
    private productsService: ProductsService,
    private categoriesService: CategoriesService,
    private router: Router,
    private formBuilder: FormBuilder
  ) {
    this.buildForm();
  }

  ngOnInit(): void {
    this.categoriesService.getList({ maxResultCount: 100, skipCount: 0 }).subscribe(res => {
      this.categories = res.items;
    });
  }

  buildForm() {
    this.productForm = this.formBuilder.group({
      nameAr: ['', [Validators.required, Validators.maxLength(300)]],
      nameEn: ['', [Validators.required, Validators.maxLength(300)]],
      descriptionAr: ['', [Validators.required, Validators.maxLength(1000)]],
      descriptionEn: ['', [Validators.required, Validators.maxLength(1000)]],
      categoryId: [null, [Validators.required]],
    });
  }

  onSubmit() {
    if (!this.productForm.valid) {
      return;
    }
    const productDto = this.productForm.value as CreateUpdateProductDto;
    this.productsService.createProduct(productDto).subscribe(() => {
      this.router.navigateByUrl('/products');
    });
  }

  back() {
    this.router.navigateByUrl('/products');
  }
}
