import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FacturaDetailsComponent } from './factura-details/factura-details.component';
import { FormularioComponent } from './factura-details/formulario/formulario.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import { ConsumidorDetailsComponent } from './consumidor-details/consumidor-details.component';
import { FormularioConsumidorComponent } from './consumidor-details/formulario-consumidor/formulario-consumidor.component';
import { ProductoDetailsComponent } from './producto-details/producto-details.component';
import { FormularioProductoComponent } from './producto-details/formulario-producto/formulario-producto.component';
import { DetalleDetailsComponent } from './detalle-details/detalle-details.component';
import { FormularioDetalleComponent } from './detalle-details/formulario-detalle/formulario-detalle.component';

@NgModule({
  declarations: [
    AppComponent,
    FacturaDetailsComponent,
    FormularioComponent,
    ConsumidorDetailsComponent,
    FormularioConsumidorComponent,
    ProductoDetailsComponent,
    FormularioProductoComponent,
    DetalleDetailsComponent,
    FormularioDetalleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule, //not the one is created in formulario-factura
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
