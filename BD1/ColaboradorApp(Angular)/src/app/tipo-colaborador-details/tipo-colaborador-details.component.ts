import { Component, OnInit  } from '@angular/core';
import { TipoColaboradorDetails } from '../shared/tipo-colaborador-details.model';
import { TipoColaboradorDetailsService } from '../shared/tipo-colaborador-details.service';

@Component({
  selector: 'app-tipo-colaborador-details',
  templateUrl: './tipo-colaborador-details.component.html',
  styleUrls: ['./tipo-colaborador-details.component.css']
})
export class TipoColaboradorDetailsComponent implements OnInit {
  constructor(public service: TipoColaboradorDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: TipoColaboradorDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.tipocolaboradorForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.tipoColaboradorStorage = answer as TipoColaboradorDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }
}
