import { Component } from '@angular/core';
import{NgForm} from '@angular/forms';
import { TipoColaboradorDetails } from 'src/app/shared/tipo-colaborador-details.model';
import { TipoColaboradorDetailsService } from 'src/app/shared/tipo-colaborador-details.service';

@Component({
  selector: 'app-formulario-tipo-colaborador',
  templateUrl: './formulario-tipo-colaborador.component.html',
  styleUrls: ['./formulario-tipo-colaborador.component.css']
})
export class FormularioTipoColaboradorComponent {
  constructor(public service: TipoColaboradorDetailsService){

  }

  onSubmit(form:NgForm){
    //changing the status of sending
    this.service.tipoColaboradorFormEnviar = true
    //send only if the form is valid: it seems ng-valid is not working properly (It can be omitted)
    if(form.valid){
      //if the id (correlativo) es 0
      if(this.service.tipocolaboradorForm.codTipoColaborador==0){
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
        this.service.tipoColaboradorStorage = answer as TipoColaboradorDetails[]
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
        this.service.tipoColaboradorStorage = answer as TipoColaboradorDetails[]
        this.service.clearForm(form)
        alert('Dato Modificado')
      },
      error: e => {
        console.log(e)
      }
    })
  }
}
