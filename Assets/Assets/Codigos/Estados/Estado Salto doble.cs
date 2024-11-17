using UnityEngine;

public class EstadoSaltoDoble : Basestate
{
    public EstadoSaltoDoble(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("DobleSalto");
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
