export class Nomina {
  public id_legajo: number;
  public apellido: string;
  public nombre: string;
  public f_nacimiento: Date;
  public cuil: number;

  constructor(id_legajo?: number, apellido?: string, nombre?: string, f_nacimiento?: Date,cuil?: number) {
    this.id_legajo = id_legajo;
    this.apellido = apellido;
    this.nombre = nombre;
    this.f_nacimiento = f_nacimiento;
    this.cuil = cuil;
  }
}
