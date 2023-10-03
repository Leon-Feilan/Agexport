import { Component, OnInit } from '@angular/core';
import { DetalleDetailsService } from '../shared/detalle-details.service';
import { DetalleDetails } from '../shared/detalle-details.model';

@Component({
  selector: 'app-detalle-details',
  templateUrl: './detalle-details.component.html',
  styleUrls: ['./detalle-details.component.css']
})
export class DetalleDetailsComponent implements OnInit{
  constructor(public service: DetalleDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: DetalleDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.detalleForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.detalleStorage = answer as DetalleDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }
}
