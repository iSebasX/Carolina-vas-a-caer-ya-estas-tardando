
public class EstadoSaltoPared: Basestate
{
    public EstadoSaltoPared(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("SaltoPared");
    }
    public override void StateUpdate()
    {
        
    }
    public override void FixedUpdateState()
    {
        
    }
    public override void StateExit(Basestate newState)
    {
        controlador.CambiarEstado(newState);
    }

}
