using UnityEngine;

public class EstadoIdle : Basestate
{
    public EstadoIdle(MovimientoStates controladorParametros) : base(controladorParametros) //Base se refiere a la clase padre
    {

    }
    public override void StateStart()
    {
        controlador.dongojo.Play("Idle");
        
    }
    public override void StateUpdate()
    {
        
    }
    public override void FixedUpdateState()
    {
        
    }
    public override void StateExit()
    {
        
    }

}
