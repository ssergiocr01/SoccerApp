import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  titulo: string = 'Bienvenido al Sistema Soccer!';
  usuarios: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get('https://localhost:7032/api/Usuario').subscribe({
      next: response => this.usuarios = response,
      error: error => console.log(error),
      complete: () => console.log('La solicitud está completa')
    })
  }


}
