import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { TipoColaboradorDetails } from './tipo-colaborador-details.model';
import{NgForm} from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class TipoColaboradorDetailsService {

  constructor(private http:HttpClient) {
  }
  
    tipoColaboradorSrc = environment.apiColaboradorUrl + '/TipoColaboradorMain'
    tipoColaboradorStorage: TipoColaboradorDetails[] =[];
    tipocolaboradorForm: TipoColaboradorDetails = new TipoColaboradorDetails()
    tipoColaboradorFormEnviar: boolean = false;
  
  
    getData(){
      this.http.get(this.tipoColaboradorSrc)
      .subscribe({
        //error
        error: e => {
          console.log(e);
        },
        //seguir
        next: data =>{
          this.tipoColaboradorStorage = data as TipoColaboradorDetails[];
        }
      })
    }
  
    //this is for the POST operation
    setData(){
      return this.http.post(this.tipoColaboradorSrc,this.tipocolaboradorForm)
    }
  
    //now, this is for clearing the form
    clearForm(form:NgForm){
      form.form.reset()
      this.tipocolaboradorForm = new TipoColaboradorDetails()
      this.tipoColaboradorFormEnviar=false
    }
  
    //put data based on id
    putData(){
      return this.http.put(this.tipoColaboradorSrc+'/'+this.tipocolaboradorForm.codTipoColaborador, this.tipocolaboradorForm)
    }
  
    //delete data based on id
    deleteData(id:number){
      return this.http.delete(this.tipoColaboradorSrc+'/'+id)
    }


}
