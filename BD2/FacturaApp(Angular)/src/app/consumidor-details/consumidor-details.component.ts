import { Component, OnInit} from '@angular/core';
import { ConsumidorDetailsService } from '../shared/consumidor-details.service';
import { ConsumidorDetails } from '../shared/consumidor-details.model';

@Component({
  selector: 'app-consumidor-details',
  templateUrl: './consumidor-details.component.html',
  styleUrls: ['./consumidor-details.component.css']
})
export class ConsumidorDetailsComponent implements OnInit {
  constructor(public service: ConsumidorDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: ConsumidorDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.consumidorForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.consumidorStorage = answer as ConsumidorDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }
}
