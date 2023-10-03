import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { FacturaDetails } from './factura-details.model';
import{NgForm} from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class FacturaDetailsService {

  constructor(private http:HttpClient) {
   }

  facturaSrc = environment.apiFacturaUrl + '/FacturaMain'
  facturaStorage: FacturaDetails[] =[];
  facturaForm: FacturaDetails = new FacturaDetails()
  facturaFormEnviar: boolean = false;


  getData(){
    this.http.get(this.facturaSrc)
    .subscribe({
      //error
      error: e => {
        console.log(e);
      },
      //seguir
      next: data =>{
        this.facturaStorage = data as FacturaDetails[];
      }
    })
  }

  //this is for the POST operation
  setData(){
    return this.http.post(this.facturaSrc,this.facturaForm)
  }

  //now, this is for clearing the form
  clearForm(form:NgForm){
    form.form.reset()
    this.facturaForm = new FacturaDetails()
    this.facturaFormEnviar=false
  }

  //put data based on id
  putData(){
    return this.http.put(this.facturaSrc+'/'+this.facturaForm.codFactura, this.facturaForm)
  }

  //delete data based on id
  deleteData(id:number){
    return this.http.delete(this.facturaSrc+'/'+id)
  }

}
