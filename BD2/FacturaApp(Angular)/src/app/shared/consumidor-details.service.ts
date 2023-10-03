import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import{NgForm} from '@angular/forms';
import { ConsumidorDetails } from './consumidor-details.model';

@Injectable({
  providedIn: 'root'
})
export class ConsumidorDetailsService {
  constructor(private http:HttpClient) {
  }

  consumidorSrc = environment.apiFacturaUrl + '/ConsumidorMain'
  consumidorStorage: ConsumidorDetails[] =[];
  consumidorForm: ConsumidorDetails = new ConsumidorDetails()
  consumidorFormEnviar: boolean = false;


  getData(){
    this.http.get(this.consumidorSrc)
    .subscribe({
      //error
      error: e => {
        console.log(e);
      },
      //seguir
      next: data =>{
        this.consumidorStorage = data as ConsumidorDetails[];
      }
    })
  }

  //this is for the POST operation
  setData(){
    return this.http.post(this.consumidorSrc,this.consumidorForm)
  }

  //now, this is for clearing the form
  clearForm(form:NgForm){
    form.form.reset()
    this.consumidorForm = new ConsumidorDetails()
    this.consumidorFormEnviar=false
  }

  //put data based on id
  putData(){
    return this.http.put(this.consumidorSrc+'/'+this.consumidorForm.codConsumidor, this.consumidorForm)
  }

  //delete data based on id
  deleteData(id:number){
    return this.http.delete(this.consumidorSrc+'/'+id)
  }
}
