import { Component } from '@angular/core';
import { ProductoDetailsService } from 'src/app/shared/producto-details.service';
import{NgForm} from '@angular/forms';
import { ProductoDetails } from 'src/app/shared/producto-details.model';

@Component({
  selector: 'app-formulario-producto',
  templateUrl: './formulario-producto.component.html',
  styleUrls: ['./formulario-producto.component.css']
})
export class FormularioProductoComponent {
  constructor(public service: ProductoDetailsService){

  }

  onSubmit(form:NgForm){
    //changing the status of sending
    this.service.productoFormEnviar = true
    //send only if the form is valid: it seems ng-valid is not working properly (It can be omitted)
    if(form.valid){
      //if the id (correlativo) es 0
      if(this.service.productoForm.codProducto==0){
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
        this.service.productoStorage= answer as ProductoDetails[]
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
        this.service.productoStorage= answer as ProductoDetails[]
        this.service.clearForm(form)
        alert('Dato Modificado')
      },
      error: e => {
        console.log(e)
      }
    })
  }

}
