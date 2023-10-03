import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import{NgForm} from '@angular/forms';
import { DetalleDetails } from './detalle-details.model';

@Injectable({
  providedIn: 'root'
})
export class DetalleDetailsService {

  constructor(private http:HttpClient) {
  }

  detalleSrc = environment.apiFacturaUrl + '/Detalle_Factura_ProductoMain'
  detalleStorage: DetalleDetails[] =[];
  detalleForm: DetalleDetails = new DetalleDetails()
  detalleFormEnviar: boolean = false;


  getData(){
    this.http.get(this.detalleSrc)
    .subscribe({
      //error
      error: e => {
        console.log(e);
      },
      //seguir
      next: data =>{
        this.detalleStorage = data as DetalleDetails[];
      }
    })
  }

  //this is for the POST operation
  setData(){
    return this.http.post(this.detalleSrc,this.detalleForm)
  }

  //now, this is for clearing the form
  clearForm(form:NgForm){
    form.form.reset()
    this.detalleForm = new DetalleDetails()
    this.detalleFormEnviar=false
  }

  //put data based on id
  putData(){
    return this.http.put(this.detalleSrc+'/'+this.detalleForm.omitId, this.detalleForm)
  }

  //delete data based on id
  deleteData(id:number){
    return this.http.delete(this.detalleSrc+'/'+id)
  }
}
