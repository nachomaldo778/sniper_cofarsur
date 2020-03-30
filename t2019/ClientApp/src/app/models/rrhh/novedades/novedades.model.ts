export class Novedades {
  public ID_LEGAJO: number;
  public APELLIDO: string;
  public NOMBRE: string;
  public ID_JORNADA: number;
  public N_JORNADA: string;
  public ID_INCIDENCIA: number;
  public N_INCIDENCIA: string;
  public MARCACIONES: string;
  public H_TEORICAS: number;
  public H_TRABAJADAS: number;
  public I_IMPARES: number;
  public I_SIN_INCIDENCIAS: number;
  public H_ADICIONALES: number;
  public H_AUSENCIA: number;


  constructor(ID_LEGAJO?: number,
    APELLIDO?: string,
    NOMBRE?: string,
    ID_JORNADA?: number,
    N_JORNADA?: string,
    ID_INCIDENCIA?: number,
    N_INCIDENCIA?: string,
    MARCACIONES?: string,
    H_TEORICAS?: number,
    H_TRABAJADAS?: number,
    I_IMPARES?: number,
    I_SIN_INCIDENCIAS?: number,
    H_ADICIONALES?: number,
    H_AUSENCIA?: number,
) {
    this.ID_LEGAJO = ID_LEGAJO;
    this.APELLIDO = APELLIDO;
    this.NOMBRE = NOMBRE;
    this.ID_JORNADA = ID_JORNADA;
    this.N_JORNADA = N_JORNADA;
    this.ID_INCIDENCIA = ID_INCIDENCIA;
    this.N_INCIDENCIA = N_INCIDENCIA;
    this.MARCACIONES = MARCACIONES;
    this.H_TEORICAS = H_TEORICAS;
    this.H_TRABAJADAS = H_TRABAJADAS;
    this.I_IMPARES = I_IMPARES;
    this.I_SIN_INCIDENCIAS = I_SIN_INCIDENCIAS;
    this.H_ADICIONALES = H_ADICIONALES;
    this.H_AUSENCIA = H_AUSENCIA;

  }
}
