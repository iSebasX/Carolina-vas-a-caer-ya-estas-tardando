
public class EstadoCaida: Basestate
{
    public EstadoCaida(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Fall");
    }
    public override void StateUpdate()
    {
        if (controlador.rigid.linearVelocity.y <= 0)
        {
            if (controlador.tocandoPiso)
            {
                if (controlador.horizontal == 0)
                {
                    StateExit(controlador.idle);
                }
                else if (controlador.horizontal != 0)
                {
                    StateExit(controlador.correr);
                }
            }
        }

    }
    public override void FixedUpdateState()
    {
        
    }
    public override void StateExit(Basestate newState)
    {
        controlador.CambiarEstado(newState);
    }

}
