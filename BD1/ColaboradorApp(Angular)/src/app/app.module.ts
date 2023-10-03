import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ColaboradorDetailsComponent } from './colaborador-details/colaborador-details.component';
import { FormularioComponent } from './colaborador-details/formulario/formulario.component';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import { TipoColaboradorDetailsComponent } from './tipo-colaborador-details/tipo-colaborador-details.component';
import { FormularioTipoColaboradorComponent } from './tipo-colaborador-details/formulario-tipo-colaborador/formulario-tipo-colaborador.component';
import { SectorEmpresarialDetailsComponent } from './sector-empresarial-details/sector-empresarial-details.component';
import { FormularioSectorEmpresarialComponent } from './sector-empresarial-details/formulario-sector-empresarial/formulario-sector-empresarial.component';
import { DetalleDetailsComponent } from './detalle-details/detalle-details.component';
import { FormularioDetallesComponent } from './detalle-details/formulario-detalles/formulario-detalles.component';

@NgModule({
  declarations: [
    AppComponent,
    ColaboradorDetailsComponent,
    FormularioComponent,
    TipoColaboradorDetailsComponent,
    FormularioTipoColaboradorComponent,
    SectorEmpresarialDetailsComponent,
    FormularioSectorEmpresarialComponent,
    DetalleDetailsComponent,
    FormularioDetallesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
