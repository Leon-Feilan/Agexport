import { Component } from '@angular/core';
import{NgForm} from '@angular/forms';
import { SectorEmpersarialDetails } from 'src/app/shared/sector-empersarial-details.model';
import { SectorEmpresarialDetailsService } from 'src/app/shared/sector-empresarial-details.service';

@Component({
  selector: 'app-formulario-sector-empresarial',
  templateUrl: './formulario-sector-empresarial.component.html',
  styleUrls: ['./formulario-sector-empresarial.component.css']
})
export class FormularioSectorEmpresarialComponent {
  constructor(public service: SectorEmpresarialDetailsService){

  }

  onSubmit(form:NgForm){
    //changing the status of sending
    this.service.sectorEmpresarialFormEnviar = true
    //send only if the form is valid: it seems ng-valid is not working properly (It can be omitted)
    if(form.valid){
      //if the id (correlativo) es 0
      if(this.service.sectorEmpresarialForm.codSector==0){
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
        this.service.sectorEmpresarialStorage = answer as SectorEmpersarialDetails[]
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
        this.service.sectorEmpresarialStorage = answer as SectorEmpersarialDetails[]
        this.service.clearForm(form)
        alert('Dato Modificado')
      },
      error: e => {
        console.log(e)
      }
    })
  }
}
