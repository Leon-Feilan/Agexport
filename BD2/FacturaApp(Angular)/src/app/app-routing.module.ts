import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FacturaDetailsComponent } from './factura-details/factura-details.component';
import { FormularioComponent } from './factura-details/formulario/formulario.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
