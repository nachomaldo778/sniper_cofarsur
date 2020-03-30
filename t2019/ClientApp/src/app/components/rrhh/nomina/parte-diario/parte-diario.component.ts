import { Component, OnInit, ViewChild } from '@angular/core';
import { Novedades } from 'src/app/models/rrhh/novedades/novedades.model';
import { NovedadesService } from 'src/app/services/rrhh/novedades/novedades.service';


import { MatTableDataSource, MatPaginator } from '@angular/material';


@Component({
  selector: 'app-parte-diario',
  templateUrl: './parte-diario.component.html',
  styleUrls: ['./parte-diario.component.css']
})
export class ParteDiarioComponent implements OnInit {

  displayedColumns: string[] = [
    'ID_LEGAJO',
    'APELLIDO',
    'NOMBRE',
    'ID_JORNADA',
    'N_JORNADA',
    'ID_INCIDENCIA',
    'N_INCIDENCIA',
    'MARCACIONES',
    'H_TEORICAS',
    'H_TRABAJADAS',
    'I_IMPARES',
    'I_SIN_INCIDENCIAS',
    'H_ADICIONALES',
    'H_AUSENCIA'
];


  dataSource = new MatTableDataSource<Novedades>([]); // primero se declara un dataSource para la tabla
  txtParam: any;


  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  constructor(private NovedadesService: NovedadesService ) { }

  ngOnInit() {
    this.NovedadesService.getnovedades(this.txtParam).subscribe((result: Novedades[]) => {
      this.dataSource.data = result;
      console.log(result);
    });
  }


  getNovedades() {
    this.NovedadesService.getnovedades(this.txtParam).subscribe((result: Novedades[]) => {
      this.dataSource.data = result;
      console.log(this.dataSource.data);
    });
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }




}
