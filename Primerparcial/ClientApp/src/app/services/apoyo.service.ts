import { Injectable, Inject } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import {Apoyo} from '../ApoyoEconomico/models/apoyo';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { FindValueSubscriber } from 'rxjs/internal/operators/find';


@Injectable({
  providedIn: 'root'
})
export class ApoyoService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
      @Inject('BASE_URL') baseUrl: string,
      private handleErrorService: HandleHttpErrorService
  ) 
  {
    this.baseUrl = baseUrl;
   }

   get(): Observable<Apoyo[]> {
    return this.http.get<Apoyo[]>(this.baseUrl + 'api/Apoyo')
        .pipe(
            tap(_ => this.handleErrorService.log('datos enviados')),
            catchError(this.handleErrorService.handleError<Apoyo[]>('Consulta Apoyo', null))
        );
  }

  post(apoyo: Apoyo): Observable<Apoyo> {
    return this.http.post<Apoyo>(this.baseUrl + 'api/Apoyo', apoyo)
        .pipe(
            tap(_ => this.handleErrorService.log('datos enviados')),
            catchError(this.handleErrorService.handleError<Apoyo>('Registrar Apoyo', null))
        );
  }
}
