import { Component } from '@angular/core';
import{NgForm} from '@angular/forms';
import { DetalleDetails } from 'src/app/shared/detalle-details.model';
import { DetalleDetailsService } from 'src/app/shared/detalle-details.service';

@Component({
  selector: 'app-formulario-detalle',
  templateUrl: './formulario-detalle.component.html',
  styleUrls: ['./formulario-detalle.component.css']
})
export class FormularioDetalleComponent {
  constructor(public service: DetalleDetailsService){

  }

  onSubmit(form:NgForm){
    //changing the status of sending
    this.service.detalleFormEnviar = true
    //send only if the form is valid: it seems ng-valid is not working properly (It can be omitted)
    if(form.valid){
      //if the id (correlativo) es 0
      if(this.service.detalleForm.omitId==0){
        this.createData(form)
      }
      else{
        this.updateData(form)
      }
    }
  }

  //separating funcction into 2 parts
  createData(form:NgForm){
    this.service.setData()
      .subscribe({
      next:answer=>{
        this.service.detalleStorage = answer as DetalleDetails[]
        this.service.clearForm(form)
        alert('Dato agregado')
      },
      error: e => {
        console.log(e)
      }
    })
  }

  updateData(form:NgForm){
    this.service.putData()
      .subscribe({
      next:answer=>{
        this.service.detalleStorage = answer as DetalleDetails[]
        this.service.clearForm(form)
        alert('Dato Modificado')
      },
      error: e => {
        console.log(e)
      }
    })
  }

}
