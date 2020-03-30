export class Usuario {
  public CUIT: number;
  public Usuario: string;
  public Contra: string;

  constructor(CUIT?: number, Usuario?: string, Contra?: string) {
    this.CUIT = CUIT;
    this.Usuario = Usuario;
    this.Contra = Contra;
  }
}
