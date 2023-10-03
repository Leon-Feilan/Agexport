import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { ColaboradorDetails } from './colaborador-details.model';
import{NgForm} from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class ColaboradorDetailsService {

constructor(private http:HttpClient) {
}

  colaboradorSrc = environment.apiColaboradorUrl + '/ColaboradorMain'
  colaboradorStorage: ColaboradorDetails[] =[];
  colaboradorForm: ColaboradorDetails = new ColaboradorDetails()
  colaboradorFormEnviar: boolean = false;


  getData(){
    this.http.get(this.colaboradorSrc)
    .subscribe({
      //error
      error: e => {
        console.log(e);
      },
      //seguir
      next: data =>{
        this.colaboradorStorage = data as ColaboradorDetails[];
      }
    })
  }

  //this is for the POST operation
  setData(){
    return this.http.post(this.colaboradorSrc,this.colaboradorForm)
  }

  //now, this is for clearing the form
  clearForm(form:NgForm){
    form.form.reset()
    this.colaboradorForm = new ColaboradorDetails()
    this.colaboradorFormEnviar=false
  }

  //put data based on id
  putData(){
    return this.http.put(this.colaboradorSrc+'/'+this.colaboradorForm.codColaborador, this.colaboradorForm)
  }

  //delete data based on id
  deleteData(id:number){
    return this.http.delete(this.colaboradorSrc+'/'+id)
  }
}
