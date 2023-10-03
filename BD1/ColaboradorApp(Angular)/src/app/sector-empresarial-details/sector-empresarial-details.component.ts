import { Component, OnInit } from '@angular/core';
import { SectorEmpresarialDetailsService } from '../shared/sector-empresarial-details.service';
import { SectorEmpersarialDetails } from '../shared/sector-empersarial-details.model';

@Component({
  selector: 'app-sector-empresarial-details',
  templateUrl: './sector-empresarial-details.component.html',
  styleUrls: ['./sector-empresarial-details.component.css']
})
export class SectorEmpresarialDetailsComponent implements OnInit{
  constructor(public service: SectorEmpresarialDetailsService){
  }
    
  ngOnInit():void{
    //getting data of Factura
    this.service.getData();
  }

  //select data and then fillform
  fillForm(data: SectorEmpersarialDetails){
    //now sending data to the form 1.copy array 2. send it
    this.service.sectorEmpresarialForm= Object.assign({},data);
  }

  onDelete(cod:number){
    if(confirm('Quieres eliminar el dato?')){
      this.service.deleteData(cod)
        .subscribe({
        next:answer=>{
          this.service.sectorEmpresarialStorage = answer as SectorEmpersarialDetails[]
          alert('Dato Eliminado')
        },
        error: e => {
          console.log(e)
        }
      })
    }
  }
}
