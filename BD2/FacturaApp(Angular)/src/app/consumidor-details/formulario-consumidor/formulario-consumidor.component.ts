import { Component } from '@angular/core';
import{NgForm} from '@angular/forms';
import { ConsumidorDetails } from 'src/app/shared/consumidor-details.model';
import { ConsumidorDetailsService } from 'src/app/shared/consumidor-details.service';

@Component({
  selector: 'app-formulario-consumidor',
  templateUrl: './formulario-consumidor.component.html',
  styleUrls: ['./formulario-consumidor.component.css']
})
export class FormularioConsumidorComponent {
  constructor(public service: ConsumidorDetailsService){

  }

  onSubmit(form:NgForm){
    //changing the status of sending
    this.service.consumidorFormEnviar = true
    //send only if the form is valid: it seems ng-valid is not working properly (It can be omitted)
    if(form.valid){
      //if the id (correlativo) es 0
      if(this.service.consumidorForm.codConsumidor==0){
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
        this.service.consumidorStorage= answer as ConsumidorDetails[]
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
        this.service.consumidorStorage= answer as ConsumidorDetails[]
        this.service.clearForm(form)
        alert('Dato Modificado')
      },
      error: e => {
        console.log(e)
      }
    })
  }
}
