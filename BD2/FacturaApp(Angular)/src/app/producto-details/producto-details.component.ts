import { Component, OnInit} from '@angular/core';
import { ProductoDetailsService } from '../shared/producto-details.service';
import { ProductoDetails } from '../shared/producto-details.model';

@Component({
  selector: 'app-producto-details',
  templateUrl: './producto-details.component.html',
  styleUrls: ['./producto-details.component.css']
})
export class ProductoDetailsComponent implements OnInit {
  constructor(public service: ProductoDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: ProductoDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.productoForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.productoStorage = answer as ProductoDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }

}
