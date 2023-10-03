import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import{NgForm} from '@angular/forms';
import { ProductoDetails } from './producto-details.model';
@Injectable({
  providedIn: 'root'
})
export class ProductoDetailsService {

  constructor(private http:HttpClient) {
  }

  productoSrc = environment.apiFacturaUrl + '/ProductoMain'
  productoStorage: ProductoDetails[] =[];
  productoForm: ProductoDetails = new ProductoDetails()
  productoFormEnviar: boolean = false;


  getData(){
    this.http.get(this.productoSrc)
    .subscribe({
      //error
      error: e => {
        console.log(e);
      },
      //seguir
      next: data =>{
        this.productoStorage = data as ProductoDetails[];
      }
    })
  }

  //this is for the POST operation
  setData(){
    return this.http.post(this.productoSrc,this.productoForm)
  }

  //now, this is for clearing the form
  clearForm(form:NgForm){
    form.form.reset()
    this.productoForm = new ProductoDetails()
    this.productoFormEnviar=false
  }

  //put data based on id
  putData(){
    return this.http.put(this.productoSrc+'/'+this.productoForm.codProducto, this.productoForm)
  }

  //delete data based on id
  deleteData(id:number){
    return this.http.delete(this.productoSrc+'/'+id)
  }
}
