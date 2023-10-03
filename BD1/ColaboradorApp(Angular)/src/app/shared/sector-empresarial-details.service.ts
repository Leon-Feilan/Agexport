import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { environment } from 'src/environments/environment';
import{NgForm} from '@angular/forms';
import { SectorEmpersarialDetails } from './sector-empersarial-details.model';

@Injectable({
  providedIn: 'root'
})
export class SectorEmpresarialDetailsService {

  
  constructor(private http:HttpClient) {
  }
  
    sectorEmpresarialSrc = environment.apiColaboradorUrl + '/SectorEmpresarialMain'
    sectorEmpresarialStorage: SectorEmpersarialDetails[] =[];
    sectorEmpresarialForm: SectorEmpersarialDetails = new SectorEmpersarialDetails()
    sectorEmpresarialFormEnviar: boolean = false;
  
  
    getData(){
      this.http.get(this.sectorEmpresarialSrc)
      .subscribe({
        //error
        error: e => {
          console.log(e);
        },
        //seguir
        next: data =>{
          this.sectorEmpresarialStorage = data as SectorEmpersarialDetails[];
        }
      })
    }
  
    //this is for the POST operation
    setData(){
      return this.http.post(this.sectorEmpresarialSrc,this.sectorEmpresarialForm)
    }
  
    //now, this is for clearing the form
    clearForm(form:NgForm){
      form.form.reset()
      this.sectorEmpresarialForm = new SectorEmpersarialDetails()
      this.sectorEmpresarialFormEnviar=false
    }
  
    //put data based on id
    putData(){
      return this.http.put(this.sectorEmpresarialSrc+'/'+this.sectorEmpresarialForm.codSector, this.sectorEmpresarialForm)
    }
  
    //delete data based on id
    deleteData(id:number){
      return this.http.delete(this.sectorEmpresarialSrc+'/'+id)
    }

}
