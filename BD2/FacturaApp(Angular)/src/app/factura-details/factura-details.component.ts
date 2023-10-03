import { Component, OnInit } from '@angular/core';
import { FacturaDetailsService } from '../shared/factura-details.service';
import { FacturaDetails } from '../shared/factura-details.model';

@Component({
  selector: 'app-factura-details',
  templateUrl: './factura-details.component.html',
  styleUrls: ['./factura-details.component.css']
})
export class FacturaDetailsComponent implements OnInit{

  constructor(public service: FacturaDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: FacturaDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.facturaForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.facturaStorage = answer as FacturaDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }


}
