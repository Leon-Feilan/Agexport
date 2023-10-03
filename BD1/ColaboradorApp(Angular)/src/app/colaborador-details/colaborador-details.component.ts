import { Component, OnInit } from '@angular/core';
import { ColaboradorDetailsService } from '../shared/colaborador-details.service';
import { ColaboradorDetails } from '../shared/colaborador-details.model';

@Component({
  selector: 'app-colaborador-details',
  templateUrl: './colaborador-details.component.html',
  styleUrls: ['./colaborador-details.component.css']
})
export class ColaboradorDetailsComponent implements OnInit{
  
  constructor(public service: ColaboradorDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: ColaboradorDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.colaboradorForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.colaboradorStorage = answer as ColaboradorDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }
}
